Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Public Class GetCreateGroupCallResult
        Inherits GenericResult
        Public Property GroupCall() As GroupCall
            Get
                Return m_GroupCall
            End Get
            Set(value As GroupCall)
                m_GroupCall = Value
            End Set
        End Property
        Private m_GroupCall As GroupCall

    End Class
End Namespace

