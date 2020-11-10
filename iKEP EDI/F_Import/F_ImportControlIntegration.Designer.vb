<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ImportControlIntegration
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_ImportControlIntegration))
        Me.gControle = New System.Windows.Forms.DataGridView()
        Me.Demande = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Statut = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Client_Trs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtCode_Trs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Trs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeBesoin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cde_Trs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumLigne_Trs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QteBesoin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtCode_ERP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_ERP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeCde_ERP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumCde_ERP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumLigneCde_ERP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QteCde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.optionAno = New System.Windows.Forms.CheckBox()
        Me.optionOK = New System.Windows.Forms.CheckBox()
        Me.iML = New System.Windows.Forms.ImageList(Me.components)
        Me.gArticle = New System.Windows.Forms.DataGridView()
        Me.ArtTrsf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bAfficher = New System.Windows.Forms.Button()
        Me.tArticle = New System.Windows.Forms.Label()
        CType(Me.gControle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gArticle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.gControle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Demande, Me.Statut, Me.Client_Trs, Me.ArtCode_Trs, Me.Date_Trs, Me.TypeBesoin, Me.cde_Trs, Me.NumLigne_Trs, Me.QteBesoin, Me.CodeClient, Me.ArtCode_ERP, Me.Date_ERP, Me.TypeCde_ERP, Me.NumCde_ERP, Me.NumLigneCde_ERP, Me.QteCde})
        Me.gControle.Location = New System.Drawing.Point(172, 67)
        Me.gControle.Name = "gControle"
        Me.gControle.RowHeadersVisible = False
        Me.gControle.Size = New System.Drawing.Size(1170, 507)
        Me.gControle.TabIndex = 2
        '
        'Demande
        '
        Me.Demande.FillWeight = 25.0!
        Me.Demande.HeaderText = "Demande"
        Me.Demande.Name = "Demande"
        Me.Demande.ReadOnly = True
        '
        'Statut
        '
        Me.Statut.FillWeight = 10.0!
        Me.Statut.HeaderText = "St."
        Me.Statut.Name = "Statut"
        Me.Statut.ReadOnly = True
        Me.Statut.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Statut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Client_Trs
        '
        Me.Client_Trs.FillWeight = 30.0!
        Me.Client_Trs.HeaderText = "Client EDI"
        Me.Client_Trs.Name = "Client_Trs"
        '
        'ArtCode_Trs
        '
        Me.ArtCode_Trs.FillWeight = 40.0!
        Me.ArtCode_Trs.HeaderText = "Article EDI"
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
        Me.Date_Trs.HeaderText = "Date EDI"
        Me.Date_Trs.Name = "Date_Trs"
        Me.Date_Trs.ReadOnly = True
        Me.Date_Trs.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Date_Trs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TypeBesoin
        '
        Me.TypeBesoin.FillWeight = 15.0!
        Me.TypeBesoin.HeaderText = "Type Cde EDI"
        Me.TypeBesoin.Name = "TypeBesoin"
        Me.TypeBesoin.ReadOnly = True
        Me.TypeBesoin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cde_Trs
        '
        Me.cde_Trs.FillWeight = 40.0!
        Me.cde_Trs.HeaderText = "N°Cde"
        Me.cde_Trs.Name = "cde_Trs"
        '
        'NumLigne_Trs
        '
        Me.NumLigne_Trs.FillWeight = 20.0!
        Me.NumLigne_Trs.HeaderText = "N°Ligne EDI"
        Me.NumLigne_Trs.Name = "NumLigne_Trs"
        '
        'QteBesoin
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.QteBesoin.DefaultCellStyle = DataGridViewCellStyle2
        Me.QteBesoin.FillWeight = 30.0!
        Me.QteBesoin.HeaderText = "Qté EDI"
        Me.QteBesoin.Name = "QteBesoin"
        Me.QteBesoin.ReadOnly = True
        Me.QteBesoin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CodeClient
        '
        Me.CodeClient.FillWeight = 30.0!
        Me.CodeClient.HeaderText = "Client ERP"
        Me.CodeClient.Name = "CodeClient"
        Me.CodeClient.ReadOnly = True
        Me.CodeClient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ArtCode_ERP
        '
        Me.ArtCode_ERP.FillWeight = 40.0!
        Me.ArtCode_ERP.HeaderText = "Article ERP"
        Me.ArtCode_ERP.Name = "ArtCode_ERP"
        Me.ArtCode_ERP.ReadOnly = True
        Me.ArtCode_ERP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Date_ERP
        '
        Me.Date_ERP.FillWeight = 30.0!
        Me.Date_ERP.HeaderText = "Date ERP"
        Me.Date_ERP.Name = "Date_ERP"
        '
        'TypeCde_ERP
        '
        Me.TypeCde_ERP.FillWeight = 15.0!
        Me.TypeCde_ERP.HeaderText = "Type Cde ERP"
        Me.TypeCde_ERP.Name = "TypeCde_ERP"
        Me.TypeCde_ERP.ReadOnly = True
        Me.TypeCde_ERP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'QteCde
        '
        DataGridViewCellStyle3.Format = "N2"
        Me.QteCde.DefaultCellStyle = DataGridViewCellStyle3
        Me.QteCde.FillWeight = 30.0!
        Me.QteCde.HeaderText = "Qté Cde"
        Me.QteCde.Name = "QteCde"
        Me.QteCde.ReadOnly = True
        Me.QteCde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'optionAno
        '
        Me.optionAno.AutoSize = True
        Me.optionAno.Checked = True
        Me.optionAno.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optionAno.Location = New System.Drawing.Point(253, 44)
        Me.optionAno.Name = "optionAno"
        Me.optionAno.Size = New System.Drawing.Size(99, 17)
        Me.optionAno.TabIndex = 53
        Me.optionAno.Text = "Lignes en écart"
        Me.optionAno.UseVisualStyleBackColor = True
        '
        'optionOK
        '
        Me.optionOK.AutoSize = True
        Me.optionOK.Checked = True
        Me.optionOK.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optionOK.Location = New System.Drawing.Point(172, 44)
        Me.optionOK.Name = "optionOK"
        Me.optionOK.Size = New System.Drawing.Size(75, 17)
        Me.optionOK.TabIndex = 52
        Me.optionOK.Text = "Lignes OK"
        Me.optionOK.UseVisualStyleBackColor = True
        '
        'iML
        '
        Me.iML.ImageStream = CType(resources.GetObject("iML.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iML.TransparentColor = System.Drawing.Color.Transparent
        Me.iML.Images.SetKeyName(0, "LigneOK.fw.png")
        Me.iML.Images.SetKeyName(1, "LigneNOK.fw.png")
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
        Me.gArticle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ArtTrsf})
        Me.gArticle.Location = New System.Drawing.Point(12, 17)
        Me.gArticle.Name = "gArticle"
        Me.gArticle.ReadOnly = True
        Me.gArticle.RowHeadersVisible = False
        Me.gArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gArticle.Size = New System.Drawing.Size(150, 557)
        Me.gArticle.TabIndex = 55
        '
        'ArtTrsf
        '
        Me.ArtTrsf.HeaderText = "Article"
        Me.ArtTrsf.Name = "ArtTrsf"
        Me.ArtTrsf.ReadOnly = True
        '
        'bAfficher
        '
        Me.bAfficher.Image = Global.WindowsApplication1.My.Resources.Resources.filtre_fw
        Me.bAfficher.Location = New System.Drawing.Point(408, 12)
        Me.bAfficher.Name = "bAfficher"
        Me.bAfficher.Size = New System.Drawing.Size(111, 49)
        Me.bAfficher.TabIndex = 54
        Me.bAfficher.Text = "Filtrer"
        Me.bAfficher.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.bAfficher.UseVisualStyleBackColor = True
        '
        'tArticle
        '
        Me.tArticle.AutoSize = True
        Me.tArticle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tArticle.ForeColor = System.Drawing.Color.Maroon
        Me.tArticle.Location = New System.Drawing.Point(168, 17)
        Me.tArticle.Name = "tArticle"
        Me.tArticle.Size = New System.Drawing.Size(145, 24)
        Me.tArticle.TabIndex = 56
        Me.tArticle.Text = "Tous les articles"
        '
        'F_ImportControlIntegration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 582)
        Me.Controls.Add(Me.tArticle)
        Me.Controls.Add(Me.gArticle)
        Me.Controls.Add(Me.bAfficher)
        Me.Controls.Add(Me.optionAno)
        Me.Controls.Add(Me.optionOK)
        Me.Controls.Add(Me.gControle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "F_ImportControlIntegration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Contrôle Intégration"
        CType(Me.gControle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gArticle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gControle As DataGridView
    Friend WithEvents optionAno As CheckBox
    Friend WithEvents optionOK As CheckBox
    Friend WithEvents bAfficher As Button
    Friend WithEvents iML As ImageList
    Friend WithEvents Demande As DataGridViewTextBoxColumn
    Friend WithEvents Statut As DataGridViewImageColumn
    Friend WithEvents Client_Trs As DataGridViewTextBoxColumn
    Friend WithEvents ArtCode_Trs As DataGridViewTextBoxColumn
    Friend WithEvents Date_Trs As DataGridViewTextBoxColumn
    Friend WithEvents TypeBesoin As DataGridViewTextBoxColumn
    Friend WithEvents cde_Trs As DataGridViewTextBoxColumn
    Friend WithEvents NumLigne_Trs As DataGridViewTextBoxColumn
    Friend WithEvents QteBesoin As DataGridViewTextBoxColumn
    Friend WithEvents CodeClient As DataGridViewTextBoxColumn
    Friend WithEvents ArtCode_ERP As DataGridViewTextBoxColumn
    Friend WithEvents Date_ERP As DataGridViewTextBoxColumn
    Friend WithEvents TypeCde_ERP As DataGridViewTextBoxColumn
    Friend WithEvents NumCde_ERP As DataGridViewTextBoxColumn
    Friend WithEvents NumLigneCde_ERP As DataGridViewTextBoxColumn
    Friend WithEvents QteCde As DataGridViewTextBoxColumn
    Friend WithEvents gArticle As DataGridView
    Friend WithEvents ArtTrsf As DataGridViewTextBoxColumn
    Friend WithEvents tArticle As Label
End Class
