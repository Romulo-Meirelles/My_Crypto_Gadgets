#Region "CALCULA VALOR ESTIMADO"
Namespace Tools
    Module Calculo
        'CALCULAR VALOR ESTIMADO
        Public Function CALCULA_VALOR_PORCENTAGEM(ByVal ABERTURA As Double, ByVal LAST As Double) As Double

            Dim L As Double = LAST
            Dim A As Double = ABERTURA
            Dim LA As Double = LAST - ABERTURA
            Dim Y As Double = LA / A
            Dim R As Double = Y * 100
            Return CDbl(FormatNumber(R, 2))
        End Function

        Public Function CALCULA_VALOR_ESTIMADO(ByVal ABERTURA As Double, ByVal LAST As Double) As Double
            If ABERTURA < LAST Then

                Dim G As Double = LAST - ABERTURA
                Return CDbl(FormatNumber(G, 2))
            Else
                Dim G As Double = CDbl(FormatNumber(ABERTURA - LAST, 8))
                Return CDbl(FormatNumber(G, 2))
            End If
        End Function
    End Module
End Namespace
#End Region