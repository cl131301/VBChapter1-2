﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrenchNumbers
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
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Do you know the French words for the numbers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " 1 through 5?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the buttons be" & _
    "low to see them."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(35, 115)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(40, 23)
        Me.btnOne.TabIndex = 1
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Location = New System.Drawing.Point(81, 115)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(40, 23)
        Me.btnTwo.TabIndex = 2
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Location = New System.Drawing.Point(173, 115)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(40, 23)
        Me.btnFour.TabIndex = 3
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Location = New System.Drawing.Point(127, 115)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(40, 23)
        Me.btnThree.TabIndex = 4
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(113, 144)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnFive
        '
        Me.btnFive.Location = New System.Drawing.Point(219, 115)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(40, 23)
        Me.btnFive.TabIndex = 6
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = True
        '
        'FrenchNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 200)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrenchNumbers"
        Me.Text = "French Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOne As System.Windows.Forms.Button
    Friend WithEvents btnTwo As System.Windows.Forms.Button
    Friend WithEvents btnFour As System.Windows.Forms.Button
    Friend WithEvents btnThree As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnFive As System.Windows.Forms.Button

End Class
