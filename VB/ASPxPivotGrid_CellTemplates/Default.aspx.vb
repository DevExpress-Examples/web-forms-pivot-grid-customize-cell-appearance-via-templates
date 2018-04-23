Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraPivotGrid

Namespace CellTemplates
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ASPxPivotGrid1.CellTemplate = New CellTemplate()
		End Sub
		Private Class CellTemplate
			Implements ITemplate
			Private Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
				Dim templateContainer As PivotGridCellTemplateContainer = CType(container, PivotGridCellTemplateContainer)
				Dim field As PivotGridField = templateContainer.DataField

				If field IsNot Nothing AndAlso field.Caption = "Percents" Then
					Dim value As Integer = Convert.ToInt32(Convert.ToDecimal(templateContainer.Value) * 350)

					Dim table As New Table()
					table.Width = Unit.Pixel(400)
					templateContainer.Controls.Add(table)

					Dim row As New TableRow()
					table.Controls.Add(row)

					Dim cell As New TableCell()
					cell.Style.Add(HtmlTextWriterStyle.Padding, "0px")
					cell.Width = Unit.Pixel(value)
					cell.Height = Unit.Pixel(20)
					If templateContainer.Item.RowValueType = PivotGridValueType.Total Then
						cell.BackColor = Color.Blue
					Else
						cell.BackColor = Color.Red
					End If
					If templateContainer.Item.RowValueType = PivotGridValueType.GrandTotal Then
						cell.BackColor = Color.Green
					End If
					row.Controls.Add(cell)

					cell = New TableCell()
					cell.Text = templateContainer.Item.Text
					cell.Wrap = False
					row.Controls.Add(cell)
				Else
					templateContainer.Controls.Add(New LiteralControl(templateContainer.Text))
				End If
			End Sub
		End Class
	End Class
End Namespace
