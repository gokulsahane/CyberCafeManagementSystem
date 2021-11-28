Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel4.Text = Now
    End Sub


    Private Sub ABOUTUSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECEIPTToolStripMenuItem.Click
    End Sub

    Private Sub ADDCOMPUTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDCOMPUTERToolStripMenuItem.Click
        Me.Hide()
        AddNewComputer.Show()
    End Sub

    Private Sub EDITCOMPUTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITCOMPUTERToolStripMenuItem.Click
        Me.Hide()
        EditComputerDetails.Show()
    End Sub

    Private Sub ADDMEMBERDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDMEMBERDETAILSToolStripMenuItem.Click
        Me.Hide()
        AddMemberDetails.Show()
    End Sub

    Private Sub EDITMEMBERDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITMEMBERDETAILSToolStripMenuItem.Click
        Me.Hide()
        EditMemberDetails.Show()

    End Sub

    Private Sub ADDMEMBERENTRYDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDMEMBERENTRYDETAILSToolStripMenuItem.Click
        Me.Hide()
        AddMemberEntryDetails.Show()
    End Sub

    Private Sub EDITMEMBERENTRYDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITMEMBERENTRYDETAILSToolStripMenuItem.Click
        Me.Hide()
        EditMemberEntryDetails.Show()
    End Sub

    Private Sub COMPUTERREPORTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPUTERDATAToolStripMenuItem.Click
        Me.Hide()
        ComputerReports.Show()
    End Sub

    Private Sub MEMBERREPORTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEMBERDATAToolStripMenuItem.Click
        Me.Hide()
        MemberReports.Show()
    End Sub

    Private Sub ENTRYREPORTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ENTRYDATAToolStripMenuItem.Click
        Me.Hide()
        EntryReports.Show()
    End Sub

    

    Private Sub REPORTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTSToolStripMenuItem.Click

    End Sub

    

    

    Private Sub RECEIPTDATAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECEIPTDATAToolStripMenuItem.Click
        Me.Hide()
        ReceiptReports.Show()
    End Sub

    Private Sub MEMBERRECEIPTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEMBERRECEIPTToolStripMenuItem.Click
        Me.Hide()
        MEMBERREPT.Show()

    End Sub

    Private Sub LOGOUTToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem1.Click
        Me.Hide()
        Form1.Show()
        Form1.UserName.Text = ""
        Form1.Password.Text = ""
        Form1.UserName.Focus()
        Form1.ProgressBar1.Visible = False
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Hide()
        AboutUs.Show()
    End Sub

    Private Sub ABOUTUSToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABOUTUSToolStripMenuItem1.Click
        Me.Hide()
        Receipt.Show()
    End Sub

    Private Sub COMPUTERRECEIPTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPUTERRECEIPTToolStripMenuItem.Click
        Me.Hide()
        COMPUTERREPT.Show()

    End Sub

    Private Sub MEMBERENTRYRECEIPTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEMBERENTRYRECEIPTToolStripMenuItem.Click
        Me.Hide()
        MEMBERENTRYREPT.Show()

    End Sub

    Private Sub BILLSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BILLSToolStripMenuItem.Click
        Me.Hide()
        BILLREPT.Show()
    End Sub
End Class