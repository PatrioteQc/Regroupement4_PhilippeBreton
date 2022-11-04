Imports System.Diagnostics.Eventing
Imports System.Xml
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities.Collections

Module MySQLDB

    'Procédure qui initialise une connexion à la base de donnée
    Public Function InitiateConn()
        Dim conn As New MySqlConnection
        Dim myConnectionString As String

        myConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=Bloc3Users;" _
            & "database=bloc3philippebreton"

        Try
            conn.ConnectionString = myConnectionString
            conn.Open()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try

        Return conn
    End Function

    'Procédure qui ferme la connexion à la base de données
    Public Sub CloseConn(ByRef conn As MySqlConnection)

        conn.Dispose()
        conn.Close()

    End Sub

    'Fonction générique permettant de retourner une table de la base de données en utilisant son nom comme paramètre. La fonction retourne une Datatable
    Function ObtenirTable(nomTable) As DataTable
        Dim dt As New DataTable
        Dim conn As MySqlConnection = InitiateConn()

        Using conn
            Using cmd As New MySqlCommand("SELECT * FROM " & nomTable, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt
                        sda.Fill(dt)
                    End Using
                End Using
            End Using
        End Using

        CloseConn(conn)

        Return dt

    End Function

    'Cette fonction reçoit un objet Client et le sauvegarde dans la base de données. La fonctionne retourne VRAI si la sauvegarde est réussie
    Function CreerClientBD(client As Client) As Boolean
        Dim isSucces As Boolean = False

        Dim conn As MySqlConnection = InitiateConn()
        Using conn
            Using cmd As New MySqlCommand("INSERT INTO bloc3philippebreton.personne (nom, prenom, sexe)
                VALUES('" & client.nom & "','" & client.prenom & "','" & client.sexe & "');
                  SELECT LAST_INSERT_ID();", conn)
                cmd.CommandType = CommandType.Text
                Dim newIdPersonne As Integer = cmd.ExecuteScalar()

                cmd.CommandText = "INSERT INTO bloc3philippebreton.client (idPersonne, dtInscr, email, password)
                VALUES(" & newIdPersonne & ",'" & client.dtInscr & "','" & client.email & "','" & client.password & "')"

                If cmd.ExecuteNonQuery() = 1 Then
                    isSucces = True
                End If

            End Using
        End Using

        CloseConn(conn)

        Return isSucces
    End Function

    'Cette fonction reçoit un objet Client et le met à jour dans la base de données. La fonctionne retourne VRAI si la mise à jour est réussie.
    Function MiseAJourClientBD(client As Client) As Boolean
        Dim isSucces As Boolean = False
        Dim isSuccesPersonne As Boolean = False
        Dim isSuccesClient As Boolean = False

        Dim conn As MySqlConnection = InitiateConn()
        Using conn
            Using cmd As New MySqlCommand("UPDATE bloc3philippebreton.personne SET prenom='" & client.prenom & "', nom='" & client.nom & "', sexe='" & client.sexe & "' WHERE id=" & client.idPersonne, conn)
                cmd.CommandType = CommandType.Text
                If cmd.ExecuteNonQuery() = 1 Then
                    isSuccesPersonne = True
                End If

                cmd.CommandText = "UPDATE bloc3philippebreton.client SET email='" & client.email & "', password='" & client.password & "' WHERE idClient=" & client.idClient

                If cmd.ExecuteNonQuery() = 1 Then
                    isSuccesClient = True
                End If

            End Using
        End Using

        CloseConn(conn)

        If isSuccesPersonne And isSuccesClient Then
            isSucces = True
        End If

        Return isSucces
    End Function

    'Cette fonctionne reçoit un id Client et supprime l'enregistrement correspondant dans la BD. Si la suppression est réussie, la fonction retourne VRAI.
    Function SupprimerClientBD(idClient As Integer) As Boolean
        Dim isSucces As Boolean = False
        Dim isSuccesPersonne As Boolean = False
        Dim isSuccesClient As Boolean = False

        'On recherche l'id Client dans la BD temporaire et on récupère l'id Personne associé
        Dim idPersonne As Integer
        For i = 0 To dtClient.Rows.Count - 1
            If dtClient.Rows(i).Item("idClient") = idClient Then
                idPersonne = dtClient.Rows(i).Item("idPersonne")
            End If
        Next

        Dim conn As MySqlConnection = InitiateConn()
        Using conn
            Using cmd As New MySqlCommand("DELETE FROM bloc3philippebreton.client WHERE idClient=" & idClient, conn)
                cmd.CommandType = CommandType.Text
                If cmd.ExecuteNonQuery() = 1 Then
                    isSuccesClient = True
                End If

                cmd.CommandText = "DELETE FROM bloc3philippebreton.personne WHERE id=" & idPersonne

                If cmd.ExecuteNonQuery() = 1 Then
                    isSuccesPersonne = True
                End If

            End Using
        End Using

        CloseConn(conn)

        If isSuccesPersonne And isSuccesClient Then
            isSucces = True
        End If

        Return isSucces
    End Function

End Module
