<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_UsersListe
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
        Me.gUser = New System.Windows.Forms.DataGridView()
        Me.UserId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserLogin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiersPLus = New System.Windows.Forms.Button()
        Me.TiersMoins = New System.Windows.Forms.Button()
        CType(Me.gUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gUser
        '
        Me.gUser.AllowUserToAddRows = False
        Me.gUser.AllowUserToDeleteRows = False
        Me.gUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gUser.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gUser.ColumnHeadersHeight = 24
        Me.gUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserId, Me.UserLogin})
        Me.gUser.Location = New System.Drawing.Point(12, 12)
        Me.gUser.MultiSelect = False
        Me.gUser.Name = "gUser"
        Me.gUser.ReadOnly = True
        Me.gUser.RowHeadersVisible = False
        Me.gUser.RowHeadersWidth = 28
        Me.gUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gUser.Size = New System.Drawing.Size(226, 421)
        Me.gUser.TabIndex = 3
        '
        'UserId
        '
        Me.UserId.FillWeight = 60.0!
        Me.UserId.HeaderText = "Id"
        Me.UserId.Name = "UserId"
        Me.UserId.ReadOnly = True
        Me.UserId.Visible = False
        '
        'UserLogin
        '
        Me.UserLogin.HeaderText = "Login"
        Me.UserLogin.Name = "UserLogin"
        Me.UserLogin.ReadOnly = True
        '
        'TiersPLus
        '
        Me.TiersPLus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TiersPLus.Location = New System.Drawing.Point(244, 12)
        Me.TiersPLus.Name = "TiersPLus"
        Me.TiersPLus.Size = New System.Drawing.Size(32, 32)
        Me.TiersPLus.TabIndex = 5
        Me.TiersPLus.Text = "+"
        Me.TiersPLus.UseVisualStyleBackColor = True
        '
        'TiersMoins
        '
        Me.TiersMoins.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TiersMoins.Location = New System.Drawing.Point(244, 50)
        Me.TiersMoins.Name = "TiersMoins"
        Me.TiersMoins.Size = New System.Drawing.Size(32, 32)
        Me.TiersMoins.TabIndex = 6
        Me.TiersMoins.Text = "-"
        Me.TiersMoins.UseVisualStyleBackColor = True
        '
        'F_UsersListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 445)
        Me.Controls.Add(Me.TiersMoins)
        Me.Controls.Add(Me.TiersPLus)
        Me.Controls.Add(Me.gUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "F_UsersListe"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste Utilisateurs"
        CType(Me.gUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gUser As System.Windows.Forms.DataGridView
    Friend WithEvents TiersPLus As System.Windows.Forms.Button
    Friend WithEvents TiersMoins As System.Windows.Forms.Button
    Friend WithEvents UserId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserLogin As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
