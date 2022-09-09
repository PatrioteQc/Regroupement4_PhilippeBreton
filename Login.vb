Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Au chargement de la fenêtre d'authentification, on exécute la procédure permettant de simuler la présence d'une base de données.
        CreationDonneesDepart()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userName As String
        Dim password As String

        'En cliquant sur le bouton Entrer, on envoi les informations entrées dans la fonction permettant de valider l'authentification.
        userName = txtUserName.Text
        password = txtpassword.Text

        Dim currentUser As New Utilisateur
        currentUser = ValiderAuthentification(userName, password)

        'Si l'authentification est invalide, on avise l'utilisateur, sinon on poursuit et on indique dans la variable de niveau d'accès si l'utilisateur peut apporter des modifications ou s'il est en lecture seule.
        If Not currentUser.AuthentificationValide Then
            AfficherBoiteDialogue("Nom d'utilisateur et/ou mot de passe invalide(s)")
        Else
            Dim main As New Main
            If currentUser.typeAcces = "W" Then
                niveauAccesComplet = True
            End If

            'Une fois l'authentification complétée, on affiche la fenêtre principale du programme et on ferme celle d'authentification.
            main.Show()
            Me.Hide()
        End If

    End Sub

    'En cliquant sur le bouton Quitter, l'application se ferme.
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Application.Exit()
    End Sub
End Class
