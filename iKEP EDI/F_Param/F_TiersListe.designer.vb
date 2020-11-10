<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_TiersListe
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
        Me.gTiers = New System.Windows.Forms.DataGridView()
        Me.TiersPLus = New System.Windows.Forms.Button()
        Me.TiersMoins = New System.Windows.Forms.Button()
        Me.TiersId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gTiers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gTiers
        '
        Me.gTiers.AllowUserToAddRows = False
        Me.gTiers.AllowUserToDeleteRows = False
        Me.gTiers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gTiers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gTiers.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gTiers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gTiers.ColumnHeadersHeight = 30
        Me.gTiers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TiersId, Me.Nom})
        Me.gTiers.Location = New System.Drawing.Point(12, 12)
        Me.gTiers.MultiSelect = False
        Me.gTiers.Name = "gTiers"
        Me.gTiers.ReadOnly = True
        Me.gTiers.RowHeadersVisible = False
        Me.gTiers.RowHeadersWidth = 32
        Me.gTiers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gTiers.Size = New System.Drawing.Size(226, 313)
        Me.gTiers.TabIndex = 3
        '
        'TiersPLus
        '
        Me.TiersPLus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TiersPLus.Location = New System.Drawing.Point(244, 12)
        Me.TiersPLus.Name = "TiersPLus"
        Me.TiersPLus.Size = New System.Drawing.Size(32, 32)
        Me.TiersPLus.TabIndex = 5
        Me.TiersPLus.Text = "+"
        Me.TiersPLus.UseVisualStyleBackColor = True
        '
        'TiersMoins
        '
        Me.TiersMoins.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TiersMoins.Location = New System.Drawing.Point(244, 50)
        Me.TiersMoins.Name = "TiersMoins"
        Me.TiersMoins.Size = New System.Drawing.Size(32, 32)
        Me.TiersMoins.TabIndex = 6
        Me.TiersMoins.Text = "-"
        Me.TiersMoins.UseVisualStyleBackColor = True
        '
        'TiersId
        '
        Me.TiersId.FillWeight = 60.0!
        Me.TiersId.HeaderText = "Id"
        Me.TiersId.Name = "TiersId"
        Me.TiersId.ReadOnly = True
        Me.TiersId.Visible = False
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        '
        'F_TiersListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 337)
        Me.Controls.Add(Me.TiersMoins)
        Me.Controls.Add(Me.TiersPLus)
        Me.Controls.Add(Me.gTiers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "F_TiersListe"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paramétrage Tiers"
        CType(Me.gTiers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gTiers As System.Windows.Forms.DataGridView
    Friend WithEvents TiersPLus As System.Windows.Forms.Button
    Friend WithEvents TiersMoins As System.Windows.Forms.Button
    Friend WithEvents TiersId As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
End Class
