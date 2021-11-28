Imports System.Data.OleDb
Imports System.Data

Public Class MemberReports

    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Core-i3\Desktop\CyberCafeManagementSystem\CyberCafeManagementSystem.accdb;"
    Private Const ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Core-i3\Desktop\CyberCafeManagementSystem\CyberCafeManagementSystem.accdb;"






    Private Sub EEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EEXIT.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub MemberReports_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frmMain.Show()
    End Sub

    Private ReadOnly Property Connection() As OleDbConnection
        Get
            Dim ConnectionToFetch As New OleDbConnection(ConnectionString)
            ConnectionToFetch.Open()
            Return ConnectionToFetch

        End Get
    End Property



    Public Function GetData() As DataView
        Dim SelectQry = "SELECT (MEMBERID) AS [MEMBER ID],(MEMBERNAME) AS [MEMBER NAME],(ADDRESS) AS [ADDRESS],(AGE) AS [AGE],(PHONENO) AS [PHONE NO],(EMAIL) AS [EMAIL] FROM MEMBER"
        Dim SampleSource As New DataSet
        Dim TableView As DataView

        Try
            Dim SampleDataAdapter = New OleDbDataAdapter()
            Dim SampleCommand = New OleDbCommand
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = Connection
            SampleDataAdapter.SelectCommand = SampleCommand
            SampleDataAdapter.Fill(SampleSource)
            TableView = SampleSource.Tables(0).DefaultView
        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return TableView


    End Function

    Private Sub MemberReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = GetData()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT (MEMBERID) AS [MEMBER ID],(MEMBERNAME) AS [MEMBER NAME],(ADDRESS) AS [ADDRESS],(AGE) AS [AGE],(PHONENO) AS [PHONE NO],(EMAIL) AS [EMAIL] FROM MEMBER WHERE MEMBERNAME LIKE '" & TextBox1.Text & "%' ORDER BY MEMBERID", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "MEMBERENTRY")
            DataGridView1.DataSource = myDataSet.Tables("MEMBERENTRY").DefaultView
            con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class