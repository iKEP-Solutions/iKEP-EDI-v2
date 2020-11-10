<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Doc
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
        Me.gDoc = New System.Windows.Forms.DataGridView()
        Me.DocTiersid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gDoc
        '
        Me.gDoc.AllowUserToAddRows = False
        Me.gDoc.AllowUserToDeleteRows = False
        Me.gDoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gDoc.BackgroundColor = System.Drawing.Color.White
        Me.gDoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gDoc.ColumnHeadersHeight = 30
        Me.gDoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DocTiersid, Me.DocNom, Me.DocRef})
        Me.gDoc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.gDoc.Location = New System.Drawing.Point(12, 12)
        Me.gDoc.MultiSelect = False
        Me.gDoc.Name = "gDoc"
        Me.gDoc.ReadOnly = True
        Me.gDoc.RowHeadersVisible = False
        Me.gDoc.RowHeadersWidth = 32
        Me.gDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gDoc.Size = New System.Drawing.Size(776, 426)
        Me.gDoc.TabIndex = 15
        '
        'DocTiersid
        '
        Me.DocTiersid.HeaderText = "DocTiersid"
        Me.DocTiersid.Name = "DocTiersid"
        Me.DocTiersid.Visible = False
        '
        'DocNom
        '
        Me.DocNom.HeaderText = "Nom Document"
        Me.DocNom.Name = "DocNom"
        '
        'DocRef
        '
        Me.DocRef.HeaderText = "Référence"
        Me.DocRef.Name = "DocRef"
        Me.DocRef.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'F_Doc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gDoc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "F_Doc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documents"
        CType(Me.gDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gDoc As DataGridView
    Friend WithEvents DocTiersid As DataGridViewTextBoxColumn
    Friend WithEvents DocNom As DataGridViewTextBoxColumn
    Friend WithEvents DocRef As DataGridViewTextBoxColumn
End Class
