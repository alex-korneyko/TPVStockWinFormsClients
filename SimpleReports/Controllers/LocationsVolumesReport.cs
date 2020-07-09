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

        public LocationsVolumesReport(HttpClient httpClient)
        {
            InitializeComponent();

            GetData(httpClient);

            IBindingList bindingList = new BindingList<LocationVolumeReportView>(reportItems);
            dataGridVolReports.DataSource = bindingList;
        }

        private void GetData(HttpClient httpClient)
        {
            httpClient.Post<List<LocationVolumeReportView>>("/api/locationVolumeReport", (response, code) =>
            {
                if (code == HttpStatusCode.OK)
                    reportItems.AddRange(response);
            });
        }
    }
}