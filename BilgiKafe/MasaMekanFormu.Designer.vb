<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasaMekanFormu
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.KaydetBtn = New System.Windows.Forms.Button()
        Me.EkleBtn = New System.Windows.Forms.Button()
        Me.SilBtn = New System.Windows.Forms.Button()
        Me.VazgecBtn = New System.Windows.Forms.Button()
        Me.MasaMekanAdiTBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MekanlarDGV = New System.Windows.Forms.DataGridView()
        Me.MasaMekanNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasaMekanAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasaMekanTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.BilgiKafeDS = New System.Data.DataSet()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.MekanlarDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasaMekanTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.KaydetBtn, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EkleBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SilBtn, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.VazgecBtn, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 184)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(428, 75)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'KaydetBtn
        '
        Me.KaydetBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KaydetBtn.Image = Global.BilgiKafe.My.Resources.Resources.Kaydet
        Me.KaydetBtn.Location = New System.Drawing.Point(324, 3)
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(101, 69)
        Me.KaydetBtn.TabIndex = 0
        Me.KaydetBtn.Text = "&Kaydet"
        Me.KaydetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'EkleBtn
        '
        Me.EkleBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EkleBtn.Image = Global.BilgiKafe.My.Resources.Resources.Ekle
        Me.EkleBtn.Location = New System.Drawing.Point(3, 3)
        Me.EkleBtn.Name = "EkleBtn"
        Me.EkleBtn.Size = New System.Drawing.Size(101, 69)
        Me.EkleBtn.TabIndex = 1
        Me.EkleBtn.Text = "&Ekle"
        Me.EkleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'SilBtn
        '
        Me.SilBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SilBtn.Image = Global.BilgiKafe.My.Resources.Resources.Sil
        Me.SilBtn.Location = New System.Drawing.Point(217, 3)
        Me.SilBtn.Name = "SilBtn"
        Me.SilBtn.Size = New System.Drawing.Size(101, 69)
        Me.SilBtn.TabIndex = 3
        Me.SilBtn.Text = "Sil"
        Me.SilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'VazgecBtn
        '
        Me.VazgecBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VazgecBtn.Image = Global.BilgiKafe.My.Resources.Resources.Vazgec
        Me.VazgecBtn.Location = New System.Drawing.Point(110, 3)
        Me.VazgecBtn.Name = "VazgecBtn"
        Me.VazgecBtn.Size = New System.Drawing.Size(101, 69)
        Me.VazgecBtn.TabIndex = 2
        Me.VazgecBtn.Text = "Vazgeç"
        Me.VazgecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'MasaMekanAdiTBox
        '
        Me.MasaMekanAdiTBox.Location = New System.Drawing.Point(131, 22)
        Me.MasaMekanAdiTBox.Name = "MasaMekanAdiTBox"
        Me.MasaMekanAdiTBox.Size = New System.Drawing.Size(306, 20)
        Me.MasaMekanAdiTBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mekan Adı:"
        '
        'MekanlarDGV
        '
        Me.MekanlarDGV.AllowUserToAddRows = False
        Me.MekanlarDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MekanlarDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MekanlarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MekanlarDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MasaMekanNoC, Me.MasaMekanAdiC})
        Me.MekanlarDGV.Location = New System.Drawing.Point(14, 49)
        Me.MekanlarDGV.Name = "MekanlarDGV"
        Me.MekanlarDGV.ReadOnly = True
        Me.MekanlarDGV.RowHeadersVisible = False
        Me.MekanlarDGV.RowTemplate.Height = 24
        Me.MekanlarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MekanlarDGV.Size = New System.Drawing.Size(423, 129)
        Me.MekanlarDGV.TabIndex = 7
        '
        'MasaMekanNoC
        '
        Me.MasaMekanNoC.DataPropertyName = "MasaMekanNo"
        Me.MasaMekanNoC.HeaderText = "Masa Mekan No"
        Me.MasaMekanNoC.Name = "MasaMekanNoC"
        Me.MasaMekanNoC.ReadOnly = True
        Me.MasaMekanNoC.Visible = False
        '
        'MasaMekanAdiC
        '
        Me.MasaMekanAdiC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MasaMekanAdiC.DataPropertyName = "MasaMekanAdi"
        Me.MasaMekanAdiC.HeaderText = "Mekan Adı"
        Me.MasaMekanAdiC.Name = "MasaMekanAdiC"
        Me.MasaMekanAdiC.ReadOnly = True
        '
        'BilgiKafeDS
        '
        Me.BilgiKafeDS.DataSetName = "NewDataSet"
        '
        'MasaMekanFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 271)
        Me.Controls.Add(Me.MekanlarDGV)
        Me.Controls.Add(Me.MasaMekanAdiTBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MasaMekanFormu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Masa Mekanları"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.MekanlarDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasaMekanTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents KaydetBtn As Button
    Friend WithEvents EkleBtn As Button
    Friend WithEvents SilBtn As Button
    Friend WithEvents VazgecBtn As Button
    Friend WithEvents MasaMekanAdiTBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MekanlarDGV As DataGridView
    Friend WithEvents MasaMekanTablosuBS As BindingSource
    Friend WithEvents BilgiKafeDS As DataSet
    Friend WithEvents MasaMekanNoC As DataGridViewTextBoxColumn
    Friend WithEvents MasaMekanAdiC As DataGridViewTextBoxColumn
End Class
