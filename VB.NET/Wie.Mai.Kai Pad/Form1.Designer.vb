Imports System.Net.WebRequestMethods

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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


    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernunterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeitenansichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RückgängigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WiederholenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AlleauswählenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnpassenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InhaltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AufUpdatesÜberprüfenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WieMaiKaideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.BearbeitenToolStripMenuItem, Me.ExtrasToolStripMenuItem, Me.HilfeToolStripMenuItem, Me.WieMaiKaideToolStripMenuItem, Me.ToolStripTextBox1, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(1641, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.ÖffnenToolStripMenuItem, Me.toolStripSeparator, Me.SpeichernToolStripMenuItem, Me.SpeichernunterToolStripMenuItem, Me.toolStripSeparator1, Me.DruckenToolStripMenuItem, Me.SeitenansichtToolStripMenuItem, Me.toolStripSeparator2, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Image = CType(resources.GetObject("NeuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NeuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.NeuToolStripMenuItem.Text = "&Neu"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Image = CType(resources.GetObject("ÖffnenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ÖffnenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Ö&ffnen"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(165, 6)
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Image = CType(resources.GetObject("SpeichernToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SpeichernToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SpeichernToolStripMenuItem.Text = "&Speichern"
        '
        'SpeichernunterToolStripMenuItem
        '
        Me.SpeichernunterToolStripMenuItem.Name = "SpeichernunterToolStripMenuItem"
        Me.SpeichernunterToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SpeichernunterToolStripMenuItem.Text = "Speichern &unter"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'DruckenToolStripMenuItem
        '
        Me.DruckenToolStripMenuItem.Image = CType(resources.GetObject("DruckenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DruckenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DruckenToolStripMenuItem.Name = "DruckenToolStripMenuItem"
        Me.DruckenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.DruckenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.DruckenToolStripMenuItem.Text = "&Drucken"
        '
        'SeitenansichtToolStripMenuItem
        '
        Me.SeitenansichtToolStripMenuItem.Image = CType(resources.GetObject("SeitenansichtToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SeitenansichtToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SeitenansichtToolStripMenuItem.Name = "SeitenansichtToolStripMenuItem"
        Me.SeitenansichtToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SeitenansichtToolStripMenuItem.Text = "&Seitenansicht"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RückgängigToolStripMenuItem, Me.WiederholenToolStripMenuItem, Me.toolStripSeparator3, Me.AusschneidenToolStripMenuItem, Me.KopierenToolStripMenuItem, Me.EinfügenToolStripMenuItem, Me.toolStripSeparator4, Me.AlleauswählenToolStripMenuItem})
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BearbeitenToolStripMenuItem.Text = "&Bearbeiten"
        '
        'RückgängigToolStripMenuItem
        '
        Me.RückgängigToolStripMenuItem.Name = "RückgängigToolStripMenuItem"
        Me.RückgängigToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.RückgängigToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.RückgängigToolStripMenuItem.Text = "&Rückgängig"
        '
        'WiederholenToolStripMenuItem
        '
        Me.WiederholenToolStripMenuItem.Name = "WiederholenToolStripMenuItem"
        Me.WiederholenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.WiederholenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.WiederholenToolStripMenuItem.Text = "Wiede&rholen"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(188, 6)
        '
        'AusschneidenToolStripMenuItem
        '
        Me.AusschneidenToolStripMenuItem.Image = CType(resources.GetObject("AusschneidenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AusschneidenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AusschneidenToolStripMenuItem.Name = "AusschneidenToolStripMenuItem"
        Me.AusschneidenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.AusschneidenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AusschneidenToolStripMenuItem.Text = "&Ausschneiden"
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.Image = CType(resources.GetObject("KopierenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KopierenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        Me.KopierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.KopierenToolStripMenuItem.Text = "&Kopieren"
        '
        'EinfügenToolStripMenuItem
        '
        Me.EinfügenToolStripMenuItem.Image = CType(resources.GetObject("EinfügenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EinfügenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
        Me.EinfügenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.EinfügenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EinfügenToolStripMenuItem.Text = "&Einfügen"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(188, 6)
        '
        'AlleauswählenToolStripMenuItem
        '
        Me.AlleauswählenToolStripMenuItem.Name = "AlleauswählenToolStripMenuItem"
        Me.AlleauswählenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AlleauswählenToolStripMenuItem.Text = "&Alle auswählen"
        '
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnpassenToolStripMenuItem, Me.OptionenToolStripMenuItem})
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ExtrasToolStripMenuItem.Text = "E&xtras"
        '
        'AnpassenToolStripMenuItem
        '
        Me.AnpassenToolStripMenuItem.Name = "AnpassenToolStripMenuItem"
        Me.AnpassenToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AnpassenToolStripMenuItem.Text = "&Anpassen"
        '
        'OptionenToolStripMenuItem
        '
        Me.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem"
        Me.OptionenToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.OptionenToolStripMenuItem.Text = "&Optionen"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InhaltToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SuchenToolStripMenuItem, Me.toolStripSeparator5, Me.AufUpdatesÜberprüfenToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "&Hilfe"
        '
        'InhaltToolStripMenuItem
        '
        Me.InhaltToolStripMenuItem.Name = "InhaltToolStripMenuItem"
        Me.InhaltToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.InhaltToolStripMenuItem.Text = "I&nhalt"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SuchenToolStripMenuItem
        '
        Me.SuchenToolStripMenuItem.Name = "SuchenToolStripMenuItem"
        Me.SuchenToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SuchenToolStripMenuItem.Text = "&Suchen"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(198, 6)
        '
        'AufUpdatesÜberprüfenToolStripMenuItem
        '
        Me.AufUpdatesÜberprüfenToolStripMenuItem.Name = "AufUpdatesÜberprüfenToolStripMenuItem"
        Me.AufUpdatesÜberprüfenToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.AufUpdatesÜberprüfenToolStripMenuItem.Text = "Auf Updates überprüfen"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.InfoToolStripMenuItem.Text = "Inf&o..."
        '
        'WieMaiKaideToolStripMenuItem
        '
        Me.WieMaiKaideToolStripMenuItem.Name = "WieMaiKaideToolStripMenuItem"
        Me.WieMaiKaideToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.WieMaiKaideToolStripMenuItem.Text = "&WieMaiKai.de"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.ReadOnly = True
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(700, 23)
        Me.ToolStripTextBox1.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        Me.ToolStripMenuItem1.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 24)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(1641, 824)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("http://wiemaikai.de", System.UriKind.Absolute)
        Me.WebBrowser1.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(1464, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(180, 23)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name:"
        Me.Label1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(72, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(240, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 31)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1641, 848)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wie.Mai.Kai - TechnikPad"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SpeichernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeichernunterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DruckenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeitenansichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RückgängigToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WiederholenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AusschneidenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KopierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinfügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AlleauswählenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnpassenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InhaltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuchenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AufUpdatesÜberprüfenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents WieMaiKaideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ToolStripTextBox1.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub WieMaiKaideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WieMaiKaideToolStripMenuItem.Click
        If WebBrowser1.Visible() = False Then
            WieMaiKaideToolStripMenuItem.Text = "Bro&wser schliessen"
            WebBrowser1.Visible() = True
            ToolStripTextBox1.Visible = True
            ProgressBar1.Visible = True
            ToolStripMenuItem1.Visible = False
        Else
            WebBrowser1.Visible() = False
            WieMaiKaideToolStripMenuItem.Text = "&WieMaiKai.de"
            WebBrowser1.Url = New System.Uri("http://wiemaikai.de", System.UriKind.Absolute)
            ToolStripTextBox1.Visible = False
            ProgressBar1.Visible = False
            ToolStripMenuItem1.Visible = False
        End If

    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        wmkpad_about.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.CSGOPATH IsNot "" Then
            'My.Settings.Name = ""
            'My.Settings.Save()
            ToolStripMenuItem1.Visible = True
            ToolStripMenuItem1.Text = "Lizensiert für: " + My.Settings.CSGOPATH
            ToolStripMenuItem1.Alignment = ToolStripItemAlignment.Right
        Else
            Me.Text = "Bitte gib deinen Namen an."
            Me.Width = "300"
            Me.Height = "85"
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            MenuStrip1.Visible = False
            Label1.Visible = True
            TextBox1.Visible = True
            Button1.Visible = True
            'wmkpad_firstrun.Show()
            'Me.Hide()
        End If

    End Sub

    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        Try
            ProgressBar1.Value = e.CurrentProgress
            ProgressBar1.Maximum = e.MaximumProgress
        Catch ex As Exception
        End Try

        If ProgressBar1.Value = e.MaximumProgress Then
            ProgressBar1.Visible = False
        End If
    End Sub
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernToolStripMenuItem.Click
        MsgBox("Wird noch hinzugefügt  :3", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub SpeichernunterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernunterToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        My.Settings.CSGOPATH = ""
        My.Settings.Save()
        Application.Exit()
    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text IsNot "" Then

            My.Settings.CSGOPATH = TextBox1.Text
            My.Settings.Save()

            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.Width = "1661"
            Me.Height = "890"
            Me.Text = "Wie.Mai.Kai - TechnikPad"
            MenuStrip1.Visible = True
            ToolStripMenuItem1.Visible = True
            ToolStripMenuItem1.Text = "Lizensiert für: " + My.Settings.CSGOPATH
            ToolStripMenuItem1.Alignment = ToolStripItemAlignment.Right
            Label1.Visible = False
            TextBox1.Visible = False
            Button1.Visible = False

        Else
            MsgBox("Bitte gebe einen Namen ein.", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class