Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class Group

        Private _Name As String = String.Empty

        Private _TinyName As String = String.Empty

        Private _StartGroupCallOnEnter As String = String.Empty

        Private _EndGroupCallOnExit As String = String.Empty

        Private _Members As String = String.Empty

        Private _groupId As String = String.Empty
        Private _MemberId As String = String.Empty

        Private _Number As String = String.Empty


        'private string _MembersName = string.Empty;

        'private string _MembersNumber = string.Empty;
        Public Property Name() As String
            Get
                Return Me._Name
            End Get
            Set(value As String)
                Me._Name = value
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

        Public Property TinyName() As String
            Get
                Return Me._TinyName
            End Get
            Set(value As String)
                Me._TinyName = value
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

        Public Property MemberId() As String
            Get
                Return Me._MemberId
            End Get
            Set(value As String)
                Me._MemberId = value
            End Set
        End Property
        Public Property Members() As List(Of Members)
            Get
                Return m_Members
            End Get
            Set(value As List(Of Members))
                m_Members = Value
            End Set
        End Property
        Private m_Members As List(Of Members)

        Public Property groupId() As String
            Get
                Return Me._groupId
            End Get
            Set(value As String)
                Me._groupId = value
            End Set
        End Property


    End Class
    'public string Members
    ' {
    '     get { return this._Members; }
    '     set { this._Members = value; }
    '}
    ' public string MembersName
    ' {
    '     get { return this._MembersName; }
    '     set { this._MembersName = value; }
    ' }

    '     public string MembersNumber
    ' {
    '     get { return this._MembersNumber; }
    '     set { this._MembersNumber = value; }
    ' }

    ' }
    Public Class Members
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
