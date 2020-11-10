<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Users
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
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cDroit = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lSite = New System.Windows.Forms.ComboBox()
        Me.lConfig = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(18, 152)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 25)
        Me.bAnnul.TabIndex = 5
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(194, 152)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 25)
        Me.bOK.TabIndex = 4
        Me.bOK.Text = "OK"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(91, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Tag = "UserLogin,t"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Code Config"
        '
        'tID
        '
        Me.tID.Enabled = False
        Me.tID.Location = New System.Drawing.Point(246, 4)
        Me.tID.Name = "tID"
        Me.tID.ReadOnly = True
        Me.tID.Size = New System.Drawing.Size(23, 20)
        Me.tID.TabIndex = 6
        Me.tID.Tag = "UserId,k"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Droit"
        '
        'cDroit
        '
        Me.cDroit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cDroit.FormattingEnabled = True
        Me.cDroit.Location = New System.Drawing.Point(91, 109)
        Me.cDroit.Name = "cDroit"
        Me.cDroit.Size = New System.Drawing.Size(178, 21)
        Me.cDroit.TabIndex = 3
        Me.cDroit.Tag = "Droit,n"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Site"
        '
        'lSite
        '
        Me.lSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lSite.FormattingEnabled = True
        Me.lSite.Location = New System.Drawing.Point(91, 56)
        Me.lSite.Name = "lSite"
        Me.lSite.Size = New System.Drawing.Size(178, 21)
        Me.lSite.TabIndex = 1
        Me.lSite.Tag = "sitecode,n"
        '
        'lConfig
        '
        Me.lConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lConfig.FormattingEnabled = True
        Me.lConfig.Location = New System.Drawing.Point(91, 82)
        Me.lConfig.Name = "lConfig"
        Me.lConfig.Size = New System.Drawing.Size(178, 21)
        Me.lConfig.TabIndex = 12
        Me.lConfig.Tag = "cfgid,n"
        '
        'F_Users
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(286, 198)
        Me.Controls.Add(Me.lConfig)
        Me.Controls.Add(Me.lSite)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cDroit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.bAnnul)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "F_Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Utilisateur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cDroit As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lSite As ComboBox
    Friend WithEvents lConfig As ComboBox
End Class
