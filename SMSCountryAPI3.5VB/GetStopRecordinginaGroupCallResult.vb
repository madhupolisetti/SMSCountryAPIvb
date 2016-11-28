Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class GetStopRecordinginaGroupCallResult
        Inherits GenericResult
        Public Property AffetcedRecordingUUIDs() As String
            Get
                Return m_AffetcedRecordingUUIDs
            End Get
            Set(value As String)
                m_AffetcedRecordingUUIDs = Value
            End Set
        End Property
        Private m_AffetcedRecordingUUIDs As String


    End Class
End Namespace

