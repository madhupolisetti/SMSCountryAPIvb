Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class GetUnmuteMuteAllParticipantsinaGroupCall
        Inherits GenericResult

        Public Property FailedParticipantIds() As String
            Get
                Return m_FailedParticipantIds
            End Get
            Set(value As String)
                m_FailedParticipantIds = Value
            End Set
        End Property
        Private m_FailedParticipantIds As String
    End Class
End Namespace

