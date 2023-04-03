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
        components = New ComponentModel.Container()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        visitLabel = New Label()
        daysLabel = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ctyLabel = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(42, 91)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(148, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 15)
        Label1.TabIndex = 1
        Label1.Text = "Select a Location Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(319, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 15)
        Label2.TabIndex = 2
        Label2.Text = "Country:"
        ' 
        ' visitLabel
        ' 
        visitLabel.AutoSize = True
        visitLabel.Location = New Point(319, 140)
        visitLabel.Name = "visitLabel"
        visitLabel.Size = New Size(66, 15)
        visitLabel.TabIndex = 3
        visitLabel.Text = "Visit When:"
        ' 
        ' daysLabel
        ' 
        daysLabel.AutoSize = True
        daysLabel.Location = New Point(319, 190)
        daysLabel.Name = "daysLabel"
        daysLabel.Size = New Size(35, 15)
        daysLabel.TabIndex = 4
        daysLabel.Text = "Days:"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' ctyLabel
        ' 
        ctyLabel.AutoSize = True
        ctyLabel.BorderStyle = BorderStyle.Fixed3D
        ctyLabel.Location = New Point(456, 99)
        ctyLabel.Name = "ctyLabel"
        ctyLabel.Size = New Size(43, 17)
        ctyLabel.TabIndex = 6
        ctyLabel.Text = "Label5"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.Location = New Point(456, 140)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 17)
        Label6.TabIndex = 7
        Label6.Text = "Label6"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Location = New Point(456, 190)
        Label7.Name = "Label7"
        Label7.Size = New Size(43, 17)
        Label7.TabIndex = 8
        Label7.Text = "Label7"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(visitLabel)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(daysLabel)
        Panel1.Controls.Add(ctyLabel)
        Panel1.Location = New Point(114, 82)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(587, 297)
        Panel1.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents visitLabel As Label
    Friend WithEvents daysLabel As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ctyLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
End Class
