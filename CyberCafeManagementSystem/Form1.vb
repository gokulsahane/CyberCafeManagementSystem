Imports System.Data
Imports System.Data.OleDb

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub login_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_button.Click
        If Len(Trim(UserName.Text)) = 0 Then
            MessageBox.Show("Please enter username", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UserName.Focus()
            Exit Sub

        End If
        If Len(Trim(Password.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Password.Focus()
            Exit Sub

        End If

        Try
            Dim myConnection As OleDbConnection
            myConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Core-i3\Desktop\CyberCafeManagementSystem\CyberCafeManagementSystem.accdb;")
            Dim myCommand As OleDbCommand
            myCommand = New OleDbCommand("SELECT UserName,Password FROM Users WHERE UserName=@UserName and Password=@Password", myConnection)
            Dim uName As New OleDbParameter("@UserName", SqlDbType.VarChar)
            Dim uPassword As New OleDbParameter("@Password", SqlDbType.VarChar)
            uName.Value = UserName.Text
            uPassword.Value = Password.Text
            myCommand.Parameters.Add(uName)
            myCommand.Parameters.Add(uPassword)
            myCommand.Connection.Open()
            Dim myReader As OleDbDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim Login As Object = 0
            If myReader.HasRows Then
                myReader.Read()
                Login = myReader(Login)

            End If
            If Login = Nothing Then
                MsgBox("login is failed... Try Again|", MsgBoxStyle.Critical, "login denied")
                UserName.Clear()
                Password.Clear()
                UserName.Focus()
            Else
                ProgressBar1.Visible = True
                ProgressBar1.Maximum = 5000
                ProgressBar1.Minimum = 0
                ProgressBar1.Value = 4
                ProgressBar1.Step = 1
                For i = 0 To 5000
                    ProgressBar1.PerformStep()
                Next
                frmMain.ToolStripStatusLabel2.Text = UserName.Text
                Me.Hide()
                frmMain.Show()
            End If
            myCommand.Dispose()
            myConnection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Me.Hide()
    End Sub
End Class
