Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCounTryApi
    Public Class GenericResult
        Private _apiId As String = String.Empty
        Private _success As Boolean = False
        Private _message As String = String.Empty
        'private System.Net.HttpStatusCode _statusCode;
        Private _statusCode As String
        Private _subStatusCode As Byte = 0


        Public Property ApiId() As String
            Get
                Return Me._apiId
            End Get
            Set(ByVal Value As String)
                Me._apiId = value
            End Set
        End Property
        Public Property Success() As Boolean
            Get
                Return Me._success
            End Get
            Set(ByVal Value As Boolean)
                Me._success = value
            End Set
        End Property
        Public Property Message() As String
            Get
                Return Me._message
            End Get
            Set(ByVal Value As String)
                Me._message = value
            End Set
        End Property
        'public System.Net.HttpStatusCode StatusCode
        '{
        '    get { return this._statusCode; }
        '    set { this._statusCode = value; }
        '}

        Public Property StatusCode() As String
            Get
                Return Me._statusCode
            End Get
            Set(ByVal Value As String)
                Me._statusCode = value
            End Set
        End Property
        Public Property SubStatusCode() As Byte
            Get
                Return Me._subStatusCode
            End Get
            Set(ByVal Value As Byte)
                Me._subStatusCode = value
            End Set
        End Property
    End Class
End Namespace
