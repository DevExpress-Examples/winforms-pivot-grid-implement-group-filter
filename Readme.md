<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/GroupFilter/Form1.cs) (VB: [Form1.vb](./VB/GroupFilter/Form1.vb))
<!-- default file list end -->
# How to Implement Group Filter in PivotGridControl

This example demonstrates how to create group filters in PivotGridControl. 

Set the [PivotGroupFilterValues.FilterType](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGroupFilterValues.FilterType) property to the [PivotFilterType.Included](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotFilterType). Create filter values and add them to the [PivotGroupFilterValues.Values](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGroupFilterValues.Values) and [PivotGroupFilterValue.ChildValues](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGroupFilterValue.ChildValues) collections.
