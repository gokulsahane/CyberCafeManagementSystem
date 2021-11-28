<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewComputer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SSAVE = New System.Windows.Forms.Button()
        Me.RRESET = New System.Windows.Forms.Button()
        Me.EEXIT = New System.Windows.Forms.Button()
        Me.IDADDRESS = New System.Windows.Forms.TextBox()
        Me.COMPUTERNAME = New System.Windows.Forms.TextBox()
        Me.COMPUTERLOCATION = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(333, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD NEW COMPUTER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(318, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "COMPUTER NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(278, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "COMPUTER LOCATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(381, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID ADDRESS"
        '
        'SSAVE
        '
        Me.SSAVE.BackColor = System.Drawing.Color.Lime
        Me.SSAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSAVE.Location = New System.Drawing.Point(283, 335)
        Me.SSAVE.Name = "SSAVE"
        Me.SSAVE.Size = New System.Drawing.Size(112, 35)
        Me.SSAVE.TabIndex = 4
        Me.SSAVE.Text = "SAVE"
        Me.SSAVE.UseVisualStyleBackColor = False
        '
        'RRESET
        '
        Me.RRESET.BackColor = System.Drawing.Color.Gray
        Me.RRESET.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RRESET.Location = New System.Drawing.Point(444, 335)
        Me.RRESET.Name = "RRESET"
        Me.RRESET.Size = New System.Drawing.Size(109, 35)
        Me.RRESET.TabIndex = 5
        Me.RRESET.Text = "RESET"
        Me.RRESET.UseVisualStyleBackColor = False
        '
        'EEXIT
        '
        Me.EEXIT.BackColor = System.Drawing.Color.Red
        Me.EEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EEXIT.Location = New System.Drawing.Point(604, 335)
        Me.EEXIT.Name = "EEXIT"
        Me.EEXIT.Size = New System.Drawing.Size(87, 35)
        Me.EEXIT.TabIndex = 6
        Me.EEXIT.Text = "EXIT"
        Me.EEXIT.UseVisualStyleBackColor = False
        '
        'IDADDRESS
        '
        Me.IDADDRESS.BackColor = System.Drawing.Color.MistyRose
        Me.IDADDRESS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDADDRESS.Location = New System.Drawing.Point(547, 272)
        Me.IDADDRESS.Name = "IDADDRESS"
        Me.IDADDRESS.Size = New System.Drawing.Size(157, 29)
        Me.IDADDRESS.TabIndex = 7
        '
        'COMPUTERNAME
        '
        Me.COMPUTERNAME.BackColor = System.Drawing.Color.MistyRose
        Me.COMPUTERNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMPUTERNAME.Location = New System.Drawing.Point(547, 175)
        Me.COMPUTERNAME.Name = "COMPUTERNAME"
        Me.COMPUTERNAME.Size = New System.Drawing.Size(157, 29)
        Me.COMPUTERNAME.TabIndex = 8
        '
        'COMPUTERLOCATION
        '
        Me.COMPUTERLOCATION.BackColor = System.Drawing.Color.MistyRose
        Me.COMPUTERLOCATION.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMPUTERLOCATION.Location = New System.Drawing.Point(547, 222)
        Me.COMPUTERLOCATION.Name = "COMPUTERLOCATION"
        Me.COMPUTERLOCATION.Size = New System.Drawing.Size(157, 29)
        Me.COMPUTERLOCATION.TabIndex = 9
        '
        'AddNewComputer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.CyberCafe_900x600
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1073, 522)
        Me.Controls.Add(Me.COMPUTERLOCATION)
        Me.Controls.Add(Me.COMPUTERNAME)
        Me.Controls.Add(Me.IDADDRESS)
        Me.Controls.Add(Me.EEXIT)
        Me.Controls.Add(Me.RRESET)
        Me.Controls.Add(Me.SSAVE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddNewComputer"
        Me.Text = "ADD NEW COMPUTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SSAVE As System.Windows.Forms.Button
    Friend WithEvents RRESET As System.Windows.Forms.Button
    Friend WithEvents EEXIT As System.Windows.Forms.Button
    Friend WithEvents IDADDRESS As System.Windows.Forms.TextBox
    Friend WithEvents COMPUTERNAME As System.Windows.Forms.TextBox
    Friend WithEvents COMPUTERLOCATION As System.Windows.Forms.TextBox
End Class
