<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditMemberEntryDetails
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
        Me.MEMBERID = New System.Windows.Forms.ComboBox()
        Me.OUTTIME = New System.Windows.Forms.TextBox()
        Me.INTIME = New System.Windows.Forms.TextBox()
        Me.DDATE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.COMPUTERNAME = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FEES = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EEXIT = New System.Windows.Forms.Button()
        Me.DDELETE = New System.Windows.Forms.Button()
        Me.UUPDATE = New System.Windows.Forms.Button()
        Me.CCURRENTTIME = New System.Windows.Forms.Button()
        Me.CCURRENTDATE = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(289, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 36)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "EDIT MEMBER ENTRY DETAILS"
        '
        'MEMBERID
        '
        Me.MEMBERID.BackColor = System.Drawing.Color.MistyRose
        Me.MEMBERID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEMBERID.FormattingEnabled = True
        Me.MEMBERID.Location = New System.Drawing.Point(495, 115)
        Me.MEMBERID.Name = "MEMBERID"
        Me.MEMBERID.Size = New System.Drawing.Size(157, 28)
        Me.MEMBERID.TabIndex = 64
        '
        'OUTTIME
        '
        Me.OUTTIME.BackColor = System.Drawing.Color.MistyRose
        Me.OUTTIME.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OUTTIME.Location = New System.Drawing.Point(493, 263)
        Me.OUTTIME.Name = "OUTTIME"
        Me.OUTTIME.Size = New System.Drawing.Size(157, 29)
        Me.OUTTIME.TabIndex = 63
        '
        'INTIME
        '
        Me.INTIME.BackColor = System.Drawing.Color.MistyRose
        Me.INTIME.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INTIME.Location = New System.Drawing.Point(493, 214)
        Me.INTIME.Name = "INTIME"
        Me.INTIME.Size = New System.Drawing.Size(157, 29)
        Me.INTIME.TabIndex = 62
        '
        'DDATE
        '
        Me.DDATE.BackColor = System.Drawing.Color.MistyRose
        Me.DDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDATE.Location = New System.Drawing.Point(493, 311)
        Me.DDATE.Name = "DDATE"
        Me.DDATE.Size = New System.Drawing.Size(157, 29)
        Me.DDATE.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(401, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 25)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "DATE :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(360, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 25)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "OUTTIME :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(378, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 25)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "IN TIME :"
        '
        'COMPUTERNAME
        '
        Me.COMPUTERNAME.BackColor = System.Drawing.Color.MistyRose
        Me.COMPUTERNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMPUTERNAME.Location = New System.Drawing.Point(493, 161)
        Me.COMPUTERNAME.Name = "COMPUTERNAME"
        Me.COMPUTERNAME.Size = New System.Drawing.Size(157, 29)
        Me.COMPUTERNAME.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(261, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 25)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "COMPUTER NAME :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(340, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 25)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "MEMBER ID:"
        '
        'FEES
        '
        Me.FEES.BackColor = System.Drawing.Color.MistyRose
        Me.FEES.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FEES.Location = New System.Drawing.Point(495, 360)
        Me.FEES.Name = "FEES"
        Me.FEES.Size = New System.Drawing.Size(157, 29)
        Me.FEES.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Yellow
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(402, 360)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 25)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "FEES :"
        '
        'EEXIT
        '
        Me.EEXIT.BackColor = System.Drawing.Color.Red
        Me.EEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EEXIT.Location = New System.Drawing.Point(555, 415)
        Me.EEXIT.Name = "EEXIT"
        Me.EEXIT.Size = New System.Drawing.Size(87, 35)
        Me.EEXIT.TabIndex = 69
        Me.EEXIT.Text = "EXIT"
        Me.EEXIT.UseVisualStyleBackColor = False
        '
        'DDELETE
        '
        Me.DDELETE.BackColor = System.Drawing.Color.Gray
        Me.DDELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDELETE.Location = New System.Drawing.Point(411, 415)
        Me.DDELETE.Name = "DDELETE"
        Me.DDELETE.Size = New System.Drawing.Size(109, 35)
        Me.DDELETE.TabIndex = 68
        Me.DDELETE.Text = "DELETE"
        Me.DDELETE.UseVisualStyleBackColor = False
        '
        'UUPDATE
        '
        Me.UUPDATE.BackColor = System.Drawing.Color.Lime
        Me.UUPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UUPDATE.Location = New System.Drawing.Point(266, 415)
        Me.UUPDATE.Name = "UUPDATE"
        Me.UUPDATE.Size = New System.Drawing.Size(112, 35)
        Me.UUPDATE.TabIndex = 67
        Me.UUPDATE.Text = "UPDATE"
        Me.UUPDATE.UseVisualStyleBackColor = False
        '
        'CCURRENTTIME
        '
        Me.CCURRENTTIME.BackColor = System.Drawing.Color.PaleGreen
        Me.CCURRENTTIME.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCURRENTTIME.Location = New System.Drawing.Point(677, 263)
        Me.CCURRENTTIME.Name = "CCURRENTTIME"
        Me.CCURRENTTIME.Size = New System.Drawing.Size(194, 35)
        Me.CCURRENTTIME.TabIndex = 70
        Me.CCURRENTTIME.Text = "CURRENT TIME"
        Me.CCURRENTTIME.UseVisualStyleBackColor = False
        '
        'CCURRENTDATE
        '
        Me.CCURRENTDATE.BackColor = System.Drawing.Color.PaleGreen
        Me.CCURRENTDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCURRENTDATE.Location = New System.Drawing.Point(677, 311)
        Me.CCURRENTDATE.Name = "CCURRENTDATE"
        Me.CCURRENTDATE.Size = New System.Drawing.Size(208, 35)
        Me.CCURRENTDATE.TabIndex = 71
        Me.CCURRENTDATE.Text = "CURRENT DATE"
        Me.CCURRENTDATE.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCoral
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(667, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 35)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "RECEIPT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'EditMemberEntryDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.customer_experience_header
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1070, 525)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CCURRENTDATE)
        Me.Controls.Add(Me.CCURRENTTIME)
        Me.Controls.Add(Me.EEXIT)
        Me.Controls.Add(Me.DDELETE)
        Me.Controls.Add(Me.UUPDATE)
        Me.Controls.Add(Me.FEES)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MEMBERID)
        Me.Controls.Add(Me.OUTTIME)
        Me.Controls.Add(Me.INTIME)
        Me.Controls.Add(Me.DDATE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.COMPUTERNAME)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditMemberEntryDetails"
        Me.Text = "EDIT MEMBER DETAILS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MEMBERID As System.Windows.Forms.ComboBox
    Friend WithEvents OUTTIME As System.Windows.Forms.TextBox
    Friend WithEvents INTIME As System.Windows.Forms.TextBox
    Friend WithEvents DDATE As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents COMPUTERNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FEES As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EEXIT As System.Windows.Forms.Button
    Friend WithEvents DDELETE As System.Windows.Forms.Button
    Friend WithEvents UUPDATE As System.Windows.Forms.Button
    Friend WithEvents CCURRENTTIME As System.Windows.Forms.Button
    Friend WithEvents CCURRENTDATE As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
