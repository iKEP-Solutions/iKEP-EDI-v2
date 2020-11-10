<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ImportEncours
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tNbLigJour = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gEncours = New System.Windows.Forms.DataGridView()
        Me.CodeClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumCde_ERP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NbLignes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gEncours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(130, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nb de lignes en cours de transfert"
        '
        'tNbLigJour
        '
        Me.tNbLigJour.Location = New System.Drawing.Point(184, 6)
        Me.tNbLigJour.Name = "tNbLigJour"
        Me.tNbLigJour.ReadOnly = True
        Me.tNbLigJour.Size = New System.Drawing.Size(57, 20)
        Me.tNbLigJour.TabIndex = 2
        Me.tNbLigJour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(247, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 22)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Actualiser"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'gEncours
        '
        Me.gEncours.AllowUserToAddRows = False
        Me.gEncours.AllowUserToDeleteRows = False
        Me.gEncours.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gEncours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gEncours.BackgroundColor = System.Drawing.SystemColors.Control
        Me.gEncours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gEncours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gEncours.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeClient, Me.NumCde_ERP, Me.NbLignes})
        Me.gEncours.Location = New System.Drawing.Point(12, 32)
        Me.gEncours.Name = "gEncours"
        Me.gEncours.RowHeadersVisible = False
        Me.gEncours.Size = New System.Drawing.Size(329, 438)
        Me.gEncours.TabIndex = 4
        '
        'CodeClient
        '
        Me.CodeClient.HeaderText = "Client"
        Me.CodeClient.Name = "CodeClient"
        Me.CodeClient.ReadOnly = True
        Me.CodeClient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'NumCde_ERP
        '
        Me.NumCde_ERP.HeaderText = "N°Cde"
        Me.NumCde_ERP.Name = "NumCde_ERP"
        Me.NumCde_ERP.ReadOnly = True
        Me.NumCde_ERP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'NbLignes
        '
        Me.NbLignes.FillWeight = 50.0!
        Me.NbLignes.HeaderText = "NbLignes"
        Me.NbLignes.Name = "NbLignes"
        '
        'F_ImportEncours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 511)
        Me.Controls.Add(Me.gEncours)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tNbLigJour)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "F_ImportEncours"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "En cours d'Import"
        CType(Me.gEncours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tNbLigJour As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents gEncours As DataGridView
    Friend WithEvents CodeClient As DataGridViewTextBoxColumn
    Friend WithEvents NumCde_ERP As DataGridViewTextBoxColumn
    Friend WithEvents NbLignes As DataGridViewTextBoxColumn
End Class
