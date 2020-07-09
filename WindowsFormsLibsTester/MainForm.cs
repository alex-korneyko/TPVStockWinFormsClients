using System;
using System.Windows.Forms;

namespace WindowsFormsLibsTester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void simpleReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainWindow = new SimpleReports.MainWindow("http://localhost:5000", "oleksandr.korneiko", "") 
                {MdiParent = this};
            
            mainWindow.Show();
        }
    }
}