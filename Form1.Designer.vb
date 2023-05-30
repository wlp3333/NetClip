<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnSend = New Button()
        btnReceive = New Button()
        Label1 = New Label()
        txtNetworkPort = New TextBox()
        rbIPv4 = New RadioButton()
        rbIPv6 = New RadioButton()
        Label2 = New Label()
        txtDetectFreq = New TextBox()
        StatusStrip1 = New StatusStrip()
        tsL1 = New ToolStripStatusLabel()
        tsL2 = New ToolStripStatusLabel()
        PictureBox1 = New PictureBox()
        lblVersion = New Label()
        StatusStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSend
        ' 
        btnSend.Location = New Point(12, 12)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(75, 23)
        btnSend.TabIndex = 0
        btnSend.Text = "Send"
        btnSend.UseVisualStyleBackColor = True
        ' 
        ' btnReceive
        ' 
        btnReceive.Location = New Point(93, 12)
        btnReceive.Name = "btnReceive"
        btnReceive.Size = New Size(75, 23)
        btnReceive.TabIndex = 1
        btnReceive.Text = "Receive"
        btnReceive.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 15)
        Label1.TabIndex = 2
        Label1.Text = "Port:"
        ' 
        ' txtNetworkPort
        ' 
        txtNetworkPort.Location = New Point(50, 41)
        txtNetworkPort.Name = "txtNetworkPort"
        txtNetworkPort.Size = New Size(118, 23)
        txtNetworkPort.TabIndex = 3
        ' 
        ' rbIPv4
        ' 
        rbIPv4.AutoSize = True
        rbIPv4.Checked = True
        rbIPv4.Location = New Point(12, 106)
        rbIPv4.Name = "rbIPv4"
        rbIPv4.Size = New Size(47, 19)
        rbIPv4.TabIndex = 4
        rbIPv4.TabStop = True
        rbIPv4.Text = "IPv4"
        rbIPv4.UseVisualStyleBackColor = True
        ' 
        ' rbIPv6
        ' 
        rbIPv6.AutoSize = True
        rbIPv6.Enabled = False
        rbIPv6.Location = New Point(83, 106)
        rbIPv6.Name = "rbIPv6"
        rbIPv6.Size = New Size(47, 19)
        rbIPv6.TabIndex = 5
        rbIPv6.Text = "IPv6"
        rbIPv6.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 15)
        Label2.TabIndex = 6
        Label2.Text = "Frequency:"
        ' 
        ' txtDetectFreq
        ' 
        txtDetectFreq.Location = New Point(83, 77)
        txtDetectFreq.Name = "txtDetectFreq"
        txtDetectFreq.Size = New Size(85, 23)
        txtDetectFreq.TabIndex = 7
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {tsL1, tsL2})
        StatusStrip1.Location = New Point(0, 130)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(318, 22)
        StatusStrip1.TabIndex = 8
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' tsL1
        ' 
        tsL1.Name = "tsL1"
        tsL1.Size = New Size(45, 17)
        tsL1.Text = "Status: "
        ' 
        ' tsL2
        ' 
        tsL2.Name = "tsL2"
        tsL2.Size = New Size(14, 17)
        tsL2.Text = "X"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.netclip1
        PictureBox1.Location = New Point(174, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(132, 88)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' lblVersion
        ' 
        lblVersion.AutoSize = True
        lblVersion.Location = New Point(174, 108)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(63, 15)
        lblVersion.TabIndex = 10
        lblVersion.Text = "Version 1.0"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(318, 152)
        Controls.Add(lblVersion)
        Controls.Add(PictureBox1)
        Controls.Add(StatusStrip1)
        Controls.Add(txtDetectFreq)
        Controls.Add(Label2)
        Controls.Add(rbIPv6)
        Controls.Add(rbIPv4)
        Controls.Add(txtNetworkPort)
        Controls.Add(Label1)
        Controls.Add(btnReceive)
        Controls.Add(btnSend)
        Name = "Form1"
        Text = "NetClip | Main"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSend As Button
    Friend WithEvents btnReceive As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNetworkPort As TextBox
    Friend WithEvents rbIPv4 As RadioButton
    Friend WithEvents rbIPv6 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDetectFreq As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsL1 As ToolStripStatusLabel
    Friend WithEvents tsL2 As ToolStripStatusLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblVersion As Label
End Class
