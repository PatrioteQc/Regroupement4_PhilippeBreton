Imports System.Diagnostics.Metrics
Imports System.Net
Imports System.Text.RegularExpressions

Public Module Utile
    'Procédure permettant d'obtenir les données requises au démarrage de l'application au démmarage
    Sub ObtentionDonneesDepart()
        dtPersonne = MySQLDB.ObtenirTable("Personne")
        dtClient = MySQLDB.ObtenirTable("Client")
        dtActeur = MySQLDB.ObtenirTable("Acteur")
        dtEmploye = MySQLDB.ObtenirTable("Employe")
        dtCarteCredit = MySQLDB.ObtenirTable("CarteCredit")
        dtFilm = MySQLDB.ObtenirTable("Film")
        dtCategorie = MySQLDB.ObtenirTable("Categorie")
        dtFilmActeur = MySQLDB.ObtenirTable("FilmActeur")
        dtFilmCategorie = MySQLDB.ObtenirTable("FilmCategorie")
    End Sub

    'Cette fonction reçoit un nom d'utilisateur et un mot de passe et retourne un objet Utilisateur si l'authentification est valide.
    Function ValiderAuthentification(ByVal username As String, ByVal password As String) As Utilisateur
        Dim currentUser As New Utilisateur
        currentUser.AuthentificationValide = False

        'On rafraichit les données de base pour s'assurer de prendre en compte les changements depuis le dernier chargement.
        ObtentionDonneesDepart()

        'Dans la BD' on recherche l'employé associé au nom d'utilisateur, on décrypte le mot de passe correspondant pour le comparer à celui reçu. Si c'est valide, on indique que l'authentification est valide et on ajoute le type d'accès assigné dans la BD la propriété de la classe prévue à cet effet.
        For i = 0 To dtEmploye.Rows.Count - 1
            If dtEmploye.Rows(i).Item("username") = username Then
                If Decrypt(dtEmploye.Rows(i).Item("password")) = password Then
                    currentUser.AuthentificationValide = True
                    currentUser.typeAcces = dtEmploye.Rows(i).Item("typeAcces")
                End If
            End If
        Next

        Return currentUser
    End Function

    'Fonctioner permettant de vérifier dans la BD si le courriel reçu en paramètre a déjà été utilisé.
    Function isCourrielExistant(ByVal email As String) As Boolean

        'On rafraichit les données de base pour s'assurer de prendre en compte les changements depuis le dernier chargement.
        ObtentionDonneesDepart()

        Dim courrielExistant As Boolean = False

        For i = 0 To dtClient.Rows.Count - 1
            If dtClient.Rows(i).Item("email") = email Then
                courrielExistant = True
            End If
        Next

        Return courrielExistant
    End Function

    'Fonction permettant d'obtenir un objet Personne et toutes ses propriétés contenues dans la BD à partir de son ID.
    Function ObtenirPersonneParId(ByVal id As Integer) As Personne
        Dim personne As New Personne

        For i = 0 To dtPersonne.Rows.Count - 1
            If dtPersonne.Rows(i).Item("id") = id Then
                personne.id = id
                personne.nom = dtPersonne.Rows(i).Item("nom")
                personne.prenom = dtPersonne.Rows(i).Item("prenom")
                personne.sexe = dtPersonne.Rows(i).Item("sexe")
            End If
        Next

        Return personne

    End Function

    'Fonction permettant d'obtenir un objet Client et toutes ses propriétés contenues dans la BD à partir de son ID.
    Function ObtenirClientParId(ByVal idClient As Integer) As Client
        Dim client As New Client
        Dim personne As New Personne

        'On recherche d'abord les propriétés Client contenues dans la table dtClient.
        For i = 0 To dtClient.Rows.Count - 1
            If dtClient.Rows(i).Item("idClient") = idClient Then
                client.idClient = idClient
                client.idPersonne = dtClient.Rows(i).Item("idPersonne")
                client.dtInscr = dtClient.Rows(i).Item("dtInscr")
                client.email = dtClient.Rows(i).Item("email")
                client.password = Decrypt(dtClient.Rows(i).Item("password"))
            End If
        Next

        'On recherche ensuite les propriétés Personne associées à ce client dans la table dtPersonne.
        For i = 0 To dtPersonne.Rows.Count - 1
            If dtPersonne.Rows(i).Item("id") = client.idPersonne Then
                client.id = dtPersonne.Rows(i).Item("id")
                client.nom = dtPersonne.Rows(i).Item("nom")
                client.prenom = dtPersonne.Rows(i).Item("prenom")
                client.sexe = dtPersonne.Rows(i).Item("sexe")
            End If
        Next

        Return client

    End Function

    'Fonction permettant d'obtenir le nom d'une catégorie sous forme de chaîne de texte à partir de son ID.
    Function ObtenirCategorieParId(ByVal idCategorie As Integer) As String
        Dim nomCategorie As String = ""

        For i = 0 To dtCategorie.Rows.Count - 1
            If dtCategorie.Rows(i).Item("idCategorie") = idCategorie Then
                nomCategorie = dtCategorie.Rows(i).Item("nom").ToString
            End If
        Next

        Return nomCategorie
    End Function

    'Cette fonction reçoit un ID de film et retourne toutes les catégories qui lui sont assignées dans la table FilmCategorie de la BD sous forme de chaîne de texte. Tous les noms de catégorie sont concaténées.
    Function ObtenirCategoriesParIdFilm(ByVal idFilm As Integer) As String
        Dim enumCategories As String = ""

        For i = 0 To dtFilmCategorie.Rows.Count - 1
            If dtFilmCategorie.Rows(i).Item("idFilm") = idFilm Then
                enumCategories = enumCategories & "," & ObtenirCategorieParId(dtFilmCategorie.Rows(i).Item("idCategorie"))
            End If
        Next

        'On utilise TRIM pour supprimer les virgules excédentaires.
        enumCategories = enumCategories.Trim(",")

        Return enumCategories
    End Function

    'Cette fonction permet d'obtenir une chaîne de texte représentant le prénom, le nom et le personnage à partir d'un ID d'acteur. Exemple: Tom Hanks (Forrest Gump)
    Function ObtenirActeurParId(ByVal idActeur As Integer) As String
        Dim detailsActeur As String = ""

        For i = 0 To dtActeur.Rows.Count - 1
            If dtActeur.Rows(i).Item("idActeur") = idActeur Then
                Dim personne As Personne = ObtenirPersonneParId(dtActeur.Rows(i).Item("idPersonne"))
                detailsActeur = personne.prenom & " " & personne.nom & " (" & dtActeur.Rows(i).Item("nomPersn") & ")"
            End If
        Next

        Return detailsActeur
    End Function

    'Cette fonction reçoit un ID de film et retourne une chaîne de texte représentant les détails de tous les acteurs qui y jouent incluant leur prénom, nom et personnage.
    Function ObtenirActeursParIdFilm(ByVal idFilm As Integer) As String
        Dim enumActeurs As String = ""

        For i = 0 To dtFilmActeur.Rows.Count - 1
            If dtFilmActeur.Rows(i).Item("idFilm") = idFilm Then
                enumActeurs = enumActeurs & "," & ObtenirActeurParId(dtFilmActeur.Rows(i).Item("idActeur"))
            End If
        Next

        enumActeurs = enumActeurs.Trim(",")

        Return enumActeurs
    End Function

    'Fonction permettant de convertir un nombre de secondes en format texte de durée plus facile à lire dans l'interface. Exemple: 01:38:12
    Function FormaterNbSecondes(iSecond As Integer) As String
        Dim iSpan As TimeSpan = TimeSpan.FromSeconds(iSecond)
        Dim SecondesFormat As String

        SecondesFormat = iSpan.Hours.ToString.PadLeft(2, "0"c) & ":" &
                                iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" &
                                iSpan.Seconds.ToString.PadLeft(2, "0"c)

        Return SecondesFormat
    End Function

    'Fonction permettant de valider si la chaîne de texte reçue est bien dans un format de courriel valide. Un REGEX est utilisé.
    Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$")

        Return emailExpression.IsMatch(email)
    End Function

    'Procédure permettant d'afficher une boîte de dialogue. Permet d'uniformiser l'appel et le visuel.
    Public Sub AfficherBoiteDialogue(ByVal message As String)
        MsgBox(message, , "Video Gestion")
    End Sub

    'Procédure permettant d'informer l'utilisateur qu'un problème inattendu s'est produit et de fermer l'application ensuite.
    Public Sub GestionErreurStandard(ex As Exception)
        AfficherBoiteDialogue("Un problème inattendu s'est produit: " & ex.Message)
        Application.Exit()
    End Sub

End Module
