Imports System.DirectoryServices
Imports System.Security.Permissions

''' <summary>
''' Connector to Active Directory services
''' </summary>
''' <remarks></remarks>
<PermissionSet(SecurityAction.Demand, Name:="FullTrust")> _
<System.Runtime.InteropServices.ComVisibleAttribute(True)> _
Public Class ADConnector

    ''' <summary>
    ''' Authenticates a user usin his credentials.
    ''' </summary>
    ''' <param name="username">The username</param>
    ''' <param name="password">The password</param>
    ''' <returns>True if the user exists and has provided valid credentials</returns>
    ''' <remarks></remarks>
    Public Function Authenticate(ByVal username As String, ByVal password As String) As Boolean

        Dim result As Boolean = False

        Dim Entry As New DirectoryEntry()
        Entry.Path = "LDAP://inss.local"
        Entry.Username = username
        Entry.Password = password

        Dim Searcher As New DirectorySearcher(Entry)
        Searcher.PropertiesToLoad.Add("givenName")
        Searcher.PropertiesToLoad.Add("mail")
        Searcher.PropertiesToLoad.Add("userWorkstations")
        Searcher.PropertiesToLoad.Add("givenName")

        Searcher.SearchScope = SearchScope.OneLevel

        Try
            Dim SearchResult As SearchResult = Searcher.FindOne
            result = Not (SearchResult Is Nothing)

        Catch ex As Exception
            result = False
        End Try

        Return result

    End Function
End Class
