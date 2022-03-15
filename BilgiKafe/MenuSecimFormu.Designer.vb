<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuSecimFormu
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BilgiKafeDS = New System.Data.DataSet()
        Me.MenuDGV = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.EkleBtn = New System.Windows.Forms.Button()
        Me.MenuAraTBox = New System.Windows.Forms.TextBox()
        Me.AramaPanel = New System.Windows.Forms.Panel()
        Me.AraBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DurumCubugu = New System.Windows.Forms.StatusStrip()
        Me.KategoriTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KategoriNoC = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UrunAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiyatC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdetC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResimC = New System.Windows.Forms.DataGridViewImageColumn()
        Me.icindekilerC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuncellemeTarihiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.AramaPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.KategoriTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BilgiKafeDS
        '
        Me.BilgiKafeDS.DataSetName = "NewDataSet"
        '
        'MenuDGV
        '
        Me.MenuDGV.AllowUserToAddRows = False
        Me.MenuDGV.AllowUserToDeleteRows = False
        Me.MenuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuNoC, Me.KategoriNoC, Me.UrunAdiC, Me.FiyatC, Me.AdetC, Me.ResimC, Me.icindekilerC, Me.GuncellemeTarihiC})
        Me.MenuDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuDGV.Location = New System.Drawing.Point(0, 0)
        Me.MenuDGV.Name = "MenuDGV"
        Me.MenuDGV.RowTemplate.Height = 50
        Me.MenuDGV.Size = New System.Drawing.Size(657, 357)
        Me.MenuDGV.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.EkleBtn, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(121, 71)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'EkleBtn
        '
        Me.EkleBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EkleBtn.Image = Global.BilgiKafe.My.Resources.Resources.Ekle
        Me.EkleBtn.Location = New System.Drawing.Point(3, 3)
        Me.EkleBtn.Name = "EkleBtn"
        Me.EkleBtn.Size = New System.Drawing.Size(115, 65)
        Me.EkleBtn.TabIndex = 1
        Me.EkleBtn.Text = "&Ekle"
        Me.EkleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'MenuAraTBox
        '
        Me.MenuAraTBox.Location = New System.Drawing.Point(6, 26)
        Me.MenuAraTBox.Name = "MenuAraTBox"
        Me.MenuAraTBox.Size = New System.Drawing.Size(255, 20)
        Me.MenuAraTBox.TabIndex = 1
        '
        'AramaPanel
        '
        Me.AramaPanel.Controls.Add(Me.Label1)
        Me.AramaPanel.Controls.Add(Me.AraBtn)
        Me.AramaPanel.Controls.Add(Me.MenuAraTBox)
        Me.AramaPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.AramaPanel.Location = New System.Drawing.Point(121, 0)
        Me.AramaPanel.Name = "AramaPanel"
        Me.AramaPanel.Size = New System.Drawing.Size(396, 71)
        Me.AramaPanel.TabIndex = 2
        '
        'AraBtn
        '
        Me.AraBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.AraBtn.Image = Global.BilgiKafe.My.Resources.Resources.Ara
        Me.AraBtn.Location = New System.Drawing.Point(267, 0)
        Me.AraBtn.Name = "AraBtn"
        Me.AraBtn.Size = New System.Drawing.Size(129, 71)
        Me.AraBtn.TabIndex = 2
        Me.AraBtn.Text = "Ara"
        Me.AraBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AraBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AramaPanel)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 357)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 71)
        Me.Panel1.TabIndex = 4
        '
        'DurumCubugu
        '
        Me.DurumCubugu.Location = New System.Drawing.Point(0, 428)
        Me.DurumCubugu.Name = "DurumCubugu"
        Me.DurumCubugu.Size = New System.Drawing.Size(657, 22)
        Me.DurumCubugu.TabIndex = 3
        Me.DurumCubugu.Text = "StatusStrip1"
        '
        'MenuNoC
        '
        Me.MenuNoC.DataPropertyName = "MenuNo"
        Me.MenuNoC.Frozen = True
        Me.MenuNoC.HeaderText = "Menü No"
        Me.MenuNoC.Name = "MenuNoC"
        Me.MenuNoC.ReadOnly = True
        Me.MenuNoC.Visible = False
        '
        'KategoriNoC
        '
        Me.KategoriNoC.DataPropertyName = "KategoriNo"
        Me.KategoriNoC.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.KategoriNoC.Frozen = True
        Me.KategoriNoC.HeaderText = "Kategori"
        Me.KategoriNoC.Name = "KategoriNoC"
        Me.KategoriNoC.ReadOnly = True
        '
        'UrunAdiC
        '
        Me.UrunAdiC.DataPropertyName = "UrunAdi"
        Me.UrunAdiC.Frozen = True
        Me.UrunAdiC.HeaderText = "Ürün Adı"
        Me.UrunAdiC.Name = "UrunAdiC"
        Me.UrunAdiC.ReadOnly = True
        Me.UrunAdiC.Width = 150
        '
        'FiyatC
        '
        Me.FiyatC.DataPropertyName = "Fiyat"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FiyatC.DefaultCellStyle = DataGridViewCellStyle3
        Me.FiyatC.Frozen = True
        Me.FiyatC.HeaderText = "Fiyat"
        Me.FiyatC.Name = "FiyatC"
        Me.FiyatC.ReadOnly = True
        '
        'AdetC
        '
        Me.AdetC.DataPropertyName = "Adet"
        Me.AdetC.Frozen = True
        Me.AdetC.HeaderText = "Adet"
        Me.AdetC.Name = "AdetC"
        '
        'ResimC
        '
        Me.ResimC.DataPropertyName = "Resim"
        Me.ResimC.Frozen = True
        Me.ResimC.HeaderText = "Resim"
        Me.ResimC.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.ResimC.Name = "ResimC"
        Me.ResimC.ReadOnly = True
        '
        'icindekilerC
        '
        Me.icindekilerC.DataPropertyName = "icindekiler"
        Me.icindekilerC.Frozen = True
        Me.icindekilerC.HeaderText = "İçindekiler"
        Me.icindekilerC.Name = "icindekilerC"
        Me.icindekilerC.ReadOnly = True
        Me.icindekilerC.Visible = False
        Me.icindekilerC.Width = 350
        '
        'GuncellemeTarihiC
        '
        Me.GuncellemeTarihiC.DataPropertyName = "GuncellemeTarihi"
        Me.GuncellemeTarihiC.HeaderText = "Güncelleme Tarihi"
        Me.GuncellemeTarihiC.Name = "GuncellemeTarihiC"
        Me.GuncellemeTarihiC.ReadOnly = True
        Me.GuncellemeTarihiC.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ürün Adı Ara:"
        '
        'MenuSecimFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 450)
        Me.Controls.Add(Me.MenuDGV)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DurumCubugu)
        Me.Name = "MenuSecimFormu"
        Me.Text = "MenuSecimFormu"
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.AramaPanel.ResumeLayout(False)
        Me.AramaPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.KategoriTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KategoriTablosuBS As BindingSource
    Friend WithEvents EkleBtn As Button
    Friend WithEvents AraBtn As Button
    Friend WithEvents BilgiKafeDS As DataSet
    Friend WithEvents MenuTablosuBS As BindingSource
    Friend WithEvents MenuDGV As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MenuAraTBox As TextBox
    Friend WithEvents AramaPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DurumCubugu As StatusStrip
    Friend WithEvents MenuNoC As DataGridViewTextBoxColumn
    Friend WithEvents KategoriNoC As DataGridViewComboBoxColumn
    Friend WithEvents UrunAdiC As DataGridViewTextBoxColumn
    Friend WithEvents FiyatC As DataGridViewTextBoxColumn
    Friend WithEvents AdetC As DataGridViewTextBoxColumn
    Friend WithEvents ResimC As DataGridViewImageColumn
    Friend WithEvents icindekilerC As DataGridViewTextBoxColumn
    Friend WithEvents GuncellemeTarihiC As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
