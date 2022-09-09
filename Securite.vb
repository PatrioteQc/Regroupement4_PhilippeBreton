Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Module Securite

    'Classe définissant un utilisateur
    Public Class Utilisateur
        Public AuthentificationValide As Boolean
        Public typeAcces As String
        Public Sub New()
        End Sub
    End Class

    'Fonction qui reçoit un mot de passe en clair et qui le retourne sous forme de chaîne de texte encryptée selon la clé d'encryption c43Mek0536k677V
    Public Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "c43Mek0536k677V"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    'Fonction qui reçoit une chaîne de texte encryptée selon la clé d'encryption c43Mek0536k677V et qui retourne le mot de passe en texte clair.
    Public Function Decrypt(cipherText As String) As String
        Dim EncryptionKey As String = "c43Mek0536k677V"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function
End Module
