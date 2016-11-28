Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class GetRecordingDetailsOfaGroupCallRecord
        Inherits GenericResult
        Public Property objGetRecordingDetailsOfaGroupCallList() As List(Of GetRecordingDetailsOfaGroupCallList)
            Get
                Return m_objGetRecordingDetailsOfaGroupCallList
            End Get
            Set(value As List(Of GetRecordingDetailsOfaGroupCallList))
                m_objGetRecordingDetailsOfaGroupCallList = Value
            End Set
        End Property
        Private m_objGetRecordingDetailsOfaGroupCallList As List(Of GetRecordingDetailsOfaGroupCallList)
        Public Property objGetRecordingDetailsOfaGroupCallSingle() As GetSingleRecordingDetailsOfaGroupCallList
            Get
                Return m_objGetRecordingDetailsOfaGroupCallSingle
            End Get
            Set(value As GetSingleRecordingDetailsOfaGroupCallList)
                m_objGetRecordingDetailsOfaGroupCallSingle = Value
            End Set
        End Property
        Private m_objGetRecordingDetailsOfaGroupCallSingle As GetSingleRecordingDetailsOfaGroupCallList
    End Class

    Public Class GetRecordingDetailsOfaGroupCallList
        Public Property UUID() As String
            Get
                Return m_UUID
            End Get
            Set(value As String)
                m_UUID = Value
            End Set
        End Property
        Private m_UUID As String
        Public Property Url() As String
            Get
                Return m_Url
            End Get
            Set(value As String)
                m_Url = Value
            End Set
        End Property
        Private m_Url As String
    End Class

    Public Class GetSingleRecordingDetailsOfaGroupCallList
        Public Property RecordingID() As String
            Get
                Return m_RecordingID
            End Get
            Set(value As String)
                m_RecordingID = Value
            End Set
        End Property
        Private m_RecordingID As String
        Public Property Url() As String
            Get
                Return m_Url
            End Get
            Set(value As String)
                m_Url = Value
            End Set
        End Property
        Private m_Url As String
    End Class

End Namespace
