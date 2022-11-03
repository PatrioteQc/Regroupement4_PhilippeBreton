<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.dgvClient = New System.Windows.Forms.DataGridView()
        Me.dgvClientPrenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvClientNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvClientCourriel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbListeClient = New System.Windows.Forms.Label()
        Me.btnCreer = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.dgvFilms = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblListeFilms = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        CType(Me.dgvClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFilms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(1902, 623)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(193, 43)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Se déconnecter"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'dgvClient
        '
        Me.dgvClient.AllowUserToAddRows = False
        Me.dgvClient.AllowUserToDeleteRows = False
        Me.dgvClient.AllowUserToResizeColumns = False
        Me.dgvClient.AllowUserToResizeRows = False
        Me.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvClientPrenom, Me.dgvClientNom, Me.dgvClientCourriel})
        Me.dgvClient.Location = New System.Drawing.Point(15, 68)
        Me.dgvClient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvClient.MultiSelect = False
        Me.dgvClient.Name = "dgvClient"
        Me.dgvClient.ReadOnly = True
        Me.dgvClient.RowHeadersVisible = False
        Me.dgvClient.RowHeadersWidth = 62
        Me.dgvClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvClient.RowTemplate.Height = 33
        Me.dgvClient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClient.Size = New System.Drawing.Size(1122, 489)
        Me.dgvClient.TabIndex = 1
        '
        'dgvClientPrenom
        '
        Me.dgvClientPrenom.DataPropertyName = "prenom"
        Me.dgvClientPrenom.HeaderText = "Prénom"
        Me.dgvClientPrenom.MinimumWidth = 8
        Me.dgvClientPrenom.Name = "dgvClientPrenom"
        Me.dgvClientPrenom.ReadOnly = True
        Me.dgvClientPrenom.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientPrenom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvClientPrenom.Width = 150
        '
        'dgvClientNom
        '
        Me.dgvClientNom.DataPropertyName = "nom"
        Me.dgvClientNom.HeaderText = "Nom"
        Me.dgvClientNom.MinimumWidth = 8
        Me.dgvClientNom.Name = "dgvClientNom"
        Me.dgvClientNom.ReadOnly = True
        Me.dgvClientNom.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientNom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvClientNom.Width = 150
        '
        'dgvClientCourriel
        '
        Me.dgvClientCourriel.DataPropertyName = "courriel"
        Me.dgvClientCourriel.HeaderText = "Courriel"
        Me.dgvClientCourriel.MinimumWidth = 8
        Me.dgvClientCourriel.Name = "dgvClientCourriel"
        Me.dgvClientCourriel.ReadOnly = True
        Me.dgvClientCourriel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientCourriel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvClientCourriel.Width = 300
        '
        'lbListeClient
        '
        Me.lbListeClient.AutoSize = True
        Me.lbListeClient.Location = New System.Drawing.Point(15, 19)
        Me.lbListeClient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbListeClient.Name = "lbListeClient"
        Me.lbListeClient.Size = New System.Drawing.Size(181, 32)
        Me.lbListeClient.TabIndex = 2
        Me.lbListeClient.Text = "Liste des clients"
        '
        'btnCreer
        '
        Me.btnCreer.Location = New System.Drawing.Point(15, 572)
        Me.btnCreer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCreer.Name = "btnCreer"
        Me.btnCreer.Size = New System.Drawing.Size(193, 94)
        Me.btnCreer.TabIndex = 3
        Me.btnCreer.Text = "Créer"
        Me.btnCreer.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Location = New System.Drawing.Point(215, 572)
        Me.btnModifier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(193, 94)
        Me.btnModifier.TabIndex = 4
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnSupprimer
        '
        Me.btnSupprimer.Location = New System.Drawing.Point(416, 572)
        Me.btnSupprimer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(193, 94)
        Me.btnSupprimer.TabIndex = 5
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'dgvFilms
        '
        Me.dgvFilms.AllowUserToAddRows = False
        Me.dgvFilms.AllowUserToDeleteRows = False
        Me.dgvFilms.AllowUserToResizeColumns = False
        Me.dgvFilms.AllowUserToResizeRows = False
        Me.dgvFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFilms.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgvFilms.Location = New System.Drawing.Point(1174, 68)
        Me.dgvFilms.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvFilms.MultiSelect = False
        Me.dgvFilms.Name = "dgvFilms"
        Me.dgvFilms.ReadOnly = True
        Me.dgvFilms.RowHeadersVisible = False
        Me.dgvFilms.RowHeadersWidth = 62
        Me.dgvFilms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvFilms.RowTemplate.Height = 33
        Me.dgvFilms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvFilms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFilms.Size = New System.Drawing.Size(1122, 489)
        Me.dgvFilms.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nom"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "duree"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Durée"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "categorie"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Catégorie(s)"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 325
        '
        'lblListeFilms
        '
        Me.lblListeFilms.AutoSize = True
        Me.lblListeFilms.Location = New System.Drawing.Point(1174, 19)
        Me.lblListeFilms.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblListeFilms.Name = "lblListeFilms"
        Me.lblListeFilms.Size = New System.Drawing.Size(164, 32)
        Me.lblListeFilms.TabIndex = 7
        Me.lblListeFilms.Text = "Liste des films"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(2102, 623)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(193, 43)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "Quitter"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2316, 689)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblListeFilms)
        Me.Controls.Add(Me.dgvFilms)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnCreer)
        Me.Controls.Add(Me.lbListeClient)
        Me.Controls.Add(Me.dgvClient)
        Me.Controls.Add(Me.btnLogout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "Video Gestion"
        CType(Me.dgvClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFilms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents dgvClient As DataGridView
    Friend WithEvents lbListeClient As Label
    Friend WithEvents btnCreer As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents dgvFilms As DataGridView
    Friend WithEvents lblListeFilms As Label
    Friend WithEvents dgvClientPrenom As DataGridViewTextBoxColumn
    Friend WithEvents dgvClientNom As DataGridViewTextBoxColumn
    Friend WithEvents dgvClientCourriel As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents btnQuit As Button
End Class
