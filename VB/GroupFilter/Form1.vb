Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace GroupFilter
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

			' Binds the pivot grid to data.
			Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)

			' Gets the field group from the collection.
			Dim OrderDateGroup As PivotGridGroup = pivotGridControl1.Groups(0)

			' Locks the PivotGroupFilterValues object by disabling visual updates.
			OrderDateGroup.FilterValues.BeginUpdate()

			' Sets the filter type. 
			' It specifies that the PivotGridControl should display only filter values.
			OrderDateGroup.FilterValues.FilterType = PivotFilterType.Included

			' Creates a filter value and adds it to the PivotGroupFilterValues.Values collection.
			OrderDateGroup.FilterValues.Values.Add(New PivotGroupFilterValue(2014))

			' Creates a filter value and adds it to the PivotGroupFilterValues.Values collection.
			' Then creates a child value of the filter value and adds it to the parent value collection.
			OrderDateGroup.FilterValues.Values.Add(2015).ChildValues.Add(1)

			' Unlocks the PivotGroupFilterValues object.
			OrderDateGroup.FilterValues.EndUpdate()
		End Sub
	End Class
End Namespace
