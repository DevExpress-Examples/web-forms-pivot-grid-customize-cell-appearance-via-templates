using System;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraPivotGrid;

namespace CellTemplates {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxPivotGrid1.CellTemplate = new CellTemplate();
        }
        class CellTemplate : ITemplate {
            void ITemplate.InstantiateIn(Control container) {
                PivotGridCellTemplateContainer templateContainer =
                    (PivotGridCellTemplateContainer)container;
                PivotGridField field = templateContainer.DataField;

                if (field != null && field.Caption == "Percents") {
                    int value = Convert.ToInt32(Convert.ToDecimal(
                                                  templateContainer.Value) * 350);

                    Table table = new Table();
                    table.Width = Unit.Pixel(400);
                    templateContainer.Controls.Add(table);

                    TableRow row = new TableRow();
                    table.Controls.Add(row);

                    TableCell cell = new TableCell();
                    cell.Style.Add(HtmlTextWriterStyle.Padding, "0px");
                    cell.Width = Unit.Pixel(value);
                    cell.Height = Unit.Pixel(20);
                    if (templateContainer.Item.RowValueType == 
                                 PivotGridValueType.Total)
                        cell.BackColor = Color.Blue;
                    else
                        cell.BackColor = Color.Red;
                    if (templateContainer.Item.RowValueType == 
                               PivotGridValueType.GrandTotal)
                        cell.BackColor = Color.Green;
                    row.Controls.Add(cell);

                    cell = new TableCell();
                    cell.Text = templateContainer.Item.Text;
                    cell.Wrap = false;
                    row.Controls.Add(cell);
                }
                else {
                    templateContainer.Controls.Add(
                            new LiteralControl(templateContainer.Text));
                }
            }
        }
    }
}
