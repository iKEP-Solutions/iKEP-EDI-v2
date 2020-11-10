<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LigneVerouille
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gCdeVerou = New System.Windows.Forms.DataGridView()
        Me.CodeClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumCde_ERP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumLigneCde_ERP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Util = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.gCdeVerou, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gCdeVerou
        '
        Me.gCdeVerou.AllowUserToAddRows = False
        Me.gCdeVerou.AllowUserToDeleteRows = False
        Me.gCdeVerou.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gCdeVerou.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gCdeVerou.BackgroundColor = System.Drawing.SystemColors.Control
        Me.gCdeVerou.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gCdeVerou.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gCdeVerou.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeClient, Me.NumCde_ERP, Me.NumLigneCde_ERP, Me.Util})
        Me.gCdeVerou.Location = New System.Drawing.Point(12, 12)
        Me.gCdeVerou.Name = "gCdeVerou"
        Me.gCdeVerou.RowHeadersVisible = False
        Me.gCdeVerou.Size = New System.Drawing.Size(475, 356)
        Me.gCdeVerou.TabIndex = 3
        '
        'CodeClient
        '
        Me.CodeClient.FillWeight = 30.0!
        Me.CodeClient.HeaderText = "Client ERP"
        Me.CodeClient.Name = "CodeClient"
        Me.CodeClient.ReadOnly = True
        Me.CodeClient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'NumCde_ERP
        '
        Me.NumCde_ERP.FillWeight = 40.0!
        Me.NumCde_ERP.HeaderText = "N°Cde"
        Me.NumCde_ERP.Name = "NumCde_ERP"
        Me.NumCde_ERP.ReadOnly = True
        Me.NumCde_ERP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'NumLigneCde_ERP
        '
        Me.NumLigneCde_ERP.FillWeight = 20.0!
        Me.NumLigneCde_ERP.HeaderText = "N° Ligne ERP"
        Me.NumLigneCde_ERP.Name = "NumLigneCde_ERP"
        Me.NumLigneCde_ERP.ReadOnly = True
        Me.NumLigneCde_ERP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Util
        '
        DataGridViewCellStyle1.Format = "N2"
        Me.Util.DefaultCellStyle = DataGridViewCellStyle1
        Me.Util.FillWeight = 50.0!
        Me.Util.HeaderText = "Utilisateur"
        Me.Util.Name = "Util"
        Me.Util.ReadOnly = True
        Me.Util.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(412, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'F_LigneVerouille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 406)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gCdeVerou)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "F_LigneVerouille"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lignes Vérouillées"
        CType(Me.gCdeVerou, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gCdeVerou As DataGridView
    Friend WithEvents CodeClient As DataGridViewTextBoxColumn
    Friend WithEvents NumCde_ERP As DataGridViewTextBoxColumn
    Friend WithEvents NumLigneCde_ERP As DataGridViewTextBoxColumn
    Friend WithEvents Util As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
