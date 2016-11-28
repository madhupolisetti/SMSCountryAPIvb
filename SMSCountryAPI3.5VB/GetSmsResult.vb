Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class GetSmsResult
        Inherits GenericResult

        Private _ApiId As String = String.Empty
        Private _Message As String = String.Empty
        Private _MessageUUID As String = String.Empty
        Private _Number As String = String.Empty
        Private _Tool As String = String.Empty
        Private _SenderId As String = String.Empty
        Private _Text As String = String.Empty
        Private _Status As String = String.Empty
        Private _StatusTime As String = String.Empty
        Private _Cost As String = String.Empty
        Private _Success As Boolean

        Public Property MessageUUID() As String
            Get
                Return Me._MessageUUID
            End Get
            Set(value As String)
                Me._MessageUUID = value
            End Set
        End Property
        Public Property ApiId() As String
            Get
                Return Me._ApiId
            End Get
            Set(value As String)
                Me._ApiId = value
            End Set
        End Property
        Public Property Message() As String
            Get
                Return Me._Message
            End Get
            Set(value As String)
                Me._Message = value
            End Set
        End Property

        Public Property Number() As String
            Get
                Return Me._Number
            End Get
            Set(value As String)
                Me._Number = value
            End Set
        End Property
        Public Property Tool() As String
            Get
                Return Me._Tool
            End Get
            Set(value As String)
                Me._Tool = value
            End Set
        End Property
        Public Property SenderId() As String
            Get
                Return Me._SenderId
            End Get
            Set(value As String)
                Me._SenderId = value
            End Set
        End Property

        Public Property Text() As String
            Get
                Return Me._Text
            End Get
            Set(value As String)
                Me._Text = value
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
        Public Property StatusTime() As String
            Get
                Return Me._StatusTime
            End Get
            Set(value As String)
                Me._StatusTime = value
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

        Public Property Success() As Boolean
            Get
                Return Me._Success
            End Get
            Set(value As Boolean)
                Me._Success = value
            End Set
        End Property

    End Class


End Namespace
