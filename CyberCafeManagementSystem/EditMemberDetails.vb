Imports System.Data.OleDb
Imports System.Data
Public Class EditMemberDetails
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

    Private Sub EditMemberDetails_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub PHONENO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PHONENO.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub MEMBERNAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEMBERNAME.TextChanged

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

    Private Sub AGE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AGE.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub EditMemberDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcombo()
    End Sub

    Private Sub UUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UUPDATE.Click
        Try
            If MEMBERID.Text = "" Then
                MessageBox.Show("PLEASE SELECT MEMBER ID", "ENTRY", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub

            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update MEMBER set MEMBERNAME ='" & MEMBERNAME.Text & "',ADDRESS='" & ADDRESS.Text & "',AGE ='" & AGE.Text & "',PHONENO='" & PHONENO.Text & "',EMAIL='" & EMAIL.Text & "' where MEMBERID='" & MEMBERID.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            MessageBox.Show("SUCCESSFULLY UPLOADED", "USERDETAILS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fillcombo()
            con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Sub fillcombo()
        Try
            Dim Cn As New OleDbConnection(cs)
            Cn.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct (MEMBERID) FROM MEMBER", Cn)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            MEMBERID.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                MEMBERID.Items.Add(drow(0).ToString())
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub MEMBERID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEMBERID.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "SELECT * FROM MEMBER WHERE MEMBERID=@find"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 30, "MEMBERID"))
            cmd.Parameters("@find").Value = Trim(MEMBERID.Text)
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                MEMBERNAME.Text = Trim(rdr.GetString(1))
                ADDRESS.Text = Trim(rdr.GetString(2))
                AGE.Text = Trim(rdr.GetString(3))
                PHONENO.Text = Trim(rdr.GetString(4))
                EMAIL.Text = Trim(rdr.GetString(5))


            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub DDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DDELETE.Click
        Try
            If MEMBERID.Text = "" Then
                MessageBox.Show("PLEASE SELECT MEMBERID", "ENTRY", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If MEMBERID.Items.Count > 0 Then

                delete_records()
                fillcombo()
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub delete_records()

        Try
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()

            Dim cq As String = "delete from MEMBER where MEMBERID=@DELETE1;"
            cmd = New OleDbCommand(cq)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@DELETE1", System.Data.OleDb.OleDbType.VarChar, 30, "MEMBERID"))
            cmd.Parameters("@DELETE1").Value = Trim(MEMBERID.Text)
            RowsAffected = cmd.ExecuteNonQuery()

            If RowsAffected > 0 Then
                MessageBox.Show("SUCCESSFULLY DELETED", "RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox("SORRY NO RECORDS DELETED")
                MEMBERID.Text = ""
                MEMBERNAME.Text = ""
                ADDRESS.Text = ""
                AGE.Text = ""
                PHONENO.Text = ""
                EMAIL.Text = ""

                cmd.ExecuteReader()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()
            End If
            MEMBERID.Text = ""
            MEMBERNAME.Text = ""
            ADDRESS.Text = ""
            AGE.Text = ""
            PHONENO.Text = ""
            EMAIL.Text = ""


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub


End Class