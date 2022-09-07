Imports System.Text.RegularExpressions

Public Class GestionClient
    Private Sub GestionClient_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not isClientSelectionne Then
            lblTitre.Text = "Création d'un client"
        Else
            lblTitre.Text = "Modification d'un client"
            Dim client As Client = ObtenirClientParId(clientSelectionneId)
            txtNom.Text = client.nom
            txtPrenom.Text = client.prenom
            txtpassword.Text = client.password
            txtUserName.Text = client.email
            dropSexe.SelectedItem = client.sexe
        End If

    End Sub

    Function FormulaireValide() As Boolean
        Dim isFormulaireValide As Boolean = True
        Dim messageErreur As String = "Les données saisies contiennent ne sont pas conformes: "

        If Not IsEmail(txtUserName.Text) Then
            messageErreur = messageErreur & vbLf & "Le format du courriel n'est pas conforme."
            isFormulaireValide = False
        End If

        If txtpassword.TextLength < 8 Then
            messageErreur = messageErreur & vbLf & "Le mot de passe n'est passez long. (8 caractères minimum)"
            isFormulaireValide = False
        End If

        If txtPrenom.TextLength = 0 Then
            messageErreur = messageErreur & vbLf & "Le prénom doit être entré."
            isFormulaireValide = False
        End If

        If txtNom.TextLength = 0 Then
            messageErreur = messageErreur & vbLf & "Le nom doit être entré."
            isFormulaireValide = False
        End If

        If Not dropSexe.SelectedItem Is Nothing Then
            If dropSexe.SelectedItem.ToString <> "Homme" And dropSexe.SelectedItem.ToString <> "Femme" Then
                messageErreur = messageErreur & vbLf & "Le sexe doit être saisi correctement."
                isFormulaireValide = False
            End If
        Else
            messageErreur = messageErreur & vbLf & "Le sexe doit être saisi correctement."
            isFormulaireValide = False
        End If

        If Not isFormulaireValide Then
            MsgBox(messageErreur)
        End If

        Return isFormulaireValide
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtNom.Text = ""
        txtPrenom.Text = ""
        txtUserName.Text = ""
        txtpassword.Text = ""
        isClientSelectionne = False
        Me.Close()
        Main.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If FormulaireValide() Then
            If Not isCourrielExistant(txtUserName.Text) Then
                If Not isClientSelectionne Then
                    Dim newClient As New Client()
                    newClient.id = ObtenirId()
                    newClient.idClient = ObtenirId()
                    newClient.nom = txtNom.Text
                    newClient.prenom = txtPrenom.Text
                    newClient.sexe = dropSexe.SelectedItem.ToString
                    newClient.email = txtUserName.Text
                    newClient.password = Encrypt(txtpassword.Text)
                    newClient.dtInscr = DateTime.Now()
                    newClient.idPersonne = newClient.id

                    If CreerClientDB(newClient) Then
                        AfficherBoiteDialogue("Création du client complétée")
                        txtNom.Text = ""
                        txtPrenom.Text = ""
                        txtUserName.Text = ""
                        txtpassword.Text = ""
                        Me.Close()
                        Main.Show()
                    End If

                Else
                    Dim updatedClient As New Client()
                    updatedClient.idClient = clientSelectionneId
                    updatedClient.idPersonne = ObtenirClientParId(clientSelectionneId).idPersonne
                    updatedClient.nom = txtNom.Text
                    updatedClient.prenom = txtPrenom.Text
                    updatedClient.sexe = dropSexe.SelectedItem.ToString
                    updatedClient.email = txtUserName.Text
                    updatedClient.password = Encrypt(txtpassword.Text)

                    If MiseAJourClientDB(updatedClient) Then
                        AfficherBoiteDialogue("Mise à jour du client complétée")
                        Me.Close()
                        Main.Show()
                    End If

                End If
            Else
                AfficherBoiteDialogue("Un compte client existe déjà avec ce courriel.")
            End If

        End If

    End Sub


End Class
