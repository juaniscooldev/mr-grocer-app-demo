<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GroceryProducerDatabaseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim BlueberriesLabel As System.Windows.Forms.Label
        Dim StrawberriesLabel As System.Windows.Forms.Label
        Dim CarrotsLabel As System.Windows.Forms.Label
        Dim WatermelonsLabel As System.Windows.Forms.Label
        Dim CabbagesLabel As System.Windows.Forms.Label
        Dim TomatoesLabel As System.Windows.Forms.Label
        Dim ApplesLabel As System.Windows.Forms.Label
        Dim BananasLabel As System.Windows.Forms.Label
        Dim OrangesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GroceryProducerDatabaseForm))
        Me.TableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroceryProduceDatabaseDataSet = New Final_Project_Juan_De_Leon.GroceryProduceDatabaseDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.LoginTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginDatabaseDataSet = New Final_Project_Juan_De_Leon.LoginDatabaseDataSet()
        Me.BlueberriesTextBox = New System.Windows.Forms.TextBox()
        Me.StrawberriesTextBox = New System.Windows.Forms.TextBox()
        Me.CarrotsTextBox = New System.Windows.Forms.TextBox()
        Me.WatermelonsTextBox = New System.Windows.Forms.TextBox()
        Me.CabbagesTextBox = New System.Windows.Forms.TextBox()
        Me.TomatoesTextBox = New System.Windows.Forms.TextBox()
        Me.ApplesTextBox = New System.Windows.Forms.TextBox()
        Me.BananasTextBox = New System.Windows.Forms.TextBox()
        Me.OrangesTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblGroceryDatabaseTitle = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTotalProduce = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableTableAdapter = New Final_Project_Juan_De_Leon.GroceryProduceDatabaseDataSetTableAdapters.TableTableAdapter()
        Me.TableAdapterManager = New Final_Project_Juan_De_Leon.GroceryProduceDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.LoginTableTableAdapter = New Final_Project_Juan_De_Leon.LoginDatabaseDataSetTableAdapters.LoginTableTableAdapter()
        Me.TableAdapterManager1 = New Final_Project_Juan_De_Leon.LoginDatabaseDataSetTableAdapters.TableAdapterManager()
        UsernameLabel = New System.Windows.Forms.Label()
        BlueberriesLabel = New System.Windows.Forms.Label()
        StrawberriesLabel = New System.Windows.Forms.Label()
        CarrotsLabel = New System.Windows.Forms.Label()
        WatermelonsLabel = New System.Windows.Forms.Label()
        CabbagesLabel = New System.Windows.Forms.Label()
        TomatoesLabel = New System.Windows.Forms.Label()
        ApplesLabel = New System.Windows.Forms.Label()
        BananasLabel = New System.Windows.Forms.Label()
        OrangesLabel = New System.Windows.Forms.Label()
        CType(Me.TableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableBindingNavigator.SuspendLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroceryProduceDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(1, 34)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(73, 16)
        UsernameLabel.TabIndex = 1
        UsernameLabel.Text = "Username:"
        '
        'BlueberriesLabel
        '
        BlueberriesLabel.AutoSize = True
        BlueberriesLabel.Location = New System.Drawing.Point(1, 62)
        BlueberriesLabel.Name = "BlueberriesLabel"
        BlueberriesLabel.Size = New System.Drawing.Size(79, 16)
        BlueberriesLabel.TabIndex = 3
        BlueberriesLabel.Text = "Blueberries:"
        '
        'StrawberriesLabel
        '
        StrawberriesLabel.AutoSize = True
        StrawberriesLabel.Location = New System.Drawing.Point(1, 90)
        StrawberriesLabel.Name = "StrawberriesLabel"
        StrawberriesLabel.Size = New System.Drawing.Size(85, 16)
        StrawberriesLabel.TabIndex = 5
        StrawberriesLabel.Text = "Strawberries:"
        '
        'CarrotsLabel
        '
        CarrotsLabel.AutoSize = True
        CarrotsLabel.Location = New System.Drawing.Point(1, 118)
        CarrotsLabel.Name = "CarrotsLabel"
        CarrotsLabel.Size = New System.Drawing.Size(53, 16)
        CarrotsLabel.TabIndex = 7
        CarrotsLabel.Text = "Carrots:"
        '
        'WatermelonsLabel
        '
        WatermelonsLabel.AutoSize = True
        WatermelonsLabel.Location = New System.Drawing.Point(1, 146)
        WatermelonsLabel.Name = "WatermelonsLabel"
        WatermelonsLabel.Size = New System.Drawing.Size(90, 16)
        WatermelonsLabel.TabIndex = 9
        WatermelonsLabel.Text = "Watermelons:"
        '
        'CabbagesLabel
        '
        CabbagesLabel.AutoSize = True
        CabbagesLabel.Location = New System.Drawing.Point(1, 174)
        CabbagesLabel.Name = "CabbagesLabel"
        CabbagesLabel.Size = New System.Drawing.Size(74, 16)
        CabbagesLabel.TabIndex = 11
        CabbagesLabel.Text = "Cabbages:"
        '
        'TomatoesLabel
        '
        TomatoesLabel.AutoSize = True
        TomatoesLabel.Location = New System.Drawing.Point(1, 202)
        TomatoesLabel.Name = "TomatoesLabel"
        TomatoesLabel.Size = New System.Drawing.Size(72, 16)
        TomatoesLabel.TabIndex = 13
        TomatoesLabel.Text = "Tomatoes:"
        '
        'ApplesLabel
        '
        ApplesLabel.AutoSize = True
        ApplesLabel.Location = New System.Drawing.Point(1, 230)
        ApplesLabel.Name = "ApplesLabel"
        ApplesLabel.Size = New System.Drawing.Size(53, 16)
        ApplesLabel.TabIndex = 15
        ApplesLabel.Text = "Apples:"
        '
        'BananasLabel
        '
        BananasLabel.AutoSize = True
        BananasLabel.Location = New System.Drawing.Point(1, 258)
        BananasLabel.Name = "BananasLabel"
        BananasLabel.Size = New System.Drawing.Size(64, 16)
        BananasLabel.TabIndex = 17
        BananasLabel.Text = "Bananas:"
        '
        'OrangesLabel
        '
        OrangesLabel.AutoSize = True
        OrangesLabel.Location = New System.Drawing.Point(1, 286)
        OrangesLabel.Name = "OrangesLabel"
        OrangesLabel.Size = New System.Drawing.Size(62, 16)
        OrangesLabel.TabIndex = 19
        OrangesLabel.Text = "Oranges:"
        '
        'TableBindingNavigator
        '
        Me.TableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TableBindingNavigator.BindingSource = Me.TableBindingSource
        Me.TableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TableBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TableBindingNavigatorSaveItem})
        Me.TableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TableBindingNavigator.Name = "TableBindingNavigator"
        Me.TableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TableBindingNavigator.Size = New System.Drawing.Size(427, 27)
        Me.TableBindingNavigator.TabIndex = 0
        Me.TableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.GroceryProduceDatabaseDataSet
        '
        'GroceryProduceDatabaseDataSet
        '
        Me.GroceryProduceDatabaseDataSet.DataSetName = "GroceryProduceDatabaseDataSet"
        Me.GroceryProduceDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'TableBindingNavigatorSaveItem
        '
        Me.TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TableBindingNavigatorSaveItem.Image = CType(resources.GetObject("TableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TableBindingNavigatorSaveItem.Name = "TableBindingNavigatorSaveItem"
        Me.TableBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.TableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginTableBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(97, 31)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UsernameTextBox.TabIndex = 2
        '
        'LoginTableBindingSource
        '
        Me.LoginTableBindingSource.DataMember = "LoginTable"
        Me.LoginTableBindingSource.DataSource = Me.LoginDatabaseDataSet
        '
        'LoginDatabaseDataSet
        '
        Me.LoginDatabaseDataSet.DataSetName = "LoginDatabaseDataSet"
        Me.LoginDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BlueberriesTextBox
        '
        Me.BlueberriesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Blueberries", True))
        Me.BlueberriesTextBox.Location = New System.Drawing.Point(97, 59)
        Me.BlueberriesTextBox.Name = "BlueberriesTextBox"
        Me.BlueberriesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BlueberriesTextBox.TabIndex = 4
        '
        'StrawberriesTextBox
        '
        Me.StrawberriesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Strawberries", True))
        Me.StrawberriesTextBox.Location = New System.Drawing.Point(97, 87)
        Me.StrawberriesTextBox.Name = "StrawberriesTextBox"
        Me.StrawberriesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StrawberriesTextBox.TabIndex = 6
        '
        'CarrotsTextBox
        '
        Me.CarrotsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Carrots", True))
        Me.CarrotsTextBox.Location = New System.Drawing.Point(97, 115)
        Me.CarrotsTextBox.Name = "CarrotsTextBox"
        Me.CarrotsTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CarrotsTextBox.TabIndex = 8
        '
        'WatermelonsTextBox
        '
        Me.WatermelonsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Watermelons", True))
        Me.WatermelonsTextBox.Location = New System.Drawing.Point(97, 143)
        Me.WatermelonsTextBox.Name = "WatermelonsTextBox"
        Me.WatermelonsTextBox.Size = New System.Drawing.Size(100, 22)
        Me.WatermelonsTextBox.TabIndex = 10
        '
        'CabbagesTextBox
        '
        Me.CabbagesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Cabbages", True))
        Me.CabbagesTextBox.Location = New System.Drawing.Point(97, 171)
        Me.CabbagesTextBox.Name = "CabbagesTextBox"
        Me.CabbagesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CabbagesTextBox.TabIndex = 12
        '
        'TomatoesTextBox
        '
        Me.TomatoesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Tomatoes", True))
        Me.TomatoesTextBox.Location = New System.Drawing.Point(97, 199)
        Me.TomatoesTextBox.Name = "TomatoesTextBox"
        Me.TomatoesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TomatoesTextBox.TabIndex = 14
        '
        'ApplesTextBox
        '
        Me.ApplesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Apples", True))
        Me.ApplesTextBox.Location = New System.Drawing.Point(97, 227)
        Me.ApplesTextBox.Name = "ApplesTextBox"
        Me.ApplesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ApplesTextBox.TabIndex = 16
        '
        'BananasTextBox
        '
        Me.BananasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Bananas", True))
        Me.BananasTextBox.Location = New System.Drawing.Point(97, 255)
        Me.BananasTextBox.Name = "BananasTextBox"
        Me.BananasTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BananasTextBox.TabIndex = 18
        '
        'OrangesTextBox
        '
        Me.OrangesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Oranges", True))
        Me.OrangesTextBox.Location = New System.Drawing.Point(97, 283)
        Me.OrangesTextBox.Name = "OrangesTextBox"
        Me.OrangesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.OrangesTextBox.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(UsernameLabel)
        Me.Panel1.Controls.Add(Me.UsernameTextBox)
        Me.Panel1.Controls.Add(BlueberriesLabel)
        Me.Panel1.Controls.Add(Me.BlueberriesTextBox)
        Me.Panel1.Controls.Add(StrawberriesLabel)
        Me.Panel1.Controls.Add(Me.StrawberriesTextBox)
        Me.Panel1.Controls.Add(CarrotsLabel)
        Me.Panel1.Controls.Add(Me.CarrotsTextBox)
        Me.Panel1.Controls.Add(WatermelonsLabel)
        Me.Panel1.Controls.Add(Me.WatermelonsTextBox)
        Me.Panel1.Controls.Add(CabbagesLabel)
        Me.Panel1.Controls.Add(Me.CabbagesTextBox)
        Me.Panel1.Controls.Add(TomatoesLabel)
        Me.Panel1.Controls.Add(Me.TomatoesTextBox)
        Me.Panel1.Controls.Add(ApplesLabel)
        Me.Panel1.Controls.Add(Me.ApplesTextBox)
        Me.Panel1.Controls.Add(BananasLabel)
        Me.Panel1.Controls.Add(Me.BananasTextBox)
        Me.Panel1.Controls.Add(OrangesLabel)
        Me.Panel1.Controls.Add(Me.OrangesTextBox)
        Me.Panel1.Location = New System.Drawing.Point(13, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 355)
        Me.Panel1.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblGroceryDatabaseTitle)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(13, 41)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(377, 52)
        Me.FlowLayoutPanel1.TabIndex = 23
        '
        'lblGroceryDatabaseTitle
        '
        Me.lblGroceryDatabaseTitle.AutoSize = True
        Me.lblGroceryDatabaseTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroceryDatabaseTitle.Location = New System.Drawing.Point(60, 0)
        Me.lblGroceryDatabaseTitle.Name = "lblGroceryDatabaseTitle"
        Me.lblGroceryDatabaseTitle.Size = New System.Drawing.Size(298, 38)
        Me.lblGroceryDatabaseTitle.TabIndex = 23
        Me.lblGroceryDatabaseTitle.Text = "# Of Produce Items"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(275, 446)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "E&xit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTotalProduce
        '
        Me.txtTotalProduce.Location = New System.Drawing.Point(275, 317)
        Me.txtTotalProduce.Multiline = True
        Me.txtTotalProduce.Name = "txtTotalProduce"
        Me.txtTotalProduce.ReadOnly = True
        Me.txtTotalProduce.Size = New System.Drawing.Size(140, 100)
        Me.txtTotalProduce.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(274, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Total Produce in Stock"
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TableTableAdapter = Me.TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = Final_Project_Juan_De_Leon.GroceryProduceDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LoginTableTableAdapter
        '
        Me.LoginTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.LoginTableTableAdapter = Me.LoginTableTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Final_Project_Juan_De_Leon.LoginDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroceryProducerDatabaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 482)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalProduce)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GroceryProducerDatabaseForm"
        Me.Text = "Admin: Grocery Produce Database"
        CType(Me.TableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableBindingNavigator.ResumeLayout(False)
        Me.TableBindingNavigator.PerformLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroceryProduceDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroceryProduceDatabaseDataSet As GroceryProduceDatabaseDataSet
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As GroceryProduceDatabaseDataSetTableAdapters.TableTableAdapter
    Friend WithEvents TableAdapterManager As GroceryProduceDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents BlueberriesTextBox As TextBox
    Friend WithEvents StrawberriesTextBox As TextBox
    Friend WithEvents CarrotsTextBox As TextBox
    Friend WithEvents WatermelonsTextBox As TextBox
    Friend WithEvents CabbagesTextBox As TextBox
    Friend WithEvents TomatoesTextBox As TextBox
    Friend WithEvents ApplesTextBox As TextBox
    Friend WithEvents BananasTextBox As TextBox
    Friend WithEvents OrangesTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblGroceryDatabaseTitle As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtTotalProduce As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginDatabaseDataSet As LoginDatabaseDataSet
    Friend WithEvents LoginTableBindingSource As BindingSource
    Friend WithEvents LoginTableTableAdapter As LoginDatabaseDataSetTableAdapters.LoginTableTableAdapter
    Friend WithEvents TableAdapterManager1 As LoginDatabaseDataSetTableAdapters.TableAdapterManager
End Class
