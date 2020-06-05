Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo
Imports XpoTutorial1.DataModel

Namespace XpoTutorial1
	Partial Public Class XtraForm1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub XtraForm1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			If xpCollection1.Count = 0 Then
				Dim customer1 = New Customer(session1)
				customer1.Name = "John"
				customer1.Age = 21
				customer1.Save()
				xpCollection1.Add(customer1)
				Dim customer2 = New Customer(session1)
				customer2.Name = "Bob"
				customer2.Age = 37
				customer2.Save()
				xpCollection1.Add(customer2)
			End If
		End Sub
	End Class
End Namespace