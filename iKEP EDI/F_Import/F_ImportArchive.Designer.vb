<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ImportArchive
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_ImportArchive))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tArticle = New System.Windows.Forms.Label()
        Me.gArticle = New System.Windows.Forms.DataGridView()
        Me.ArtERP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTrsf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iML = New System.Windows.Forms.ImageList(Me.components)
        Me.gControle = New System.Windows.Forms.DataGridView()
        Me.Client_Trs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumCOntrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtCode_Trs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Trs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeBesoin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QteBesoin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cde_Trs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumLigne_Trs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUmLigneProp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cImport = New System.Windows.Forms.ComboBox()
        CType(Me.gArticle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tArticle
        '
        Me.tArticle.AutoSize = True
        Me.tArticle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tArticle.ForeColor = System.Drawing.Color.Maroon
        Me.tArticle.Location = New System.Drawing.Point(326, 13)
        Me.tArticle.Name = "tArticle"
        Me.tArticle.Size = New System.Drawing.Size(145, 24)
        Me.tArticle.TabIndex = 62
        Me.tArticle.Text = "Tous les articles"
        '
        'gArticle
        '
        Me.gArticle.AllowUserToAddRows = False
        Me.gArticle.AllowUserToDeleteRows = False
        Me.gArticle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gArticle.BackgroundColor = System.Drawing.Color.White
        Me.gArticle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gArticle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ArtERP, Me.DateTrsf})
        Me.gArticle.Location = New System.Drawing.Point(20, 40)
        Me.gArticle.Name = "gArticle"
        Me.gArticle.ReadOnly = True
        Me.gArticle.RowHeadersVisible = False
        Me.gArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gArticle.Size = New System.Drawing.Size(285, 556)
        Me.gArticle.TabIndex = 61
        '
        'ArtERP
        '
        Me.ArtERP.HeaderText = "Article"
        Me.ArtERP.Name = "ArtERP"
        Me.ArtERP.ReadOnly = True
        '
        'DateTrsf
        '
        Me.DateTrsf.HeaderText = "Date Envoi"
        Me.DateTrsf.Name = "DateTrsf"
        Me.DateTrsf.ReadOnly = True
        '
        'iML
        '
        Me.iML.ImageStream = CType(resources.GetObject("iML.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iML.TransparentColor = System.Drawing.Color.Transparent
        Me.iML.Images.SetKeyName(0, "LigneOK.fw.png")
        Me.iML.Images.SetKeyName(1, "LigneNOK.fw.png")
        '
        'gControle
        '
        Me.gControle.AllowUserToAddRows = False
        Me.gControle.AllowUserToDeleteRows = False
        Me.gControle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gControle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gControle.BackgroundColor = System.Drawing.SystemColors.Control
        Me.gControle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gControle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gControle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Client_Trs, Me.NumCOntrat, Me.ArtCode_Trs, Me.Date_Trs, Me.TypeBesoin, Me.QteBesoin, Me.cde_Trs, Me.NumLigne_Trs, Me.NUmLigneProp})
        Me.gControle.Location = New System.Drawing.Point(330, 40)
        Me.gControle.Name = "gControle"
        Me.gControle.RowHeadersVisible = False
        Me.gControle.Size = New System.Drawing.Size(939, 556)
        Me.gControle.TabIndex = 57
        '
        'Client_Trs
        '
        Me.Client_Trs.FillWeight = 30.0!
        Me.Client_Trs.HeaderText = "Client"
        Me.Client_Trs.Name = "Client_Trs"
        '
        'NumCOntrat
        '
        Me.NumCOntrat.FillWeight = 30.0!
        Me.NumCOntrat.HeaderText = "Contrat"
        Me.NumCOntrat.Name = "NumCOntrat"
        '
        'ArtCode_Trs
        '
        Me.ArtCode_Trs.FillWeight = 40.0!
        Me.ArtCode_Trs.HeaderText = "Article"
        Me.ArtCode_Trs.Name = "ArtCode_Trs"
        Me.ArtCode_Trs.ReadOnly = True
        Me.ArtCode_Trs.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ArtCode_Trs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Date_Trs
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Date_Trs.DefaultCellStyle = DataGridViewCellStyle1
        Me.Date_Trs.FillWeight = 30.0!
        Me.Date_Trs.HeaderText = "Date"
        Me.Date_Trs.Name = "Date_Trs"
        Me.Date_Trs.ReadOnly = True
        Me.Date_Trs.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Date_Trs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TypeBesoin
        '
        Me.TypeBesoin.FillWeight = 15.0!
        Me.TypeBesoin.HeaderText = "Type Besoin"
        Me.TypeBesoin.Name = "TypeBesoin"
        Me.TypeBesoin.ReadOnly = True
        Me.TypeBesoin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'QteBesoin
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.QteBesoin.DefaultCellStyle = DataGridViewCellStyle2
        Me.QteBesoin.FillWeight = 30.0!
        Me.QteBesoin.HeaderText = "Qté Besoin"
        Me.QteBesoin.Name = "QteBesoin"
        Me.QteBesoin.ReadOnly = True
        Me.QteBesoin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cde_Trs
        '
        Me.cde_Trs.FillWeight = 40.0!
        Me.cde_Trs.HeaderText = "N°Cde ERP"
        Me.cde_Trs.Name = "cde_Trs"
        '
        'NumLigne_Trs
        '
        Me.NumLigne_Trs.FillWeight = 20.0!
        Me.NumLigne_Trs.HeaderText = "N°Ligne ERP"
        Me.NumLigne_Trs.Name = "NumLigne_Trs"
        '
        'NUmLigneProp
        '
        Me.NUmLigneProp.FillWeight = 20.0!
        Me.NUmLigneProp.HeaderText = "N°Ligne Prop"
        Me.NUmLigneProp.Name = "NUmLigneProp"
        '
        'cImport
        '
        Me.cImport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cImport.FormattingEnabled = True
        Me.cImport.Location = New System.Drawing.Point(20, 13)
        Me.cImport.Name = "cImport"
        Me.cImport.Size = New System.Drawing.Size(285, 21)
        Me.cImport.TabIndex = 63
        '
        'F_ImportArchive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 608)
        Me.Controls.Add(Me.cImport)
        Me.Controls.Add(Me.tArticle)
        Me.Controls.Add(Me.gArticle)
        Me.Controls.Add(Me.gControle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "F_ImportArchive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Archives Imports"
        CType(Me.gArticle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tArticle As Label
    Friend WithEvents gArticle As DataGridView
    Friend WithEvents iML As ImageList
    Friend WithEvents gControle As DataGridView
    Friend WithEvents cImport As ComboBox
    Friend WithEvents Client_Trs As DataGridViewTextBoxColumn
    Friend WithEvents NumCOntrat As DataGridViewTextBoxColumn
    Friend WithEvents ArtCode_Trs As DataGridViewTextBoxColumn
    Friend WithEvents Date_Trs As DataGridViewTextBoxColumn
    Friend WithEvents TypeBesoin As DataGridViewTextBoxColumn
    Friend WithEvents QteBesoin As DataGridViewTextBoxColumn
    Friend WithEvents cde_Trs As DataGridViewTextBoxColumn
    Friend WithEvents NumLigne_Trs As DataGridViewTextBoxColumn
    Friend WithEvents NUmLigneProp As DataGridViewTextBoxColumn
    Friend WithEvents ArtERP As DataGridViewTextBoxColumn
    Friend WithEvents DateTrsf As DataGridViewTextBoxColumn
End Class
