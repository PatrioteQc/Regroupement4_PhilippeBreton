Public Class Login
    'Au chargement de la fenêtre d'authentification, on exécute la procédure permettant de simuler la présence d'une base de données.
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If idList.Count = 0 Then
                ObtentionDonneesDepart()
            End If

        Catch ex As Exception
            GestionErreurStandard(ex)
        End Try

    End Sub

    'En cliquant sur le bouton Entrer, on envoi les informations entrées dans la fonction permettant de valider l'authentification.
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim userName As String
            Dim password As String

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

        Catch ex As Exception
            GestionErreurStandard(ex)
        End Try

    End Sub

    'En cliquant sur le bouton Quitter, l'application se ferme.
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MySQLDB.ObtenirTable()
    End Sub
End Class
