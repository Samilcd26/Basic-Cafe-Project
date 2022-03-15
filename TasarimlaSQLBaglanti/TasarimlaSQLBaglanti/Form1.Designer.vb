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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim MenuUrunNoLabel As System.Windows.Forms.Label
        Dim MenuUrunAdiLabel As System.Windows.Forms.Label
        Dim FiyatLabel As System.Windows.Forms.Label
        Dim FotografLabel As System.Windows.Forms.Label
        Dim IcerikLabel As System.Windows.Forms.Label
        Dim GuncellemeTarihiLabel As System.Windows.Forms.Label
        Me.MenuTablosuBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.MenuTablosuBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MenuUrunNoTextBox = New System.Windows.Forms.TextBox()
        Me.MenuUrunAdiTextBox = New System.Windows.Forms.TextBox()
        Me.FiyatTextBox = New System.Windows.Forms.TextBox()
        Me.FotografPictureBox = New System.Windows.Forms.PictureBox()
        Me.IcerikTextBox = New System.Windows.Forms.TextBox()
        Me.GuncellemeTarihiDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MenuTablosuDataGridView = New System.Windows.Forms.DataGridView()
        Me.MenuUrunAraToolStrip = New System.Windows.Forms.ToolStrip()
        Me.MenuUrunAdiToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.MenuUrunAdiToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.MenuUrunAraToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuTablosuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BilgiKafeDS = New TasarimlaSQLBaglanti.BilgiKafeDS()
        Me.MenuTablosuTableAdapter = New TasarimlaSQLBaglanti.BilgiKafeDSTableAdapters.MenuTablosuTableAdapter()
        Me.TableAdapterManager = New TasarimlaSQLBaglanti.BilgiKafeDSTableAdapters.TableAdapterManager()
        MenuUrunNoLabel = New System.Windows.Forms.Label()
        MenuUrunAdiLabel = New System.Windows.Forms.Label()
        FiyatLabel = New System.Windows.Forms.Label()
        FotografLabel = New System.Windows.Forms.Label()
        IcerikLabel = New System.Windows.Forms.Label()
        GuncellemeTarihiLabel = New System.Windows.Forms.Label()
        CType(Me.MenuTablosuBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuTablosuBindingNavigator.SuspendLayout()
        CType(Me.FotografPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTablosuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuUrunAraToolStrip.SuspendLayout()
        CType(Me.MenuTablosuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuTablosuBindingNavigator
        '
        Me.MenuTablosuBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MenuTablosuBindingNavigator.BindingSource = Me.MenuTablosuBindingSource
        Me.MenuTablosuBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MenuTablosuBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MenuTablosuBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MenuTablosuBindingNavigatorSaveItem})
        Me.MenuTablosuBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MenuTablosuBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MenuTablosuBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MenuTablosuBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MenuTablosuBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MenuTablosuBindingNavigator.Name = "MenuTablosuBindingNavigator"
        Me.MenuTablosuBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MenuTablosuBindingNavigator.Size = New System.Drawing.Size(835, 25)
        Me.MenuTablosuBindingNavigator.TabIndex = 0
        Me.MenuTablosuBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'MenuTablosuBindingNavigatorSaveItem
        '
        Me.MenuTablosuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MenuTablosuBindingNavigatorSaveItem.Image = CType(resources.GetObject("MenuTablosuBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MenuTablosuBindingNavigatorSaveItem.Name = "MenuTablosuBindingNavigatorSaveItem"
        Me.MenuTablosuBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MenuTablosuBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MenuUrunNoLabel
        '
        MenuUrunNoLabel.AutoSize = True
        MenuUrunNoLabel.Location = New System.Drawing.Point(50, 67)
        MenuUrunNoLabel.Name = "MenuUrunNoLabel"
        MenuUrunNoLabel.Size = New System.Drawing.Size(80, 13)
        MenuUrunNoLabel.TabIndex = 1
        MenuUrunNoLabel.Text = "Menu Urun No:"
        '
        'MenuUrunNoTextBox
        '
        Me.MenuUrunNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuTablosuBindingSource, "MenuUrunNo", True))
        Me.MenuUrunNoTextBox.Location = New System.Drawing.Point(151, 64)
        Me.MenuUrunNoTextBox.Name = "MenuUrunNoTextBox"
        Me.MenuUrunNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MenuUrunNoTextBox.TabIndex = 2
        '
        'MenuUrunAdiLabel
        '
        MenuUrunAdiLabel.AutoSize = True
        MenuUrunAdiLabel.Location = New System.Drawing.Point(50, 93)
        MenuUrunAdiLabel.Name = "MenuUrunAdiLabel"
        MenuUrunAdiLabel.Size = New System.Drawing.Size(81, 13)
        MenuUrunAdiLabel.TabIndex = 3
        MenuUrunAdiLabel.Text = "Menu Urun Adi:"
        '
        'MenuUrunAdiTextBox
        '
        Me.MenuUrunAdiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuTablosuBindingSource, "MenuUrunAdi", True))
        Me.MenuUrunAdiTextBox.Location = New System.Drawing.Point(151, 90)
        Me.MenuUrunAdiTextBox.Name = "MenuUrunAdiTextBox"
        Me.MenuUrunAdiTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MenuUrunAdiTextBox.TabIndex = 4
        '
        'FiyatLabel
        '
        FiyatLabel.AutoSize = True
        FiyatLabel.Location = New System.Drawing.Point(50, 119)
        FiyatLabel.Name = "FiyatLabel"
        FiyatLabel.Size = New System.Drawing.Size(32, 13)
        FiyatLabel.TabIndex = 5
        FiyatLabel.Text = "Fiyat:"
        '
        'FiyatTextBox
        '
        Me.FiyatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuTablosuBindingSource, "Fiyat", True))
        Me.FiyatTextBox.Location = New System.Drawing.Point(151, 116)
        Me.FiyatTextBox.Name = "FiyatTextBox"
        Me.FiyatTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FiyatTextBox.TabIndex = 6
        '
        'FotografLabel
        '
        FotografLabel.AutoSize = True
        FotografLabel.Location = New System.Drawing.Point(50, 142)
        FotografLabel.Name = "FotografLabel"
        FotografLabel.Size = New System.Drawing.Size(49, 13)
        FotografLabel.TabIndex = 7
        FotografLabel.Text = "Fotograf:"
        '
        'FotografPictureBox
        '
        Me.FotografPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.MenuTablosuBindingSource, "Fotograf", True))
        Me.FotografPictureBox.Location = New System.Drawing.Point(151, 142)
        Me.FotografPictureBox.Name = "FotografPictureBox"
        Me.FotografPictureBox.Size = New System.Drawing.Size(200, 50)
        Me.FotografPictureBox.TabIndex = 8
        Me.FotografPictureBox.TabStop = False
        '
        'IcerikLabel
        '
        IcerikLabel.AutoSize = True
        IcerikLabel.Location = New System.Drawing.Point(50, 201)
        IcerikLabel.Name = "IcerikLabel"
        IcerikLabel.Size = New System.Drawing.Size(35, 13)
        IcerikLabel.TabIndex = 9
        IcerikLabel.Text = "icerik:"
        '
        'IcerikTextBox
        '
        Me.IcerikTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuTablosuBindingSource, "icerik", True))
        Me.IcerikTextBox.Location = New System.Drawing.Point(151, 198)
        Me.IcerikTextBox.Name = "IcerikTextBox"
        Me.IcerikTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IcerikTextBox.TabIndex = 10
        '
        'GuncellemeTarihiLabel
        '
        GuncellemeTarihiLabel.AutoSize = True
        GuncellemeTarihiLabel.Location = New System.Drawing.Point(50, 228)
        GuncellemeTarihiLabel.Name = "GuncellemeTarihiLabel"
        GuncellemeTarihiLabel.Size = New System.Drawing.Size(95, 13)
        GuncellemeTarihiLabel.TabIndex = 11
        GuncellemeTarihiLabel.Text = "Guncelleme Tarihi:"
        '
        'GuncellemeTarihiDateTimePicker
        '
        Me.GuncellemeTarihiDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MenuTablosuBindingSource, "GuncellemeTarihi", True))
        Me.GuncellemeTarihiDateTimePicker.Location = New System.Drawing.Point(151, 224)
        Me.GuncellemeTarihiDateTimePicker.Name = "GuncellemeTarihiDateTimePicker"
        Me.GuncellemeTarihiDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.GuncellemeTarihiDateTimePicker.TabIndex = 12
        '
        'MenuTablosuDataGridView
        '
        Me.MenuTablosuDataGridView.AutoGenerateColumns = False
        Me.MenuTablosuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuTablosuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.MenuTablosuDataGridView.DataSource = Me.MenuTablosuBindingSource
        Me.MenuTablosuDataGridView.Location = New System.Drawing.Point(391, 64)
        Me.MenuTablosuDataGridView.Name = "MenuTablosuDataGridView"
        Me.MenuTablosuDataGridView.Size = New System.Drawing.Size(403, 399)
        Me.MenuTablosuDataGridView.TabIndex = 13
        '
        'MenuUrunAraToolStrip
        '
        Me.MenuUrunAraToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuUrunAdiToolStripLabel, Me.MenuUrunAdiToolStripTextBox, Me.MenuUrunAraToolStripButton})
        Me.MenuUrunAraToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.MenuUrunAraToolStrip.Name = "MenuUrunAraToolStrip"
        Me.MenuUrunAraToolStrip.Size = New System.Drawing.Size(835, 25)
        Me.MenuUrunAraToolStrip.TabIndex = 14
        Me.MenuUrunAraToolStrip.Text = "MenuUrunAraToolStrip"
        '
        'MenuUrunAdiToolStripLabel
        '
        Me.MenuUrunAdiToolStripLabel.Name = "MenuUrunAdiToolStripLabel"
        Me.MenuUrunAdiToolStripLabel.Size = New System.Drawing.Size(85, 22)
        Me.MenuUrunAdiToolStripLabel.Text = "MenuUrunAdi:"
        '
        'MenuUrunAdiToolStripTextBox
        '
        Me.MenuUrunAdiToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuUrunAdiToolStripTextBox.Name = "MenuUrunAdiToolStripTextBox"
        Me.MenuUrunAdiToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'MenuUrunAraToolStripButton
        '
        Me.MenuUrunAraToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MenuUrunAraToolStripButton.Name = "MenuUrunAraToolStripButton"
        Me.MenuUrunAraToolStripButton.Size = New System.Drawing.Size(86, 22)
        Me.MenuUrunAraToolStripButton.Text = "MenuUrunAra"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MenuUrunNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MenuUrunNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MenuUrunAdi"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MenuUrunAdi"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Fiyat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fiyat"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Fotograf"
        Me.DataGridViewImageColumn1.HeaderText = "Fotograf"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "icerik"
        Me.DataGridViewTextBoxColumn4.HeaderText = "icerik"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "GuncellemeTarihi"
        Me.DataGridViewTextBoxColumn5.HeaderText = "GuncellemeTarihi"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'MenuTablosuBindingSource
        '
        Me.MenuTablosuBindingSource.DataMember = "MenuTablosu"
        Me.MenuTablosuBindingSource.DataSource = Me.BilgiKafeDS
        '
        'BilgiKafeDS
        '
        Me.BilgiKafeDS.DataSetName = "BilgiKafeDS"
        Me.BilgiKafeDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuTablosuTableAdapter
        '
        Me.MenuTablosuTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdisyonDetayTablosuTableAdapter = Nothing
        Me.TableAdapterManager.AdisyonTablosuTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MasaTablosuTableAdapter = Nothing
        Me.TableAdapterManager.MekanBolumTablosuTableAdapter = Nothing
        Me.TableAdapterManager.MenuTablosuTableAdapter = Me.MenuTablosuTableAdapter
        Me.TableAdapterManager.sysdiagramsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TasarimlaSQLBaglanti.BilgiKafeDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 507)
        Me.Controls.Add(Me.MenuUrunAraToolStrip)
        Me.Controls.Add(Me.MenuTablosuDataGridView)
        Me.Controls.Add(MenuUrunNoLabel)
        Me.Controls.Add(Me.MenuUrunNoTextBox)
        Me.Controls.Add(MenuUrunAdiLabel)
        Me.Controls.Add(Me.MenuUrunAdiTextBox)
        Me.Controls.Add(FiyatLabel)
        Me.Controls.Add(Me.FiyatTextBox)
        Me.Controls.Add(FotografLabel)
        Me.Controls.Add(Me.FotografPictureBox)
        Me.Controls.Add(IcerikLabel)
        Me.Controls.Add(Me.IcerikTextBox)
        Me.Controls.Add(GuncellemeTarihiLabel)
        Me.Controls.Add(Me.GuncellemeTarihiDateTimePicker)
        Me.Controls.Add(Me.MenuTablosuBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MenuTablosuBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuTablosuBindingNavigator.ResumeLayout(False)
        Me.MenuTablosuBindingNavigator.PerformLayout()
        CType(Me.FotografPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTablosuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuUrunAraToolStrip.ResumeLayout(False)
        Me.MenuUrunAraToolStrip.PerformLayout()
        CType(Me.MenuTablosuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BilgiKafeDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BilgiKafeDS As BilgiKafeDS
    Friend WithEvents MenuTablosuBindingSource As BindingSource
    Friend WithEvents MenuTablosuTableAdapter As BilgiKafeDSTableAdapters.MenuTablosuTableAdapter
    Friend WithEvents TableAdapterManager As BilgiKafeDSTableAdapters.TableAdapterManager
    Friend WithEvents MenuTablosuBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MenuTablosuBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MenuUrunNoTextBox As TextBox
    Friend WithEvents MenuUrunAdiTextBox As TextBox
    Friend WithEvents FiyatTextBox As TextBox
    Friend WithEvents FotografPictureBox As PictureBox
    Friend WithEvents IcerikTextBox As TextBox
    Friend WithEvents GuncellemeTarihiDateTimePicker As DateTimePicker
    Friend WithEvents MenuTablosuDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents MenuUrunAraToolStrip As ToolStrip
    Friend WithEvents MenuUrunAdiToolStripLabel As ToolStripLabel
    Friend WithEvents MenuUrunAdiToolStripTextBox As ToolStripTextBox
    Friend WithEvents MenuUrunAraToolStripButton As ToolStripButton
End Class
