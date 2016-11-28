Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class Sms
        Private _text As String = String.Empty
        Private _number As String = String.Empty
        Private _numbers As String = String.Empty
        Private _Startdate As String = String.Empty

        Private _Enddate As String = String.Empty
        Private _senderId As String = String.Empty
        Private _drNotifyUrl As String = String.Empty
        Private _drNotifyMethod As String = String.Empty
        Private _messageUUID As String = String.Empty
        Private _tool As String = String.Empty
        Private _status As String = String.Empty
        Private _statusTime As Long = 0
        Private _cost As String = String.Empty



        Public Sub New()
        End Sub
        Public Sub New(text As String, number As String, Optional senderId As String = "", Optional drNotifyUrl As String = "", Optional drNotifyMethod As String = "")
            Me._text = text
            Me._number = number
            Me._senderId = senderId
            Me._drNotifyUrl = drNotifyUrl
            Me._drNotifyMethod = drNotifyMethod
        End Sub
        Public Property Text() As String
            Get
                Return Me._text
            End Get
            Set(value As String)
                Me._text = value
            End Set
        End Property
        Public Property Number() As String
            Get
                Return Me._number
            End Get
            Set(value As String)
                Me._number = value
            End Set
        End Property

        Public Property Numbers() As String
            Get
                Return Me._numbers
            End Get
            Set(value As String)
                Me._numbers = value
            End Set
        End Property
        Public Property SenderId() As String
            Get
                Return Me._senderId
            End Get
            Set(value As String)
                Me._senderId = value
            End Set
        End Property
        Public Property DRNotifyUrl() As String
            Get
                Return Me._drNotifyUrl
            End Get
            Set(value As String)
                Me._drNotifyUrl = value
            End Set
        End Property
        Public Property DRNotifyMethod() As String
            Get
                Return Me._drNotifyMethod
            End Get
            Set(value As String)
                Me._drNotifyMethod = value
            End Set
        End Property
        Public Property MessageUUID() As String
            Get
                Return Me._messageUUID
            End Get
            Set(value As String)
                Me._messageUUID = value
            End Set
        End Property
        Public Property Tool() As String
            Get
                Return Me._tool
            End Get
            Set(value As String)
                Me._tool = value
            End Set
        End Property
        Public Property Status() As String
            Get
                Return Me._status
            End Get
            Set(value As String)
                Me._status = value
            End Set
        End Property
        Public ReadOnly Property StatusTime() As Long
            Get
                Return Me._statusTime
            End Get
        End Property
        Public Property Cost() As String
            Get
                Return Me._cost
            End Get
            Set(value As String)
                Me._cost = value
            End Set
        End Property

        Public Property Startdate() As String
            Get
                Return Me._Startdate
            End Get
            Set(value As String)
                Me._Startdate = value
            End Set
        End Property

        Public Property Enddate() As String
            Get
                Return Me._Enddate
            End Get
            Set(value As String)
                Me._Enddate = value
            End Set
        End Property



    End Class
End Namespace
