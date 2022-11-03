Imports System.Diagnostics.Eventing
Imports MySql.Data
Imports MySql.Data.MySqlClient

Module MySQLDB
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

    Public Sub CloseConn(ByRef conn As MySqlConnection)

        conn.Dispose()
        conn.Close()

    End Sub

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

        Return dt

    End Function

    Public Sub Test()
        Dim conn As MySqlConnection = InitiateConn()

        Dim cmd As New MySqlCommand()
        cmd.CommandText = "clients"
        cmd.Connection = conn
        cmd.CommandType = CommandType.TableDirect
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While (reader.Read())
            Console.WriteLine(reader(0))
        End While

        CloseConn(conn)

    End Sub

End Module
