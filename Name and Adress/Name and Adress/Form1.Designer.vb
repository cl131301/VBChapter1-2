﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lblNameAndAdress
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
        Me.btnShowInfo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.lblCityStateZip = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShowInfo
        '
        Me.btnShowInfo.Location = New System.Drawing.Point(46, 168)
        Me.btnShowInfo.Name = "btnShowInfo"
        Me.btnShowInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnShowInfo.TabIndex = 0
        Me.btnShowInfo.Text = "Show Info"
        Me.btnShowInfo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(164, 168)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(87, 41)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(113, 19)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Christine Lewis"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblName.Visible = False
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreet.Location = New System.Drawing.Point(67, 60)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(172, 19)
        Me.lblStreet.TabIndex = 3
        Me.lblStreet.Text = "211 Timber Valley Drive"
        Me.lblStreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblStreet.Visible = False
        '
        'lblCityStateZip
        '
        Me.lblCityStateZip.AutoSize = True
        Me.lblCityStateZip.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityStateZip.Location = New System.Drawing.Point(76, 79)
        Me.lblCityStateZip.Name = "lblCityStateZip"
        Me.lblCityStateZip.Size = New System.Drawing.Size(152, 19)
        Me.lblCityStateZip.TabIndex = 4
        Me.lblCityStateZip.Text = "Blue Grass, IA 52726"
        Me.lblCityStateZip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCityStateZip.Visible = False
        '
        'lblNameAndAdress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblCityStateZip)
        Me.Controls.Add(Me.lblStreet)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowInfo)
        Me.Name = "lblNameAndAdress"
        Me.Text = "Name and Adress"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShowInfo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblStreet As System.Windows.Forms.Label
    Friend WithEvents lblCityStateZip As System.Windows.Forms.Label

End Class
