﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GMListe
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GMListe))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(-2, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1060, 466)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "UserUID"
        Me.ColumnHeader1.Width = 109
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "UserID"
        Me.ColumnHeader2.Width = 126
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Passwort"
        Me.ColumnHeader3.Width = 141
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Admin"
        Me.ColumnHeader4.Width = 82
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "AdminLevel"
        Me.ColumnHeader5.Width = 95
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 104
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "UserType"
        Me.ColumnHeader7.Width = 106
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "UserIP"
        Me.ColumnHeader8.Width = 153
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 478)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(282, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "GM-Rechte nehmen..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(303, 478)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(282, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Liste neuladen..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(593, 478)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(282, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Schließen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GMListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 513)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GMListe"
        Me.Text = "GM-Liste"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
