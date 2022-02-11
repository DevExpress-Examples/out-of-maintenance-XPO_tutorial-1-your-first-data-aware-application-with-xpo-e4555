Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports XpoTutorial1.DataModel

Namespace XpoTutorial1

    Public Partial Class XtraForm1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub XtraForm1_Load(ByVal sender As Object, ByVal e As EventArgs)
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
