<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Afferme
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tClient = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tHorizon = New System.Windows.Forms.TextBox()
        Me.gAfferme = New System.Windows.Forms.DataGridView()
        Me.Client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NumCde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumLigne = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Article = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QteCde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSel = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bAfficher = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tArticle = New System.Windows.Forms.TextBox()
        CType(Me.gAfferme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tClient
        '
        Me.tClient.Location = New System.Drawing.Point(210, 12)
        Me.tClient.Name = "tClient"
        Me.tClient.Size = New System.Drawing.Size(113, 20)
        Me.tClient.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Mois"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Horizon"
        '
        'tHorizon
        '
        Me.tHorizon.Location = New System.Drawing.Point(60, 12)
        Me.tHorizon.Name = "tHorizon"
        Me.tHorizon.Size = New System.Drawing.Size(36, 20)
        Me.tHorizon.TabIndex = 0
        Me.tHorizon.Text = "3"
        Me.tHorizon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gAfferme
        '
        Me.gAfferme.AllowUserToAddRows = False
        Me.gAfferme.AllowUserToDeleteRows = False
        Me.gAfferme.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gAfferme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gAfferme.BackgroundColor = System.Drawing.SystemColors.Control
        Me.gAfferme.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gAfferme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gAfferme.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Client, Me.Sel, Me.NumCde, Me.NumLigne, Me.DateCde, Me.Article, Me.QteCde, Me.CodeClient})
        Me.gAfferme.Location = New System.Drawing.Point(12, 64)
        Me.gAfferme.MultiSelect = False
        Me.gAfferme.Name = "gAfferme"
        Me.gAfferme.RowHeadersVisible = False
        Me.gAfferme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gAfferme.Size = New System.Drawing.Size(975, 462)
        Me.gAfferme.TabIndex = 33
        '
        'Client
        '
        Me.Client.HeaderText = "Client"
        Me.Client.Name = "Client"
        Me.Client.ReadOnly = True
        '
        'Sel
        '
        Me.Sel.FillWeight = 15.0!
        Me.Sel.HeaderText = "Sel"
        Me.Sel.Name = "Sel"
        Me.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'NumCde
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NumCde.DefaultCellStyle = DataGridViewCellStyle1
        Me.NumCde.FillWeight = 30.0!
        Me.NumCde.HeaderText = "N°Cde"
        Me.NumCde.Name = "NumCde"
        Me.NumCde.ReadOnly = True
        '
        'NumLigne
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NumLigne.DefaultCellStyle = DataGridViewCellStyle2
        Me.NumLigne.FillWeight = 15.0!
        Me.NumLigne.HeaderText = "Ligne"
        Me.NumLigne.Name = "NumLigne"
        Me.NumLigne.ReadOnly = True
        Me.NumLigne.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DateCde
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DateCde.DefaultCellStyle = DataGridViewCellStyle3
        Me.DateCde.FillWeight = 30.0!
        Me.DateCde.HeaderText = "Date Mini"
        Me.DateCde.Name = "DateCde"
        Me.DateCde.ReadOnly = True
        Me.DateCde.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Article
        '
        Me.Article.FillWeight = 80.0!
        Me.Article.HeaderText = "Article"
        Me.Article.Name = "Article"
        Me.Article.ReadOnly = True
        '
        'QteCde
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.QteCde.DefaultCellStyle = DataGridViewCellStyle4
        Me.QteCde.FillWeight = 30.0!
        Me.QteCde.HeaderText = "Qté Totale"
        Me.QteCde.Name = "QteCde"
        Me.QteCde.ReadOnly = True
        '
        'CodeClient
        '
        Me.CodeClient.HeaderText = "CodeClient"
        Me.CodeClient.Name = "CodeClient"
        Me.CodeClient.Visible = False
        '
        'cSel
        '
        Me.cSel.AutoSize = True
        Me.cSel.Location = New System.Drawing.Point(13, 41)
        Me.cSel.Name = "cSel"
        Me.cSel.Size = New System.Drawing.Size(48, 17)
        Me.cSel.TabIndex = 4
        Me.cSel.Text = "Tout"
        Me.cSel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Client"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.bAfferme_fw
        Me.Button1.Location = New System.Drawing.Point(863, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 42)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Prév > Ferme"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bAfficher
        '
        Me.bAfficher.Image = Global.WindowsApplication1.My.Resources.Resources.filtre_fw
        Me.bAfficher.Location = New System.Drawing.Point(352, 12)
        Me.bAfficher.Name = "bAfficher"
        Me.bAfficher.Size = New System.Drawing.Size(134, 42)
        Me.bAfficher.TabIndex = 3
        Me.bAfficher.Text = "Filtrer"
        Me.bAfficher.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.bAfficher.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Article"
        '
        'tArticle
        '
        Me.tArticle.Location = New System.Drawing.Point(210, 34)
        Me.tArticle.Name = "tArticle"
        Me.tArticle.Size = New System.Drawing.Size(113, 20)
        Me.tArticle.TabIndex = 2
        '
        'F_Afferme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 538)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tArticle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cSel)
        Me.Controls.Add(Me.tClient)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tHorizon)
        Me.Controls.Add(Me.bAfficher)
        Me.Controls.Add(Me.gAfferme)
        Me.Name = "F_Afferme"
        Me.Text = "SIlog - Commandes Prévisionnelles"
        CType(Me.gAfferme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tClient As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tHorizon As TextBox
    Friend WithEvents bAfficher As Button
    Friend WithEvents gAfferme As DataGridView
    Friend WithEvents cSel As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Client As DataGridViewTextBoxColumn
    Friend WithEvents Sel As DataGridViewCheckBoxColumn
    Friend WithEvents NumCde As DataGridViewTextBoxColumn
    Friend WithEvents NumLigne As DataGridViewTextBoxColumn
    Friend WithEvents DateCde As DataGridViewTextBoxColumn
    Friend WithEvents Article As DataGridViewTextBoxColumn
    Friend WithEvents QteCde As DataGridViewTextBoxColumn
    Friend WithEvents CodeClient As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents tArticle As TextBox
End Class
