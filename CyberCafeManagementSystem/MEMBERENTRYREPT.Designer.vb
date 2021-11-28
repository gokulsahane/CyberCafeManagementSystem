<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MEMBERENTRYREPT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.EEXIT = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'EEXIT
        '
        Me.EEXIT.BackColor = System.Drawing.Color.Red
        Me.EEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EEXIT.Location = New System.Drawing.Point(1019, 572)
        Me.EEXIT.Name = "EEXIT"
        Me.EEXIT.Size = New System.Drawing.Size(87, 35)
        Me.EEXIT.TabIndex = 33
        Me.EEXIT.Text = "EXIT"
        Me.EEXIT.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(43, 50)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1063, 516)
        Me.ReportViewer1.TabIndex = 35
        '
        'MEMBERENTRYREPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.analytics_data_ss_19201_800x450
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1148, 616)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.EEXIT)
        Me.Name = "MEMBERENTRYREPT"
        Me.Text = "MEMBERREPORTREPT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EEXIT As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
