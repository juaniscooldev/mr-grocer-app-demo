Imports System.Data.SqlClient

Public Class CreateAccountForm
    'Credits for making Log in form below:
    'guide for making log in form: https://www.c-sharpcorner.com/article/create-loginsign-in-and-registration-sign-up-form-in-c-sharp-windows-form-with-da/
    'C# to VB.NET translator

    ReadOnly connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\meowk\source\repos\Final Solution-Juan De Leon\Final Project-Juan De Leon\LoginDatabase.mdf"";Integrated Security=True")
    Private Sub CreateAccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginFormCustomer.Hide()
        connection.Open()
    End Sub
    Private passwordShow As Boolean = False

    Private Sub txtSold_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Accept only numbers, the hyphen, and the Backspace.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub linklblShowPassword1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklblShowPassword1.LinkClicked
        'shows/hides password
        If passwordShow = False Then
            txtPassword.PasswordChar = ""
            linklblShowPassword1.Text = "Hide Password"
            passwordShow = True
        Else
            txtPassword.PasswordChar = "*"
            linklblShowPassword1.Text = "Show Password"
            passwordShow = False
        End If
    End Sub

    Private Sub BtnRegister_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK.Click



        If txtconfirmpassword.Text <> String.Empty OrElse txtPassword.Text <> String.Empty OrElse txtusername.Text <> String.Empty Then

            If txtPassword.Text = txtconfirmpassword.Text Then
                'cmd allows sql commands to made
                Dim cmd As New SqlCommand("select * from LoginTable where username='" & txtusername.Text & "'", connection)
                Dim dr = cmd.ExecuteReader()

                'reads the table
                If dr.Read() Then
                    dr.Close()
                    'error if username exists
                    MessageBox.Show("Username already exists. Please try another. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Else
                    dr.Close()
                    cmd = New SqlCommand("insert into LoginTable values(@username,@password,@wallet)", connection)

                    cmd.Parameters.AddWithValue("username", txtusername.Text)
                    cmd.Parameters.AddWithValue("password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("wallet", 0)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Your account is created! Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loginFormCustomer.Show()
                    Me.Close()

                    frmMain.Show()
                End If
            Else
                'error message if no password exists in textbox
                MessageBox.Show("Please enter both passwords as the same. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If
        Else
            'error message if no username/password exists 
            MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub


End Class