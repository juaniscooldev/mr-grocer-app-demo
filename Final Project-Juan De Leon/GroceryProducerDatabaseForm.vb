Public Class GroceryProducerDatabaseForm
    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GroceryProduceDatabaseDataSet)
        MessageBox.Show("Information saved")
        MessageBox.Show("Close the app to see the refreshed changes. ")

    End Sub

    Private Sub GroceryProducerDatabaseForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Prompts user if they want to close the form
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", 'display message for closing application
                                    "Mr. Grocer's App",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Exclamation)
        'if no is selected, do not close form

        If dlgButton = DialogResult.No Then
            e.Cancel = True
            frmMain.Show()
        End If

    End Sub
    Private Sub GroceryProducerDatabaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginDatabaseDataSet.LoginTable' table. You can move, or remove it, as needed.
        Me.LoginTableTableAdapter.Fill(Me.LoginDatabaseDataSet.LoginTable)
        'TODO: This line of code loads data into the 'GroceryProduceDatabaseDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.GroceryProduceDatabaseDataSet.Table)

        txtTotalProduce.Text = Me.TableTableAdapter.TotalProduceScalarQuery() & " produce in stock as of " & Environment.NewLine & Environment.NewLine & DateTime.Now.ToString("hh:mm dddd, dd MMMM yyyy")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class