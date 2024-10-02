using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tabPageDashboard_Click(object sender, EventArgs e)
        {
            PieChart chart = new PieChart();
            pnlUnresolvedIncidents.Controls.Add(chart);
            pnlIncidentsPDeadline.Controls.Add(chart);
            chart.Colors = new Color[] { Color.Salmon, Color.Orange, Color.Lime };
            chart.Values = new float[] { 10, 20, 40 };
        }
    }
}
