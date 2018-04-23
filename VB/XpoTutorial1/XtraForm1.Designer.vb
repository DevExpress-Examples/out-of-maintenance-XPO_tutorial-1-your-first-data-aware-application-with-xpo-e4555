Namespace XpoTutorial1
    Partial Public Class XtraForm1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.session1 = New DevExpress.Xpo.Session(Me.components)
            Me.xpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAge = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            CType(Me.session1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' session1
            ' 
            Me.session1.TrackPropertiesModifications = False
            ' 
            ' xpCollection1
            ' 
            Me.xpCollection1.ObjectType = GetType(XpoTutorial1.DataModel.Customer)
            Me.xpCollection1.Session = Me.session1
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.xpCollection1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(313, 288)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.UseEmbeddedNavigator = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOid, Me.colName, Me.colAge})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' colOid
            ' 
            Me.colOid.FieldName = "Oid"
            Me.colOid.Name = "colOid"
            Me.colOid.OptionsColumn.ReadOnly = True
            Me.colOid.Visible = True
            Me.colOid.VisibleIndex = 0
            ' 
            ' colName
            ' 
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 1
            ' 
            ' colAge
            ' 
            Me.colAge.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colAge.FieldName = "Age"
            Me.colAge.Name = "colAge"
            Me.colAge.Visible = True
            Me.colAge.VisibleIndex = 2
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' XtraForm1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(313, 288)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "XtraForm1"
            Me.Text = "XtraForm1"
'            Me.Load += New System.EventHandler(Me.XtraForm1_Load)
            CType(Me.session1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private xpCollection1 As DevExpress.Xpo.XPCollection
        Private session1 As DevExpress.Xpo.Session
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colOid As DevExpress.XtraGrid.Columns.GridColumn
        Private colName As DevExpress.XtraGrid.Columns.GridColumn
        Private colAge As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

    End Class
End Namespace