Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi


    Public Class GetAllRecordingDetailsOfaGroupCallRecord
        Inherits GenericResult
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


End Namespace

