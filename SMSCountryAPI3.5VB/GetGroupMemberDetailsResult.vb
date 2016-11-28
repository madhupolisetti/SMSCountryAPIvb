Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class GetGroupMemberDetailsResult
        Inherits GenericResult


        Public Property objGetGroupMemberDetailsSingle() As GetGroupMemberDetailsList
            Get
                Return m_objGetGroupMemberDetailsSingle
            End Get
            Set(value As GetGroupMemberDetailsList)
                m_objGetGroupMemberDetailsSingle = Value
            End Set
        End Property
        Private m_objGetGroupMemberDetailsSingle As GetGroupMemberDetailsList

        Public Property objGetGroupMemberDetailsList() As List(Of GetGroupMemberDetailsList)
            Get
                Return m_objGetGroupMemberDetailsList
            End Get
            Set(value As List(Of GetGroupMemberDetailsList))
                m_objGetGroupMemberDetailsList = Value
            End Set
        End Property
        Private m_objGetGroupMemberDetailsList As List(Of GetGroupMemberDetailsList)

    End Class


    Public Class GetGroupMemberDetailsList


        Public Property Id() As String
            Get
                Return m_Id
            End Get
            Set(value As String)
                m_Id = Value
            End Set
        End Property
        Private m_Id As String
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

