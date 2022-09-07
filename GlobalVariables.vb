Public Module GlobalVariables
    Public idList As New List(Of Integer)

    Public dtPersonne As New DataTable
    Public dtClient As New DataTable
    Public dtActeur As New DataTable
    Public dtEmploye As New DataTable
    Public dtCarteCredit As New DataTable
    Public dtFilm As New DataTable
    Public dtCategorie As New DataTable
    Public dtFilmActeur As New DataTable
    Public dtFilmCategorie As New DataTable

    Public niveauAccesComplet As Boolean = False
    Public isClientSelectionne As Boolean = False
    Public clientSelectionneId As Integer = Nothing

End Module
