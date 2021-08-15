Imports System.Net
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json.Converters
Imports Newtonsoft.Json.Serialization
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json.Schema
Imports Newtonsoft.Json

#Region "Web Tools"
Namespace Tools

    Public Class Crypto

        Public Function GetPriceBittrex(ByVal Pair As String) As String()
            Try
                Dim RQS As New Request
                Dim URL As String = "https://api.bittrex.com/v3/markets/" & Pair & "/ticker"
                'Dim POST As String = 
                Dim Response As String = RQS.SEND(URL, Nothing, Request.Method.DOWNLOAD_, Request.Secure.TLS12)

                Dim jsonObject As JObject = JObject.Parse(Response)

                Dim k As String = "[" & jsonObject.ToString & "]"

                Dim h() = Newtonsoft.Json.JsonConvert.DeserializeObject(Of InfoBittrex())(k)

                Dim G(3) As String

                For Each item As InfoBittrex In h
                    G(0) = item.symbol
                    G(1) = item.lastTradeRate
                    G(2) = item.bidRate
                    G(3) = item.askRate
                Next

                Return G

            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function GetPriceBinance(ByVal Pair As String) As String()
            Try
                Dim RQS As New Request
                Dim URL As String = "https://api.binance.com/api/v3/ticker/price?symbol=" & Pair
                'Dim POST As String = 
                Dim Response As String = RQS.SEND(URL, Nothing, Request.Method.DOWNLOAD_, Request.Secure.TLS12)

                Dim jsonObject As JObject = JObject.Parse(Response)

                Dim A As String = "[" & jsonObject.ToString & "]"

                'Dim k As String = jsonObject.ToString
                ' Dim B As List(Of Info) = JsonConvert.DeserializeObject(Of List(Of Info))(A)
                Dim h() = Newtonsoft.Json.JsonConvert.DeserializeObject(Of InfoBinance())(A)

                Dim G(1) As String

                For Each item As InfoBinance In h
                    G(0) = item.symbol
                    G(1) = item.price
                Next

                Return G

            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function GetPriceBitfinex(ByVal Pair As String) As String()
            Try
                Dim RQS As New Request
                Dim URL As String = "https://api-pub.bitfinex.com/v2/ticker/" & Pair
                'Dim POST As String = 
                Dim Response As String = RQS.SEND(URL, Nothing, Request.Method.DOWNLOAD_, Request.Secure.TLS12)
                Dim B As String() = Response.Split(",".ToCharArray)
                Return B

            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        <Serializable()> _
        Public Class InfoBittrex
            <JsonProperty("symbol")>
            Public Property symbol As String
            <JsonProperty("lastTradeRate")>
            Public Property lastTradeRate As String
            <JsonProperty("bidRate")>
            Public Property bidRate As String
            <JsonProperty("askRate")>
            Public Property askRate As String 'close
        End Class

        <Serializable()> _
        Public Class InfoBinance
            <JsonProperty("symbol")>
            Public Property symbol As String
            <JsonProperty("Price")>
            Public Property price As String
        End Class
    End Class

    Public Class Internet_Protocol
        Public Function GetMyIP() As String()
            Try
                Dim RQS As New Request
                Dim URL As String = "http://ip-api.com/json/"
                'Dim POST As String = 
                Dim Response As String = RQS.SEND(URL, Nothing, Request.Method.DOWNLOAD_, Request.Secure.TLS12)

                Dim jsonObject As JObject = JObject.Parse(Response)

                Dim A As String = "[" & jsonObject.ToString & "]"

                'Dim k As String = jsonObject.ToString
                ' Dim B As List(Of Info) = JsonConvert.DeserializeObject(Of List(Of Info))(A)
                Dim h() = Newtonsoft.Json.JsonConvert.DeserializeObject(Of IP())(A)

                Dim G(5) As String

                For Each item As IP In h
                    G(0) = item.query
                    G(1) = item.city
                    G(2) = item.region
                    G(3) = item.countryCode
                    G(4) = item.org
                Next

                Return G

            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        <Serializable()> _
        Public Class IP
            <JsonProperty("status")>
            Public Property status As String
            <JsonProperty("country")>
            Public Property country As String
            <JsonProperty("countryCode")>
            Public Property countryCode As String
            <JsonProperty("region")>
            Public Property region As String
            <JsonProperty("regionName")>
            Public Property regionName As String
            <JsonProperty("city")>
            Public Property city As String
            <JsonProperty("zip")>
            Public Property zip As String
            <JsonProperty("lat")>
            Public Property lat As String
            <JsonProperty("lon")>
            Public Property lon As String
            <JsonProperty("timezone")>
            Public Property timezone As String
            <JsonProperty("isp")>
            Public Property isp As String
            <JsonProperty("org")>
            Public Property org As String
            <JsonProperty("as")>
            Public Property as_ As String
            <JsonProperty("query")>
            Public Property query As String

        End Class
    End Class

    Public Class Request

        Enum Method
            POST_
            GET_
            HEAD_
            PUT_
            DELETE_
            CONNECT_
            OPTIONS_
            TRACE_
            PATCH_
            DOWNLOAD_
        End Enum

        Enum Secure
            SSL3
            TLS
            TLS11
            TLS12
            Unsecure
        End Enum

        Public Function SEND(ByRef URL As String, ByVal Post As String, Optional ByVal Method As Method = Method.POST_, Optional ByVal Secure As Secure = Secure.TLS12) As String

            'FAZ O SERVIÇO FICAR SEGURO CRIPTOGRAFADO
            Select Case Secure
                Case Tools.Request.Secure.SSL3
                    ServicePointManager.SecurityProtocol = DirectCast(48, SecurityProtocolType)
                Case Tools.Request.Secure.TLS
                    ServicePointManager.SecurityProtocol = DirectCast(192, SecurityProtocolType)
                Case Tools.Request.Secure.TLS11
                    ServicePointManager.SecurityProtocol = DirectCast(768, SecurityProtocolType)
                Case Tools.Request.Secure.TLS12
                    ServicePointManager.SecurityProtocol = DirectCast(3072, SecurityProtocolType)
                Case Tools.Request.Secure.Unsecure

            End Select

            Try
                Dim REQUESTWEB As HttpWebRequest = DirectCast(HttpWebRequest.Create(URL), HttpWebRequest)
                With REQUESTWEB
                    Select Case Method
                        Case Tools.Request.Method.POST_
                            .Method = "POST"
                        Case Tools.Request.Method.GET_
                            .Method = "GET"
                        Case Tools.Request.Method.HEAD_
                            .Method = "HEAD"
                        Case Tools.Request.Method.PUT_
                            .Method = "PUT"
                        Case Tools.Request.Method.DELETE_
                            .Method = "DELETE"
                        Case Tools.Request.Method.CONNECT_
                            .Method = "CONNECT"
                        Case Tools.Request.Method.OPTIONS_
                            .Method = "OPTIONS"
                        Case Tools.Request.Method.TRACE_
                            .Method = "TRACE"
                        Case Tools.Request.Method.PATCH_
                            .Method = "PATCH"
                        Case Tools.Request.Method.DOWNLOAD_
                            Dim REQ As String
                            Try
                                'O QUE SERÁ ENVIADO PARA OBTER UMA RESPOSTA
                                Dim Client As WebClient = New WebClient()

                                Try

                                    REQ = Client.DownloadString(URL)
                                    Return REQ
                                Catch ex As WebException
                                    REQ = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()
                                    Return REQ
                                End Try

                            Catch ex As Exception
                                'CASO TENHA ALGUM ERRO RETORNA O NOME DO ERRO
                                Return ex.ToString
                            End Try
                            Return REQ
                    End Select




                    Dim TempCookies As New CookieContainer
                    Dim Encoding_UTF8() As Byte = Encoding.UTF8.GetBytes(Post)
                    Dim DataStream As Stream
                    Dim Response As WebResponse
                    Dim Reader As StreamReader
                    Dim ResponseFromServer As String = Nothing


                    .ContentType = "application/x-www-form-urlencoded"
                    .UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:64.0) Gecko/20100101 Firefox/64.0"
                    .KeepAlive = True
                    .CookieContainer = TempCookies
                    .ContentLength = Encoding_UTF8.Length
                    DataStream = .GetRequestStream
                    DataStream.Write(Encoding_UTF8, 0, Encoding_UTF8.Length)
                    DataStream.Close()

                    Response = .GetResponse
                    DataStream = Response.GetResponseStream()

                    Reader = New StreamReader(DataStream)
                    ResponseFromServer = Reader.ReadToEnd()
                    Reader.Close()
                    DataStream.Close()
                    Response.Close()
                    Return ResponseFromServer
                End With

            Catch ex As Exception
                Return ex.Message
            End Try

        End Function

    End Class


End Namespace


#End Region
