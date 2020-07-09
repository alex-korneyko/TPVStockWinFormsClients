using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using HttpResource;
using SimpleReports.Model.Domain.DataViewObjects;

namespace SimpleReports.Controllers
{
    public partial class LocationsVolumesReport : UserControl
    {
        private List<LocationVolumeReportView> reportItems = new List<LocationVolumeReportView>();
        private BindingList<LocationVolumeReportView> bindingList;
        private BindingSource source;

        public LocationsVolumesReport(HttpClient httpClient)
        {
            InitializeComponent();

            GetData(httpClient);

            bindingList = new BindingList<LocationVolumeReportView>(reportItems);
            source = new BindingSource(bindingList, null);

            dataGridVolReports.DataSource = reportItems;
        }
        
        private void GetData(HttpClient httpClient)
        {
            httpClient.Post<List<LocationVolumeReportView>>("/api/locationVolumeReport", (response, code) =>
            {
                if (code == HttpStatusCode.OK)
                {
                    foreach (var locationVolumeReportView in response)
                    {
                        reportItems.Add(locationVolumeReportView);
                    }
                }
            });
        }
    }
}