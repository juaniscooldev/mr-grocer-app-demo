<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class loginFormCustomer
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginFormCustomer))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.lblLoginMessage = New System.Windows.Forms.Label()
        Me.linklblShowPassword = New System.Windows.Forms.LinkLabel()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lnklblCreateNewUser = New System.Windows.Forms.LinkLabel()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(195, 23)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(195, 80)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(197, 100)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(220, 22)
        Me.txtPassword.TabIndex = 3
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.SystemColors.Control
        Me.OK.Location = New System.Drawing.Point(220, 160)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.SystemColors.Control
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(323, 160)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Close"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'lblLoginMessage
        '
        Me.lblLoginMessage.AutoSize = True
        Me.lblLoginMessage.Font = New System.Drawing.Font("Franklin Gothic Demi", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginMessage.ForeColor = System.Drawing.Color.Teal
        Me.lblLoginMessage.Location = New System.Drawing.Point(13, 13)
        Me.lblLoginMessage.Name = "lblLoginMessage"
        Me.lblLoginMessage.Size = New System.Drawing.Size(63, 23)
        Me.lblLoginMessage.TabIndex = 6
        Me.lblLoginMessage.Text = "Log in "
        '
        'linklblShowPassword
        '
        Me.linklblShowPassword.AutoSize = True
        Me.linklblShowPassword.Location = New System.Drawing.Point(323, 129)
        Me.linklblShowPassword.Name = "linklblShowPassword"
        Me.linklblShowPassword.Size = New System.Drawing.Size(103, 16)
        Me.linklblShowPassword.TabIndex = 7
        Me.linklblShowPassword.TabStop = True
        Me.linklblShowPassword.Text = "&Show Password"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(197, 43)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(220, 22)
        Me.txtUser.TabIndex = 1
        '
        'lnklblCreateNewUser
        '
        Me.lnklblCreateNewUser.AutoSize = True
        Me.lnklblCreateNewUser.Location = New System.Drawing.Point(308, 68)
        Me.lnklblCreateNewUser.Name = "lnklblCreateNewUser"
        Me.lnklblCreateNewUser.Size = New System.Drawing.Size(109, 16)
        Me.lnklblCreateNewUser.TabIndex = 8
        Me.lnklblCreateNewUser.TabStop = True
        Me.lnklblCreateNewUser.Text = "Create New User"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 31)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(87, 91)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(88, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'loginFormCustomer
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(474, 218)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lnklblCreateNewUser)
        Me.Controls.Add(Me.linklblShowPassword)
        Me.Controls.Add(Me.lblLoginMessage)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loginFormCustomer"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Log in Form"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLoginMessage As Label
    Friend WithEvents linklblShowPassword As LinkLabel
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lnklblCreateNewUser As LinkLabel
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
