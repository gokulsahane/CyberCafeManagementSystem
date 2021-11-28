﻿Imports System.Data.OleDb
Imports System.Data

Public Class AddMemberEntryDetails

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

    Private Sub AddMemberEntryDetails_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub RRESET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RRESET.Click

        MEMBERID.Text = ""
        MEMBERNAME.Text = ""
        ADDRESS.Text = ""
        PHONENO.Text = ""
        EMAIL.Text = ""
        COMPUTERNAME.Text = ""
        INTIME.Text = ""
        OUTTIME.Text = ""
        FEES.Text = ""
        TextBox1.Text = ""

    End Sub

    Private Sub PHONENO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PHONENO.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FEES_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FEES.KeyPress
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

    Private Sub SSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSAVE.Click

       
        If Len(Trim(MEMBERID.Text)) = 0 Then
            MessageBox.Show("please enter member id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MEMBERID.Focus()
            Exit Sub
        End If

        If Len(Trim(MEMBERNAME.Text)) = 0 Then
            MessageBox.Show("please enter member name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MEMBERNAME.Focus()
            Exit Sub
        End If

        If Len(Trim(ADDRESS.Text)) = 0 Then
            MessageBox.Show("please enter address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ADDRESS.Focus()
            Exit Sub
        End If

        If Len(Trim(PHONENO.Text)) = 0 Then
            MessageBox.Show("please enter phoneno", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PHONENO.Focus()
            Exit Sub
        End If

        If Len(Trim(EMAIL.Text)) = 0 Then
            MessageBox.Show("please enter email address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EMAIL.Focus()
            Exit Sub
        End If

        If Len(Trim(COMPUTERNAME.Text)) = 0 Then
            MessageBox.Show("please enter computer name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            COMPUTERNAME.Focus()
            Exit Sub
        End If

        If Len(Trim(INTIME.Text)) = 0 Then
            MessageBox.Show("please enter in time", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            INTIME.Focus()
            Exit Sub
        End If

        If Len(Trim(OUTTIME.Text)) = 0 Then
            MessageBox.Show("please enter outtime", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OUTTIME.Focus()
            Exit Sub
        End If

        If Len(Trim(DDATE.Text)) = 0 Then
            MessageBox.Show("please enter date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DDATE.Focus()
            Exit Sub
        End If

        If Len(Trim(FEES.Text)) = 0 Then
            MessageBox.Show("please enter fees", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FEES.Focus()
            Exit Sub
        End If


        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select MEMBERID from MEMBERENTRY where MEMBERID=@find"

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
                Dim cb As String = "insert into MEMBERENTRY(MEMBERID,MEMBERNAME,ADDRESS,PHONENO,EMAIL,COMPUTERNAME,INTIME,OUTTIME,DDATE,FEES,AGE) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11)"
                cmd = New OleDbCommand(cb)
                cmd.Connection = con

                cmd.Parameters.Add(New OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 30, "MEMBERID"))
                cmd.Parameters.Add(New OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "MEMBERNAME"))
                cmd.Parameters.Add(New OleDbParameter("@d3", System.Data.OleDb.OleDbType.VarChar, 30, "ADDRESS"))
                cmd.Parameters.Add(New OleDbParameter("@d4", System.Data.OleDb.OleDbType.VarChar, 30, "PHONENO"))
                cmd.Parameters.Add(New OleDbParameter("@d5", System.Data.OleDb.OleDbType.VarChar, 30, "EMAIL"))
                cmd.Parameters.Add(New OleDbParameter("@d6", System.Data.OleDb.OleDbType.VarChar, 30, "COMPUTERNAME"))
                cmd.Parameters.Add(New OleDbParameter("@d7", System.Data.OleDb.OleDbType.VarChar, 30, "INTIME"))
                cmd.Parameters.Add(New OleDbParameter("@d8", System.Data.OleDb.OleDbType.VarChar, 30, "OUTTIME"))
                cmd.Parameters.Add(New OleDbParameter("@d9", System.Data.OleDb.OleDbType.VarChar, 30, "DDATE"))
                cmd.Parameters.Add(New OleDbParameter("@d10", System.Data.OleDb.OleDbType.VarChar, 30, "FEES"))
                cmd.Parameters.Add(New OleDbParameter("@d11", System.Data.OleDb.OleDbType.VarChar, 30, "AGE"))


                cmd.Parameters("@d1").Value = Trim(MEMBERID.Text)
                cmd.Parameters("@d2").Value = Trim(MEMBERNAME.Text)
                cmd.Parameters("@d3").Value = Trim(ADDRESS.Text)
                cmd.Parameters("@d4").Value = Trim(PHONENO.Text)
                cmd.Parameters("@d5").Value = Trim(EMAIL.Text)
                cmd.Parameters("@d6").Value = Trim(COMPUTERNAME.Text)
                cmd.Parameters("@d7").Value = Trim(INTIME.Text)
                cmd.Parameters("@d8").Value = Trim(OUTTIME.Text)
                cmd.Parameters("@d9").Value = Trim(DDATE.Text)
                cmd.Parameters("@d10").Value = Trim(FEES.Text)
                cmd.Parameters("@d11").Value = Trim(TextBox1.Text)

                cmd.ExecuteReader()

                MessageBox.Show("MEMBER DETAILS SUCCESSFULLY REGISTERED", "USER", MessageBoxButtons.OK, MessageBoxIcon.Information)


                con.Close()



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

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



    Sub fillcombo1()

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




    Private Sub AddMemberEntryDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcombo()
        fillcombo1()
        DDATE.Text = Today
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
                EMAIL.Text = Trim(rdr.GetString(5))
                PHONENO.Text = Trim(rdr.GetString(4))
                TextBox1.Text = Trim(rdr.GetString(3))
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub CCURRENTTIME_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCURRENTTIME.Click
        INTIME.Text = TimeOfDay
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Receipt.Show()
    End Sub
End Class






