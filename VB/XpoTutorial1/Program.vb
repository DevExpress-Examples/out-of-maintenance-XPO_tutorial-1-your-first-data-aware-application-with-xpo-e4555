Imports System
Imports System.Windows.Forms
Imports DevExpress.Xpo.DB
Imports XpoTutorial1.DataModel

Namespace XpoTutorial1

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Connect(AutoCreateOption.DatabaseAndSchema)
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            DevExpress.Skins.SkinManager.EnableFormSkins()
            Call Application.Run(New XtraForm1())
        End Sub
    End Module
End Namespace
