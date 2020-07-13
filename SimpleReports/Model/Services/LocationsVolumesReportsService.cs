using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SimpleReports.Model.Services.AuxDataObjects;

namespace SimpleReports.Model.Services
{
    public class LocationsVolumesReportsService
    {
        public void PaintRows(DataGridView dataGridView, params DataGridViewRowColor[] rowColor)
        {
            for (var index = 0; index < dataGridView.Rows.Count - 1; index++)
            {
                foreach (var color in rowColor)
                {
                    var columnIndex = GetColumnByName(dataGridView, color.ColumnName).Index;
                    if (dataGridView.Rows[index].Cells[columnIndex].Value.ToString() == color.ColumnValue)
                    {
                        dataGridView.Rows[index].DefaultCellStyle.ForeColor = color.RowColor;
                    }
                }
            }
        }

        public DataGridViewColumn GetColumnByName(DataGridView dataGridView, string columnName)
        {
            return dataGridView.Columns.Cast<DataGridViewColumn>()
                .FirstOrDefault(column => column.Name == columnName);
        }
    }
}