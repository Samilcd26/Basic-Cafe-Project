<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuFormu
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
        Me.DurumCubugu = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AramaPanel = New System.Windows.Forms.Panel()
        Me.AraBtn = New System.Windows.Forms.Button()
        Me.MenuAraTBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.EkleBtn = New System.Windows.Forms.Button()
        Me.DuzenleBtn = New System.Windows.Forms.Button()
        Me.MenuDGV = New System.Windows.Forms.DataGridView()
        Me.MenuNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrunAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.icindekilerC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiyatC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KategoriNoC = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ResimC = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GuncellemeTarihiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BilgiKafeDS = New System.Data.DataSet()
        Me.MenuTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.KategoriTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.AramaPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.MenuDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KategoriTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DurumCubugu
        '
        Me.DurumCubugu.Location = New System.Drawing.Point(0, 637)
        Me.DurumCubugu.Name = "DurumCubugu"
        Me.DurumCubugu.Size = New System.Drawing.Size(1077, 22)
        Me.DurumCubugu.TabIndex = 0
        Me.DurumCubugu.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AramaPanel)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 537)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1077, 100)
        Me.Panel1.TabIndex = 1
        '
        'AramaPanel
        '
        Me.AramaPanel.Controls.Add(Me.AraBtn)
        Me.AramaPanel.Controls.Add(Me.MenuAraTBox)
        Me.AramaPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.AramaPanel.Location = New System.Drawing.Point(271, 0)
        Me.AramaPanel.Name = "AramaPanel"
        Me.AramaPanel.Size = New System.Drawing.Size(396, 100)
        Me.AramaPanel.TabIndex = 2
        '
        'AraBtn
        '
        Me.AraBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.AraBtn.Image = Global.BilgiKafe.My.Resources.Resources.Ara
        Me.AraBtn.Location = New System.Drawing.Point(267, 0)
        Me.AraBtn.Name = "AraBtn"
        Me.AraBtn.Size = New System.Drawing.Size(129, 100)
        Me.AraBtn.TabIndex = 2
        Me.AraBtn.Text = "Ara"
        Me.AraBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AraBtn.UseVisualStyleBackColor = True
        '
        'MenuAraTBox
        '
        Me.MenuAraTBox.Location = New System.Drawing.Point(6, 41)
        Me.MenuAraTBox.Name = "MenuAraTBox"
        Me.MenuAraTBox.Size = New System.Drawing.Size(255, 20)
        Me.MenuAraTBox.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.EkleBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DuzenleBtn, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(271, 100)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'EkleBtn
        '
        Me.EkleBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EkleBtn.Image = Global.BilgiKafe.My.Resources.Resources.Ekle
        Me.EkleBtn.Location = New System.Drawing.Point(3, 3)
        Me.EkleBtn.Name = "EkleBtn"
        Me.EkleBtn.Size = New System.Drawing.Size(129, 94)
        Me.EkleBtn.TabIndex = 1
        Me.EkleBtn.Text = "&Ekle"
        Me.EkleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'DuzenleBtn
        '
        Me.DuzenleBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DuzenleBtn.Image = Global.BilgiKafe.My.Resources.Resources.Duzenle
        Me.DuzenleBtn.Location = New System.Drawing.Point(138, 3)
        Me.DuzenleBtn.Name = "DuzenleBtn"
        Me.DuzenleBtn.Size = New System.Drawing.Size(130, 94)
        Me.DuzenleBtn.TabIndex = 2
        Me.DuzenleBtn.Text = "Düzenle"
        Me.DuzenleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'MenuDGV
        '
        Me.MenuDGV.AllowUserToAddRows = False
        Me.MenuDGV.AllowUserToDeleteRows = False
        Me.MenuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuNoC, Me.UrunAdiC, Me.icindekilerC, Me.FiyatC, Me.KategoriNoC, Me.ResimC, Me.GuncellemeTarihiC})
        Me.MenuDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuDGV.Location = New System.Drawing.Point(0, 0)
        Me.MenuDGV.Name = "MenuDGV"
        Me.MenuDGV.RowTemplate.Height = 50
        Me.MenuDGV.Size = New System.Drawing.Size(1077, 537)
        Me.MenuDGV.TabIndex = 0
        '
        'MenuNoC
        '
        Me.MenuNoC.DataPropertyName = "MenuNo"
        Me.MenuNoC.Frozen = True
        Me.MenuNoC.HeaderText = "Menü No"
        Me.MenuNoC.Name = "MenuNoC"
        Me.MenuNoC.Visible = False
        '
        'UrunAdiC
        '
        Me.UrunAdiC.DataPropertyName = "UrunAdi"
        Me.UrunAdiC.Frozen = True
        Me.UrunAdiC.HeaderText = "Ürün Adı"
        Me.UrunAdiC.Name = "UrunAdiC"
        Me.UrunAdiC.Width = 150
        '
        'icindekilerC
        '
        Me.icindekilerC.DataPropertyName = "icindekiler"
        Me.icindekilerC.HeaderText = "İçindekiler"
        Me.icindekilerC.Name = "icindekilerC"
        Me.icindekilerC.Width = 350
        '
        'FiyatC
        '
        Me.FiyatC.DataPropertyName = "Fiyat"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FiyatC.DefaultCellStyle = DataGridViewCellStyle1
        Me.FiyatC.HeaderText = "Fiyat"
        Me.FiyatC.Name = "FiyatC"
        '
        'KategoriNoC
        '
        Me.KategoriNoC.DataPropertyName = "KategoriNo"
        Me.KategoriNoC.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.KategoriNoC.HeaderText = "Kategori"
        Me.KategoriNoC.Name = "KategoriNoC"
        '
        'ResimC
        '
        Me.ResimC.DataPropertyName = "Resim"
        Me.ResimC.HeaderText = "Resim"
        Me.ResimC.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.ResimC.Name = "ResimC"
        '
        'GuncellemeTarihiC
        '
        Me.GuncellemeTarihiC.DataPropertyName = "GuncellemeTarihi"
        Me.GuncellemeTarihiC.HeaderText = "Güncelleme Tarihi"
        Me.GuncellemeTarihiC.Name = "GuncellemeTarihiC"
        '
        'BilgiKafeDS
        '
        Me.BilgiKafeDS.DataSetName = "NewDataSet"
        '
        'MenuFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 659)
        Me.Controls.Add(Me.MenuDGV)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DurumCubugu)
        Me.Name = "MenuFormu"
        Me.Text = "Menü"
        Me.Panel1.ResumeLayout(False)
        Me.AramaPanel.ResumeLayout(False)
        Me.AramaPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.MenuDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KategoriTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DurumCubugu As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuDGV As DataGridView
    Friend WithEvents BilgiKafeDS As DataSet
    Friend WithEvents MenuTablosuBS As BindingSource
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents EkleBtn As Button
    Friend WithEvents DuzenleBtn As Button
    Friend WithEvents KategoriTablosuBS As BindingSource
    Friend WithEvents MenuNoC As DataGridViewTextBoxColumn
    Friend WithEvents UrunAdiC As DataGridViewTextBoxColumn
    Friend WithEvents icindekilerC As DataGridViewTextBoxColumn
    Friend WithEvents FiyatC As DataGridViewTextBoxColumn
    Friend WithEvents KategoriNoC As DataGridViewComboBoxColumn
    Friend WithEvents ResimC As DataGridViewImageColumn
    Friend WithEvents GuncellemeTarihiC As DataGridViewTextBoxColumn
    Friend WithEvents AramaPanel As Panel
    Friend WithEvents AraBtn As Button
    Friend WithEvents MenuAraTBox As TextBox
End Class
