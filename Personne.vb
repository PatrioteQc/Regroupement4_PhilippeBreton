'Classe définissant une personne
Public Class Personne
    Public id As Integer
    Public nom As String
    Public prenom As String
    Public sexe As String

    Public Sub New()
    End Sub
End Class

'Classe définissant un client, les propriétés de la classe Personne sont héritées
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

'Classe définissant un acteur, les propriétés de la classe Personne sont héritées
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

'Classe définissant un employé, les propriétés de la classe Personne sont héritées
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

'Classe définissant une carte de crédit
Public Class CarteCredit
    Public id As Integer
    Public no As String
    Public dtExprt As Date
    Public codeSecrt As String

    Public Sub New()
    End Sub

End Class