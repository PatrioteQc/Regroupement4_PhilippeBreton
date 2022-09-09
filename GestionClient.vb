Imports System.Text.RegularExpressions

Public Class GestionClient

    'Au chargement de la fenêtre de gestion des clients, on valide si on est en contexte de création ou de modification grâce à l'indicateur de client sélectionné.
    Private Sub GestionClient_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not isClientSelectionne Then
            lblTitre.Text = "Création d'un client"
        Else
            'Si on est contexte de modification, on récupère l'objet Client à partir de l'id et on assigne les valeurs existantes dans les bons champs.
            lblTitre.Text = "Modification d'un client"
            Dim client As Client = ObtenirClientParId(clientSelectionneId)
            txtNom.Text = client.nom
            txtPrenom.Text = client.prenom
            txtpassword.Text = client.password
            txtUserName.Text = client.email
            dropSexe.SelectedItem = client.sexe
        End If

    End Sub

    'Cette fonction permet de valider la conformité de tous les champs du formulaire de gestion des clients. La fonction retourne VRAI si les données sont valides.
    'Si des données ne sont pas conformes, un message d'erreur est affiché et indique les champs qui ne sont pas valides.
    Function FormulaireValide() As Boolean
        Dim isFormulaireValide As Boolean = True
        Dim messageErreur As String = "Les données saisies contiennent ne sont pas conformes: "

        'Validation du format du courriel
        If Not IsEmail(txtUserName.Text) Then
            messageErreur = messageErreur & vbLf & "Le format du courriel n'est pas conforme."
            isFormulaireValide = False
        End If

        'Validation de la longueur du mot de passe. 8 caractères minimium
        If txtpassword.TextLength < 8 Then
            messageErreur = messageErreur & vbLf & "Le mot de passe n'est passez long. (8 caractères minimum)"
            isFormulaireValide = False
        End If

        'Valider de la présence d'un prénom
        If txtPrenom.TextLength = 0 Then
            messageErreur = messageErreur & vbLf & "Le prénom doit être entré."
            isFormulaireValide = False
        End If

        'Valider de la présence d'un nom
        If txtNom.TextLength = 0 Then
            messageErreur = messageErreur & vbLf & "Le nom doit être entré."
            isFormulaireValide = False
        End If

        'Valider si un sexe est entré et qu'il correspond à Homme ou Femme
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

    'En cliquant sur le bouton Annuler, on réinitialise les valeurs de tous les champs et on retourne à la fenêtre principale.
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtNom.Text = ""
        txtPrenom.Text = ""
        txtUserName.Text = ""
        txtpassword.Text = ""
        isClientSelectionne = False
        Me.Close()
        Main.Show()
    End Sub

    'En cliquant sur le bouton Sauvegarder, une validation des champs du formulaire est faite. Si tous les champs sont valides, on procède à l'enregistrement des données.
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If FormulaireValide() Then
            'Si le courriel n'est pas déjà utilisé dans la BD, on poursuit, sinon on indique à l'utilisateur qu'il est déjà existant.
            If Not isCourrielExistant(txtUserName.Text) Then
                'Si on est contexte de création de client, on obtient de nouveaux IDs, on assigne les propriétés de l'objet Client en fonction des informations entrées dans le formulaire.
                If Not isClientSelectionne Then
                    Dim newClient As New Client()
                    newClient.id = ObtenirId()
                    newClient.idClient = ObtenirId()
                    newClient.nom = txtNom.Text
                    newClient.prenom = txtPrenom.Text
                    newClient.sexe = dropSexe.SelectedItem.ToString
                    newClient.email = txtUserName.Text
                    'Encryption du mot de passe
                    newClient.password = Encrypt(txtpassword.Text)
                    'Date d'inscription avec la date et l'heure actuelle
                    newClient.dtInscr = DateTime.Now()
                    newClient.idPersonne = newClient.id

                    'Si la sauvegarde du client créé est réussie, on l'indique à l'utilisateur, on réinitialise les champs et on retourne à la fenêtre principale du programme.
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
                    'Si on est en contexte de modification de client, on conserve les IDs déjà existants et on assigne les valeurs modifiées aux propriétées de l'objet Client.
                    Dim updatedClient As New Client()
                    updatedClient.idClient = clientSelectionneId
                    updatedClient.idPersonne = ObtenirClientParId(clientSelectionneId).idPersonne
                    updatedClient.nom = txtNom.Text
                    updatedClient.prenom = txtPrenom.Text
                    updatedClient.sexe = dropSexe.SelectedItem.ToString
                    updatedClient.email = txtUserName.Text
                    updatedClient.password = Encrypt(txtpassword.Text)

                    'Si la sauvegarde du client modifié est réussie, on l'indique à l'utilisateur, on réinitialise les champs et on retourne à la fenêtre principale du programme.
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
