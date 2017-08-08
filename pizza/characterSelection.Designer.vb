<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class characterSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(characterSelection))
        Me.ReggieB = New System.Windows.Forms.Button()
        Me.SuzzyB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ReggieB
        '
        Me.ReggieB.BackColor = System.Drawing.Color.Transparent
        Me.ReggieB.Image = CType(resources.GetObject("ReggieB.Image"), System.Drawing.Image)
        Me.ReggieB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ReggieB.Location = New System.Drawing.Point(96, 12)
        Me.ReggieB.Name = "ReggieB"
        Me.ReggieB.Size = New System.Drawing.Size(80, 88)
        Me.ReggieB.TabIndex = 0
        Me.ReggieB.Text = "Reggie"
        Me.ReggieB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ReggieB.UseVisualStyleBackColor = False
        '
        'SuzzyB
        '
        Me.SuzzyB.Image = CType(resources.GetObject("SuzzyB.Image"), System.Drawing.Image)
        Me.SuzzyB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SuzzyB.Location = New System.Drawing.Point(96, 137)
        Me.SuzzyB.Name = "SuzzyB"
        Me.SuzzyB.Size = New System.Drawing.Size(80, 88)
        Me.SuzzyB.TabIndex = 1
        Me.SuzzyB.Text = "Suzzy"
        Me.SuzzyB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SuzzyB.UseVisualStyleBackColor = True
        '
        'characterSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.SuzzyB)
        Me.Controls.Add(Me.ReggieB)
        Me.Name = "characterSelection"
        Me.Text = "characterSelection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReggieB As Button
    Friend WithEvents SuzzyB As Button
End Class
