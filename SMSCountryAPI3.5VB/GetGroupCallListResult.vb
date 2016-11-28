Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class GetGroupCallListResult
        Inherits GenericResult



        Public Property objGetGroupCallList() As List(Of GetGroupCallList)
            Get
                Return m_objGetGroupCallList
            End Get
            Set(value As List(Of GetGroupCallList))
                m_objGetGroupCallList = Value
            End Set
        End Property
        Private m_objGetGroupCallList As List(Of GetGroupCallList)

        Public Property objGetGroupCallSingle() As GetGroupCallList
            Get
                Return m_objGetGroupCallSingle
            End Get
            Set(value As GetGroupCallList)
                m_objGetGroupCallSingle = Value
            End Set
        End Property
        Private m_objGetGroupCallSingle As GetGroupCallList
    End Class

    Public Class GetGroupCallList



        Public Property GroupCallUUID() As String
            Get
                Return m_GroupCallUUID
            End Get
            Set(value As String)
                m_GroupCallUUID = Value
            End Set
        End Property
        Private m_GroupCallUUID As String
        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = Value
            End Set
        End Property
        Private m_Name As String
        Public Property WelcomeSound() As String
            Get
                Return m_WelcomeSound
            End Get
            Set(value As String)
                m_WelcomeSound = Value
            End Set
        End Property
        Private m_WelcomeSound As String
        Public Property WaitSound() As String
            Get
                Return m_WaitSound
            End Get
            Set(value As String)
                m_WaitSound = Value
            End Set
        End Property
        Private m_WaitSound As String
        Public Property StartGroupCallOnEnter() As String
            Get
                Return m_StartGroupCallOnEnter
            End Get
            Set(value As String)
                m_StartGroupCallOnEnter = Value
            End Set
        End Property
        Private m_StartGroupCallOnEnter As String
        Public Property EndGroupCallOnExit() As String
            Get
                Return m_EndGroupCallOnExit
            End Get
            Set(value As String)
                m_EndGroupCallOnExit = Value
            End Set
        End Property
        Private m_EndGroupCallOnExit As String

    End Class

End Namespace
