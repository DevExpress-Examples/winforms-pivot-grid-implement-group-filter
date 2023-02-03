<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4581)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Pivot Grid for WinForms - How to Implement Group Filter

This example demonstrates how to create group filters in the Pivot Grid. 

![Pivot Grid](./images/pivotgrid.png)

Set the [PivotGroupFilterValues.FilterType](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGroupFilterValues.FilterType) property to [PivotFilterType.Included](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotFilterType). Create filter values and add them to the [PivotGroupFilterValues.Values](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGroupFilterValues.Values) and [PivotGroupFilterValue.ChildValues](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGroupFilterValue.ChildValues) collections.

## Files to Reiew

* [Form1.cs](./CS/GroupFilter/Form1.cs) (VB: [Form1.vb](./VB/GroupFilter/Form1.vb))

## Documentation

- [Pop-up Filter](https://docs.devexpress.com/WindowsForms/8554/controls-and-libraries/pivot-grid/data-shaping/filtering/pop-up-filter)
- [Field Groups](https://docs.devexpress.com/WindowsForms/1958/controls-and-libraries/pivot-grid/layout/field-groups)

