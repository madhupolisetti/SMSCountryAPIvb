Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class GetCallDetailsCollectionResult
        Inherits GenericResult

        Public Property objGetCallDetailsCollectionSingle() As GetCallDetailsCollectionList
            Get
                Return m_objGetCallDetailsCollectionSingle
            End Get
            Set(value As GetCallDetailsCollectionList)
                m_objGetCallDetailsCollectionSingle = Value
            End Set
        End Property
        Private m_objGetCallDetailsCollectionSingle As GetCallDetailsCollectionList
        Public Property objGetCallDetailsCollectionList() As List(Of GetCallDetailsCollectionList)
            Get
                Return m_objGetCallDetailsCollectionList
            End Get
            Set(value As List(Of GetCallDetailsCollectionList))
                m_objGetCallDetailsCollectionList = Value
            End Set
        End Property
        Private m_objGetCallDetailsCollectionList As List(Of GetCallDetailsCollectionList)

        Private _Next As String = String.Empty
        Public Property [Next]() As String
            Get
                Return Me._Next
            End Get
            Set(value As String)
                Me._Next = value
            End Set
        End Property

    End Class

    Public Class GetCallDetailsCollectionList

        Private _Number As String = String.Empty
        Private _CallUUID As String = String.Empty
        Private _CallerId As String = String.Empty
        Private _Status As String = String.Empty
        Private _RingTime As String = String.Empty
        Private _AnswerTime As String = String.Empty
        Private _EndTime As String = String.Empty
        Private _EndReason As String = String.Empty
        Private _Cost As String = String.Empty
        Private _Direction As String = String.Empty
        Private _Pulse As String = String.Empty
        Private _Pulses As String = String.Empty
        Private _PricePerPulse As String = String.Empty


        Public Property Number() As String
            Get
                Return Me._Number
            End Get
            Set(value As String)
                Me._Number = value
            End Set
        End Property
        Public Property CallUUID() As String
            Get
                Return Me._CallUUID
            End Get
            Set(value As String)
                Me._CallUUID = value
            End Set
        End Property
        Public Property CallerId() As String
            Get
                Return Me._CallerId
            End Get
            Set(value As String)
                Me._CallerId = value
            End Set
        End Property

        Public Property Status() As String
            Get
                Return Me._Status
            End Get
            Set(value As String)
                Me._Status = value
            End Set
        End Property
        Public Property RingTime() As String
            Get
                Return Me._RingTime
            End Get
            Set(value As String)
                Me._RingTime = value
            End Set
        End Property
        Public Property AnswerTime() As String
            Get
                Return Me._AnswerTime
            End Get
            Set(value As String)
                Me._AnswerTime = value
            End Set
        End Property

        Public Property EndTime() As String
            Get
                Return Me._EndTime
            End Get
            Set(value As String)
                Me._EndTime = value
            End Set
        End Property
        Public Property EndReason() As String
            Get
                Return Me._EndReason
            End Get
            Set(value As String)
                Me._EndReason = value
            End Set
        End Property
        Public Property Cost() As String
            Get
                Return Me._Cost
            End Get
            Set(value As String)
                Me._Cost = value
            End Set
        End Property

        Public Property Direction() As String
            Get
                Return Me._Direction
            End Get
            Set(value As String)
                Me._Direction = value
            End Set
        End Property

        Public Property Pulses() As String
            Get
                Return Me._Pulses
            End Get
            Set(value As String)
                Me._Pulses = value
            End Set
        End Property
        Public Property Pulse() As String
            Get
                Return Me._Pulse
            End Get
            Set(value As String)
                Me._Pulse = value
            End Set
        End Property
        Public Property PricePerPulse() As String
            Get
                Return Me._PricePerPulse
            End Get
            Set(value As String)
                Me._PricePerPulse = value
            End Set
        End Property

    End Class
End Namespace

