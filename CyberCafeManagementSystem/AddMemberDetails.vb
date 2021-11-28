Imports System.Data.OleDb
Imports System.Data
Public Class AddMemberDetails
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Core-i3\Desktop\CyberCafeManagementSystem\CyberCafeManagementSystem.accdb;"


    Private Sub EEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EEXIT.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub AddMemberDetails_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub RRESET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RRESET.Click

        MEMBERID.Text = ""
        MEMBERNAME.Text = ""
        ADDRESS.Text = ""
        AGE.Text = ""
        PHONENO.Text = ""
        EMAIL.Text = ""

    End Sub

    Private Sub PHONENO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PHONENO.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If

    End Sub

    Private Sub MEMBERNAME_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MEMBERNAME.KeyPress

        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
       Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
       And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
       Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then

            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If

    End Sub

    Private Sub MEMBERID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MEMBERID.KeyPress

    End Sub

    Private Sub AGE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AGE.KeyPress

        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If

    End Sub

    Private Sub AddMemberDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSAVE.Click

        If Len(Trim(MEMBERID.Text)) = 0 Then
            MessageBox.Show("please enter member id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MEMBERID.Focus()
            Exit Sub
        End If

        If Len(Trim(MEMBERNAME.Text)) = 0 Then
            MessageBox.Show("please enter membername", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MEMBERNAME.Focus()
            Exit Sub
        End If

        If Len(Trim(ADDRESS.Text)) = 0 Then
            MessageBox.Show("Please enter address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ADDRESS.Focus()
            Exit Sub
        End If

        If Len(Trim(AGE.Text)) = 0 Then
            MessageBox.Show("Please enter age", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AGE.Focus()
            Exit Sub
        End If

        If Len(Trim(PHONENO.Text)) = 0 Then
            MessageBox.Show("please enter phoneno", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PHONENO.Focus()
            Exit Sub
        End If

        If Len(Trim(EMAIL.Text)) = 0 Then
            MessageBox.Show("Please enter email ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EMAIL.Focus()
            Exit Sub
        End If


        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select MEMBERID from MEMBER where MEMBERID=@find"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 30, "MEMBERID"))
            cmd.Parameters("@find").Value = MEMBERID.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show(" MEMBERID  is already exist", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MEMBERID.Text = ""

                If Not rdr Is Nothing Then
                    rdr.Close()

                End If
            Else
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb As String = "insert into MEMBER(MEMBERID,MEMBERNAME,ADDRESS,AGE,PHONENO,EMAIL) VALUES (@d1,@d2,@d3,@d4,@d5,@d6)"
                cmd = New OleDbCommand(cb)
                cmd.Connection = con

                cmd.Parameters.Add(New OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 30, "MEMBERID"))
                cmd.Parameters.Add(New OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "MEMBERNAME"))
                cmd.Parameters.Add(New OleDbParameter("@d3", System.Data.OleDb.OleDbType.VarChar, 30, "ADDRESS"))
                cmd.Parameters.Add(New OleDbParameter("@d4", System.Data.OleDb.OleDbType.VarChar, 30, "AGE"))
                cmd.Parameters.Add(New OleDbParameter("@d5", System.Data.OleDb.OleDbType.VarChar, 30, "PHONENO"))
                cmd.Parameters.Add(New OleDbParameter("@d6", System.Data.OleDb.OleDbType.VarChar, 30, "EMAIL"))


                cmd.Parameters("@d1").Value = Trim(MEMBERID.Text)
                cmd.Parameters("@d2").Value = Trim(MEMBERNAME.Text)
                cmd.Parameters("@d3").Value = Trim(ADDRESS.Text)
                cmd.Parameters("@d4").Value = Trim(AGE.Text)
                cmd.Parameters("@d5").Value = Trim(PHONENO.Text)
                cmd.Parameters("@d6").Value = Trim(EMAIL.Text)

                cmd.ExecuteReader()

                MessageBox.Show("MEMBER DETAILS SUCCESSFULLY REGISTERED", "USER", MessageBoxButtons.OK, MessageBoxIcon.Information)


                con.Close()



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class