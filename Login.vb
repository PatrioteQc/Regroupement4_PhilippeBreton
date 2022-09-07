Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        CreationDonneesDepart()
        txtUserName.Text = "CGERMAIN"
        txtpassword.Text = "20Lapins"
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userName As String
        Dim password As String

        userName = txtUserName.Text
        password = txtpassword.Text

        Dim currentUser As New Utilisateur
        currentUser = ValiderAuthentification(userName, password)

        If Not currentUser.AuthentificationValide Then
            AfficherBoiteDialogue("Nom d'utilisateur et/ou mot de passe invalide(s)")
        Else
            Dim main As New Main
            If currentUser.typeAcces = "R" Then
                niveauAccesComplet = True
            End If
            main.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Application.Exit()
    End Sub
End Class
