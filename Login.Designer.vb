<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.lblAuthentification = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Location = New System.Drawing.Point(178, 166)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(290, 39)
        Me.txtUserName.TabIndex = 0
        Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Location = New System.Drawing.Point(178, 279)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(290, 39)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'lblAuthentification
        '
        Me.lblAuthentification.AutoSize = True
        Me.lblAuthentification.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAuthentification.Location = New System.Drawing.Point(128, 19)
        Me.lblAuthentification.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblAuthentification.Name = "lblAuthentification"
        Me.lblAuthentification.Size = New System.Drawing.Size(446, 72)
        Me.lblAuthentification.TabIndex = 2
        Me.lblAuthentification.Text = "Authentification"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(232, 117)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(199, 32)
        Me.lblUserName.TabIndex = 3
        Me.lblUserName.Text = "Nom d'utilisateur"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(245, 230)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(158, 32)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Mot de passe"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(178, 354)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(292, 49)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Entrer"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(178, 431)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(292, 49)
        Me.btnQuitter.TabIndex = 6
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 46)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 518)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblAuthentification)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtUserName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Authentification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents lblAuthentification As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents Button1 As Button
End Class
