<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditComputerDetails
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
        Me.COMPUTERLOCATION = New System.Windows.Forms.TextBox()
        Me.IDADDRESS = New System.Windows.Forms.TextBox()
        Me.EEXIT = New System.Windows.Forms.Button()
        Me.DDELETE = New System.Windows.Forms.Button()
        Me.UUPDATE = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.COMPUTERNAME = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'COMPUTERLOCATION
        '
        Me.COMPUTERLOCATION.BackColor = System.Drawing.Color.MistyRose
        Me.COMPUTERLOCATION.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMPUTERLOCATION.Location = New System.Drawing.Point(598, 256)
        Me.COMPUTERLOCATION.Name = "COMPUTERLOCATION"
        Me.COMPUTERLOCATION.Size = New System.Drawing.Size(157, 29)
        Me.COMPUTERLOCATION.TabIndex = 19
        '
        'IDADDRESS
        '
        Me.IDADDRESS.BackColor = System.Drawing.Color.MistyRose
        Me.IDADDRESS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDADDRESS.Location = New System.Drawing.Point(598, 306)
        Me.IDADDRESS.Name = "IDADDRESS"
        Me.IDADDRESS.Size = New System.Drawing.Size(157, 29)
        Me.IDADDRESS.TabIndex = 17
        '
        'EEXIT
        '
        Me.EEXIT.BackColor = System.Drawing.Color.Red
        Me.EEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EEXIT.Location = New System.Drawing.Point(655, 369)
        Me.EEXIT.Name = "EEXIT"
        Me.EEXIT.Size = New System.Drawing.Size(87, 35)
        Me.EEXIT.TabIndex = 16
        Me.EEXIT.Text = "EXIT"
        Me.EEXIT.UseVisualStyleBackColor = False
        '
        'DDELETE
        '
        Me.DDELETE.BackColor = System.Drawing.Color.Gray
        Me.DDELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDELETE.Location = New System.Drawing.Point(495, 369)
        Me.DDELETE.Name = "DDELETE"
        Me.DDELETE.Size = New System.Drawing.Size(109, 35)
        Me.DDELETE.TabIndex = 15
        Me.DDELETE.Text = "DELETE"
        Me.DDELETE.UseVisualStyleBackColor = False
        '
        'UUPDATE
        '
        Me.UUPDATE.BackColor = System.Drawing.Color.Lime
        Me.UUPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UUPDATE.Location = New System.Drawing.Point(334, 369)
        Me.UUPDATE.Name = "UUPDATE"
        Me.UUPDATE.Size = New System.Drawing.Size(112, 35)
        Me.UUPDATE.TabIndex = 14
        Me.UUPDATE.Text = "UPDATE"
        Me.UUPDATE.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(329, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ID ADDRESS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(320, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "COMPUTER LOCATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "COMPUTER NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(352, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 36)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "EDIT COMPUTER DETAILS"
        '
        'COMPUTERNAME
        '
        Me.COMPUTERNAME.BackColor = System.Drawing.Color.MistyRose
        Me.COMPUTERNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMPUTERNAME.FormattingEnabled = True
        Me.COMPUTERNAME.Location = New System.Drawing.Point(598, 210)
        Me.COMPUTERNAME.Name = "COMPUTERNAME"
        Me.COMPUTERNAME.Size = New System.Drawing.Size(157, 28)
        Me.COMPUTERNAME.TabIndex = 20
        '
        'EditComputerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.CyberCafe_900x600
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1075, 527)
        Me.Controls.Add(Me.COMPUTERNAME)
        Me.Controls.Add(Me.COMPUTERLOCATION)
        Me.Controls.Add(Me.IDADDRESS)
        Me.Controls.Add(Me.EEXIT)
        Me.Controls.Add(Me.DDELETE)
        Me.Controls.Add(Me.UUPDATE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditComputerDetails"
        Me.Text = "EDIT COMPUTER DETAILS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents COMPUTERLOCATION As System.Windows.Forms.TextBox
    Friend WithEvents IDADDRESS As System.Windows.Forms.TextBox
    Friend WithEvents EEXIT As System.Windows.Forms.Button
    Friend WithEvents DDELETE As System.Windows.Forms.Button
    Friend WithEvents UUPDATE As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents COMPUTERNAME As System.Windows.Forms.ComboBox
End Class
