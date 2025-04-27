<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EtchASketch
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
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopMenu = New System.Windows.Forms.MenuStrip()
        Me.FileTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        Me.TopMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawingPictureBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.DrawingPictureBox.Location = New System.Drawing.Point(1, 27)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(799, 365)
        Me.DrawingPictureBox.TabIndex = 0
        Me.DrawingPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.DrawingPictureBox, "Draw within this area")
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileContextMenuItem, Me.EditContextMenuItem, Me.HelpContextMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(100, 70)
        '
        'FileContextMenuItem
        '
        Me.FileContextMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitContextMenuItem})
        Me.FileContextMenuItem.Name = "FileContextMenuItem"
        Me.FileContextMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.FileContextMenuItem.Text = "File"
        '
        'ExitContextMenuItem
        '
        Me.ExitContextMenuItem.Name = "ExitContextMenuItem"
        Me.ExitContextMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitContextMenuItem.Text = "Exit"
        '
        'EditContextMenuItem
        '
        Me.EditContextMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorContextMenuItem, Me.DrawWaveformsContextMenuItem, Me.ClearContextMenuItem})
        Me.EditContextMenuItem.Name = "EditContextMenuItem"
        Me.EditContextMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.EditContextMenuItem.Text = "Edit"
        '
        'SelectColorContextMenuItem
        '
        Me.SelectColorContextMenuItem.Name = "SelectColorContextMenuItem"
        Me.SelectColorContextMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SelectColorContextMenuItem.Text = "Select Color"
        '
        'DrawWaveformsContextMenuItem
        '
        Me.DrawWaveformsContextMenuItem.Name = "DrawWaveformsContextMenuItem"
        Me.DrawWaveformsContextMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DrawWaveformsContextMenuItem.Text = "Draw Waveforms"
        '
        'ClearContextMenuItem
        '
        Me.ClearContextMenuItem.Name = "ClearContextMenuItem"
        Me.ClearContextMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ClearContextMenuItem.Text = "Clear"
        '
        'HelpContextMenuItem
        '
        Me.HelpContextMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutContextMenuItem})
        Me.HelpContextMenuItem.Name = "HelpContextMenuItem"
        Me.HelpContextMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.HelpContextMenuItem.Text = "Help"
        '
        'AboutContextMenuItem
        '
        Me.AboutContextMenuItem.Name = "AboutContextMenuItem"
        Me.AboutContextMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutContextMenuItem.Text = "About"
        '
        'TopMenu
        '
        Me.TopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopMenuItem, Me.EditTopMenuItem, Me.HelpTopMenuItem})
        Me.TopMenu.Location = New System.Drawing.Point(0, 0)
        Me.TopMenu.Name = "TopMenu"
        Me.TopMenu.Size = New System.Drawing.Size(800, 24)
        Me.TopMenu.TabIndex = 1
        Me.TopMenu.Text = "MenuStrip1"
        '
        'FileTopMenuItem
        '
        Me.FileTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitTopMenuItem})
        Me.FileTopMenuItem.Name = "FileTopMenuItem"
        Me.FileTopMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileTopMenuItem.Text = "File"
        '
        'ExitTopMenuItem
        '
        Me.ExitTopMenuItem.Name = "ExitTopMenuItem"
        Me.ExitTopMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitTopMenuItem.Text = "Exit"
        '
        'EditTopMenuItem
        '
        Me.EditTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorTopMenuItem, Me.DrawWaveformsTopMenuItem, Me.ClearTopMenuItem})
        Me.EditTopMenuItem.Name = "EditTopMenuItem"
        Me.EditTopMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditTopMenuItem.Text = "Edit"
        '
        'SelectColorTopMenuItem
        '
        Me.SelectColorTopMenuItem.Name = "SelectColorTopMenuItem"
        Me.SelectColorTopMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SelectColorTopMenuItem.Text = "Select Color"
        '
        'DrawWaveformsTopMenuItem
        '
        Me.DrawWaveformsTopMenuItem.Name = "DrawWaveformsTopMenuItem"
        Me.DrawWaveformsTopMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DrawWaveformsTopMenuItem.Text = "Draw Waveforms"
        '
        'ClearTopMenuItem
        '
        Me.ClearTopMenuItem.Name = "ClearTopMenuItem"
        Me.ClearTopMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ClearTopMenuItem.Text = "Clear"
        '
        'HelpTopMenuItem
        '
        Me.HelpTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTopMenuItem})
        Me.HelpTopMenuItem.Name = "HelpTopMenuItem"
        Me.HelpTopMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpTopMenuItem.Text = "Help"
        '
        'AboutTopMenuItem
        '
        Me.AboutTopMenuItem.Name = "AboutTopMenuItem"
        Me.AboutTopMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutTopMenuItem.Text = "About"
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SelectColorButton.Location = New System.Drawing.Point(143, 415)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(75, 23)
        Me.SelectColorButton.TabIndex = 3
        Me.SelectColorButton.Text = "&Select Color"
        Me.ToolTip1.SetToolTip(Me.SelectColorButton, "Selects Color to Draw with")
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(289, 415)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(106, 23)
        Me.DrawWaveformsButton.TabIndex = 4
        Me.DrawWaveformsButton.Text = "Draw &Waveforms"
        Me.ToolTip1.SetToolTip(Me.DrawWaveformsButton, "Draws a Sine, Cosine, and Tangent Wave")
        Me.DrawWaveformsButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ClearButton.Location = New System.Drawing.Point(476, 415)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clears the Drawing")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ExitButton.Location = New System.Drawing.Point(619, 415)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exits the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'EtchASketch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DrawWaveformsButton)
        Me.Controls.Add(Me.SelectColorButton)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Controls.Add(Me.TopMenu)
        Me.MainMenuStrip = Me.TopMenu
        Me.Name = "EtchASketch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etch-A-Sketch"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.TopMenu.ResumeLayout(False)
        Me.TopMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents TopMenu As MenuStrip
    Friend WithEvents FileTopMenuItem As ToolStripMenuItem
    Friend WithEvents ExitTopMenuItem As ToolStripMenuItem
    Friend WithEvents EditTopMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorTopMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsTopMenuItem As ToolStripMenuItem
    Friend WithEvents ClearTopMenuItem As ToolStripMenuItem
    Friend WithEvents HelpTopMenuItem As ToolStripMenuItem
    Friend WithEvents AboutTopMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents FileContextMenuItem As ToolStripMenuItem
    Friend WithEvents ExitContextMenuItem As ToolStripMenuItem
    Friend WithEvents EditContextMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorContextMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsContextMenuItem As ToolStripMenuItem
    Friend WithEvents ClearContextMenuItem As ToolStripMenuItem
    Friend WithEvents HelpContextMenuItem As ToolStripMenuItem
    Friend WithEvents AboutContextMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents DrawWaveformsButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ColorDialog As ColorDialog
End Class
