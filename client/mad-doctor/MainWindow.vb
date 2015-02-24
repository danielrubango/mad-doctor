Imports System.Security.Permissions

<PermissionSet(SecurityAction.Demand, Name:="FullTrust")> _
<System.Runtime.InteropServices.ComVisibleAttribute(True)> _
Public Class MainWindow
    Public Ad As ADConnector
    Public user As User


    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        WebBrowser1.ObjectForScripting = Me
        Ad = New ADConnector
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If Not User Is Nothing Then
            Dim args(1) As String
            args(0) = "False"

            WebBrowser1.Document.InvokeScript("setAuthenticated", args)
        End If
    End Sub
End Class
