<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KiloConverter
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
        Me.btnInches = New System.Windows.Forms.Button()
        Me.btnFeet = New System.Windows.Forms.Button()
        Me.btnMiles = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnYards = New System.Windows.Forms.Button()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnInches
        '
        Me.btnInches.Location = New System.Drawing.Point(30, 91)
        Me.btnInches.Name = "btnInches"
        Me.btnInches.Size = New System.Drawing.Size(75, 23)
        Me.btnInches.TabIndex = 0
        Me.btnInches.Text = "Inches"
        Me.btnInches.UseVisualStyleBackColor = True
        '
        'btnFeet
        '
        Me.btnFeet.Location = New System.Drawing.Point(139, 91)
        Me.btnFeet.Name = "btnFeet"
        Me.btnFeet.Size = New System.Drawing.Size(75, 23)
        Me.btnFeet.TabIndex = 1
        Me.btnFeet.Text = "Feet"
        Me.btnFeet.UseVisualStyleBackColor = True
        '
        'btnMiles
        '
        Me.btnMiles.Location = New System.Drawing.Point(364, 91)
        Me.btnMiles.Name = "btnMiles"
        Me.btnMiles.Size = New System.Drawing.Size(75, 23)
        Me.btnMiles.TabIndex = 2
        Me.btnMiles.Text = "Miles"
        Me.btnMiles.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 133)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnYards
        '
        Me.btnYards.Location = New System.Drawing.Point(251, 91)
        Me.btnYards.Name = "btnYards"
        Me.btnYards.Size = New System.Drawing.Size(75, 23)
        Me.btnYards.TabIndex = 4
        Me.btnYards.Text = "Yards"
        Me.btnYards.UseVisualStyleBackColor = True
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessage.Location = New System.Drawing.Point(158, 21)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(156, 24)
        Me.LblMessage.TabIndex = 5
        Me.LblMessage.Text = "1 Kilometer = ? "
        '
        'KiloConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 168)
        Me.Controls.Add(Me.LblMessage)
        Me.Controls.Add(Me.btnYards)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMiles)
        Me.Controls.Add(Me.btnFeet)
        Me.Controls.Add(Me.btnInches)
        Me.Name = "KiloConverter"
        Me.Text = "Kilometer Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInches As System.Windows.Forms.Button
    Friend WithEvents btnFeet As System.Windows.Forms.Button
    Friend WithEvents btnMiles As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnYards As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label

End Class
