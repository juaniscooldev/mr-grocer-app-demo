<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccountForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateAccountForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtconfirmpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.linklblShowPassword1 = New System.Windows.Forms.LinkLabel()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Olive
        Me.Label1.Location = New System.Drawing.Point(10, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Create New User Customer"
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.SystemColors.Control
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(406, 261)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 14
        Me.Cancel.Text = "&Close"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.SystemColors.Control
        Me.OK.Location = New System.Drawing.Point(303, 261)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 13
        Me.OK.Text = "&OK"
        Me.OK.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(284, 135)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(220, 22)
        Me.txtPassword.TabIndex = 12
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(282, 115)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 11
        Me.PasswordLabel.Text = "New Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(29, 78)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(102, 105)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 9
        Me.LogoPictureBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(137, 122)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'txtconfirmpassword
        '
        Me.txtconfirmpassword.Location = New System.Drawing.Point(283, 190)
        Me.txtconfirmpassword.Name = "txtconfirmpassword"
        Me.txtconfirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmpassword.Size = New System.Drawing.Size(220, 22)
        Me.txtconfirmpassword.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(281, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Re-enter Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(282, 78)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(220, 22)
        Me.txtusername.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(280, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 23)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "&New User name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(499, 23)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "*Note: This is a Demo App please do not enter ACTUAL personal information. "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'linklblShowPassword1
        '
        Me.linklblShowPassword1.AutoSize = True
        Me.linklblShowPassword1.Location = New System.Drawing.Point(401, 224)
        Me.linklblShowPassword1.Name = "linklblShowPassword1"
        Me.linklblShowPassword1.Size = New System.Drawing.Size(103, 16)
        Me.linklblShowPassword1.TabIndex = 25
        Me.linklblShowPassword1.TabStop = True
        Me.linklblShowPassword1.Text = "&Show Password"
        '
        'CreateAccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(528, 336)
        Me.Controls.Add(Me.linklblShowPassword1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtconfirmpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreateAccountForm"
        Me.Text = "CreateAccountForm"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtconfirmpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents linklblShowPassword1 As LinkLabel
End Class
