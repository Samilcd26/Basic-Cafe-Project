<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasaEklemeFormu
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
        Me.MasalarDGV = New System.Windows.Forms.DataGridView()
        Me.MasaKayitNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasaNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasaMekanNoC = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MasaNoTBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BilgiKafeDS = New System.Data.DataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MasaMekanNoLBox = New System.Windows.Forms.ListBox()
        Me.KaydetBtn = New System.Windows.Forms.Button()
        Me.EkleBtn = New System.Windows.Forms.Button()
        Me.SilBtn = New System.Windows.Forms.Button()
        Me.VazgecBtn = New System.Windows.Forms.Button()
        Me.MasaMekanTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasaTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DurumCBox = New System.Windows.Forms.ComboBox()
        CType(Me.MasalarDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasaMekanTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasaTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MasalarDGV
        '
        Me.MasalarDGV.AllowUserToAddRows = False
        Me.MasalarDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MasalarDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MasalarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MasalarDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MasaKayitNoC, Me.MasaNoC, Me.MasaMekanNoC})
        Me.MasalarDGV.Location = New System.Drawing.Point(19, 177)
        Me.MasalarDGV.Name = "MasalarDGV"
        Me.MasalarDGV.ReadOnly = True
        Me.MasalarDGV.RowHeadersVisible = False
        Me.MasalarDGV.RowTemplate.Height = 24
        Me.MasalarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MasalarDGV.Size = New System.Drawing.Size(423, 129)
        Me.MasalarDGV.TabIndex = 11
        '
        'MasaKayitNoC
        '
        Me.MasaKayitNoC.DataPropertyName = "MasaKayitNo"
        Me.MasaKayitNoC.HeaderText = "Masa Kayıt No"
        Me.MasaKayitNoC.Name = "MasaKayitNoC"
        Me.MasaKayitNoC.ReadOnly = True
        Me.MasaKayitNoC.Visible = False
        '
        'MasaNoC
        '
        Me.MasaNoC.DataPropertyName = "MasaNo"
        Me.MasaNoC.HeaderText = "Masa No"
        Me.MasaNoC.Name = "MasaNoC"
        Me.MasaNoC.ReadOnly = True
        '
        'MasaMekanNoC
        '
        Me.MasaMekanNoC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MasaMekanNoC.DataPropertyName = "MasaMekanNo"
        Me.MasaMekanNoC.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.MasaMekanNoC.HeaderText = "Mekan Adı"
        Me.MasaMekanNoC.Name = "MasaMekanNoC"
        Me.MasaMekanNoC.ReadOnly = True
        Me.MasaMekanNoC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MasaMekanNoC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'MasaNoTBox
        '
        Me.MasaNoTBox.Location = New System.Drawing.Point(137, 12)
        Me.MasaNoTBox.Name = "MasaNoTBox"
        Me.MasaNoTBox.Size = New System.Drawing.Size(119, 20)
        Me.MasaNoTBox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Masa No:"
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(19, 327)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(428, 75)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'BilgiKafeDS
        '
        Me.BilgiKafeDS.DataSetName = "NewDataSet"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Mekan:"
        '
        'MasaMekanNoLBox
        '
        Me.MasaMekanNoLBox.FormattingEnabled = True
        Me.MasaMekanNoLBox.Location = New System.Drawing.Point(137, 38)
        Me.MasaMekanNoLBox.Name = "MasaMekanNoLBox"
        Me.MasaMekanNoLBox.Size = New System.Drawing.Size(200, 95)
        Me.MasaMekanNoLBox.TabIndex = 13
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Durum:"
        '
        'DurumCBox
        '
        Me.DurumCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DurumCBox.FormattingEnabled = True
        Me.DurumCBox.Items.AddRange(New Object() {"Boş", "Dolu", "Rezerve"})
        Me.DurumCBox.Location = New System.Drawing.Point(137, 139)
        Me.DurumCBox.Name = "DurumCBox"
        Me.DurumCBox.Size = New System.Drawing.Size(121, 21)
        Me.DurumCBox.TabIndex = 15
        '
        'MasaEklemeFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 409)
        Me.Controls.Add(Me.DurumCBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MasaMekanNoLBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MasalarDGV)
        Me.Controls.Add(Me.MasaNoTBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MasaEklemeFormu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Masa Ekleme"
        CType(Me.MasalarDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasaMekanTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasaTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MasalarDGV As DataGridView
    Friend WithEvents MasaNoTBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents KaydetBtn As Button
    Friend WithEvents EkleBtn As Button
    Friend WithEvents SilBtn As Button
    Friend WithEvents VazgecBtn As Button
    Friend WithEvents BilgiKafeDS As DataSet
    Friend WithEvents MasaMekanTablosuBS As BindingSource
    Friend WithEvents MasaTablosuBS As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents MasaMekanNoLBox As ListBox
    Friend WithEvents MasaKayitNoC As DataGridViewTextBoxColumn
    Friend WithEvents MasaNoC As DataGridViewTextBoxColumn
    Friend WithEvents MasaMekanNoC As DataGridViewComboBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents DurumCBox As ComboBox
End Class
