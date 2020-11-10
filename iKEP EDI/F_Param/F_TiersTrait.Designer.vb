<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_TiersTrait
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
        Me.lSite = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tID = New System.Windows.Forms.TextBox()
        Me.tTypeTrait = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bOK = New System.Windows.Forms.Button()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.lCatTrait = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tETL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lSite
        '
        Me.lSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lSite.FormattingEnabled = True
        Me.lSite.Location = New System.Drawing.Point(118, 22)
        Me.lSite.Name = "lSite"
        Me.lSite.Size = New System.Drawing.Size(178, 21)
        Me.lSite.TabIndex = 13
        Me.lSite.Tag = "TiersId,n"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Tiers"
        '
        'tID
        '
        Me.tID.Enabled = False
        Me.tID.Location = New System.Drawing.Point(149, 148)
        Me.tID.Name = "tID"
        Me.tID.ReadOnly = True
        Me.tID.Size = New System.Drawing.Size(23, 20)
        Me.tID.TabIndex = 15
        Me.tID.Tag = "TiersTraitId,k"
        '
        'tTypeTrait
        '
        Me.tTypeTrait.Location = New System.Drawing.Point(118, 76)
        Me.tTypeTrait.Name = "tTypeTrait"
        Me.tTypeTrait.Size = New System.Drawing.Size(178, 20)
        Me.tTypeTrait.TabIndex = 12
        Me.tTypeTrait.Tag = "TypeTraitement,t"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Type Traitement"
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(221, 145)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 25)
        Me.bOK.TabIndex = 17
        Me.bOK.Text = "OK"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(23, 145)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 25)
        Me.bAnnul.TabIndex = 18
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'lCatTrait
        '
        Me.lCatTrait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lCatTrait.FormattingEnabled = True
        Me.lCatTrait.Location = New System.Drawing.Point(118, 49)
        Me.lCatTrait.Name = "lCatTrait"
        Me.lCatTrait.Size = New System.Drawing.Size(178, 21)
        Me.lCatTrait.TabIndex = 19
        Me.lCatTrait.Tag = "CatTraitId,n"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Cat. Traitement"
        '
        'tETL
        '
        Me.tETL.Location = New System.Drawing.Point(118, 102)
        Me.tETL.Name = "tETL"
        Me.tETL.Size = New System.Drawing.Size(178, 20)
        Me.tETL.TabIndex = 21
        Me.tETL.Tag = "ETL,t"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "ETL"
        '
        'F_TiersTrait
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(329, 192)
        Me.Controls.Add(Me.tETL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lCatTrait)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.lSite)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tID)
        Me.Controls.Add(Me.tTypeTrait)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "F_TiersTrait"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traitement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lSite As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tID As TextBox
    Friend WithEvents tTypeTrait As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bOK As Button
    Friend WithEvents bAnnul As Button
    Friend WithEvents lCatTrait As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tETL As TextBox
    Friend WithEvents Label3 As Label
End Class
