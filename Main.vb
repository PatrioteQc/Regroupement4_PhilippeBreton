Public Class Main
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New Login
        login.Show()
        Me.Hide()

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        RafraichirListeClient()
        RafraichirListeFilms()
        If niveauAccesComplet Then
            btnCreer.Visible = True
            btnModifier.Visible = True
            btnSupprimer.Visible = True
        Else
            btnCreer.Visible = False
            btnModifier.Visible = False
            btnSupprimer.Visible = False
        End If
    End Sub

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

        dgvClient.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvClient.ColumnHeadersDefaultCellStyle.BackColor

    End Sub

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


        For i = 0 To dgvFilms.Rows.Count - 1
            For i2 = 0 To dgvFilms.Rows(i).Cells.Count - 1
                dgvFilms.Rows(i).Cells(i2).ToolTipText = ObtenirActeursParIdFilm(dtFilm.Rows(i).Item("idFilm"))
            Next
        Next

        dgvFilms.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvFilms.ColumnHeadersDefaultCellStyle.BackColor

    End Sub

    Private Sub btnCreer_Click(sender As Object, e As EventArgs) Handles btnCreer.Click
        isClientSelectionne = False
        Me.Close()
        GestionClient.Show()
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        isClientSelectionne = True
        clientSelectionneId = dtClient.Rows(dgvClient.CurrentCell.RowIndex).Item("idClient")
        Me.Close()
        GestionClient.Show()
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click

        Dim result As DialogResult = MessageBox.Show("Souhaitez-vous vraiment supprimer cet utilisateur ?", "Video Gesstion", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            clientSelectionneId = dtClient.Rows(dgvClient.CurrentCell.RowIndex).Item("idClient")

            If SupprimerClientDB(clientSelectionneId) Then
                dgvClient.Rows.RemoveAt(dgvClient.CurrentCell.RowIndex)
                AfficherBoiteDialogue("Suppresion du client complétée")
            Else
                AfficherBoiteDialogue("Suppresion impossible")
            End If
        End If

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class