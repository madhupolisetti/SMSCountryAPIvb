Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class CreateBulkCallResult
        Inherits GenericResult
        Private _CallUUIDs As String

        Public Property CallUUID() As String
            Get
                Return Me._CallUUIDs
            End Get
            Set(value As String)
                Me._CallUUIDs = value
            End Set
        End Property
        Public Property CallUUIDs() As List(Of String)
            Get
                Return m_CallUUIDs
            End Get
            Set(value As List(Of String))
                m_CallUUIDs = Value
            End Set
        End Property
        Private m_CallUUIDs As List(Of String)
    End Class
End Namespace

