Public Class Main

    'Au chargement de la fenêtre principale du programme, on rafraichit la liste des clients et la liste des films affichés.
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            ObtentionDonneesDepart()
            RafraichirListeClient()
            RafraichirListeFilms()
            'Si le niveau d'accès de l'utilisateur permet la modification, les boutons permettant d'éditer les données sont affichés. Si l'utilisateur est en lecture seule, ces boutons sont masqués.
            If niveauAccesComplet Then
                btnCreer.Visible = True
                btnModifier.Visible = True
                btnSupprimer.Visible = True
            Else
                btnCreer.Visible = False
                btnModifier.Visible = False
                btnSupprimer.Visible = False
            End If

        Catch ex As Exception
            GestionErreurStandard(ex)
        End Try
    End Sub

    'Cette procédure permet de créer les colonnes requises dans le DataGridView de clients et de le remplir avec les données provenant des tables clients et personnes.
    Public Sub RafraichirListeClient()
        Dim dtListeClient As New DataTable
        dtListeClient.Columns.Add("idClient")
        dtListeClient.Columns.Add("prenom")
        dtListeClient.Columns.Add("nom")
        dtListeClient.Columns.Add("courriel")

        Dim rowListeClient As DataRow = dtListeClient.NewRow

        For i = 0 To dtClient.Rows.Count - 1
            Dim personne As Personne = ObtenirPersonneParId(dtClient.Rows(i).Item("idPersonne"))
            rowListeClient("idClient") = dtClient.Rows(i).Item("idClient")
            rowListeClient("prenom") = personne.prenom
            rowListeClient("nom") = personne.nom
            rowListeClient("courriel") = dtClient.Rows(i).Item("email")
            dtListeClient.Rows.Add(rowListeClient)
            rowListeClient = dtListeClient.NewRow
        Next

        dgvClient.DataSource = dtListeClient

        'Permet d'améliorer le visuel lors de la sélection d'une ligne. L'entête ne change pas de couleur.
        dgvClient.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvClient.ColumnHeadersDefaultCellStyle.BackColor
    End Sub

    'Cette procédure permet de créer les colonnes requises dans le DataGridView de films et de le remplir avec les données provenant des tables films, acteurs, catégories, etc.
    Private Sub RafraichirListeFilms()
        Dim dtListeFilm As New DataTable
        dtListeFilm.Columns.Add("nom")
        dtListeFilm.Columns.Add("duree")
        dtListeFilm.Columns.Add("categorie")

        Dim rowListeFilm As DataRow = dtListeFilm.NewRow

        For i = 0 To dtFilm.Rows.Count - 1
            rowListeFilm("nom") = dtFilm.Rows(i).Item("nom")
            rowListeFilm("duree") = FormaterNbSecondes(dtFilm.Rows(i).Item("duree"))
            rowListeFilm("categorie") = ObtenirCategoriesParIdFilm(dtFilm.Rows(i).Item("idFilm"))

            dtListeFilm.Rows.Add(rowListeFilm)
            rowListeFilm = dtListeFilm.NewRow
        Next

        dgvFilms.DataSource = dtListeFilm


        'Ajout des Tooltip permettant de voir les acteurs de chacun des films. Il est assingé sur chacune des cellules de la ligne du film.
        For i = 0 To dgvFilms.Rows.Count - 1
            For i2 = 0 To dgvFilms.Rows(i).Cells.Count - 1
                dgvFilms.Rows(i).Cells(i2).ToolTipText = ObtenirActeursParIdFilm(dtFilm.Rows(i).Item("idFilm"))
            Next
        Next

        'Permet d'améliorer le visuel lors de la sélection d'une ligne. L'entête ne change pas de couleur.
        dgvFilms.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvFilms.ColumnHeadersDefaultCellStyle.BackColor

    End Sub

    'En cliquant sur le bouton Créer, la fenêtre principale du programme se ferme et celle de la gestion des clients s'affiche.
    Private Sub btnCreer_Click(sender As Object, e As EventArgs) Handles btnCreer.Click
        'On attribue FAUX à l'indicateur de client sélectionné pour être en contexte de création.
        Try
            isClientSelectionne = False
            Me.Close()
            GestionClient.Show()
        Catch ex As Exception
            GestionErreurStandard(ex)
        End Try
    End Sub

    'En cliquant sur le bouton Modifier, la fenêtre principale du programe se ferme et celle de la gestion des clients s'affiche.
    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        'On attribue VRAI à l'indicateur de client sélectionné pour être en contexte de modification.
        Try
            isClientSelectionne = True
            clientSelectionneId = dtClient.Rows(dgvClient.CurrentCell.RowIndex).Item("idClient")
            Me.Close()
            GestionClient.Show()
        Catch ex As Exception
            GestionErreurStandard(ex)
        End Try

    End Sub

    'En cliquant sur le bouton Supprimer, on supprime la ligne correspondante au client sélectionné de la DataGridView et on appelle la fonction permettant de supprimer ce même client dans la BD.
    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        Try
            'Après un clic sur Supprimer, on demande à l'utilisateur de confirmer la suppression.
            Dim result As DialogResult = MessageBox.Show("Souhaitez-vous vraiment supprimer cet utilisateur ?", "Video Gestion", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                clientSelectionneId = dtClient.Rows(dgvClient.CurrentCell.RowIndex).Item("idClient")

                If SupprimerClientBD(clientSelectionneId) Then
                    dgvClient.Rows.RemoveAt(dgvClient.CurrentCell.RowIndex)
                    AfficherBoiteDialogue("Suppresion du client complétée")
                Else
                    AfficherBoiteDialogue("Suppresion impossible")
                End If
            End If
        Catch ex As Exception
            GestionErreurStandard(ex)
        End Try
    End Sub

    'En cliquant sur le bouton Se déconnecter, on réinitialise le niveau d'accès, on ferme la fenêtre principale du programme et on affiche celle d'authentification.
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New Login
        niveauAccesComplet = False
        login.Show()
        Me.Hide()
    End Sub

    'En cliquant sur le bouton Quitter, l'application se ferme.
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class