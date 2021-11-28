Imports System.Data.OleDb
Imports System.Data

Public Class AddNewComputer
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Core-i3\Desktop\CyberCafeManagementSystem\CyberCafeManagementSystem.accdb;"

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub EEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EEXIT.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub AddNewComputer_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub AddNewComputer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RRESET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RRESET.Click
        COMPUTERNAME.Text = ""
        COMPUTERLOCATION.Text = ""
        IDADDRESS.Text = ""

    End Sub
   

    Private Sub SSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSAVE.Click

        If Len(Trim(COMPUTERNAME.Text)) = 0 Then
            MessageBox.Show("Plese enter computer name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            COMPUTERNAME.Focus()
            Exit Sub
        End If

        If Len(Trim(COMPUTERLOCATION.Text)) = 0 Then
            MessageBox.Show("Please enter computer location", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            COMPUTERLOCATION.Focus()
            Exit Sub
        End If

        If Len(Trim(IDADDRESS.Text)) = 0 Then
            MessageBox.Show("Please enter id address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            IDADDRESS.Focus()
            Exit Sub
        End If

        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select COMPUTERNAME from COMPUTER where COMPUTERNAME=@find"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 30, "COMPUTERNAME"))
            cmd.Parameters("@find").Value = COMPUTERNAME.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show(" COMPUTERNAME  is already exist", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                COMPUTERNAME.Text = ""

                If Not rdr Is Nothing Then
                    rdr.Close()

                End If
            Else
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb As String = "insert into COMPUTER(COMPUTERNAME,COMPUTERLOCATION,IDADDRESS) VALUES (@d1,@d2,@d3)"
                cmd = New OleDbCommand(cb)
                cmd.Connection = con

                cmd.Parameters.Add(New OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 30, "COMPUTERNAME"))
                cmd.Parameters.Add(New OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "COMPUTERLOCATION"))
                cmd.Parameters.Add(New OleDbParameter("@d3", System.Data.OleDb.OleDbType.VarChar, 30, "IDADDRESS"))

                cmd.Parameters("@d1").Value = Trim(COMPUTERNAME.Text)
                cmd.Parameters("@d2").Value = Trim(COMPUTERLOCATION.Text)
                cmd.Parameters("@d3").Value = Trim(IDADDRESS.Text)

                cmd.ExecuteReader()

                MessageBox.Show("RECORDS SUCCESSFULLY REGISTERED", "USER", MessageBoxButtons.OK, MessageBoxIcon.Information)


                con.Close()



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class