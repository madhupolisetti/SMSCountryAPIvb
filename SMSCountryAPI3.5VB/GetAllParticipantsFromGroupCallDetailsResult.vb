Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi


    Public Class fff
        Public Property Participants() As List(Of GetAllParticipantsFromGroupCallDetailsResult)
            Get
                Return m_Participants
            End Get
            Set(value As List(Of GetAllParticipantsFromGroupCallDetailsResult))
                m_Participants = Value
            End Set
        End Property
        Private m_Participants As List(Of GetAllParticipantsFromGroupCallDetailsResult)
    End Class





    Public Class CallParticipant
        Public Property CallStatus() As String
            Get
                Return m_CallStatus
            End Get
            Set(value As String)
                m_CallStatus = Value
            End Set
        End Property
        Private m_CallStatus As String
        Public Property AnswerTime() As String
            Get
                Return m_AnswerTime
            End Get
            Set(value As String)
                m_AnswerTime = Value
            End Set
        End Property
        Private m_AnswerTime As String
        Public Property EndTime() As String
            Get
                Return m_EndTime
            End Get
            Set(value As String)
                m_EndTime = Value
            End Set
        End Property
        Private m_EndTime As String
        Public Property EndReason() As String
            Get
                Return m_EndReason
            End Get
            Set(value As String)
                m_EndReason = Value
            End Set
        End Property
        Private m_EndReason As String
        Public Property Cost() As String
            Get
                Return m_Cost
            End Get
            Set(value As String)
                m_Cost = Value
            End Set
        End Property
        Private m_Cost As String
        Public Property Pulse() As Integer
            Get
                Return m_Pulse
            End Get
            Set(value As Integer)
                m_Pulse = Value
            End Set
        End Property
        Private m_Pulse As Integer
        Public Property PricePerPulse() As Double
            Get
                Return m_PricePerPulse
            End Get
            Set(value As Double)
                m_PricePerPulse = Value
            End Set
        End Property
        Private m_PricePerPulse As Double
    End Class

    Public Class GetAllParticipantsFromGroupCallDetailsResult
        Inherits GenericResult
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
        Public Property Calls() As List(Of CallParticipant)
            Get
                Return m_Calls
            End Get
            Set(value As List(Of CallParticipant))
                m_Calls = Value
            End Set
        End Property
        Private m_Calls As List(Of CallParticipant)
    End Class



End Namespace
