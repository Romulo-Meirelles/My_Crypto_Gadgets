Namespace Tools
    Module Registro
        Public Sub RegistryInsert()
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath & " -hide")
        End Sub

        Public Sub RegistryDelete()
            'Remove
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
        End Sub
    End Module
End Namespace
