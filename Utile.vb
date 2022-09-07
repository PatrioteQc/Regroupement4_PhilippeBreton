﻿Imports System.Diagnostics.Metrics
Imports System.Net
Imports System.Text.RegularExpressions

Module Utile
    Sub CreationDonneesDepart()
        Try
            dtPersonne.Columns.Add("id")
            dtPersonne.Columns.Add("nom")
            dtPersonne.Columns.Add("prenom")
            dtPersonne.Columns.Add("sexe")

            Dim rowPersonne As DataRow = dtPersonne.NewRow

            rowPersonne("id") = 1
            rowPersonne("nom") = "Bouchard"
            rowPersonne("prenom") = "Pauline"
            rowPersonne("sexe") = "Femme"
            dtPersonne.Rows.Add(rowPersonne)

            rowPersonne = dtPersonne.NewRow

            rowPersonne("id") = 2
            rowPersonne("nom") = "Parizeau"
            rowPersonne("prenom") = "Lucien"
            rowPersonne("sexe") = "Homme"
            dtPersonne.Rows.Add(rowPersonne)

            rowPersonne = dtPersonne.NewRow

            rowPersonne("id") = 3
            rowPersonne("nom") = "Germain"
            rowPersonne("prenom") = "Christian"
            rowPersonne("sexe") = "Homme"
            dtPersonne.Rows.Add(rowPersonne)

            rowPersonne = dtPersonne.NewRow

            rowPersonne("id") = 4
            rowPersonne("nom") = "Marois"
            rowPersonne("prenom") = "Renée"
            rowPersonne("sexe") = "Femme"
            dtPersonne.Rows.Add(rowPersonne)

            rowPersonne = dtPersonne.NewRow

            rowPersonne("id") = 5
            rowPersonne("nom") = "J. Fox"
            rowPersonne("prenom") = "Michael"
            rowPersonne("sexe") = "Homme"
            dtPersonne.Rows.Add(rowPersonne)

            rowPersonne = dtPersonne.NewRow

            rowPersonne("id") = 6
            rowPersonne("nom") = "Loyd"
            rowPersonne("prenom") = "Christopher"
            rowPersonne("sexe") = "Homme"
            dtPersonne.Rows.Add(rowPersonne)

            rowPersonne = dtPersonne.NewRow

            rowPersonne("id") = 7
            rowPersonne("nom") = "Roberts"
            rowPersonne("prenom") = "Julia"
            rowPersonne("sexe") = "Femme"
            dtPersonne.Rows.Add(rowPersonne)

            rowPersonne = dtPersonne.NewRow

            rowPersonne("id") = 8
            rowPersonne("nom") = "Hanks"
            rowPersonne("prenom") = "Tom"
            rowPersonne("sexe") = "Homme"
            dtPersonne.Rows.Add(rowPersonne)


            dtClient.Columns.Add("idClient")
            dtClient.Columns.Add("idPersonne")
            dtClient.Columns.Add("dtInscr")
            dtClient.Columns.Add("email")
            dtClient.Columns.Add("password")

            Dim rowClient As DataRow = dtClient.NewRow

            rowClient("idClient") = 9
            rowClient("idPersonne") = 1
            rowClient("dtInscr") = DateTime.Now()
            rowClient("email") = "pauline.bouchard@email.com"
            rowClient("password") = Encrypt("10Lapins")
            dtClient.Rows.Add(rowClient)

            rowClient = dtClient.NewRow

            rowClient("idClient") = 10
            rowClient("idPersonne") = 2
            rowClient("dtInscr") = DateTime.Now()
            rowClient("email") = "lucien.parizeau@email.com"
            rowClient("password") = Encrypt("10Lapins")
            dtClient.Rows.Add(rowClient)

            dtActeur.Columns.Add("idActeur")
            dtActeur.Columns.Add("idPersonne")
            dtActeur.Columns.Add("nomPersn")
            dtActeur.Columns.Add("dtDebt")
            dtActeur.Columns.Add("dtFin")
            dtActeur.Columns.Add("cacht")

            Dim rowActeur As DataRow = dtActeur.NewRow

            rowActeur("idActeur") = 11
            rowActeur("idPersonne") = 5
            rowActeur("nomPersn") = "Marty McFly"
            rowActeur("dtDebt") = #1984-5-31#
            rowActeur("dtFin") = #1984-9-30#
            rowActeur("cacht") = 500000
            dtActeur.Rows.Add(rowActeur)

            rowActeur = dtActeur.NewRow

            rowActeur("idActeur") = 12
            rowActeur("idPersonne") = 6
            rowActeur("nomPersn") = "Dr Emmett Brown"
            rowActeur("dtDebt") = #1984-5-31#
            rowActeur("dtFin") = #1984-9-30#
            rowActeur("cacht") = 400000
            dtActeur.Rows.Add(rowActeur)

            rowActeur = dtActeur.NewRow

            rowActeur("idActeur") = 13
            rowActeur("idPersonne") = 7
            rowActeur("nomPersn") = "Viviane Ward"
            rowActeur("dtDebt") = #1990-6-14#
            rowActeur("dtFin") = #1990-10-31#
            rowActeur("cacht") = 700000
            dtActeur.Rows.Add(rowActeur)

            rowActeur = dtActeur.NewRow

            rowActeur("idActeur") = 14
            rowActeur("idPersonne") = 8
            rowActeur("nomPersn") = "Forrest Gump"
            rowActeur("dtDebt") = #1994-6-14#
            rowActeur("dtFin") = #1994-12-25#
            rowActeur("cacht") = 700000
            dtActeur.Rows.Add(rowActeur)

            dtEmploye.Columns.Add("idEmploye")
            dtEmploye.Columns.Add("idPersonne")
            dtEmploye.Columns.Add("dtEmbch")
            dtEmploye.Columns.Add("username")
            dtEmploye.Columns.Add("password")
            dtEmploye.Columns.Add("typeAcces")

            Dim rowEmploye As DataRow = dtEmploye.NewRow

            rowEmploye("idEmploye") = 15
            rowEmploye("idPersonne") = 3
            rowEmploye("dtEmbch") = #2022-2-28#
            rowEmploye("username") = "CGERMAIN"
            rowEmploye("password") = Encrypt("20Lapins")
            rowEmploye("typeAcces") = "R"
            dtEmploye.Rows.Add(rowEmploye)

            rowEmploye = dtEmploye.NewRow

            rowEmploye("idEmploye") = 16
            rowEmploye("idPersonne") = 4
            rowEmploye("dtEmbch") = #2021-6-24#
            rowEmploye("username") = "RMAROIS"
            rowEmploye("password") = Encrypt("20Lapins")
            rowEmploye("typeAcces") = "W"
            dtEmploye.Rows.Add(rowEmploye)

            dtCarteCredit.Columns.Add("idCarteCredit")
            dtCarteCredit.Columns.Add("idClient")
            dtCarteCredit.Columns.Add("numero")
            dtCarteCredit.Columns.Add("dtExprt")
            dtCarteCredit.Columns.Add("codeSecrt")

            Dim rowCarteCredit As DataRow = dtCarteCredit.NewRow

            rowCarteCredit("idCarteCredit") = 17
            rowCarteCredit("idClient") = 9
            rowCarteCredit("numero") = "4540123412341234"
            rowCarteCredit("dtExprt") = #2024-2-28#
            rowCarteCredit("codeSecrt") = 639
            dtCarteCredit.Rows.Add(rowCarteCredit)

            rowCarteCredit = dtCarteCredit.NewRow

            rowCarteCredit("idCarteCredit") = 18
            rowCarteCredit("idClient") = 9
            rowCarteCredit("numero") = "5120123412341234"
            rowCarteCredit("dtExprt") = #2026-6-14#
            rowCarteCredit("codeSecrt") = 123
            dtCarteCredit.Rows.Add(rowCarteCredit)

            rowCarteCredit = dtCarteCredit.NewRow

            rowCarteCredit("idCarteCredit") = 19
            rowCarteCredit("idClient") = 10
            rowCarteCredit("numero") = "9032123412341234"
            rowCarteCredit("dtExprt") = #2022-12-20#
            rowCarteCredit("codeSecrt") = 521
            dtCarteCredit.Rows.Add(rowCarteCredit)

            dtFilm.Columns.Add("idFilm")
            dtFilm.Columns.Add("nom")
            dtFilm.Columns.Add("duree")
            dtFilm.Columns.Add("descr")

            Dim rowFilm As DataRow = dtFilm.NewRow

            rowFilm("idFilm") = 20
            rowFilm("nom") = "Retour vers le futur"
            rowFilm("duree") = 5760
            rowFilm("descr") = "Voyage dans le temps"
            dtFilm.Rows.Add(rowFilm)

            rowFilm = dtFilm.NewRow

            rowFilm("idFilm") = 21
            rowFilm("nom") = "Retour vers le futur 2"
            rowFilm("duree") = 5530
            rowFilm("descr") = "Encore un voyage dans le temps"
            dtFilm.Rows.Add(rowFilm)

            rowFilm = dtFilm.NewRow

            rowFilm("idFilm") = 22
            rowFilm("nom") = "Pretty Woman"
            rowFilm("duree") = 6201
            rowFilm("descr") = "Histoire d'amour atypique"
            dtFilm.Rows.Add(rowFilm)

            rowFilm = dtFilm.NewRow

            rowFilm("idFilm") = 23
            rowFilm("nom") = "Forrest Gump"
            rowFilm("duree") = 7102
            rowFilm("descr") = "L'histoire incroyable d'un homme faible d'esprit"
            dtFilm.Rows.Add(rowFilm)

            dtCategorie.Columns.Add("idCategorie")
            dtCategorie.Columns.Add("nom")
            dtCategorie.Columns.Add("descr")

            Dim rowCategorie As DataRow = dtCategorie.NewRow

            rowCategorie("idCategorie") = 24
            rowCategorie("nom") = "Action"
            rowCategorie("descr") = "Film qui bouge beaucoup"
            dtCategorie.Rows.Add(rowCategorie)

            rowCategorie = dtCategorie.NewRow

            rowCategorie("idCategorie") = 25
            rowCategorie("nom") = "Science-fiction"
            rowCategorie("descr") = "Film qui ne se peut même pas"
            dtCategorie.Rows.Add(rowCategorie)

            rowCategorie = dtCategorie.NewRow

            rowCategorie("idCategorie") = 26
            rowCategorie("nom") = "Drame"
            rowCategorie("descr") = "Film qui bouge moins"
            dtCategorie.Rows.Add(rowCategorie)

            rowCategorie = dtCategorie.NewRow

            rowCategorie("idCategorie") = 27
            rowCategorie("nom") = "Comédie"
            rowCategorie("descr") = "Film qui dilate la rate"
            dtCategorie.Rows.Add(rowCategorie)

            dtFilmActeur.Columns.Add("idFilmsActeur")
            dtFilmActeur.Columns.Add("idFilm")
            dtFilmActeur.Columns.Add("idActeur")

            Dim rowFilmActeur As DataRow = dtFilmActeur.NewRow

            rowFilmActeur("idFilmsActeur") = 28
            rowFilmActeur("idFilm") = 20
            rowFilmActeur("idActeur") = 11
            dtFilmActeur.Rows.Add(rowFilmActeur)

            rowFilmActeur = dtFilmActeur.NewRow

            rowFilmActeur("idFilmsActeur") = 29
            rowFilmActeur("idFilm") = 20
            rowFilmActeur("idActeur") = 12
            dtFilmActeur.Rows.Add(rowFilmActeur)

            rowFilmActeur = dtFilmActeur.NewRow

            rowFilmActeur("idFilmsActeur") = 30
            rowFilmActeur("idFilm") = 21
            rowFilmActeur("idActeur") = 11
            dtFilmActeur.Rows.Add(rowFilmActeur)

            rowFilmActeur = dtFilmActeur.NewRow

            rowFilmActeur("idFilmsActeur") = 31
            rowFilmActeur("idFilm") = 21
            rowFilmActeur("idActeur") = 12
            dtFilmActeur.Rows.Add(rowFilmActeur)

            rowFilmActeur = dtFilmActeur.NewRow

            rowFilmActeur("idFilmsActeur") = 32
            rowFilmActeur("idFilm") = 22
            rowFilmActeur("idActeur") = 13
            dtFilmActeur.Rows.Add(rowFilmActeur)

            rowFilmActeur = dtFilmActeur.NewRow

            rowFilmActeur("idFilmsActeur") = 33
            rowFilmActeur("idFilm") = 23
            rowFilmActeur("idActeur") = 14
            dtFilmActeur.Rows.Add(rowFilmActeur)

            dtFilmCategorie.Columns.Add("idFilmCategorie")
            dtFilmCategorie.Columns.Add("idFilm")
            dtFilmCategorie.Columns.Add("idCategorie")

            Dim rowFilmCategorie As DataRow = dtFilmCategorie.NewRow

            rowFilmCategorie("idFilmCategorie") = 34
            rowFilmCategorie("idFilm") = 20
            rowFilmCategorie("idCategorie") = 24
            dtFilmCategorie.Rows.Add(rowFilmCategorie)

            rowFilmCategorie = dtFilmCategorie.NewRow

            rowFilmCategorie("idFilmCategorie") = 35
            rowFilmCategorie("idFilm") = 20
            rowFilmCategorie("idCategorie") = 25
            dtFilmCategorie.Rows.Add(rowFilmCategorie)

            rowFilmCategorie = dtFilmCategorie.NewRow

            rowFilmCategorie("idFilmCategorie") = 36
            rowFilmCategorie("idFilm") = 20
            rowFilmCategorie("idCategorie") = 27
            dtFilmCategorie.Rows.Add(rowFilmCategorie)

            rowFilmCategorie = dtFilmCategorie.NewRow

            rowFilmCategorie("idFilmCategorie") = 37
            rowFilmCategorie("idFilm") = 21
            rowFilmCategorie("idCategorie") = 24
            dtFilmCategorie.Rows.Add(rowFilmCategorie)

            rowFilmCategorie = dtFilmCategorie.NewRow

            rowFilmCategorie("idFilmCategorie") = 38
            rowFilmCategorie("idFilm") = 21
            rowFilmCategorie("idCategorie") = 25
            dtFilmCategorie.Rows.Add(rowFilmCategorie)

            rowFilmCategorie = dtFilmCategorie.NewRow

            rowFilmCategorie("idFilmCategorie") = 39
            rowFilmCategorie("idFilm") = 22
            rowFilmCategorie("idCategorie") = 26
            dtFilmCategorie.Rows.Add(rowFilmCategorie)

            rowFilmCategorie = dtFilmCategorie.NewRow

            rowFilmCategorie("idFilmCategorie") = 40
            rowFilmCategorie("idFilm") = 23
            rowFilmCategorie("idCategorie") = 27
            dtFilmCategorie.Rows.Add(rowFilmCategorie)


            For i = 0 To 40
                idList.Add(i)
            Next
        Catch

        Finally

        End Try

    End Sub
    Function ObtenirId() As Integer
        Dim id As Integer

        If idList.Count > 0 Then
            id = idList(idList.Count - 1) + 1
        Else
            id = 0
        End If

        idList.Add(id)

        Return id
    End Function

    Function CreerClientDB(ByVal newClient As Client) As Boolean
        Dim isSucces As Boolean = False

        Try
            Dim rowClient As DataRow = dtClient.NewRow

            rowClient("idClient") = newClient.idClient
            rowClient("idPersonne") = newClient.idPersonne
            rowClient("dtInscr") = newClient.dtInscr
            rowClient("email") = newClient.email
            rowClient("password") = newClient.password
            dtClient.Rows.Add(rowClient)

            Dim rowPersonne As DataRow = dtPersonne.NewRow

            rowPersonne("id") = newClient.id
            rowPersonne("nom") = newClient.nom
            rowPersonne("prenom") = newClient.prenom
            rowPersonne("sexe") = newClient.sexe
            dtPersonne.Rows.Add(rowPersonne)

        Catch ex As Exception

        End Try

        isSucces = True

        Return isSucces

    End Function

    Function MiseAJourClientDB(ByVal updatedClient As Client) As Boolean
        Dim isSucces As Boolean = False

        Try
            For i = 0 To dtClient.Rows.Count - 1
                If dtClient.Rows(i).Item("idClient") = updatedClient.idClient Then
                    dtClient.Rows(i)("email") = updatedClient.email
                    dtClient.Rows(i)("password") = updatedClient.password

                    For i2 = 0 To dtPersonne.Rows.Count - 1
                        If dtPersonne.Rows(i2).Item("id") = updatedClient.idPersonne Then
                            dtPersonne.Rows(i2)("nom") = updatedClient.nom
                            dtPersonne.Rows(i2)("prenom") = updatedClient.prenom
                            dtPersonne.Rows(i2)("sexe") = updatedClient.sexe
                        End If
                    Next
                End If

            Next

        Catch ex As Exception

        End Try

        isSucces = True

        Return isSucces

    End Function

    Function SupprimerClientDB(ByVal idClient As Integer) As Boolean
        Dim isSucces As Boolean = False
        Dim idPersonne As Integer

        Try
            For i = 0 To dtClient.Rows.Count - 1
                If dtClient.Rows(i).Item("idClient") = idClient Then
                    idPersonne = dtClient.Rows(i).Item("idPersonne")
                    dtClient.Rows(i).Delete()

                    For i2 = 0 To dtPersonne.Rows.Count - 1
                        If dtPersonne.Rows(i2).Item("id") = idPersonne Then
                            dtPersonne.Rows(i2).Delete()
                        End If
                    Next
                End If
            Next

        Catch ex As Exception

        End Try

        isSucces = True

        Return isSucces
    End Function

    Function ValiderAuthentification(ByVal username As String, ByVal password As String) As Utilisateur
        Dim currentUser As New Utilisateur
        currentUser.AuthentificationValide = False

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

    Function isCourrielExistant(ByVal email As String) As Boolean
        Dim courrielExistant As Boolean = False

        For i = 0 To dtClient.Rows.Count - 1
            If dtClient.Rows(i).Item("email") = email Then
                courrielExistant = True
            End If
        Next

        Return courrielExistant
    End Function

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

    Function ObtenirClientParId(ByVal idClient As Integer) As Client
        Dim client As New Client
        Dim personne As New Personne


        For i = 0 To dtClient.Rows.Count - 1
            If dtClient.Rows(i).Item("idClient") = idClient Then
                client.idClient = idClient
                client.idPersonne = dtClient.Rows(i).Item("idPersonne")
                client.dtInscr = dtClient.Rows(i).Item("dtInscr")
                client.email = dtClient.Rows(i).Item("email")
                client.password = Decrypt(dtClient.Rows(i).Item("password"))
            End If
        Next

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

    Function ObtenirCategorieParId(ByVal idCategorie As Integer) As String
        Dim nomCategorie As String = ""

        For i = 0 To dtCategorie.Rows.Count - 1
            If dtCategorie.Rows(i).Item("idCategorie") = idCategorie Then
                nomCategorie = dtCategorie.Rows(i).Item("nom").ToString
            End If
        Next

        Return nomCategorie
    End Function

    Function ObtenirCategoriesParIdFilm(ByVal idFilm As Integer) As String
        Dim enumCategories As String = ""

        For i = 0 To dtFilmCategorie.Rows.Count - 1
            If dtFilmCategorie.Rows(i).Item("idFilm") = idFilm Then
                enumCategories = enumCategories & "," & ObtenirCategorieParId(dtFilmCategorie.Rows(i).Item("idCategorie"))
            End If
        Next

        enumCategories = enumCategories.Trim(",")

        Return enumCategories
    End Function

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

    Function FormaterNbSecondes(iSecond As Integer) As String
        Dim iSpan As TimeSpan = TimeSpan.FromSeconds(iSecond)
        Dim SecondesFormat As String

        SecondesFormat = iSpan.Hours.ToString.PadLeft(2, "0"c) & ":" &
                                iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" &
                                iSpan.Seconds.ToString.PadLeft(2, "0"c)

        Return SecondesFormat
    End Function

    Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$")

        Return emailExpression.IsMatch(email)
    End Function

    Public Sub AfficherBoiteDialogue(ByVal message As String)
        MsgBox(message, , "Video Gestion")
    End Sub

End Module
