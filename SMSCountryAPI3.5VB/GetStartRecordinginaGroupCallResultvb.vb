Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi

    Public Class GetStartRecordinginaGroupCallResult
        Inherits GenericResult
        Public Property objGetStartRecordinginaGroupCall() As GetStartRecordinginaGroupCall
            Get
                Return m_objGetStartRecordinginaGroupCall
            End Get
            Set(value As GetStartRecordinginaGroupCall)
                m_objGetStartRecordinginaGroupCall = Value
            End Set
        End Property
        Private m_objGetStartRecordinginaGroupCall As GetStartRecordinginaGroupCall
        Public Property objGetStartRecordinginaGroupCallList() As List(Of GetStartRecordinginaGroupCall)
            Get
                Return m_objGetStartRecordinginaGroupCallList
            End Get
            Set(value As List(Of GetStartRecordinginaGroupCall))
                m_objGetStartRecordinginaGroupCallList = Value
            End Set
        End Property
        Private m_objGetStartRecordinginaGroupCallList As List(Of GetStartRecordinginaGroupCall)
    End Class


    Public Class GetStartRecordinginaGroupCall
        Public Property RecordingUUID() As String
            Get
                Return m_RecordingUUID
            End Get
            Set(value As String)
                m_RecordingUUID = Value
            End Set
        End Property
        Private m_RecordingUUID As String
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
