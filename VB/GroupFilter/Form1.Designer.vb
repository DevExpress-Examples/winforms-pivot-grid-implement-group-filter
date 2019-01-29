Namespace GroupFilter
	Partial Public Class Form1
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
			Dim pivotGridGroup1 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Me.fieldOrderDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New GroupFilter.nwindDataSet()
			Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.salesPersonTableAdapter = New GroupFilter.nwindDataSetTableAdapters.SalesPersonTableAdapter()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' fieldOrderDate1
			' 
			Me.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldOrderDate1.AreaIndex = 0
			Me.fieldOrderDate1.Caption = "Year"
			Me.fieldOrderDate1.FieldName = "OrderDate"
			Me.fieldOrderDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldOrderDate1.Name = "fieldOrderDate1"
			Me.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1"
			' 
			' fieldOrderDate
			' 
			Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldOrderDate.AreaIndex = 1
			Me.fieldOrderDate.Caption = "Month"
			Me.fieldOrderDate.FieldName = "OrderDate"
			Me.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
			Me.fieldOrderDate.Name = "fieldOrderDate"
			Me.fieldOrderDate.UnboundFieldName = "fieldOrderDate"
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.DataSource = Me.salesPersonBindingSource
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldProductName1, Me.fieldExtendedPrice1, Me.fieldCategoryName1, Me.fieldOrderDate1, Me.fieldOrderDate})
			pivotGridGroup1.Caption = "OrderDateGroup"
			pivotGridGroup1.Fields.Add(Me.fieldOrderDate1)
			pivotGridGroup1.Fields.Add(Me.fieldOrderDate)
			pivotGridGroup1.Hierarchy = Nothing
			pivotGridGroup1.ShowNewValues = True
			Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.LookAndFeel.SkinName = "Office 2010 Silver"
			Me.pivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(598, 310)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' salesPersonBindingSource
			' 
			Me.salesPersonBindingSource.DataMember = "SalesPerson"
			Me.salesPersonBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' fieldProductName1
			' 
			Me.fieldProductName1.AreaIndex = 0
			Me.fieldProductName1.Caption = "Product Name"
			Me.fieldProductName1.FieldName = "ProductName"
			Me.fieldProductName1.Name = "fieldProductName1"
			' 
			' fieldExtendedPrice1
			' 
			Me.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice1.AreaIndex = 0
			Me.fieldExtendedPrice1.Caption = "Extended Price"
			Me.fieldExtendedPrice1.FieldName = "Extended Price"
			Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
			' 
			' fieldCategoryName1
			' 
			Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldCategoryName1.AreaIndex = 0
			Me.fieldCategoryName1.Caption = "Category Name"
			Me.fieldCategoryName1.FieldName = "CategoryName"
			Me.fieldCategoryName1.Name = "fieldCategoryName1"
			' 
			' salesPersonTableAdapter
			' 
			Me.salesPersonTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(598, 310)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private nwindDataSet As nwindDataSet
		Private salesPersonBindingSource As System.Windows.Forms.BindingSource
		Private salesPersonTableAdapter As GroupFilter.nwindDataSetTableAdapters.SalesPersonTableAdapter
		Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDate1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

