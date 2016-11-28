Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class GroupCall
        Inherits GenericResult



        Private _Name As String = String.Empty

        Private _WelcomeSound As String = String.Empty

        Private _WaitSound As String = String.Empty

        Private _StartGroupCallOnEnter As String = String.Empty

        Private _EndGroupCallOnExit As String = String.Empty

        Private _AnswerUrl As String = String.Empty
        Private _GroupCallUUID As String = String.Empty

        Private _ParticipantId As String = String.Empty

        Private _File As String = String.Empty
        Private _FileFormat As String = String.Empty

        Private _RecordingUUID As String = String.Empty

        Public Property Name() As String
            Get
                Return Me._Name
            End Get
            Set(value As String)
                Me._Name = value
            End Set
        End Property

        Public Property WelcomeSound() As String
            Get
                Return Me._WelcomeSound
            End Get
            Set(value As String)
                Me._WelcomeSound = value
            End Set
        End Property

        Public Property WaitSound() As String
            Get
                Return Me._WaitSound
            End Get
            Set(value As String)
                Me._WaitSound = value
            End Set
        End Property


        Public Property StartGroupCallOnEnter() As String
            Get
                Return Me._StartGroupCallOnEnter
            End Get
            Set(value As String)
                Me._StartGroupCallOnEnter = value
            End Set
        End Property



        Public Property EndGroupCallOnExit() As String
            Get
                Return Me._EndGroupCallOnExit
            End Get
            Set(value As String)
                Me._EndGroupCallOnExit = value
            End Set
        End Property

        Public Property AnswerUrl() As String
            Get
                Return Me._AnswerUrl
            End Get
            Set(value As String)
                Me._AnswerUrl = value
            End Set
        End Property
        Public Property GroupCallUUID() As String
            Get
                Return Me._GroupCallUUID
            End Get
            Set(value As String)
                Me._GroupCallUUID = value
            End Set
        End Property

        Public Property ParticipantId() As String
            Get
                Return Me._ParticipantId
            End Get
            Set(value As String)
                Me._ParticipantId = value
            End Set
        End Property


        Public Property File() As String
            Get
                Return Me._File
            End Get
            Set(value As String)
                Me._File = value
            End Set
        End Property
        Public Property FileFormat() As String
            Get
                Return Me._FileFormat
            End Get
            Set(value As String)
                Me._FileFormat = value
            End Set
        End Property


        Public Property RecordingUUID() As String
            Get
                Return Me._RecordingUUID
            End Get
            Set(value As String)
                Me._RecordingUUID = value
            End Set
        End Property

        Public Property Participants() As List(Of Participatants)
            Get
                Return m_Participatants
            End Get
            Set(value As List(Of Participatants))
                m_Participatants = Value
            End Set
        End Property
        Private m_Participatants As List(Of Participatants)

    End Class

    Public Class Participatants
        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = Value
            End Set
        End Property
        Private m_Name As String
        Public Property Number() As String
            Get
                Return m_Number
            End Get
            Set(value As String)
                m_Number = Value
            End Set
        End Property
        Private m_Number As String
    End Class



End Namespace
