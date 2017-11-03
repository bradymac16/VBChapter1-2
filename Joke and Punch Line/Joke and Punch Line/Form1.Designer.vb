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
        Me.btnPunchLine = New System.Windows.Forms.Button()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.lblSetup = New System.Windows.Forms.Label()
        Me.lblPunch = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPunchLine
        '
        Me.btnPunchLine.Location = New System.Drawing.Point(168, 198)
        Me.btnPunchLine.Name = "btnPunchLine"
        Me.btnPunchLine.Size = New System.Drawing.Size(75, 23)
        Me.btnPunchLine.TabIndex = 0
        Me.btnPunchLine.Text = "Punch Line"
        Me.btnPunchLine.UseVisualStyleBackColor = True
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(41, 198)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup.TabIndex = 1
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'lblSetup
        '
        Me.lblSetup.AutoSize = True
        Me.lblSetup.Location = New System.Drawing.Point(-3, 61)
        Me.lblSetup.Name = "lblSetup"
        Me.lblSetup.Size = New System.Drawing.Size(289, 13)
        Me.lblSetup.TabIndex = 2
        Me.lblSetup.Text = "How many programmers does it take to change a light bulb?"
        Me.lblSetup.Visible = False
        '
        'lblPunch
        '
        Me.lblPunch.AutoSize = True
        Me.lblPunch.Location = New System.Drawing.Point(61, 102)
        Me.lblPunch.Name = "lblPunch"
        Me.lblPunch.Size = New System.Drawing.Size(165, 13)
        Me.lblPunch.TabIndex = 3
        Me.lblPunch.Text = "None. Thats a hardware problem."
        Me.lblPunch.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblPunch)
        Me.Controls.Add(Me.lblSetup)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.btnPunchLine)
        Me.Name = "Form1"
        Me.Text = "Joke and Punch Line"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPunchLine As System.Windows.Forms.Button
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents lblSetup As System.Windows.Forms.Label
    Friend WithEvents lblPunch As System.Windows.Forms.Label

End Class
