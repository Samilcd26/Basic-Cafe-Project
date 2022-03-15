<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasalarFormu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasalarFormu))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToplamTBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FisYazdirBtn = New System.Windows.Forms.Button()
        Me.EkleBtn = New System.Windows.Forms.Button()
        Me.TarihSaatTBox = New System.Windows.Forms.MaskedTextBox()
        Me.AdisyonDetayDGV = New System.Windows.Forms.DataGridView()
        Me.AdisyonDetayNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdisyonNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNoC = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AdetC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiyatC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToplamC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AciklamaC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AciklamaTBox = New System.Windows.Forms.TextBox()
        Me.PersonelNoCBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MekanLbl = New System.Windows.Forms.Label()
        Me.MasaNoLbl = New System.Windows.Forms.Label()
        Me.MekanlarTabControl = New System.Windows.Forms.TabControl()
        Me.BilgiKafeDS = New System.Data.DataSet()
        Me.MasaImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.MasaMekanTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasaTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdisyonTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdisyonDetayTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonelTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.AdisyonDetayDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasaMekanTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasaTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdisyonTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdisyonDetayTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonelTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToplamTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FisYazdirBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EkleBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TarihSaatTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AdisyonDetayDGV)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AciklamaTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PersonelNoCBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MekanLbl)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MasaNoLbl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.MekanlarTabControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1437, 730)
        Me.SplitContainer1.SplitterDistance = 350
        Me.SplitContainer1.TabIndex = 0
        '
        'ToplamTBox
        '
        Me.ToplamTBox.Location = New System.Drawing.Point(179, 586)
        Me.ToplamTBox.Name = "ToplamTBox"
        Me.ToplamTBox.ReadOnly = True
        Me.ToplamTBox.Size = New System.Drawing.Size(152, 20)
        Me.ToplamTBox.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 589)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Toplam:"
        '
        'FisYazdirBtn
        '
        Me.FisYazdirBtn.Location = New System.Drawing.Point(17, 625)
        Me.FisYazdirBtn.Name = "FisYazdirBtn"
        Me.FisYazdirBtn.Size = New System.Drawing.Size(75, 23)
        Me.FisYazdirBtn.TabIndex = 14
        Me.FisYazdirBtn.Text = "Yazdır"
        Me.FisYazdirBtn.UseVisualStyleBackColor = True
        '
        'EkleBtn
        '
        Me.EkleBtn.Location = New System.Drawing.Point(301, 625)
        Me.EkleBtn.Name = "EkleBtn"
        Me.EkleBtn.Size = New System.Drawing.Size(30, 23)
        Me.EkleBtn.TabIndex = 13
        Me.EkleBtn.Text = "+"
        Me.EkleBtn.UseVisualStyleBackColor = True
        '
        'TarihSaatTBox
        '
        Me.TarihSaatTBox.Location = New System.Drawing.Point(79, 94)
        Me.TarihSaatTBox.Mask = "00/00/0000 90:00"
        Me.TarihSaatTBox.Name = "TarihSaatTBox"
        Me.TarihSaatTBox.ReadOnly = True
        Me.TarihSaatTBox.Size = New System.Drawing.Size(252, 20)
        Me.TarihSaatTBox.TabIndex = 12
        Me.TarihSaatTBox.ValidatingType = GetType(Date)
        '
        'AdisyonDetayDGV
        '
        Me.AdisyonDetayDGV.AllowUserToAddRows = False
        Me.AdisyonDetayDGV.AllowUserToDeleteRows = False
        Me.AdisyonDetayDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdisyonDetayDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdisyonDetayNoC, Me.AdisyonNoC, Me.MenuNoC, Me.AdetC, Me.FiyatC, Me.ToplamC, Me.AciklamaC})
        Me.AdisyonDetayDGV.Location = New System.Drawing.Point(17, 290)
        Me.AdisyonDetayDGV.Name = "AdisyonDetayDGV"
        Me.AdisyonDetayDGV.RowHeadersVisible = False
        Me.AdisyonDetayDGV.Size = New System.Drawing.Size(314, 290)
        Me.AdisyonDetayDGV.TabIndex = 11
        '
        'AdisyonDetayNoC
        '
        Me.AdisyonDetayNoC.DataPropertyName = "AdisyonDetayNo"
        Me.AdisyonDetayNoC.HeaderText = "Adisyon Detay No"
        Me.AdisyonDetayNoC.Name = "AdisyonDetayNoC"
        Me.AdisyonDetayNoC.Visible = False
        '
        'AdisyonNoC
        '
        Me.AdisyonNoC.DataPropertyName = "AdisyonNo"
        Me.AdisyonNoC.HeaderText = "Adisyon No"
        Me.AdisyonNoC.Name = "AdisyonNoC"
        Me.AdisyonNoC.Visible = False
        '
        'MenuNoC
        '
        Me.MenuNoC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MenuNoC.DataPropertyName = "MenuNo"
        Me.MenuNoC.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.MenuNoC.HeaderText = "Ürün Adı"
        Me.MenuNoC.Name = "MenuNoC"
        Me.MenuNoC.ReadOnly = True
        Me.MenuNoC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MenuNoC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'AdetC
        '
        Me.AdetC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AdetC.DataPropertyName = "Adet"
        Me.AdetC.HeaderText = "Adet"
        Me.AdetC.Name = "AdetC"
        '
        'FiyatC
        '
        Me.FiyatC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FiyatC.DataPropertyName = "Fiyat"
        Me.FiyatC.HeaderText = "Fiyat"
        Me.FiyatC.Name = "FiyatC"
        Me.FiyatC.ReadOnly = True
        '
        'ToplamC
        '
        Me.ToplamC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ToplamC.DataPropertyName = "Toplam"
        Me.ToplamC.HeaderText = "Toplam"
        Me.ToplamC.Name = "ToplamC"
        Me.ToplamC.ReadOnly = True
        '
        'AciklamaC
        '
        Me.AciklamaC.DataPropertyName = "Aciklama"
        Me.AciklamaC.HeaderText = "Açıklama"
        Me.AciklamaC.Name = "AciklamaC"
        Me.AciklamaC.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Açıklama:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Personel:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tarih Saat:"
        '
        'AciklamaTBox
        '
        Me.AciklamaTBox.Location = New System.Drawing.Point(77, 154)
        Me.AciklamaTBox.Multiline = True
        Me.AciklamaTBox.Name = "AciklamaTBox"
        Me.AciklamaTBox.Size = New System.Drawing.Size(254, 119)
        Me.AciklamaTBox.TabIndex = 7
        '
        'PersonelNoCBox
        '
        Me.PersonelNoCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PersonelNoCBox.FormattingEnabled = True
        Me.PersonelNoCBox.Location = New System.Drawing.Point(79, 125)
        Me.PersonelNoCBox.Name = "PersonelNoCBox"
        Me.PersonelNoCBox.Size = New System.Drawing.Size(252, 21)
        Me.PersonelNoCBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mekan:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Masa No:"
        '
        'MekanLbl
        '
        Me.MekanLbl.AutoSize = True
        Me.MekanLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MekanLbl.Location = New System.Drawing.Point(97, 19)
        Me.MekanLbl.Name = "MekanLbl"
        Me.MekanLbl.Size = New System.Drawing.Size(45, 24)
        Me.MekanLbl.TabIndex = 1
        Me.MekanLbl.Text = "Yok"
        '
        'MasaNoLbl
        '
        Me.MasaNoLbl.AutoSize = True
        Me.MasaNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MasaNoLbl.Location = New System.Drawing.Point(141, 52)
        Me.MasaNoLbl.Name = "MasaNoLbl"
        Me.MasaNoLbl.Size = New System.Drawing.Size(27, 29)
        Me.MasaNoLbl.TabIndex = 2
        Me.MasaNoLbl.Text = "0"
        '
        'MekanlarTabControl
        '
        Me.MekanlarTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MekanlarTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MekanlarTabControl.Name = "MekanlarTabControl"
        Me.MekanlarTabControl.SelectedIndex = 0
        Me.MekanlarTabControl.Size = New System.Drawing.Size(1083, 730)
        Me.MekanlarTabControl.TabIndex = 0
        '
        'BilgiKafeDS
        '
        Me.BilgiKafeDS.DataSetName = "NewDataSet"
        '
        'MasaImageList
        '
        Me.MasaImageList.ImageStream = CType(resources.GetObject("MasaImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MasaImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.MasaImageList.Images.SetKeyName(0, "MasaBos.png")
        Me.MasaImageList.Images.SetKeyName(1, "MasaDolu.png")
        Me.MasaImageList.Images.SetKeyName(2, "MasaRezerve.png")
        '
        'AdisyonDetayTablosuBS
        '
        '
        'MasalarFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1437, 730)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MasalarFormu"
        Me.Text = "MasalarFormu"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.AdisyonDetayDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasaMekanTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasaTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdisyonTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdisyonDetayTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonelTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents MekanlarTabControl As TabControl
    Friend WithEvents BilgiKafeDS As DataSet
    Friend WithEvents MasaMekanTablosuBS As BindingSource
    Friend WithEvents MasaImageList As ImageList
    Friend WithEvents MasaTablosuBS As BindingSource
    Friend WithEvents MekanLbl As Label
    Friend WithEvents MasaNoLbl As Label
    Friend WithEvents AdisyonTablosuBS As BindingSource
    Friend WithEvents AdisyonDetayTablosuBS As BindingSource
    Friend WithEvents MenuTablosuBS As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AciklamaTBox As TextBox
    Friend WithEvents PersonelNoCBox As ComboBox
    Friend WithEvents AdisyonDetayDGV As DataGridView
    Friend WithEvents TarihSaatTBox As MaskedTextBox
    Friend WithEvents PersonelTablosuBS As BindingSource
    Friend WithEvents AdisyonDetayNoC As DataGridViewTextBoxColumn
    Friend WithEvents AdisyonNoC As DataGridViewTextBoxColumn
    Friend WithEvents MenuNoC As DataGridViewComboBoxColumn
    Friend WithEvents AdetC As DataGridViewTextBoxColumn
    Friend WithEvents FiyatC As DataGridViewTextBoxColumn
    Friend WithEvents ToplamC As DataGridViewTextBoxColumn
    Friend WithEvents AciklamaC As DataGridViewTextBoxColumn
    Friend WithEvents EkleBtn As Button
    Friend WithEvents FisYazdirBtn As Button
    Friend WithEvents ToplamTBox As TextBox
    Friend WithEvents Label6 As Label
End Class
