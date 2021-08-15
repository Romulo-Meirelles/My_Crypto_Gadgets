Imports System.Threading
Module Main
    Private MUTEX As Mutex = New Mutex(True, "{5F8F0AC4-B9A1-75fC-Z8CF-12F13E6BDE9K}")

    <STAThread()>
    Sub Main()

        If MUTEX.WaitOne(TimeSpan.Zero, True) Then

            Dim parametros() As String
            parametros = Environment.GetCommandLineArgs

            If parametros.Length > 1 Then
                For Each par In parametros
                    If par = "-hide" Then

                        Application.EnableVisualStyles()
                        Application.SetCompatibleTextRenderingDefault(False)
                        Config.WindowState = FormWindowState.Minimized
                        Config.ShowInTaskbar = False
                        Config.Hid = True
                        Application.Run(Config)
                        MUTEX.ReleaseMutex()
                    End If
                Next
            Else
                Application.EnableVisualStyles()
                Application.SetCompatibleTextRenderingDefault(False)
                Application.Run(Config)
                MUTEX.ReleaseMutex()
            End If
        End If
    End Sub
End Module
