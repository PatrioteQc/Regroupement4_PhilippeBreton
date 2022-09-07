Public Class Personne
    Public id As Integer
    Public nom As String
    Public prenom As String
    Public sexe As String

    Public Sub New()
    End Sub
End Class

Public Class Client
    Inherits Personne
    Public idClient As Integer
    Public dtInscr As DateTime
    Public email As String
    Public password As String
    Public idPersonne As Integer

    Public Sub New()
    End Sub

End Class

Public Class Acteur
    Inherits Personne
    Public idActeur As Integer
    Public nomPersn As String
    Public dtDebt As Date
    Public dtFin As Date
    Public cacht As Decimal
    Public idPersonne As Integer

    Public Sub New()
    End Sub

End Class

Public Class Employe
    Inherits Personne
    Public idEmploye As Integer
    Public dtEmbch As Date
    Public username As String
    Public password As String
    Public typeAcces As String
    Public idPersonne As Integer

    Public Sub New()
    End Sub

End Class

Public Class CarteCredit
    Public id As Integer
    Public no As String
    Public dtExprt As Date
    Public codeSecrt As String

    Public Sub New()
    End Sub

End Class