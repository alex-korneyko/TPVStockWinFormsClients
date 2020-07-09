using System;
using System.Windows.Forms;
using HttpResource;
using SimpleReports.Controllers;

namespace SimpleReports
{
    public partial class MainWindow: Form
    {
        private readonly HttpClient _httpClient;
        private string _applicationServerUrl;

        public MainWindow(string applicationServerUrl, string username, string password)
        {
            _httpClient = new HttpClient(applicationServerUrl);
            _applicationServerUrl = applicationServerUrl;
            _httpClient.Authenticate("/api/login", username, password);
            
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();

            var locationsVolumesReport = new LocationsVolumesReport(_httpClient);
            locationsVolumesReport.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(locationsVolumesReport);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(new SecondReport());
        }
    }
}
