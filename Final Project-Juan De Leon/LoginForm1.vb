Option Strict On
Option Explicit On
Option Infer Off

Imports System.Data.SqlClient

Public Class loginFormCustomer

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.


    Private Sub loginFormCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
    End Sub

    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\meowk\source\repos\Final Solution-Juan De Leon\Final Project-Juan De Leon\LoginDatabase.mdf"";Integrated Security=True")

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txtPassword.Text <> String.Empty OrElse txtUser.Text <> String.Empty Then
            Dim cmd As New SqlCommand("select * from LoginTable where username='" & txtUser.Text & "' and password='" + txtPassword.Text & "'", connection)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            'goes back to the main form
            If dr.Read() Then
                If (txtUser.Text.Contains("@admin")) Then
                    MessageBox.Show("You now have access to the database")
                    'close reader
                    dr.Close()
                    Me.Close()
                    GroceryProducerDatabaseForm.Show()

                    frmMain.lblUsername.Enabled = True
                    frmMain.lblUsername.Text = "Signed in"
                Else
                    MessageBox.Show("You are ready to make purchase!")
                    'closes reader
                    dr.Close()
                    Me.Close()

                    frmMain.lblUsername.Enabled = True
                    frmMain.lblUsername.Text = "Signed in"
                    frmMain.Show()
                End If


            Else
                dr.Close()
                MessageBox.Show("No account available with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If
        Else
            MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private passwordShow As Boolean = False


    Private Sub linklblShowPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklblShowPassword.LinkClicked
        'shows/hides password
        If passwordShow = False Then
            txtPassword.PasswordChar = CChar("")
            linklblShowPassword.Text = "Hide Password"
            passwordShow = True
        Else
            txtPassword.PasswordChar = CChar("*")
            linklblShowPassword.Text = "Show Password"
            passwordShow = False
        End If

    End Sub



    Private Sub lnklblCreateNewUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblCreateNewUser.LinkClicked
        'goes to create account link
        Me.Hide()
        Dim createLogin As New CreateAccountForm()
        createLogin.ShowDialog()
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub
End Class
