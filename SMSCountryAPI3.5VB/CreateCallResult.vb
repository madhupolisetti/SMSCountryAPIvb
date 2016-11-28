Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class CreateCallResult
        Inherits GenericResult
        Private _CallUUID As String = String.Empty

        Public Property CallUUID() As String
            Get
                Return Me._CallUUID
            End Get
            Set(value As String)
                Me._CallUUID = value
            End Set
        End Property
    End Class
End Namespace
