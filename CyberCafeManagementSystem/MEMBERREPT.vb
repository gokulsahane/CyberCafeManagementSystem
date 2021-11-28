Public Class MEMBERREPT

    Private Sub EEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EEXIT.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub MEMBERREPT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class