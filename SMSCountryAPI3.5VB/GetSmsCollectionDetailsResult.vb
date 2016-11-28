Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class GetSmsCollectionDetailsList
        Public Property ToolName() As String
            Get
                Return m_Tool
            End Get
            Set(value As String)
                m_Tool = value
            End Set
        End Property



        Private m_Tool As String




        Public Property Tool() As String
            Get
                Return m_Tools
            End Get
            Set(value As String)
                m_Tools = value
            End Set
        End Property
        Private m_Tools As String




        Public Property Number() As String
            Get
                Return m_Number
            End Get
            Set(value As String)
                m_Number = Value
            End Set
        End Property
        Private m_Number As String


        Public Property MessageUUID() As String
            Get
                Return m_MessageUUID
            End Get
            Set(value As String)
                m_MessageUUID = Value
            End Set
        End Property
        Private m_MessageUUID As String
        Public Property Text() As String
            Get
                Return m_Text
            End Get
            Set(value As String)
                m_Text = Value
            End Set
        End Property
        Private m_Text As String
        Public Property SenderId() As String
            Get
                Return m_SenderId
            End Get
            Set(value As String)
                m_SenderId = Value
            End Set
        End Property
        Private m_SenderId As String
        Public Property Cost() As String
            Get
                Return m_Cost
            End Get
            Set(value As String)
                m_Cost = Value
            End Set
        End Property
        Private m_Cost As String
        Public Property Status() As String
            Get
                Return m_Status
            End Get
            Set(value As String)
                m_Status = Value
            End Set
        End Property
        Private m_Status As String
        Public Property StatusTime() As String
            Get
                Return m_StatusTime
            End Get
            Set(value As String)
                m_StatusTime = Value
            End Set
        End Property
        Private m_StatusTime As String


    End Class


    Public Class GetSmsCollectionDetailsResult
        Inherits GenericResult

        Public Property [Next]() As String
            Get
                Return m_Next
            End Get
            Set(value As String)
                m_Next = Value
            End Set
        End Property
        Private m_Next As String

        Public Property objSinlgeSMS() As GetSmsCollectionDetailsList
            Get
                Return m_objSinlgeSMS
            End Get
            Set(value As GetSmsCollectionDetailsList)
                m_objSinlgeSMS = Value
            End Set
        End Property
        Private m_objSinlgeSMS As GetSmsCollectionDetailsList
        Public Property objGetSmsCollectionDetailsList() As List(Of GetSmsCollectionDetailsList)
            Get
                Return m_objGetSmsCollectionDetailsList
            End Get
            Set(value As List(Of GetSmsCollectionDetailsList))
                m_objGetSmsCollectionDetailsList = Value
            End Set
        End Property
        Private m_objGetSmsCollectionDetailsList As List(Of GetSmsCollectionDetailsList)

    End Class


End Namespace
