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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HashCBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KodTBox = New System.Windows.Forms.TextBox()
        Me.KodlaBtn = New System.Windows.Forms.Button()
        Me.UzunlukLbl = New System.Windows.Forms.Label()
        Me.MetinTBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hash Algoritması:"
        '
        'HashCBox
        '
        Me.HashCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HashCBox.FormattingEnabled = True
        Me.HashCBox.Items.AddRange(New Object() {"MD5", "SHA1", "SHA256", "SHA384", "SHA512"})
        Me.HashCBox.Location = New System.Drawing.Point(145, 8)
        Me.HashCBox.Name = "HashCBox"
        Me.HashCBox.Size = New System.Drawing.Size(121, 23)
        Me.HashCBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hash Kodu:"
        '
        'KodTBox
        '
        Me.KodTBox.Location = New System.Drawing.Point(145, 69)
        Me.KodTBox.Multiline = True
        Me.KodTBox.Name = "KodTBox"
        Me.KodTBox.Size = New System.Drawing.Size(346, 64)
        Me.KodTBox.TabIndex = 3
        '
        'KodlaBtn
        '
        Me.KodlaBtn.Location = New System.Drawing.Point(145, 139)
        Me.KodlaBtn.Name = "KodlaBtn"
        Me.KodlaBtn.Size = New System.Drawing.Size(121, 23)
        Me.KodlaBtn.TabIndex = 4
        Me.KodlaBtn.Text = "Kodla"
        Me.KodlaBtn.UseVisualStyleBackColor = True
        '
        'UzunlukLbl
        '
        Me.UzunlukLbl.AutoSize = True
        Me.UzunlukLbl.Location = New System.Drawing.Point(281, 11)
        Me.UzunlukLbl.Name = "UzunlukLbl"
        Me.UzunlukLbl.Size = New System.Drawing.Size(13, 15)
        Me.UzunlukLbl.TabIndex = 5
        Me.UzunlukLbl.Text = "0"
        '
        'MetinTBox
        '
        Me.MetinTBox.Location = New System.Drawing.Point(145, 40)
        Me.MetinTBox.Name = "MetinTBox"
        Me.MetinTBox.Size = New System.Drawing.Size(346, 23)
        Me.MetinTBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Metin:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 191)
        Me.Controls.Add(Me.MetinTBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.UzunlukLbl)
        Me.Controls.Add(Me.KodlaBtn)
        Me.Controls.Add(Me.KodTBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HashCBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Hash Algoritmaları"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents HashCBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents KodTBox As TextBox
    Friend WithEvents KodlaBtn As Button
    Friend WithEvents UzunlukLbl As Label
    Friend WithEvents MetinTBox As TextBox
    Friend WithEvents Label3 As Label
End Class
