Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class GetCreateNewGroup
        Private _Id As String = String.Empty

        Private _Name As String = String.Empty

        Private _EndGroupCallOnExit As String = String.Empty
        Private _StartGroupCallOnEnter As String = String.Empty
        Private _TinyName As String = String.Empty

        Public Property Id() As String
            Get
                Return Me._Id
            End Get
            Set(value As String)
                Me._Id = value
            End Set
        End Property


        Public Property Name() As String
            Get
                Return Me._Name
            End Get
            Set(value As String)
                Me._Name = value
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

        Public Property StartGroupCallOnEnter() As String
            Get
                Return Me._StartGroupCallOnEnter
            End Get
            Set(value As String)
                Me._StartGroupCallOnEnter = value
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
        Public Property Members() As List(Of Member)
            Get
                Return m_Members
            End Get
            Set(value As List(Of Member))
                m_Members = Value
            End Set
        End Property
        Private m_Members As List(Of Member)


    End Class

    Public Class Member
        Public Property Id() As Integer
            Get
                Return m_Id
            End Get
            Set(value As Integer)
                m_Id = Value
            End Set
        End Property
        Private m_Id As Integer
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
        Public Property Mobile() As String
            Get
                Return m_Mobile
            End Get
            Set(value As String)
                m_Mobile = Value
            End Set
        End Property
        Private m_Mobile As String
    End Class


    Public Class GetCreateNewGroupResult
        Inherits GenericResult

        Public Property objGetCreateNewGroup() As GetCreateNewGroup
            Get
                Return m_objGetCreateNewGroup
            End Get
            Set(value As GetCreateNewGroup)
                m_objGetCreateNewGroup = Value
            End Set
        End Property
        Private m_objGetCreateNewGroup As GetCreateNewGroup


    End Class
End Namespace

