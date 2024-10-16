<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128577313/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1870)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Pivot Grid for Web Forms - How to Customize Cell Appearance via Templates

This example shows the share of sold units per salesperson. This report contains absolute and percent values and their graphical representation. The content of pivot grid cells is replaced via templates, as described below:


1. A class that implements the [`ITemplate`](https://learn.microsoft.com/en-us/dotnet/api/system.web.ui.itemplate?view=netframework-4.8.1) interface is created.
2. An instance of the created class is assigned to the [`ASPxPivotGrid.CellTemplate`](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid.CellTemplate) property.
3. The `ASPxPivotGrid` passes an [`PivotGridCellTemplateContainer`](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxPivotGrid.PivotGridCellTemplateContainer?) object to the `ITemplate.InstantiateIn` method. The PivotGridCellTemplateContainer's `Value` and `Text` properties contain the current cell's value and display text, respectively. In the `InstantiateIn` method implementation, a web control is created that is rendered instead of the cell's content. The created control is added to the `PivotGridCellTemplateContainer.Controls` collection.

4. To render a simple text, a `LiteralControl` is added to the `PivotGridCellTemplateContainer.Controls` collection.

## Files to Review

* [Default.aspx](./CS/ASPxPivotGrid_CellTemplates/Default.aspx) (VB: [Default.aspx](./VB/ASPxPivotGrid_CellTemplates/Default.aspx))
* [Default.aspx.cs](./CS/ASPxPivotGrid_CellTemplates/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ASPxPivotGrid_CellTemplates/Default.aspx.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=web-forms-pivot-grid-customize-cell-appearance-via-templates&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=web-forms-pivot-grid-customize-cell-appearance-via-templates&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
