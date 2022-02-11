Imports DevExpress.Xpo

Namespace XpoTutorial1.DataModel

    Public Partial Class Customer

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
    End Class
End Namespace
