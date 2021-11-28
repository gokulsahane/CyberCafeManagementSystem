Imports System.Data.OleDb
Imports System.Data
Public Class EditComputerDetails
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Core-i3\Desktop\CyberCafeManagementSystem\CyberCafeManagementSystem.accdb;"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UUPDATE.Click
        Try
            If COMPUTERNAME.Text = "" Then
                MessageBox.Show("PLEASE SELECT COMPUTER NAME", "ENTRY", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub

            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update COMPUTER set COMPUTERLOCATION ='" & COMPUTERLOCATION.Text & "',IDADDRESS='" & IDADDRESS.Text & "' where COMPUTERNAME='" & COMPUTERNAME.Text & "'"
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

    Private Sub EEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EEXIT.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub EditComputerDetails_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frmMain.Show()
    End Sub
    Sub fillcombo()
        Try
            Dim Cn As New OleDbConnection(cs)
            Cn.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct (COMPUTERNAME) FROM COMPUTER", Cn)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            COMPUTERNAME.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                COMPUTERNAME.Items.Add(drow(0).ToString())
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub EditComputerDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcombo()
    End Sub

    Private Sub DSE_ID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPUTERNAME.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "SELECT * FROM COMPUTER WHERE COMPUTERNAME=@find"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 30, "COMPUTERNAME"))
            cmd.Parameters("@find").Value = Trim(COMPUTERNAME.Text)
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then
                COMPUTERLOCATION.Text = Trim(rdr.GetString(1))
                IDADDRESS.Text = Trim(rdr.GetString(2))

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
            If COMPUTERNAME.Text = "" Then
                MessageBox.Show("PLEASE SELECT COMPUTERNAME", "ENTRY", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If COMPUTERNAME.Items.Count > 0 Then

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

            Dim cq As String = "delete from COMPUTER where COMPUTERNAME=@DELETE1;"
            cmd = New OleDbCommand(cq)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@DELETE1", System.Data.OleDb.OleDbType.VarChar, 30, "COMPUTERNAME"))
            cmd.Parameters("@DELETE1").Value = Trim(COMPUTERNAME.Text)
            RowsAffected = cmd.ExecuteNonQuery()

            If RowsAffected > 0 Then
                MessageBox.Show("SUCCESSFULLY DELETED", "RECORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox("SORRY NO RECORDS DELETED")
                COMPUTERNAME.Text = ""
                COMPUTERLOCATION.Text = ""
                IDADDRESS.Text = ""

                cmd.ExecuteReader()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()
            End If
            COMPUTERNAME.Text = ""
            COMPUTERLOCATION.Text = ""
            IDADDRESS.Text = ""



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub
End Class