<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1870)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/ASPxPivotGrid_CellTemplates/Default.aspx) (VB: [Default.aspx](./VB/ASPxPivotGrid_CellTemplates/Default.aspx))
* [Default.aspx.cs](./CS/ASPxPivotGrid_CellTemplates/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ASPxPivotGrid_CellTemplates/Default.aspx.vb))
<!-- default file list end -->
# How to Customize Cell Appearance via Templates


<p>This example shows a share of sold units quantity per salesperson. This report contains absolute and percent values, and their graphical representation. </p><p>The content of pivot grid cells is replaced via templates, as described below: </p><p>1. A class that implements the ITemplate interface is created.<br />
2. An instance of this class is created and assigned to the ASPxPivotGrid.CellTemplate property.</p><p>The ASPxPivotGrid passes an PivotGridCellTemplateContainer object to the ITemplate.InstantiateIn method. The PivotGridCellTemplateContainer.Value and Text properties contain the current cell's value and display text, respectively. </p><p>When implementing the InstantiateIn method, a web control is created to be rendered instead of the cell's content. This control is added to the PivotGridCellTemplateContainer.Controls collection. </p><p>To render a simple text, a LiteralControl is added to the PivotGridCellTemplateContainer.Controls collection.</p>

<br/>


