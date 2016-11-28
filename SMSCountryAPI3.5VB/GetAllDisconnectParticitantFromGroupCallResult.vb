Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class GetAllDisconnectParticitantFromGroupCallResult
        Inherits GenericResult
        Public Property AfftectedParticipantIds() As String
            Get
                Return m_AfftectedParticipantIds
            End Get
            Set(value As String)
                m_AfftectedParticipantIds = Value
            End Set
        End Property
        Private m_AfftectedParticipantIds As String
    End Class
End Namespace

