<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuKategoriFormu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KategoriAdiTBox = New System.Windows.Forms.TextBox()
        Me.KategorilerDGV = New System.Windows.Forms.DataGridView()
        Me.KategoriNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KategoriAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KategoriResmiC = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BilgiKafeDS = New System.Data.DataSet()
        Me.ResimSecOFD = New System.Windows.Forms.OpenFileDialog()
        Me.ResimEkleBtn = New System.Windows.Forms.Button()
        Me.KategoriResmiPBox = New System.Windows.Forms.PictureBox()
        Me.KategoriTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.KategorilerDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KategoriResmiPBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(14, 303)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(445, 65)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'KaydetBtn
        '
        Me.KaydetBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KaydetBtn.Image = Global.BilgiKafe.My.Resources.Resources.Kaydet
        Me.KaydetBtn.Location = New System.Drawing.Point(336, 3)
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(106, 59)
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
        Me.EkleBtn.Size = New System.Drawing.Size(105, 59)
        Me.EkleBtn.TabIndex = 1
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
        Me.VazgecBtn.TabIndex = 2
        Me.VazgecBtn.Text = "Vazgeç"
        Me.VazgecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kategori Adı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kategori Resmi"
        '
        'KategoriAdiTBox
        '
        Me.KategoriAdiTBox.Location = New System.Drawing.Point(148, 26)
        Me.KategoriAdiTBox.Name = "KategoriAdiTBox"
        Me.KategoriAdiTBox.Size = New System.Drawing.Size(306, 20)
        Me.KategoriAdiTBox.TabIndex = 3
        '
        'KategorilerDGV
        '
        Me.KategorilerDGV.AllowUserToAddRows = False
        Me.KategorilerDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KategorilerDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.KategorilerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KategorilerDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KategoriNoC, Me.KategoriAdiC, Me.KategoriResmiC})
        Me.KategorilerDGV.Location = New System.Drawing.Point(15, 122)
        Me.KategorilerDGV.Name = "KategorilerDGV"
        Me.KategorilerDGV.ReadOnly = True
        Me.KategorilerDGV.RowHeadersVisible = False
        Me.KategorilerDGV.RowTemplate.Height = 48
        Me.KategorilerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.KategorilerDGV.Size = New System.Drawing.Size(439, 173)
        Me.KategorilerDGV.TabIndex = 6
        '
        'KategoriNoC
        '
        Me.KategoriNoC.DataPropertyName = "KategoriNo"
        Me.KategoriNoC.HeaderText = "Kategori Numarası"
        Me.KategoriNoC.Name = "KategoriNoC"
        Me.KategoriNoC.ReadOnly = True
        Me.KategoriNoC.Visible = False
        '
        'KategoriAdiC
        '
        Me.KategoriAdiC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.KategoriAdiC.DataPropertyName = "KategoriAdi"
        Me.KategoriAdiC.HeaderText = "Kategori Adı"
        Me.KategoriAdiC.Name = "KategoriAdiC"
        Me.KategoriAdiC.ReadOnly = True
        '
        'KategoriResmiC
        '
        Me.KategoriResmiC.DataPropertyName = "KategoriResmi"
        Me.KategoriResmiC.HeaderText = "Kategori Resmi"
        Me.KategoriResmiC.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.KategoriResmiC.Name = "KategoriResmiC"
        Me.KategoriResmiC.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Karegoriler"
        '
        'BilgiKafeDS
        '
        Me.BilgiKafeDS.DataSetName = "NewDataSet"
        '
        'ResimEkleBtn
        '
        Me.ResimEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResimEkleBtn.Image = Global.BilgiKafe.My.Resources.Resources.ResimEkle
        Me.ResimEkleBtn.Location = New System.Drawing.Point(218, 76)
        Me.ResimEkleBtn.Name = "ResimEkleBtn"
        Me.ResimEkleBtn.Size = New System.Drawing.Size(124, 40)
        Me.ResimEkleBtn.TabIndex = 5
        Me.ResimEkleBtn.Text = "Resim Ekle"
        Me.ResimEkleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ResimEkleBtn.UseVisualStyleBackColor = True
        '
        'KategoriResmiPBox
        '
        Me.KategoriResmiPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KategoriResmiPBox.Location = New System.Drawing.Point(148, 52)
        Me.KategoriResmiPBox.Name = "KategoriResmiPBox"
        Me.KategoriResmiPBox.Size = New System.Drawing.Size(64, 64)
        Me.KategoriResmiPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.KategoriResmiPBox.TabIndex = 4
        Me.KategoriResmiPBox.TabStop = False
        '
        'MenuKategoriFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 380)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.KategorilerDGV)
        Me.Controls.Add(Me.ResimEkleBtn)
        Me.Controls.Add(Me.KategoriResmiPBox)
        Me.Controls.Add(Me.KategoriAdiTBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuKategoriFormu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Menü Kategorileri"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.KategorilerDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KategoriResmiPBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KategoriTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents KaydetBtn As System.Windows.Forms.Button
    Friend WithEvents EkleBtn As System.Windows.Forms.Button
    Friend WithEvents SilBtn As Button
    Friend WithEvents VazgecBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents KategoriAdiTBox As TextBox
    Friend WithEvents KategoriResmiPBox As PictureBox
    Friend WithEvents ResimEkleBtn As Button
    Friend WithEvents KategorilerDGV As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents BilgiKafeDS As DataSet
    Friend WithEvents KategoriTablosuBS As BindingSource
    Friend WithEvents ResimSecOFD As OpenFileDialog
    Friend WithEvents KategoriNoC As DataGridViewTextBoxColumn
    Friend WithEvents KategoriAdiC As DataGridViewTextBoxColumn
    Friend WithEvents KategoriResmiC As DataGridViewImageColumn
End Class
