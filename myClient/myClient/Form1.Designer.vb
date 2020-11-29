<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.inputServerIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.connectButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.outData = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'inputServerIP
        '
        Me.inputServerIP.Location = New System.Drawing.Point(12, 44)
        Me.inputServerIP.Name = "inputServerIP"
        Me.inputServerIP.Size = New System.Drawing.Size(100, 20)
        Me.inputServerIP.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server IP:"
        '
        'connectButton
        '
        Me.connectButton.Location = New System.Drawing.Point(119, 40)
        Me.connectButton.Name = "connectButton"
        Me.connectButton.Size = New System.Drawing.Size(75, 23)
        Me.connectButton.TabIndex = 2
        Me.connectButton.Text = "Connect"
        Me.connectButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data Recieved:"
        '
        'outData
        '
        Me.outData.Location = New System.Drawing.Point(12, 109)
        Me.outData.Name = "outData"
        Me.outData.Size = New System.Drawing.Size(100, 20)
        Me.outData.TabIndex = 4
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.outData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.connectButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inputServerIP)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputServerIP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents connectButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents outData As TextBox
    Friend WithEvents Timer1 As Timer
End Class
