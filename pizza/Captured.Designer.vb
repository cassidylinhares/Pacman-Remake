<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Captured
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Captured))
        Me.tryAgain = New System.Windows.Forms.Button()
        Me.quit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tryAgain
        '
        Me.tryAgain.Location = New System.Drawing.Point(29, 201)
        Me.tryAgain.Name = "tryAgain"
        Me.tryAgain.Size = New System.Drawing.Size(75, 23)
        Me.tryAgain.TabIndex = 0
        Me.tryAgain.Text = "Try Again"
        Me.tryAgain.UseVisualStyleBackColor = True
        '
        'quit
        '
        Me.quit.Location = New System.Drawing.Point(177, 201)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(75, 23)
        Me.quit.TabIndex = 1
        Me.quit.Text = "Quit"
        Me.quit.UseVisualStyleBackColor = True
        '
        'Captured
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.tryAgain)
        Me.Name = "Captured"
        Me.Text = "Captured!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tryAgain As Button
    Friend WithEvents quit As Button
End Class
