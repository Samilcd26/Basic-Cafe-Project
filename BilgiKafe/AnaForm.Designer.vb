<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnaForm))
        Me.AnaMenu = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyarlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenüKategorileriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenüToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenüEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MetinPanel = New System.Windows.Forms.Panel()
        Me.DurumCubugu = New System.Windows.Forms.StatusStrip()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.MasaMekanBilgileriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasaEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasalarBtn = New System.Windows.Forms.Button()
        Me.MenuBtn = New System.Windows.Forms.Button()
        Me.MasalarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnaMenu.SuspendLayout()
        Me.MenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'AnaMenu
        '
        Me.AnaMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.AyarlarToolStripMenuItem})
        Me.AnaMenu.Location = New System.Drawing.Point(0, 0)
        Me.AnaMenu.Name = "AnaMenu"
        Me.AnaMenu.Size = New System.Drawing.Size(1032, 24)
        Me.AnaMenu.TabIndex = 1
        Me.AnaMenu.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÇıkışToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "&Program"
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'AyarlarToolStripMenuItem
        '
        Me.AyarlarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenüKategorileriToolStripMenuItem, Me.MenüToolStripMenuItem, Me.MenüEkleToolStripMenuItem, Me.ToolStripMenuItem1, Me.MasaMekanBilgileriToolStripMenuItem, Me.MasaEkleToolStripMenuItem, Me.MasalarToolStripMenuItem})
        Me.AyarlarToolStripMenuItem.Name = "AyarlarToolStripMenuItem"
        Me.AyarlarToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.AyarlarToolStripMenuItem.Text = "&Ayarlar"
        '
        'MenüKategorileriToolStripMenuItem
        '
        Me.MenüKategorileriToolStripMenuItem.Name = "MenüKategorileriToolStripMenuItem"
        Me.MenüKategorileriToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.MenüKategorileriToolStripMenuItem.Text = "Menü &Kategorileri"
        '
        'MenüToolStripMenuItem
        '
        Me.MenüToolStripMenuItem.Name = "MenüToolStripMenuItem"
        Me.MenüToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MenüToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.MenüToolStripMenuItem.Text = "&Menü"
        '
        'MenüEkleToolStripMenuItem
        '
        Me.MenüEkleToolStripMenuItem.Name = "MenüEkleToolStripMenuItem"
        Me.MenüEkleToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.MenüEkleToolStripMenuItem.Text = "Menü &Ekle"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 6)
        '
        'MetinPanel
        '
        Me.MetinPanel.BackColor = System.Drawing.Color.Orange
        Me.MetinPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetinPanel.Location = New System.Drawing.Point(0, 24)
        Me.MetinPanel.Name = "MetinPanel"
        Me.MetinPanel.Size = New System.Drawing.Size(1032, 30)
        Me.MetinPanel.TabIndex = 2
        '
        'DurumCubugu
        '
        Me.DurumCubugu.Location = New System.Drawing.Point(0, 606)
        Me.DurumCubugu.Name = "DurumCubugu"
        Me.DurumCubugu.Size = New System.Drawing.Size(1032, 22)
        Me.DurumCubugu.TabIndex = 3
        Me.DurumCubugu.Text = "StatusStrip1"
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.MasalarBtn)
        Me.MenuPanel.Controls.Add(Me.MenuBtn)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Location = New System.Drawing.Point(0, 54)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(200, 552)
        Me.MenuPanel.TabIndex = 4
        '
        'MasaMekanBilgileriToolStripMenuItem
        '
        Me.MasaMekanBilgileriToolStripMenuItem.Name = "MasaMekanBilgileriToolStripMenuItem"
        Me.MasaMekanBilgileriToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.MasaMekanBilgileriToolStripMenuItem.Text = "Masa Mekan &Bilgileri"
        '
        'MasaEkleToolStripMenuItem
        '
        Me.MasaEkleToolStripMenuItem.Name = "MasaEkleToolStripMenuItem"
        Me.MasaEkleToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.MasaEkleToolStripMenuItem.Text = "M&asa Ekle"
        '
        'MasalarBtn
        '
        Me.MasalarBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.MasalarBtn.Image = Global.BilgiKafe.My.Resources.Resources.Masalar
        Me.MasalarBtn.Location = New System.Drawing.Point(0, 55)
        Me.MasalarBtn.Name = "MasalarBtn"
        Me.MasalarBtn.Size = New System.Drawing.Size(200, 55)
        Me.MasalarBtn.TabIndex = 1
        Me.MasalarBtn.Text = "Masalar"
        Me.MasalarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MasalarBtn.UseVisualStyleBackColor = True
        '
        'MenuBtn
        '
        Me.MenuBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuBtn.Image = Global.BilgiKafe.My.Resources.Resources.Menu
        Me.MenuBtn.Location = New System.Drawing.Point(0, 0)
        Me.MenuBtn.Name = "MenuBtn"
        Me.MenuBtn.Size = New System.Drawing.Size(200, 55)
        Me.MenuBtn.TabIndex = 0
        Me.MenuBtn.Text = "Menü"
        Me.MenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MenuBtn.UseVisualStyleBackColor = True
        '
        'MasalarToolStripMenuItem
        '
        Me.MasalarToolStripMenuItem.Name = "MasalarToolStripMenuItem"
        Me.MasalarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.MasalarToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.MasalarToolStripMenuItem.Text = "Masalar"
        '
        'AnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 628)
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.DurumCubugu)
        Me.Controls.Add(Me.MetinPanel)
        Me.Controls.Add(Me.AnaMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.AnaMenu
        Me.Name = "AnaForm"
        Me.Text = "BilgiKafe Kafe Yazılımı"
        Me.AnaMenu.ResumeLayout(False)
        Me.AnaMenu.PerformLayout()
        Me.MenuPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AnaMenu As MenuStrip
    Friend WithEvents MetinPanel As Panel
    Friend WithEvents DurumCubugu As StatusStrip
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents MenuBtn As Button
    Friend WithEvents MasalarBtn As Button
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyarlarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenüKategorileriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenüToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenüEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents MasaMekanBilgileriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasaEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasalarToolStripMenuItem As ToolStripMenuItem
End Class
