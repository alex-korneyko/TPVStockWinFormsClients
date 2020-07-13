using System.Drawing;

namespace SimpleReports.Model.Services.AuxDataObjects
{
    public class DataGridViewRowColor
    {
        public string ColumnName { get; set; }

        public string ColumnValue { get; set; }

        public Color RowColor { get; set; }
    }
}