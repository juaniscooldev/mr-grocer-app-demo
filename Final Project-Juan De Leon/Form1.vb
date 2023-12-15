
'Name:                  Juan De Leon - Gonzalez
'Purpose:               Allow users to buy from GROWcery's via app and allow product owners to change prices (may change)
'Date Due: 12/06/2022   


Option Strict On
Option Explicit On
Option Infer Off
'credit for pictures all are from https://www.flaticon.com/ and respective owners



'IM USING VISUAL BASIC 2022
Public Class frmMain

    Private darkModeSwitch As Boolean = False
    Private lightModeSwitch As Boolean = False
    Private bkgColorSwitch As Boolean = False
    ReadOnly dblItemsTotal As Double() = {0, 0, 0, 0, 0, 0, 0, 0, 0}
    ReadOnly stringProduce As String() = {"Blueberries", "Strawberries", "Carrots",
        "Watermelons", "Cabbages", "Tomatoes", "Apples", "Bananas", "Oranges"}

    Dim accountCreatedSwitch As Boolean = False

    Private total As Double = 0

    '-------------Form HANDLING---------------
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'LoginDatabaseDataSet.LoginTable' table. You can move, or remove it, as needed.
        Me.LoginTableTableAdapter.Fill(Me.LoginDatabaseDataSet.LoginTable)
        ''TODO: This line of code loads data into the 'GroceryProduceDatabaseDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.GroceryProduceDatabaseDataSet.Table)
        If darkModeSwitch = True Then
            DarkModeToolStripMenuItem1.PerformClick()
        End If
        If lightModeSwitch = True Then
            LightModeToolStripMenuItem1.PerformClick()
        End If
        If bkgColorSwitch = True Then
            ChangeBackgroundColorToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Prompts user if they want to close the form
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", 'display message for closing application
                                    "Mr. Grocer's App",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Exclamation)
        'if no is selected, do not close form

        If dlgButton = DialogResult.No Then
            e.Cancel = True
        End If

        'StreamWriter

        'Dim outputFile As StreamWriter = File.CreateText("savedorder.txt")

        'For intCount As Integer = 0 To intCandy.GetUpperBound(0)
        '    outputFile.WriteLine(intCandy(intCount))


        'Next
        'outputFile.Close()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub



    '-------------CUSTOMIZATION CONTROLS---------------

    'changes color theme of interface to dark mode
    Private Sub DarkModeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DarkModeToolStripMenuItem1.Click

        'changes color of items on screen
        Me.BackColor = Color.DimGray
        Me.ForeColor = Color.White
        Me.MenuStrip1.BackColor = Color.DarkGray
        Me.MenuStrip1.ForeColor = Color.White
        Me.grpBoxCheckout.ForeColor = Color.White
        Me.lstItems.ForeColor = Color.White
        Me.lstItems.BackColor = Color.DarkGray
        Dim ctrl As Control = Me.GetNextControl(Me, True)

        'changes color of button
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is Button Then
                ctrl.BackColor = Color.DimGray
            End If
            If TypeOf ctrl Is Label AndAlso ctrl.BackColor = Color.Yellow Then
                ctrl.BackColor = Color.Orange
                ctrl.ForeColor = Color.Black
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop

        'debug
        'If darkModeSwitch = True Then
        '    MessageBox.Show("This button is clicked already ....")
        'Else
        '    MessageBox.Show("This button is clicked First time ....")
        'End If
        darkModeSwitch = True
    End Sub

    'changes color theme of interface to light mode
    Private Sub LightModeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LightModeToolStripMenuItem1.Click


        Me.BackColor = Color.White
        Me.ForeColor = Color.Black

        'changes menu bar to light mode

        Me.MenuStrip1.BackColor = Color.White
        Me.MenuStrip1.ForeColor = Color.Black

        Me.lstItems.ForeColor = Color.Black
        Me.lstItems.BackColor = Color.White

        Dim ctrl As Control = Me.GetNextControl(Me, True)

        'changes color of button
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is Button Then
                ctrl.BackColor = Color.White
            End If
            If TypeOf ctrl Is Label AndAlso ctrl.BackColor = Color.Orange Then
                ctrl.BackColor = Color.Yellow
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop
        'If lightModeSwitch = True Then
        '    MessageBox.Show("This button Is clicked already ....")
        'Else
        '    MessageBox.Show("This button Is clicked First time ....")
        'End If
        lightModeSwitch = True
        'save color after changes!!!!!
    End Sub

    Private Sub ChangeBackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeBackgroundColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
        Me.grpBoxCheckout.ForeColor = Color.Black
        Dim ctrl As Control = Me.GetNextControl(Me, True)

        'changes color of button
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is Button Then
                ctrl.BackColor = Color.White
            End If
            If TypeOf ctrl Is Label AndAlso ctrl.BackColor = Color.Orange Then
                ctrl.BackColor = Color.Yellow
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop
        'If bkgColorSwitch = True Then
        '    MessageBox.Show("This button Is clicked already ....")
        'Else
        '    MessageBox.Show("This button Is clicked First time ....")
        'End If
        bkgColorSwitch = True
    End Sub



    Private Sub BottomSideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BottomSideToolStripMenuItem.Click
        MenuStrip1.Dock = DockStyle.Bottom
    End Sub

    Private Sub TopSideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopSideToolStripMenuItem.Click
        MenuStrip1.Dock = DockStyle.Top
    End Sub

    '-------------LOG-IN CONTROLS---------------

    Private Sub LogInToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem1.Click
        loginFormCustomer.Show()
    End Sub


    '-------------Save Order---------------

    'Add Stream Reader/Writer!, 
    Private Sub SaveOrderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveOrderToolStripMenuItem1.Click
        MessageBox.Show("Changes are saved through the database")

        'StreamWriter

        'Dim inputFile As StreamReader

        'If File.Exists("saveorder.txt") Then
        '    inputFile = File.OpenText("candySales.txt")
        '    Do Until inputFile.Peek = -1
        '        For intCount As Integer = 0 To intCandy.GetUpperBound(0)
        '            Integer.TryParse(inputFile.ReadLine, intCandy(intCount))
        '        Next
        '    Loop
        'End If

    End Sub

    '-------------Open Order---------------
    Private Sub OpenOrderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenOrderToolStripMenuItem1.Click
        'StreamWriter outputFile = New StreamWriter("preferences.txt")
        MessageBox.Show("Changes are saved through the database")
    End Sub



    '-------------Button Click ---------------
    Private Sub btnSaveOrder_Click(sender As Object, e As EventArgs) Handles btnSaveOrder.Click
        SaveOrderToolStripMenuItem1.PerformClick()
    End Sub

    Private Sub btnBlueberries_Click(sender As Object, e As EventArgs) Handles btnBlueberries.Click
        Dim decBlueberryStock As Decimal = CDec(lblBlueStock.Text)
        Dim price As Double = 1.75
        Static items As Decimal = 0
        Decimal.TryParse(lblBlueStock.Text, decBlueberryStock)


        'adds item to list
        If (numBlueberries.Value > 0 And numBlueberries.Value <= decBlueberryStock) Then

            If (decBlueberryStock > 0) Then
                'indicates item is in stock
                picBlueberries.BackColor = Color.Green
                items += numBlueberries.Value
                lstItems.Items.Item(0) = "Blueberries:  " & items & " * " & price

                decBlueberryStock -= numBlueberries.Value

                GroceryProduceDatabaseDataSet.Table.Rows(0).Item(1) = decBlueberryStock
                lblBlueStock.Text = decBlueberryStock.ToString
                dblItemsTotal(0) = numBlueberries.Value * price
                total += (numBlueberries.Value * price)
            Else
                MessageBox.Show("Insufficient stock or balance. ")
                picBlueberries.BackColor = Color.Red
            End If
        Else
            MessageBox.Show("Enter a number for how many of the item you would like." &
                            Environment.NewLine &
                            Environment.NewLine & "Note: It must be less than or greater than the stock available.")
        End If
    End Sub

    Private Sub btnStrawberries_Click(sender As Object, e As EventArgs) Handles btnStrawberries.Click
        Dim decStrawStock As Decimal = CDec(lblStrawberryStock.Text)
        Dim price As Double = 1.35
        Static items As Decimal = 0
        Decimal.TryParse(lblStrawberryStock.Text, decStrawStock)


        'adds item to list
        If (numStrawberries.Value > 0 And numStrawberries.Value <= decStrawStock) Then

            If (decStrawStock > 0) Then
                'indicates item is in stock
                picStrawberries.BackColor = Color.Green
                items += numStrawberries.Value
                lstItems.Items.Item(1) = "Strawberries:  " & items & " * " & price

                decStrawStock -= numStrawberries.Value

                GroceryProduceDatabaseDataSet.Table.Rows(0).Item(2) = decStrawStock
                lblStrawberryStock.Text = decStrawStock.ToString
                dblItemsTotal(1) = numStrawberries.Value * price
                total += (numStrawberries.Value * price)
            Else
                MessageBox.Show("Insufficient stock or balance. ")
                picStrawberries.BackColor = Color.Red
            End If
        Else
            MessageBox.Show("Enter a number for how many of the item you would like." &
                            Environment.NewLine &
                            Environment.NewLine & "Note: It must be less than or greater than the stock available.")
        End If
    End Sub

    Private Sub btnCarrots_Click(sender As Object, e As EventArgs) Handles btnCarrots.Click
        Dim decCarrotStock As Decimal = CDec(lblCarrotStock.Text)
        Dim price As Double = 1.25
        Static items As Decimal = 0
        Decimal.TryParse(lblCarrotStock.Text, decCarrotStock)


        'adds item to list
        If (numCarrots.Value > 0 And numCarrots.Value <= decCarrotStock) Then

            If (decCarrotStock > 0) Then
                'indicates item is in stock
                picCarrot.BackColor = Color.Green
                items += numCarrots.Value
                lstItems.Items.Item(2) = "Carrots:  " & items & " * " & price

                decCarrotStock -= numCarrots.Value

                GroceryProduceDatabaseDataSet.Table.Rows(0).Item(3) = decCarrotStock
                lblCarrotStock.Text = decCarrotStock.ToString
                dblItemsTotal(2) = numCarrots.Value * price
                total += (numCarrots.Value * price)
            Else
                MessageBox.Show("Insufficient stock or balance. ")
                picCarrot.BackColor = Color.Red
            End If
        Else
            MessageBox.Show("Enter a number for how many of the item you would like." &
                            Environment.NewLine &
                            Environment.NewLine & "Note: It must be less than or greater than the stock available.")
        End If
    End Sub

    Private Sub btnWatermelons_Click(sender As Object, e As EventArgs) Handles btnWatermelons.Click

        Dim decWaterStock As Decimal = CDec(lblWaterStock.Text)
        Dim price As Double = 2.15
        Static items As Decimal = 0
        Decimal.TryParse(lblWaterStock.Text, decWaterStock)


        'adds item to list
        If (numWatermelons.Value > 0 And numWatermelons.Value <= decWaterStock) Then

            If (decWaterStock > 0) Then
                'indicates item is in stock
                picWatermelon.BackColor = Color.Green
                items += numWatermelons.Value
                lstItems.Items.Item(3) = "Watermelon:  " & items & " * " & price

                decWaterStock -= numWatermelons.Value

                GroceryProduceDatabaseDataSet.Table.Rows(0).Item(4) = decWaterStock
                lblWaterStock.Text = decWaterStock.ToString
                dblItemsTotal(3) = numWatermelons.Value * price
                total += (numWatermelons.Value * price)
            Else
                MessageBox.Show("Insufficient stock or balance. ")
                picWatermelon.BackColor = Color.Red
            End If
        Else
            MessageBox.Show("Enter a number for how many of the item you would like." &
                            Environment.NewLine &
                            Environment.NewLine & "Note: It must be less than or greater than the stock available.")
        End If
    End Sub

    Private Sub btnCabbage_Click(sender As Object, e As EventArgs) Handles btnCabbage.Click
        Dim decCabbageStock As Decimal = CDec(lblCabbageStock.Text)
        Dim price As Double = 1.7
        Static items As Decimal = 0
        Decimal.TryParse(lblCabbageStock.Text, decCabbageStock)


        'adds item to list
        If (numCabbage.Value > 0 And numCabbage.Value <= decCabbageStock) Then

            If (decCabbageStock > 0) Then
                'indicates item is in stock
                picCabbage.BackColor = Color.Green
                items += numCabbage.Value
                lstItems.Items.Item(4) = "Cabbage:  " & items & " * " & price

                decCabbageStock -= numCabbage.Value

                GroceryProduceDatabaseDataSet.Table.Rows(0).Item(5) = decCabbageStock
                lblCabbageStock.Text = decCabbageStock.ToString
                dblItemsTotal(4) = numCabbage.Value * price
                total += (numCabbage.Value * price)
            Else
                MessageBox.Show("Insufficient stock or balance. ")
                picCabbage.BackColor = Color.Red
            End If
        Else
            MessageBox.Show("Enter a number for how many of the item you would like." &
                            Environment.NewLine &
                            Environment.NewLine & "Note: It must be less than or greater than the stock available.")
        End If

    End Sub

    Private Sub btnTomatoes_Click(sender As Object, e As EventArgs) Handles btnTomatoes.Click
        Dim decTomatoStock As Decimal = CDec(lblTomatoes.Text)
        Dim price As Double = 0.8
        Static items As Decimal = 0
        Decimal.TryParse(lblTomatoes.Text, decTomatoStock)


        'adds item to list
        If (numTomatoes.Value > 0 And numTomatoes.Value <= decTomatoStock) Then

            If (decTomatoStock > 0) Then
                'indicates item is in stock
                picTomato.BackColor = Color.Green
                items += numTomatoes.Value
                lstItems.Items.Item(5) = "Tomatoes:  " & items & " * " & price

                decTomatoStock -= numTomatoes.Value

                GroceryProduceDatabaseDataSet.Table.Rows(0).Item(6) = decTomatoStock
                lblTomatoes.Text = decTomatoStock.ToString
                dblItemsTotal(5) = numTomatoes.Value * price
                total += (numTomatoes.Value * price)
            Else
                MessageBox.Show("Insufficient stock or balance. ")
                picTomato.BackColor = Color.Red
            End If
        Else
            MessageBox.Show("Enter a number for how many of the item you would like." &
                            Environment.NewLine &
                            Environment.NewLine & "Note: It must be less than or greater than the stock available.")
        End If
    End Sub

    Private Sub btnOranges_Click(sender As Object, e As EventArgs) Handles btnOranges.Click
        Dim decOrangesStock As Decimal = CDec(lblOrangeStock.Text)
        Dim price As Double = 2.0
        Static items As Decimal = 0
        Decimal.TryParse(lblOrangeStock.Text, decOrangesStock)


        'adds item to list
        If (numOranges.Value > 0 And numOranges.Value <= decOrangesStock) Then

            If (decOrangesStock > 0) Then
                'indicates item is in stock
                picOranges.BackColor = Color.Green
                items += numOranges.Value
                lstItems.Items.Item(8) = "Oranges:  " & items & " * " & price

                decOrangesStock -= numOranges.Value

                GroceryProduceDatabaseDataSet.Table.Rows(0).Item(9) = decOrangesStock
                lblOrangeStock.Text = decOrangesStock.ToString
                dblItemsTotal(8) = numOranges.Value * price
                total += (numOranges.Value * price)
            Else
                MessageBox.Show("Insufficient stock or balance. ")
                picOranges.BackColor = Color.Red
            End If
        Else
            MessageBox.Show("Enter a number for how many of the item you would like." &
                            Environment.NewLine &
                            Environment.NewLine & "Note: It must be less than or greater than the stock available.")
        End If
    End Sub

    Private Sub btnBananas_Click(sender As Object, e As EventArgs) Handles btnBananas.Click
        Dim decBananas As Decimal = CDec(lblBananaStock.Text)
        Dim price As Double = 1.85
        Static items As Decimal = 0
        Decimal.TryParse(lblBananaStock.Text, decBananas)


        'adds item to list
        If (numOranges.Value > 0 And numOranges.Value <= decBananas) Then

            If (decBananas > 0) Then
                'indicates item is in stock
                picOranges.BackColor = Color.Green
                items += numOranges.Value
                lstItems.Items.Item(7) = "Bananas:  " & items & " * " & price

                decBananas -= numOranges.Value

                GroceryProduceDatabaseDataSet.Table.Rows(0).Item(8) = decBananas
                lblBananaStock.Text = decBananas.ToString
                dblItemsTotal(7) = numOranges.Value * price
                total += (numOranges.Value * price)
            Else
                MessageBox.Show("Insufficient stock or balance. ")
                picOranges.BackColor = Color.Red
            End If
        Else
            MessageBox.Show("Enter a number for how many of the item you would like." &
                            Environment.NewLine &
                            Environment.NewLine & "Note: It must be less than or greater than the stock available.")
        End If
    End Sub

    Private Sub btnApples_Click(sender As Object, e As EventArgs) Handles btnApples.Click
        Dim decAppleStock As Decimal = CDec(lblAppleStock.Text)
        Dim price As Double = 0.95
        Static items As Decimal = 0
        Decimal.TryParse(lblAppleStock.Text, decAppleStock)


        'adds item to list
        If (numApples.Value > 0 And numApples.Value <= decAppleStock) Then

            If (decAppleStock > 0) Then
                'indicates item is in stock
                picApple.BackColor = Color.Green
                items += numApples.Value
                lstItems.Items.Item(6) = "Apples:  " & items & " * " & price

                decAppleStock -= numApples.Value

                GroceryProduceDatabaseDataSet.Table.Rows(0).Item(7) = decAppleStock
                lblAppleStock.Text = decAppleStock.ToString
                dblItemsTotal(6) = numApples.Value * price
                total += (numApples.Value * price)
            Else
                MessageBox.Show("Insufficient stock or balance. ")
                picApple.BackColor = Color.Red
            End If
        Else
            MessageBox.Show("Enter a number for how many of the item you would like." &
                            Environment.NewLine &
                            Environment.NewLine & "Note: It must be less than or greater than the stock available.")
        End If
    End Sub

    '-------------Item Removal (Checkboxes)---------------
    'all checkboxes listed below clear the item from the item list
    Private Sub chkBlueberries_CheckedChanged(sender As Object, e As EventArgs) Handles chkBlueberries.CheckedChanged
        'refunds items 
        Dim decBlueberryStock As Decimal = CDec(lblBlueStock.Text)
        lstItems.Items.Item(0) = "Blueberries: 0"
        total -= dblItemsTotal(0)
        dblItemsTotal(0) = 0

        decBlueberryStock += numBlueberries.Value
        GroceryProduceDatabaseDataSet.Table.Rows(0).Item(1) = decBlueberryStock
        lblBlueStock.Text = decBlueberryStock.ToString
        chkBlueberries.Checked = False
    End Sub

    Private Sub chkStrawberries_CheckedChanged(sender As Object, e As EventArgs) Handles chkStrawberries.CheckedChanged



        Dim decStrawStock As Decimal = CDec(lblStrawberryStock.Text)
        lstItems.Items.Item(1) = "Strawberries: 0"
        total -= dblItemsTotal(1)
        dblItemsTotal(1) = 0

        decStrawStock += numStrawberries.Value
        GroceryProduceDatabaseDataSet.Table.Rows(0).Item(2) = decStrawStock
        lblStrawberryStock.Text = decStrawStock.ToString
        chkStrawberries.Checked = False
    End Sub

    Private Sub chkCarrots_CheckedChanged(sender As Object, e As EventArgs) Handles chkCarrots.CheckedChanged


        Dim decCarrotStock As Decimal = CDec(lblCarrotStock.Text)
        lstItems.Items.Item(2) = "Carrots: 0"
        total -= dblItemsTotal(2)
        dblItemsTotal(2) = 0

        decCarrotStock += numCarrots.Value
        GroceryProduceDatabaseDataSet.Table.Rows(0).Item(3) = decCarrotStock
        lblCarrotStock.Text = decCarrotStock.ToString
        chkCarrots.Checked = False
    End Sub

    Private Sub chkWatermelons_CheckedChanged(sender As Object, e As EventArgs) Handles chkWatermelons.CheckedChanged
        Dim decWaterStock As Decimal = CDec(lblWaterStock.Text)
        lstItems.Items.Item(3) = "Watermelons: 0"
        total -= dblItemsTotal(3)
        dblItemsTotal(3) = 0

        decWaterStock += numWatermelons.Value
        GroceryProduceDatabaseDataSet.Table.Rows(0).Item(4) = decWaterStock
        lblWaterStock.Text = decWaterStock.ToString
        chkWatermelons.Checked = False
    End Sub

    Private Sub chkCabbage_CheckedChanged(sender As Object, e As EventArgs) Handles chkCabbage.CheckedChanged
        Dim decCabbage As Decimal = CDec(lblCabbageStock.Text)
        lstItems.Items.Item(4) = "Cabbage: 0"
        total -= dblItemsTotal(4)
        dblItemsTotal(4) = 0

        decCabbage += numCabbage.Value
        GroceryProduceDatabaseDataSet.Table.Rows(0).Item(5) = decCabbage
        lblCabbageStock.Text = decCabbage.ToString
        chkCabbage.Checked = False
    End Sub

    Private Sub chkTomatoes_CheckedChanged(sender As Object, e As EventArgs) Handles chkTomatoes.CheckedChanged
        Dim decTomato As Decimal = CDec(lblTomatoStock.Text)
        lstItems.Items.Item(5) = "Tomatoes: 0"
        total -= dblItemsTotal(5)
        dblItemsTotal(5) = 0

        decTomato += numTomatoes.Value
        GroceryProduceDatabaseDataSet.Table.Rows(0).Item(6) = decTomato
        lblTomatoStock.Text = decTomato.ToString
        chkTomatoes.Checked = False
    End Sub

    Private Sub chkApples_CheckedChanged(sender As Object, e As EventArgs) Handles chkApples.CheckedChanged

        Dim decApple As Decimal = CDec(lblAppleStock.Text)
        lstItems.Items.Item(6) = "Apples: 0"
        total -= dblItemsTotal(6)
        dblItemsTotal(6) = 0

        decApple += numApples.Value
        GroceryProduceDatabaseDataSet.Table.Rows(0).Item(7) = decApple
        lblAppleStock.Text = decApple.ToString
        chkApples.Checked = False
    End Sub

    Private Sub chkBananas_CheckedChanged(sender As Object, e As EventArgs) Handles chkBananas.CheckedChanged
        Dim decBananas As Decimal = CDec(lblBananaStock.Text)
        lstItems.Items.Item(7) = "Bananas: 0"
        total -= dblItemsTotal(7)
        dblItemsTotal(7) = 0

        decBananas += numBananas.Value
        GroceryProduceDatabaseDataSet.Table.Rows(0).Item(8) = decBananas
        lblBananaStock.Text = decBananas.ToString
        chkBananas.Checked = False
    End Sub

    Private Sub chkOranges_CheckedChanged(sender As Object, e As EventArgs) Handles chkOranges.CheckedChanged
        Dim decOranges As Decimal = CDec(lblOrangeStock.Text)
        lstItems.Items.Item(8) = "Oranges: 0"
        total -= dblItemsTotal(8)
        dblItemsTotal(8) = 0

        decOranges += numOranges.Value
        GroceryProduceDatabaseDataSet.Table.Rows(0).Item(9) = decOranges
        lblOrangeStock.Text = decOranges.ToString
        chkOranges.Checked = False
    End Sub

    '-------------Calculate Order---------------
    'checks if account has been created
    Public Sub accountCreated()
        If lblUsername == "Signed In" Then
        accountCreatedSwitch = True
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        'check if account has been created
        Dim dlgButton As DialogResult

        btnCalculate.PerformClick()


        Dim currentDate As String = DateTime.Now.ToString("hh:mm dddd, dd MMMM yyyy")

        
        If accountCreatedSwitch = accountCreated() Then
            dlgButton = MessageBox.Show("You need to create an account before you can proceed with your order",
                                        "Mr. Grocer's App",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation)

        Else
            dlgButton = MessageBox.Show("Today's Date: " & currentDate & Environment.NewLine &
                                        Environment.NewLine &
                                        "Your total is: " & txtTotal.Text & Environment.NewLine &
                                        "Your package will be sent to your location." &
                                        Environment.NewLine & Environment.NewLine,
                                        "Mr. Grocer's App",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation)
            'if no is selected, do not close form, then display message for closing application

            Me.Close()
        End If


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'refunds all items the total

        Dim stringOGStock As String() = {lblBlueStock.Text, lblStrawberryStock.Text, lblStrawberryStock.Text,
        lblCarrotStock.Text, lblWaterStock.Text, lblCabbageStock.Text, lblTomatoStock.Text, lblAppleStock.Text,
        lblBananaStock.Text, lblOrangeStock.Text}


        For index As Integer = 0 To stringProduce.GetUpperBound(0)
            lstItems.Items.Item(index) = stringProduce(index) & ": 0"

            Dim decAllStock As Decimal = CDec(dblItemsTotal(index))

            GroceryProduceDatabaseDataSet.Table.Rows(0).Item(index) = decAllStock

            Dim ctrl As Control = Me.GetNextControl(Me, True)

            Do Until ctrl Is Nothing

                If TypeOf ctrl Is Label And ctrl.Height = 16 Then
                    ctrl.Text = decAllStock.ToString
                    'stringOGStock(index)
                End If

                ctrl = Me.GetNextControl(ctrl, True)
            Loop
            dblItemsTotal(index) = 0



        Next


        total = 0
        txtTotal.Text = (0.00).ToString()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If chkAddPlastic.Checked = True And total > 0 And txtTotal.Text <> "0" Then
            total += 2.0

        End If

        If chkRecycableBag.Checked = True And total > 0 And txtTotal.Text <> "0" Then
            total += 2.0

        End If
        txtTotal.Text = total.ToString

    End Sub

    Dim rnd As Random = New Random


    'EASTER EGG
    Private Sub picLogo_Click(sender As Object, e As EventArgs) Handles picLogo.Click
        'randomizes background color of logo

        Me.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
    End Sub
End Class
