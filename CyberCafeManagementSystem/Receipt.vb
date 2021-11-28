Imports System.Data.OleDb
Imports System.Data
Public Class Receipt

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

    Private Sub Receipt_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub PRICE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PRICE.KeyPress

        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If

    End Sub




    Sub fillcombo()
        Try
            Dim Cn As New OleDbConnection(cs)
            Cn.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct (MEMBERID) FROM MEMBERENTRY", Cn)
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


    Private Sub Receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcombo()
    End Sub

    Private Sub MEMBERID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEMBERID.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "SELECT * FROM MEMBERENTRY WHERE MEMBERID=@find"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 30, "MEMBERID"))
            cmd.Parameters("@find").Value = Trim(MEMBERID.Text)
            rdr = cmd.ExecuteReader()

            If rdr.Read() Then

                MEMBERNAME.Text = Trim(rdr.GetString(2))
                MEMBERID.Text = Trim(rdr.GetString(1))

                INTIME.Text = Trim(rdr.GetString(7))
                OUTTIME.Text = Trim(rdr.GetString(8))
                PRICE.Text = Trim(rdr.GetString(10))



            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub PPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPRINT.Click

        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select MEMBERID from MEMBERENTRY where MEMBERID=@find"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 30, "MEMBERID"))
            cmd.Parameters("@find").Value = MEMBERID.Text
           
                con = New OleDbConnection(cs)
                con.Open()
            Dim cb As String = "insert into RECEIPT(MEMBERNAME,MEMBERID,INTIME,OUTTIME,PRICE) VALUES (@d1,@d2,@d4,@d5,@d6)"
                cmd = New OleDbCommand(cb)
                cmd.Connection = con

            cmd.Parameters.Add(New OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 30, "MEMBERNAME"))
            cmd.Parameters.Add(New OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "MEMBERID"))

            cmd.Parameters.Add(New OleDbParameter("@d4", System.Data.OleDb.OleDbType.VarChar, 30, "INTIME"))
            cmd.Parameters.Add(New OleDbParameter("@d5", System.Data.OleDb.OleDbType.VarChar, 30, "OUTTIME"))
            cmd.Parameters.Add(New OleDbParameter("@d6", System.Data.OleDb.OleDbType.VarChar, 30, "PRICE"))


            cmd.Parameters("@d1").Value = Trim(MEMBERNAME.Text)
            cmd.Parameters("@d2").Value = Trim(MEMBERID.Text)

            cmd.Parameters("@d4").Value = Trim(INTIME.Text)
            cmd.Parameters("@d5").Value = Trim(OUTTIME.Text)
            cmd.Parameters("@d6").Value = Trim(PRICE.Text)

                cmd.ExecuteReader()

                MessageBox.Show("MEMBER DETAILS SUCCESSFULLY REGISTERED", "USER", MessageBoxButtons.OK, MessageBoxIcon.Information)


                con.Close()




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        AddMemberEntryDetails.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        EditMemberEntryDetails.Show()
    End Sub
End Class

