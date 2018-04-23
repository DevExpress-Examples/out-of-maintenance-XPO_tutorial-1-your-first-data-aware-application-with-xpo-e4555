Imports System.Threading.Tasks
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports XpoTutorial1.DataModel


Namespace XpoTutorial1
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            ConnectionHelper.Connect(AutoCreateOption.DatabaseAndSchema)
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            DevExpress.Skins.SkinManager.EnableFormSkins()
            Application.Run(New XtraForm1())
        End Sub
    End Class
End Namespace
