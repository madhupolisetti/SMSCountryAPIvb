Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class CallList


        Public Property CallStatus() As String
            Get
                Return m_CallStatus
            End Get
            Set(value As String)
                m_CallStatus = Value
            End Set
        End Property
        Private m_CallStatus As String
        Public Property EndReason() As String
            Get
                Return m_EndReason
            End Get
            Set(value As String)
                m_EndReason = Value
            End Set
        End Property
        Private m_EndReason As String
        Public Property AnswerTime() As Object
            Get
                Return m_AnswerTime
            End Get
            Set(value As Object)
                m_AnswerTime = Value
            End Set
        End Property
        Private m_AnswerTime As Object
        Public Property EndTime() As String
            Get
                Return m_EndTime
            End Get
            Set(value As String)
                m_EndTime = Value
            End Set
        End Property
        Private m_EndTime As String
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
    Public Class GetaparticipantDetailsFromGroupCallList
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
        Public Property Calls() As List(Of CallList)
            Get
                Return m_Calls
            End Get
            Set(value As List(Of CallList))
                m_Calls = Value
            End Set
        End Property
        Private m_Calls As List(Of CallList)
    End Class

    Public Class GetaparticipantDetailsFromGroupCallResult
        Inherits GenericResult
        Public Property objGetaparticipantDetailsFromGroupCallList() As List(Of GetaparticipantDetailsFromGroupCallList)
            Get
                Return m_objGetaparticipantDetailsFromGroupCallList
            End Get
            Set(value As List(Of GetaparticipantDetailsFromGroupCallList))
                m_objGetaparticipantDetailsFromGroupCallList = Value
            End Set
        End Property
        Private m_objGetaparticipantDetailsFromGroupCallList As List(Of GetaparticipantDetailsFromGroupCallList)
        Public Property objGetaparticipantDetailsFromGroupCallSingle() As GetaparticipantDetailsFromGroupCallList
            Get
                Return m_objGetaparticipantDetailsFromGroupCallSingle
            End Get
            Set(value As GetaparticipantDetailsFromGroupCallList)
                m_objGetaparticipantDetailsFromGroupCallSingle = Value
            End Set
        End Property
        Private m_objGetaparticipantDetailsFromGroupCallSingle As GetaparticipantDetailsFromGroupCallList
    End Class

End Namespace

