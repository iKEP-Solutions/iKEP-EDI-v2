<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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


    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Main))
        Me.sStatus = New System.Windows.Forms.StatusStrip()
        Me.sLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mGlobal = New System.Windows.Forms.MenuStrip()
        Me.mImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mAfferme = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParamétrageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mTiers = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraitementsTiersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mUtil = New System.Windows.Forms.ToolStripMenuItem()
        Me.mConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mParam = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideEnLigneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sStatus.SuspendLayout()
        Me.mGlobal.SuspendLayout()
        Me.SuspendLayout()
        '
        'sStatus
        '
        Me.sStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sLabel, Me.sUser, Me.tVersion})
        Me.sStatus.Location = New System.Drawing.Point(0, 659)
        Me.sStatus.Name = "sStatus"
        Me.sStatus.Size = New System.Drawing.Size(1280, 22)
        Me.sStatus.TabIndex = 7
        Me.sStatus.Text = "StatusStrip"
        '
        'sLabel
        '
        Me.sLabel.Name = "sLabel"
        Me.sLabel.Size = New System.Drawing.Size(1190, 17)
        Me.sLabel.Spring = True
        Me.sLabel.Text = "Etat"
        Me.sLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'sUser
        '
        Me.sUser.DoubleClickEnabled = True
        Me.sUser.Name = "sUser"
        Me.sUser.Size = New System.Drawing.Size(30, 17)
        Me.sUser.Text = "User"
        '
        'tVersion
        '
        Me.tVersion.IsLink = True
        Me.tVersion.Name = "tVersion"
        Me.tVersion.Size = New System.Drawing.Size(45, 17)
        Me.tVersion.Text = "Version"
        '
        'mGlobal
        '
        Me.mGlobal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mImport, Me.mExport, Me.mAfferme, Me.QuitterToolStripMenuItem, Me.ParamétrageToolStripMenuItem})
        Me.mGlobal.Location = New System.Drawing.Point(0, 0)
        Me.mGlobal.Name = "mGlobal"
        Me.mGlobal.Size = New System.Drawing.Size(1280, 24)
        Me.mGlobal.TabIndex = 9
        Me.mGlobal.Text = "MenuStrip1"
        '
        'mImport
        '
        Me.mImport.Name = "mImport"
        Me.mImport.Size = New System.Drawing.Size(55, 20)
        Me.mImport.Text = "Import"
        '
        'mExport
        '
        Me.mExport.Enabled = False
        Me.mExport.Name = "mExport"
        Me.mExport.Size = New System.Drawing.Size(52, 20)
        Me.mExport.Text = "Export"
        '
        'mAfferme
        '
        Me.mAfferme.Name = "mAfferme"
        Me.mAfferme.Size = New System.Drawing.Size(95, 20)
        Me.mAfferme.Text = "Cde Prév Silog"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'ParamétrageToolStripMenuItem
        '
        Me.ParamétrageToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ParamétrageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mTiers, Me.TraitementsTiersToolStripMenuItem, Me.mUtil, Me.mConfig, Me.ToolStripSeparator4, Me.mParam, Me.AideEnLigneToolStripMenuItem})
        Me.ParamétrageToolStripMenuItem.Name = "ParamétrageToolStripMenuItem"
        Me.ParamétrageToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ParamétrageToolStripMenuItem.Text = "Paramètres"
        '
        'mTiers
        '
        Me.mTiers.Name = "mTiers"
        Me.mTiers.Size = New System.Drawing.Size(180, 22)
        Me.mTiers.Text = "Tiers"
        '
        'TraitementsTiersToolStripMenuItem
        '
        Me.TraitementsTiersToolStripMenuItem.Name = "TraitementsTiersToolStripMenuItem"
        Me.TraitementsTiersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TraitementsTiersToolStripMenuItem.Text = "Traitements - Tiers"
        '
        'mUtil
        '
        Me.mUtil.Name = "mUtil"
        Me.mUtil.Size = New System.Drawing.Size(180, 22)
        Me.mUtil.Text = "Utilisateur"
        '
        'mConfig
        '
        Me.mConfig.Name = "mConfig"
        Me.mConfig.Size = New System.Drawing.Size(180, 22)
        Me.mConfig.Text = "Config Utilisateur"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(177, 6)
        '
        'mParam
        '
        Me.mParam.Name = "mParam"
        Me.mParam.Size = New System.Drawing.Size(180, 22)
        Me.mParam.Text = "Paramètres"
        '
        'AideEnLigneToolStripMenuItem
        '
        Me.AideEnLigneToolStripMenuItem.Name = "AideEnLigneToolStripMenuItem"
        Me.AideEnLigneToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AideEnLigneToolStripMenuItem.Text = "Aide en ligne"
        '
        'F_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 681)
        Me.Controls.Add(Me.sStatus)
        Me.Controls.Add(Me.mGlobal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mGlobal
        Me.Name = "F_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iKEP EDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.sStatus.ResumeLayout(False)
        Me.sStatus.PerformLayout()
        Me.mGlobal.ResumeLayout(False)
        Me.mGlobal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents sLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tVersion As ToolStripStatusLabel
    Friend WithEvents mGlobal As MenuStrip
    Friend WithEvents mImport As ToolStripMenuItem
    Friend WithEvents mExport As ToolStripMenuItem
    Friend WithEvents mAfferme As ToolStripMenuItem
    Friend WithEvents ParamétrageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mTiers As ToolStripMenuItem
    Friend WithEvents mUtil As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents mConfig As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mParam As ToolStripMenuItem
    Friend WithEvents AideEnLigneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TraitementsTiersToolStripMenuItem As ToolStripMenuItem
End Class
