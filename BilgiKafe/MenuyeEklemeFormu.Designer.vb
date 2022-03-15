<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuyeEklemeFormu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.KaydetBtn = New System.Windows.Forms.Button()
        Me.EkleBtn = New System.Windows.Forms.Button()
        Me.SilBtn = New System.Windows.Forms.Button()
        Me.VazgecBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UrunAdiTBox = New System.Windows.Forms.TextBox()
        Me.icindekilerTBox = New System.Windows.Forms.TextBox()
        Me.KategoriNoCBox = New System.Windows.Forms.ComboBox()
        Me.GuncellemeTarihDTP = New System.Windows.Forms.DateTimePicker()
        Me.FiyatTBox = New System.Windows.Forms.TextBox()
        Me.BilgiKafeDS = New System.Data.DataSet()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.SonBtn = New System.Windows.Forms.Button()
        Me.ilkBtn = New System.Windows.Forms.Button()
        Me.SonrakiBtn = New System.Windows.Forms.Button()
        Me.OncekiBtn = New System.Windows.Forms.Button()
        Me.ResimEkleBtn = New System.Windows.Forms.Button()
        Me.ResimPBox = New System.Windows.Forms.PictureBox()
        Me.MenuTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.KategoriTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResimSecOFD = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ResimPBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KategoriTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 481)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(445, 65)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'KaydetBtn
        '
        Me.KaydetBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KaydetBtn.Image = Global.BilgiKafe.My.Resources.Resources.Kaydet
        Me.KaydetBtn.Location = New System.Drawing.Point(336, 3)
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(106, 59)
        Me.KaydetBtn.TabIndex = 3
        Me.KaydetBtn.Text = "&Kaydet"
        Me.KaydetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'EkleBtn
        '
        Me.EkleBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EkleBtn.Image = Global.BilgiKafe.My.Resources.Resources.Ekle
        Me.EkleBtn.Location = New System.Drawing.Point(3, 3)
        Me.EkleBtn.Name = "EkleBtn"
        Me.EkleBtn.Size = New System.Drawing.Size(105, 59)
        Me.EkleBtn.TabIndex = 0
        Me.EkleBtn.Text = "&Ekle"
        Me.EkleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'SilBtn
        '
        Me.SilBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SilBtn.Image = Global.BilgiKafe.My.Resources.Resources.Sil
        Me.SilBtn.Location = New System.Drawing.Point(225, 3)
        Me.SilBtn.Name = "SilBtn"
        Me.SilBtn.Size = New System.Drawing.Size(105, 59)
        Me.SilBtn.TabIndex = 3
        Me.SilBtn.Text = "Sil"
        Me.SilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'VazgecBtn
        '
        Me.VazgecBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VazgecBtn.Image = Global.BilgiKafe.My.Resources.Resources.Vazgec
        Me.VazgecBtn.Location = New System.Drawing.Point(114, 3)
        Me.VazgecBtn.Name = "VazgecBtn"
        Me.VazgecBtn.Size = New System.Drawing.Size(105, 59)
        Me.VazgecBtn.TabIndex = 1
        Me.VazgecBtn.Text = "Vazgeç"
        Me.VazgecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ürün Adı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "İçeriği:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fiyat:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Kategori:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Güncelleme Tarihi:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Ürün Resmi:"
        '
        'UrunAdiTBox
        '
        Me.UrunAdiTBox.Location = New System.Drawing.Point(125, 86)
        Me.UrunAdiTBox.Name = "UrunAdiTBox"
        Me.UrunAdiTBox.Size = New System.Drawing.Size(333, 20)
        Me.UrunAdiTBox.TabIndex = 0
        '
        'icindekilerTBox
        '
        Me.icindekilerTBox.Location = New System.Drawing.Point(125, 116)
        Me.icindekilerTBox.Multiline = True
        Me.icindekilerTBox.Name = "icindekilerTBox"
        Me.icindekilerTBox.Size = New System.Drawing.Size(336, 57)
        Me.icindekilerTBox.TabIndex = 1
        '
        'KategoriNoCBox
        '
        Me.KategoriNoCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KategoriNoCBox.FormattingEnabled = True
        Me.KategoriNoCBox.Location = New System.Drawing.Point(125, 207)
        Me.KategoriNoCBox.Name = "KategoriNoCBox"
        Me.KategoriNoCBox.Size = New System.Drawing.Size(212, 21)
        Me.KategoriNoCBox.TabIndex = 3
        '
        'GuncellemeTarihDTP
        '
        Me.GuncellemeTarihDTP.Location = New System.Drawing.Point(125, 234)
        Me.GuncellemeTarihDTP.Name = "GuncellemeTarihDTP"
        Me.GuncellemeTarihDTP.Size = New System.Drawing.Size(200, 20)
        Me.GuncellemeTarihDTP.TabIndex = 4
        '
        'FiyatTBox
        '
        Me.FiyatTBox.Location = New System.Drawing.Point(125, 179)
        Me.FiyatTBox.Name = "FiyatTBox"
        Me.FiyatTBox.Size = New System.Drawing.Size(149, 20)
        Me.FiyatTBox.TabIndex = 2
        '
        'BilgiKafeDS
        '
        Me.BilgiKafeDS.DataSetName = "NewDataSet"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.SonBtn, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ilkBtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SonrakiBtn, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.OncekiBtn, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(11, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(445, 40)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'SonBtn
        '
        Me.SonBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SonBtn.Location = New System.Drawing.Point(336, 3)
        Me.SonBtn.Name = "SonBtn"
        Me.SonBtn.Size = New System.Drawing.Size(106, 34)
        Me.SonBtn.TabIndex = 3
        Me.SonBtn.Text = ">>"
        Me.SonBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'ilkBtn
        '
        Me.ilkBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ilkBtn.Location = New System.Drawing.Point(3, 3)
        Me.ilkBtn.Name = "ilkBtn"
        Me.ilkBtn.Size = New System.Drawing.Size(105, 34)
        Me.ilkBtn.TabIndex = 0
        Me.ilkBtn.Text = "<<"
        Me.ilkBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'SonrakiBtn
        '
        Me.SonrakiBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SonrakiBtn.Location = New System.Drawing.Point(225, 3)
        Me.SonrakiBtn.Name = "SonrakiBtn"
        Me.SonrakiBtn.Size = New System.Drawing.Size(105, 34)
        Me.SonrakiBtn.TabIndex = 3
        Me.SonrakiBtn.Text = ">"
        Me.SonrakiBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'OncekiBtn
        '
        Me.OncekiBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OncekiBtn.Location = New System.Drawing.Point(114, 3)
        Me.OncekiBtn.Name = "OncekiBtn"
        Me.OncekiBtn.Size = New System.Drawing.Size(105, 34)
        Me.OncekiBtn.TabIndex = 1
        Me.OncekiBtn.Text = "<"
        Me.OncekiBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'ResimEkleBtn
        '
        Me.ResimEkleBtn.Image = Global.BilgiKafe.My.Resources.Resources.ResimEkle
        Me.ResimEkleBtn.Location = New System.Drawing.Point(331, 429)
        Me.ResimEkleBtn.Name = "ResimEkleBtn"
        Me.ResimEkleBtn.Size = New System.Drawing.Size(122, 39)
        Me.ResimEkleBtn.TabIndex = 5
        Me.ResimEkleBtn.Text = "Resim Ekle"
        Me.ResimEkleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ResimEkleBtn.UseVisualStyleBackColor = True
        '
        'ResimPBox
        '
        Me.ResimPBox.Location = New System.Drawing.Point(125, 268)
        Me.ResimPBox.Name = "ResimPBox"
        Me.ResimPBox.Size = New System.Drawing.Size(200, 200)
        Me.ResimPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ResimPBox.TabIndex = 12
        Me.ResimPBox.TabStop = False
        '
        'MenuTablosuBS
        '
        '
        'ResimSecOFD
        '
        Me.ResimSecOFD.FileName = "OpenFileDialog1"
        '
        'MenuyeEklemeFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 558)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.ResimEkleBtn)
        Me.Controls.Add(Me.FiyatTBox)
        Me.Controls.Add(Me.ResimPBox)
        Me.Controls.Add(Me.GuncellemeTarihDTP)
        Me.Controls.Add(Me.KategoriNoCBox)
        Me.Controls.Add(Me.icindekilerTBox)
        Me.Controls.Add(Me.UrunAdiTBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuyeEklemeFormu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Menü Ekle / Düzenle"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.ResimPBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KategoriTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents KaydetBtn As Button
    Friend WithEvents EkleBtn As Button
    Friend WithEvents SilBtn As Button
    Friend WithEvents VazgecBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents UrunAdiTBox As TextBox
    Friend WithEvents icindekilerTBox As TextBox
    Friend WithEvents KategoriNoCBox As ComboBox
    Friend WithEvents GuncellemeTarihDTP As DateTimePicker
    Friend WithEvents ResimPBox As PictureBox
    Friend WithEvents FiyatTBox As TextBox
    Friend WithEvents ResimEkleBtn As Button
    Friend WithEvents BilgiKafeDS As DataSet
    Friend WithEvents MenuTablosuBS As BindingSource
    Friend WithEvents KategoriTablosuBS As BindingSource
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents SonBtn As Button
    Friend WithEvents ilkBtn As Button
    Friend WithEvents SonrakiBtn As Button
    Friend WithEvents OncekiBtn As Button
    Friend WithEvents ResimSecOFD As OpenFileDialog
End Class
