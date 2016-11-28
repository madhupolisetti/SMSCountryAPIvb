Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json
Namespace SMSCountryApi
    Class HttpClient
        Public authorizationHeader1 As String = String.Empty
        Public Function SendData(url As String, httpMethod As String, payload As String, requestHeaders As Dictionary(Of String, String)) As JObject
            Dim result As JObject = Nothing
            Dim request As HttpWebRequest = Nothing
            Dim response As HttpWebResponse = Nothing
            Dim streamReader As StreamReader = Nothing
            Dim streamWriter As StreamWriter = Nothing
            Try
                request = DirectCast(WebRequest.Create(url), HttpWebRequest)
                If httpMethod.Equals("POST", StringComparison.CurrentCultureIgnoreCase) Then
                    request.Method = "POST"
                    request.ContentType = "application/json"
                    request.Headers.Add("authorization", authorizationHeader1)
                    streamWriter = New StreamWriter(request.GetRequestStream())
                    streamWriter.Write(payload)
                    streamWriter.Flush()
                    streamWriter.Close()
                End If
                response = DirectCast(request.GetResponse(), HttpWebResponse)
                streamReader = New StreamReader(response.GetResponseStream())
                result = JObject.Parse(streamReader.ReadToEnd())
                streamReader.Close()

                result.Add(New JProperty("StatusCode", CInt(response.StatusCode)))
            Catch e As WebException
                response = DirectCast(e.Response, HttpWebResponse)
                streamReader = New StreamReader(e.Response.GetResponseStream())
                result = JObject.Parse(streamReader.ReadToEnd())
                streamReader.Close()

                result.Add(New JProperty("StatusCode", CInt(response.StatusCode)))
            Finally
                request = Nothing
                response = Nothing
            End Try
            Return result
        End Function

        Public Function GetData(url As String, httpMethod As String, payload As String, requestHeaders As Dictionary(Of String, String)) As JObject
            Dim result As JObject = Nothing
            Dim request As HttpWebRequest = Nothing
            Dim response As HttpWebResponse = Nothing
            Dim streamReader As StreamReader = Nothing

            Try
                request = DirectCast(WebRequest.Create(url), HttpWebRequest)
                If httpMethod.Equals("GET", StringComparison.CurrentCultureIgnoreCase) Then
                    request.Method = "GET"
                    request.Headers.Add("authorization", authorizationHeader1)
                End If
                response = DirectCast(request.GetResponse(), HttpWebResponse)

                streamReader = New StreamReader(response.GetResponseStream())
                ' string responseText = streamReader.ReadToEnd();

                result = JObject.Parse(streamReader.ReadToEnd())
                streamReader.Close()


                result.Add(New JProperty("StatusCode", CInt(response.StatusCode)))
            Catch e As WebException
                response = DirectCast(e.Response, HttpWebResponse)
                streamReader = New StreamReader(e.Response.GetResponseStream())

                result = JObject.Parse(streamReader.ReadToEnd())
                streamReader.Close()
                result.Add(New JProperty("StatusCode", CInt(response.StatusCode)))
            Finally
                request = Nothing
                response = Nothing
            End Try
            Return result
        End Function


        Public Function SendGroupData(url As String, httpMethod As String, payload As String, requestHeaders As Dictionary(Of String, String)) As JObject
            Dim result As JObject = Nothing
            Dim request As HttpWebRequest = Nothing
            Dim response As HttpWebResponse = Nothing
            Dim streamReader As StreamReader = Nothing
            Dim streamWriter As StreamWriter = Nothing
            Try
                request = DirectCast(WebRequest.Create(url), HttpWebRequest)
                If httpMethod.Equals("POST", StringComparison.CurrentCultureIgnoreCase) Then

                    request.Method = "POST"
                    request.ContentType = "application/json"
                    request.Headers.Add("authorization", authorizationHeader1)
                    streamWriter = New StreamWriter(request.GetRequestStream())
                    streamWriter.Write(payload)
                    streamWriter.Flush()
                    streamWriter.Close()
                End If
                response = DirectCast(request.GetResponse(), HttpWebResponse)
                streamReader = New StreamReader(response.GetResponseStream())
                result = JObject.Parse(streamReader.ReadToEnd())
                streamReader.Close()
                result.Add(New JProperty("StatusCode", CInt(response.StatusCode)))
            Catch e As WebException
                response = DirectCast(e.Response, HttpWebResponse)
                streamReader = New StreamReader(e.Response.GetResponseStream())
                result = JObject.Parse(streamReader.ReadToEnd())
                streamReader.Close()
                result.Add(New JProperty("StatusCode", CInt(response.StatusCode)))
            Finally
                request = Nothing
                response = Nothing
            End Try
            Return result
        End Function


        Protected Class GroupSMS
            Public Property Text() As String
                Get
                    Return m_Text
                End Get
                Set(value As String)
                    m_Text = Value
                End Set
            End Property
            Private m_Text As String
            Public Property Numbers() As List(Of String)
                Get
                    Return m_Numbers
                End Get
                Set(value As List(Of String))
                    m_Numbers = Value
                End Set
            End Property
            Private m_Numbers As List(Of String)
        End Class

        Public Function DisconnectData(url As String, httpMethod As String, payload As String, requestHeaders As Dictionary(Of String, String)) As JObject
            Dim result As JObject = Nothing
            Dim request As HttpWebRequest = Nothing
            Dim response As HttpWebResponse = Nothing
            Dim streamReader As StreamReader = Nothing
            Dim streamWriter As StreamWriter = Nothing
            Try
                request = DirectCast(WebRequest.Create(url), HttpWebRequest)
                If httpMethod.Equals("PATCH", StringComparison.CurrentCultureIgnoreCase) Then
                    request.Method = "PATCH"
                    request.ContentType = "application/json"
                    request.Headers.Add("authorization", authorizationHeader1)
                    streamWriter = New StreamWriter(request.GetRequestStream())
                    streamWriter.Write(payload)
                    streamWriter.Flush()
                    streamWriter.Close()
                End If
                response = DirectCast(request.GetResponse(), HttpWebResponse)
                streamReader = New StreamReader(response.GetResponseStream())
                result = JObject.Parse(streamReader.ReadToEnd())
                streamReader.Close()
                result.Add(New JProperty("StatusCode", CInt(response.StatusCode)))
            Catch e As WebException
                response = DirectCast(e.Response, HttpWebResponse)
                streamReader = New StreamReader(e.Response.GetResponseStream())
                result = JObject.Parse(streamReader.ReadToEnd())
                streamReader.Close()
                result.Add(New JProperty("StatusCode", CInt(response.StatusCode)))
            Finally
                request = Nothing
                response = Nothing
            End Try
            Return result
        End Function


        Public Function UpdateData(url As String, httpMethod As String, payload As String, requestHeaders As Dictionary(Of String, String)) As JObject
            Dim result As JObject = Nothing
            Dim request As HttpWebRequest = Nothing
            Dim response As HttpWebResponse = Nothing
            Dim streamReader As StreamReader = Nothing
            Dim streamWriter As StreamWriter = Nothing
            Try
                request = DirectCast(WebRequest.Create(url), HttpWebRequest)
                If httpMethod.Equals("PATCH", StringComparison.CurrentCultureIgnoreCase) Then
                    request.Method = "PATCH"
                    request.ContentType = "application/json"
                    request.Headers.Add("authorization", authorizationHeader1)
                    streamWriter = New StreamWriter(request.GetRequestStream())
                    streamWriter.Write(payload)
                    streamWriter.Flush()
                    streamWriter.Close()
                End If
                response = DirectCast(request.GetResponse(), HttpWebResponse)
                streamReader = New StreamReader(response.GetResponseStream())
                result = JObject.Parse(streamReader.ReadToEnd())
                streamReader.Close()
                result.Add(New JProperty("StatusCode", CInt(response.StatusCode)))
            Catch e As WebException
                response = DirectCast(e.Response, HttpWebResponse)
                streamReader = New StreamReader(e.Response.GetResponseStream())
                result = JObject.Parse(streamReader.ReadToEnd())
                streamReader.Close()
                result.Add(New JProperty("StatusCode", CInt(response.StatusCode)))
            Finally
                request = Nothing
                response = Nothing
            End Try
            Return result
        End Function


        Public Function PatchData(url As String, httpMethod As String, payload As String, requestHeaders As Dictionary(Of String, String)) As JObject
            Dim result As JObject = Nothing
            Dim request As HttpWebRequest = Nothing
            Dim response As HttpWebResponse = Nothing
            Dim streamReader As StreamReader = Nothing
            Dim streamWriter As StreamWriter = Nothing
            Try
                request = DirectCast(WebRequest.Create(url), HttpWebRequest)
                If httpMethod.Equals("PATCH", StringComparison.CurrentCultureIgnoreCase) Then
                    request.Method = "PATCH"
                    request.ContentType = "application/json"
                    request.Headers.Add("authorization", authorizationHeader1)
                    streamWriter = New StreamWriter(request.GetRequestStream())
                    streamWriter.Write(payload)
                    streamWriter.Flush()
                    streamWriter.Close()
                End If
                response = DirectCast(request.GetResponse(), HttpWebResponse)
                streamReader = New StreamReader(response.GetResponseStream())
                result = JObject.Parse(streamReader.ReadToEnd())
                streamReader.Close()
                result.Add(New JProperty("StatusCode", CInt(response.StatusCode)))
            Catch e As WebException
                response = DirectCast(e.Response, HttpWebResponse)
                Dim onjResult As New GenericResult()
                onjResult.StatusCode = CInt(response.StatusCode).ToString()

                onjResult.Message = response.StatusDescription
                Dim s As String = JsonConvert.SerializeObject(onjResult)
                result = JObject.Parse(s)
            Finally
                request = Nothing
                response = Nothing
            End Try
            Return result
        End Function


        Public Function DeleteData(url As String, httpMethod As String, payload As String, requestHeaders As Dictionary(Of String, String)) As JObject
            Dim result As JObject = Nothing
            Dim request As HttpWebRequest = Nothing
            Dim response As HttpWebResponse = Nothing
            Dim streamReader As StreamReader = Nothing
            Dim streamWriter As StreamWriter = Nothing
            Try
                request = DirectCast(WebRequest.Create(url), HttpWebRequest)
                If httpMethod.Equals("DELETE", StringComparison.CurrentCultureIgnoreCase) Then
                    request.Method = "DELETE"
                    request.ContentType = "application/json"
                    request.Headers.Add("authorization", authorizationHeader1)
                    streamWriter = New StreamWriter(request.GetRequestStream())
                    streamWriter.Write(payload)
                    streamWriter.Flush()
                    streamWriter.Close()
                End If
                response = DirectCast(request.GetResponse(), HttpWebResponse)


                Dim onjResult As New GenericResult()
                onjResult.StatusCode = CInt(response.StatusCode).ToString()

                onjResult.Message = response.StatusDescription
                onjResult.Success = True
                Dim s As String = JsonConvert.SerializeObject(onjResult)
                ' result.Add(new JProperty("StatusCode", response.StatusCode));
                result = JObject.Parse(s)
            Catch e As WebException
                response = DirectCast(e.Response, HttpWebResponse)
                Dim onjResult As New GenericResult()
                onjResult.StatusCode = CInt(response.StatusCode).ToString()

                onjResult.Message = response.StatusDescription
                Dim s As String = JsonConvert.SerializeObject(onjResult)
                '  result.Add(new JProperty("StatusCode", response.StatusCode));
                result = JObject.Parse(s)
            Finally
                request = Nothing
                response = Nothing
            End Try
            Return result

        End Function

        Public Function DeleteDataResponse(url As String, httpMethod As String, payload As String, requestHeaders As Dictionary(Of String, String)) As JObject
            Dim result As JObject = Nothing
            Dim request As HttpWebRequest = Nothing
            Dim response As HttpWebResponse = Nothing
            Dim streamReader As StreamReader = Nothing
            Dim streamWriter As StreamWriter = Nothing
            Try
                request = DirectCast(WebRequest.Create(url), HttpWebRequest)
                If httpMethod.Equals("DELETE", StringComparison.CurrentCultureIgnoreCase) Then
                    request.Method = "DELETE"
                    request.ContentType = "application/json"
                    request.Headers.Add("authorization", authorizationHeader1)
                    streamWriter = New StreamWriter(request.GetRequestStream())
                    streamWriter.Write(payload)
                    streamWriter.Flush()
                    streamWriter.Close()
                End If
                response = DirectCast(request.GetResponse(), HttpWebResponse)
                streamReader = New StreamReader(response.GetResponseStream())
                result = JObject.Parse(streamReader.ReadToEnd())
                streamReader.Close()
                result.Add(New JProperty("StatusCode", CInt(response.StatusCode)))
            Catch e As WebException
                response = DirectCast(e.Response, HttpWebResponse)
                streamReader = New StreamReader(e.Response.GetResponseStream())
                result = JObject.Parse(streamReader.ReadToEnd())
                '  result.Add(new JProperty("StatusCode", response.StatusCode));
                streamReader.Close()
            Finally
                request = Nothing
                response = Nothing
            End Try
            Return result
        End Function


        Public Sub AuthorizationHeader(authKey As String, authToken As String)
            Try
                Dim toEncodeAsBytes As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(authKey & ":" & authToken)
                Dim base64 As String = System.Convert.ToBase64String(toEncodeAsBytes)

                authorizationHeader1 = "Basic " & base64
            Catch ex As Exception
                authorizationHeader1 = ""
            End Try
        End Sub

        Public Function PatchDataDisconnectparticipitant(url As String, httpMethod As String, payload As String, requestHeaders As Dictionary(Of String, String)) As JObject
            Dim result As JObject = Nothing
            Dim request As HttpWebRequest = Nothing
            Dim response As HttpWebResponse = Nothing
            Dim streamReader As StreamReader = Nothing
            Dim streamWriter As StreamWriter = Nothing
            Try
                request = DirectCast(WebRequest.Create(url), HttpWebRequest)
                If httpMethod.Equals("PATCH", StringComparison.CurrentCultureIgnoreCase) Then
                    request.Method = "PATCH"
                    request.ContentType = "application/json"
                    request.Headers.Add("authorization", authorizationHeader1)
                    streamWriter = New StreamWriter(request.GetRequestStream())
                    streamWriter.Write(payload)
                    streamWriter.Flush()
                    streamWriter.Close()
                End If
                response = DirectCast(request.GetResponse(), HttpWebResponse)
                streamReader = New StreamReader(response.GetResponseStream())
                result = JObject.Parse(streamReader.ReadToEnd())
                streamReader.Close()
                result.Add(New JProperty("StatusCode", CInt(response.StatusCode)))
            Catch e As WebException
                response = DirectCast(e.Response, HttpWebResponse)

                '   streamReader = new StreamReader(e.Response.GetResponseStream());
                Dim onjResult As New GenericResult()
                onjResult.StatusCode = CInt(response.StatusCode).ToString()
                onjResult.Message = response.StatusDescription
                Dim s As String = JsonConvert.SerializeObject(onjResult)


                result = JObject.Parse(s)
            Finally
                request = Nothing
                response = Nothing
            End Try
            Return result
        End Function


    End Class
End Namespace

