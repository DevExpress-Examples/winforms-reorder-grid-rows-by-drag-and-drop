Imports System
Imports System.Windows.Forms

Namespace E764
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        <STAThread> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace
