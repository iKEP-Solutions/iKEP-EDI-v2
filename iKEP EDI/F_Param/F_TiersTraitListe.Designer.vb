<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_TiersTraitListe
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
        Me.TiersMoins = New System.Windows.Forms.Button()
        Me.TiersPLus = New System.Windows.Forms.Button()
        Me.gTraitement = New System.Windows.Forms.DataGridView()
        Me.TiersTraitId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiersNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatTrait = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeTrait = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gTraitement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TiersMoins
        '
        Me.TiersMoins.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TiersMoins.Location = New System.Drawing.Point(743, 50)
        Me.TiersMoins.Name = "TiersMoins"
        Me.TiersMoins.Size = New System.Drawing.Size(32, 32)
        Me.TiersMoins.TabIndex = 9
        Me.TiersMoins.Text = "-"
        Me.TiersMoins.UseVisualStyleBackColor = True
        '
        'TiersPLus
        '
        Me.TiersPLus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TiersPLus.Location = New System.Drawing.Point(743, 12)
        Me.TiersPLus.Name = "TiersPLus"
        Me.TiersPLus.Size = New System.Drawing.Size(32, 32)
        Me.TiersPLus.TabIndex = 8
        Me.TiersPLus.Text = "+"
        Me.TiersPLus.UseVisualStyleBackColor = True
        '
        'gTraitement
        '
        Me.gTraitement.AllowUserToAddRows = False
        Me.gTraitement.AllowUserToDeleteRows = False
        Me.gTraitement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gTraitement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gTraitement.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gTraitement.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gTraitement.ColumnHeadersHeight = 30
        Me.gTraitement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TiersTraitId, Me.TiersNom, Me.CatTrait, Me.TypeTrait, Me.ETL})
        Me.gTraitement.Location = New System.Drawing.Point(12, 12)
        Me.gTraitement.MultiSelect = False
        Me.gTraitement.Name = "gTraitement"
        Me.gTraitement.ReadOnly = True
        Me.gTraitement.RowHeadersVisible = False
        Me.gTraitement.RowHeadersWidth = 32
        Me.gTraitement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gTraitement.Size = New System.Drawing.Size(725, 307)
        Me.gTraitement.TabIndex = 7
        '
        'TiersTraitId
        '
        Me.TiersTraitId.FillWeight = 60.0!
        Me.TiersTraitId.HeaderText = "Id"
        Me.TiersTraitId.Name = "TiersTraitId"
        Me.TiersTraitId.ReadOnly = True
        Me.TiersTraitId.Visible = False
        '
        'TiersNom
        '
        Me.TiersNom.HeaderText = "Tiers"
        Me.TiersNom.Name = "TiersNom"
        Me.TiersNom.ReadOnly = True
        '
        'CatTrait
        '
        Me.CatTrait.HeaderText = "Cat. Traitement"
        Me.CatTrait.Name = "CatTrait"
        Me.CatTrait.ReadOnly = True
        '
        'TypeTrait
        '
        Me.TypeTrait.HeaderText = "Type Trait."
        Me.TypeTrait.Name = "TypeTrait"
        Me.TypeTrait.ReadOnly = True
        '
        'ETL
        '
        Me.ETL.HeaderText = "ETL"
        Me.ETL.Name = "ETL"
        Me.ETL.ReadOnly = True
        '
        'F_TiersTraitListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 331)
        Me.Controls.Add(Me.TiersMoins)
        Me.Controls.Add(Me.TiersPLus)
        Me.Controls.Add(Me.gTraitement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "F_TiersTraitListe"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tiers - Traitement"
        CType(Me.gTraitement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TiersMoins As Button
    Friend WithEvents TiersPLus As Button
    Friend WithEvents gTraitement As DataGridView
    Friend WithEvents TiersTraitId As DataGridViewTextBoxColumn
    Friend WithEvents TiersNom As DataGridViewTextBoxColumn
    Friend WithEvents CatTrait As DataGridViewTextBoxColumn
    Friend WithEvents TypeTrait As DataGridViewTextBoxColumn
    Friend WithEvents ETL As DataGridViewTextBoxColumn
End Class
