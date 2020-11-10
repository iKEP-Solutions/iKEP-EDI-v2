<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Param
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
        Me.pGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.bOK = New System.Windows.Forms.Button()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bTestCon = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pGrid1
        '
        Me.pGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pGrid1.HelpVisible = False
        Me.pGrid1.Location = New System.Drawing.Point(12, 12)
        Me.pGrid1.Name = "pGrid1"
        Me.pGrid1.Size = New System.Drawing.Size(612, 183)
        Me.pGrid1.TabIndex = 1
        Me.pGrid1.ToolbarVisible = False
        '
        'bOK
        '
        Me.bOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bOK.Location = New System.Drawing.Point(549, 214)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 33)
        Me.bOK.TabIndex = 2
        Me.bOK.Text = "OK"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'bAnnul
        '
        Me.bAnnul.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(12, 214)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 33)
        Me.bAnnul.TabIndex = 2
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bTestCon
        '
        Me.bTestCon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bTestCon.Location = New System.Drawing.Point(441, 214)
        Me.bTestCon.Name = "bTestCon"
        Me.bTestCon.Size = New System.Drawing.Size(102, 33)
        Me.bTestCon.TabIndex = 3
        Me.bTestCon.Text = "Test connection"
        Me.bTestCon.UseVisualStyleBackColor = True
        '
        'F_Param
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(636, 259)
        Me.Controls.Add(Me.bTestCon)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.pGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "F_Param"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paramètres"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bTestCon As System.Windows.Forms.Button
End Class
