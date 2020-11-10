<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ImportListe
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
        Me.gFichier = New System.Windows.Forms.DataGridView()
        Me.FicServ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FicLocal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bOK = New System.Windows.Forms.Button()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.oFileDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.gFichier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TiersMoins
        '
        Me.TiersMoins.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TiersMoins.Location = New System.Drawing.Point(528, 50)
        Me.TiersMoins.Name = "TiersMoins"
        Me.TiersMoins.Size = New System.Drawing.Size(32, 32)
        Me.TiersMoins.TabIndex = 9
        Me.TiersMoins.Text = "-"
        Me.TiersMoins.UseVisualStyleBackColor = True
        '
        'TiersPLus
        '
        Me.TiersPLus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TiersPLus.Location = New System.Drawing.Point(528, 12)
        Me.TiersPLus.Name = "TiersPLus"
        Me.TiersPLus.Size = New System.Drawing.Size(32, 32)
        Me.TiersPLus.TabIndex = 8
        Me.TiersPLus.Text = "+"
        Me.TiersPLus.UseVisualStyleBackColor = True
        '
        'gFichier
        '
        Me.gFichier.AllowUserToAddRows = False
        Me.gFichier.AllowUserToDeleteRows = False
        Me.gFichier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gFichier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gFichier.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gFichier.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gFichier.ColumnHeadersHeight = 30
        Me.gFichier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FicServ, Me.FicLocal})
        Me.gFichier.Location = New System.Drawing.Point(12, 12)
        Me.gFichier.MultiSelect = False
        Me.gFichier.Name = "gFichier"
        Me.gFichier.RowHeadersVisible = False
        Me.gFichier.RowHeadersWidth = 32
        Me.gFichier.Size = New System.Drawing.Size(510, 177)
        Me.gFichier.TabIndex = 7
        '
        'FicServ
        '
        Me.FicServ.HeaderText = "ficserv"
        Me.FicServ.Name = "FicServ"
        Me.FicServ.ReadOnly = True
        Me.FicServ.Visible = False
        '
        'FicLocal
        '
        Me.FicLocal.HeaderText = "Fichier"
        Me.FicLocal.Name = "FicLocal"
        Me.FicLocal.ReadOnly = True
        '
        'bOK
        '
        Me.bOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bOK.Location = New System.Drawing.Point(424, 204)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(98, 38)
        Me.bOK.TabIndex = 10
        Me.bOK.Text = "OK"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'bAnnul
        '
        Me.bAnnul.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(12, 204)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(98, 38)
        Me.bAnnul.TabIndex = 11
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'F_ImportListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 259)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.TiersMoins)
        Me.Controls.Add(Me.TiersPLus)
        Me.Controls.Add(Me.gFichier)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "F_ImportListe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Imports"
        CType(Me.gFichier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TiersMoins As Button
    Friend WithEvents TiersPLus As Button
    Friend WithEvents gFichier As DataGridView
    Friend WithEvents bOK As Button
    Friend WithEvents bAnnul As Button
    Friend WithEvents oFileDialog As OpenFileDialog
    Friend WithEvents FicServ As DataGridViewTextBoxColumn
    Friend WithEvents FicLocal As DataGridViewTextBoxColumn
End Class
