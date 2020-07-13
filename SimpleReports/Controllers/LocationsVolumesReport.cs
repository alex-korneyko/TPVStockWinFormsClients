using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using HttpResource;
using SimpleReports.Model.Domain.DataViewObjects;
using SimpleReports.Model.Services;
using SimpleReports.Model.Services.AuxDataObjects;

namespace SimpleReports.Controllers
{
    public partial class LocationsVolumesReport : UserControl
    {
        private LocationsVolumesReportsService _locationsVolumesReportsService;
        private List<LocationVolumeReportView> _reportItems = new List<LocationVolumeReportView>();

        public LocationsVolumesReport(HttpClient httpClient)
        {
            InitializeComponent();
            
            _locationsVolumesReportsService = new LocationsVolumesReportsService();

            IBindingList bindingList = new BindingList<LocationVolumeReportView>(_reportItems);
            
            GetData(httpClient);

            dataGridVolReports.DataSource = bindingList;
            
            _locationsVolumesReportsService.PaintRows(dataGridVolReports, new DataGridViewRowColor
            {
                ColumnName = "VolumeStatus",
                ColumnValue = "Dopełnij FIXBIN",
                RowColor = Color.Yellow
            });
        }

        private void GetData(HttpClient httpClient)
        {
            httpClient.Post<List<LocationVolumeReportView>>("/api/locationVolumeReport", (response, code) =>
            {
                if (code == HttpStatusCode.OK) _reportItems.AddRange(response);
            });
        }

        private void HeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columnNumber = e.ColumnIndex;
            var column = dataGridVolReports.Columns[columnNumber];
            
            if (column.Name != "VolumeStatus" && column.Name != "VolumeState") return;
            
            foreach (DataGridViewColumn o in dataGridVolReports.Columns)
            {
                if (o.Name == dataGridVolReports.Columns[columnNumber].Name) continue;

                o.HeaderCell.SortGlyphDirection = SortOrder.None;
            }

            IOrderedEnumerable<LocationVolumeReportView> temp;
            var sortOrder = SortOrder.None;
            
            switch (column.Name)
            {
                case "VolumeStatus":
                {
                    if (dataGridVolReports.Columns[columnNumber].HeaderCell.SortGlyphDirection == SortOrder.None
                        || dataGridVolReports.Columns[columnNumber].HeaderCell.SortGlyphDirection == SortOrder.Descending)
                    {
                        temp = from item in _reportItems orderby item.VolumeStatus select item;
                        sortOrder = SortOrder.Ascending;
                    }
                    else
                    {
                        temp = from item in _reportItems orderby item.VolumeStatus descending select item;
                        sortOrder = SortOrder.Descending;
                    }
                    _reportItems = new List<LocationVolumeReportView>(temp);
                    break;
                }
                case "VolumeState":
                {
                    if (dataGridVolReports.Columns[columnNumber].HeaderCell.SortGlyphDirection == SortOrder.None
                        || dataGridVolReports.Columns[columnNumber].HeaderCell.SortGlyphDirection == SortOrder.Descending)
                    {
                        temp = from item in _reportItems orderby item.VolumeState select item;
                        sortOrder = SortOrder.Ascending;
                    }
                    else
                    {
                        temp = from item in _reportItems orderby item.VolumeState descending select item;
                        sortOrder = SortOrder.Descending;
                    }
                    _reportItems = new List<LocationVolumeReportView>(temp);
                    break;
                }
            }
            
            dataGridVolReports.DataSource = new BindingList<LocationVolumeReportView>(_reportItems);
            dataGridVolReports.Columns[columnNumber].HeaderCell.SortGlyphDirection = sortOrder;
        }
    }
}