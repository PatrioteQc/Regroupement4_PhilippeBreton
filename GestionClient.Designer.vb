<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionClient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblCourriel = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblSexe = New System.Windows.Forms.Label()
        Me.dropSexe = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Location = New System.Drawing.Point(12, 79)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(157, 23)
        Me.txtUserName.TabIndex = 0
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Location = New System.Drawing.Point(12, 132)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(157, 23)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitre.Location = New System.Drawing.Point(12, 9)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(148, 30)
        Me.lblTitre.TabIndex = 2
        Me.lblTitre.Text = "Gestion client"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourriel
        '
        Me.lblCourriel.AutoSize = True
        Me.lblCourriel.Location = New System.Drawing.Point(12, 58)
        Me.lblCourriel.Name = "lblCourriel"
        Me.lblCourriel.Size = New System.Drawing.Size(49, 15)
        Me.lblCourriel.TabIndex = 3
        Me.lblCourriel.Text = "Courriel"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 111)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(77, 15)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Mot de passe"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(185, 223)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(157, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Sauvegarder"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 223)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(157, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(185, 58)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(49, 15)
        Me.lblPrenom.TabIndex = 8
        Me.lblPrenom.Text = "Prénom"
        '
        'txtPrenom
        '
        Me.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrenom.Location = New System.Drawing.Point(185, 79)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(157, 23)
        Me.txtPrenom.TabIndex = 2
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(185, 111)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(34, 15)
        Me.lblNom.TabIndex = 10
        Me.lblNom.Text = "Nom"
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNom.Location = New System.Drawing.Point(185, 132)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(157, 23)
        Me.txtNom.TabIndex = 3
        '
        'lblSexe
        '
        Me.lblSexe.AutoSize = True
        Me.lblSexe.Location = New System.Drawing.Point(12, 169)
        Me.lblSexe.Name = "lblSexe"
        Me.lblSexe.Size = New System.Drawing.Size(31, 15)
        Me.lblSexe.TabIndex = 11
        Me.lblSexe.Text = "Sexe"
        '
        'dropSexe
        '
        Me.dropSexe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dropSexe.Items.AddRange(New Object() {"Homme", "Femme"})
        Me.dropSexe.Location = New System.Drawing.Point(12, 190)
        Me.dropSexe.MaxDropDownItems = 2
        Me.dropSexe.Name = "dropSexe"
        Me.dropSexe.Size = New System.Drawing.Size(157, 23)
        Me.dropSexe.TabIndex = 4
        '
        'GestionClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 258)
        Me.Controls.Add(Me.dropSexe)
        Me.Controls.Add(Me.lblSexe)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblCourriel)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtUserName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MaximizeBox = False
        Me.Name = "GestionClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Authentification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents lblTitre As Label
    Friend WithEvents lblCourriel As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblPrenom As Label
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents lblNom As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents lblSexe As Label
    Friend WithEvents dropSexe As ComboBox
End Class
