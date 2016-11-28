Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class SendSmsResult
        Inherits GenericResult
        Private _MessageUUID As String = String.Empty

        Public Property MessageUUID() As String
            Get
                Return Me._MessageUUID
            End Get
            Set(value As String)
                Me._MessageUUID = value
            End Set
        End Property

        Public Property MessageUUIDs() As List(Of String)
            Get
                Return m_MessageUUIDs
            End Get
            Set(value As List(Of String))
                m_MessageUUIDs = Value
            End Set
        End Property
        Private m_MessageUUIDs As List(Of String)

        Public Property BatchId() As String
            Get
                Return m_BatchId
            End Get
            Set(value As String)
                m_BatchId = Value
            End Set
        End Property
        Private m_BatchId As String



    End Class





End Namespace

