Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports XpoTutorial1.DataModel


Namespace XpoTutorial1
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			ConnectionHelper.Connect(AutoCreateOption.DatabaseAndSchema)
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			DevExpress.Skins.SkinManager.EnableFormSkins()
			Application.Run(New XtraForm1())
		End Sub
	End Module
End Namespace
