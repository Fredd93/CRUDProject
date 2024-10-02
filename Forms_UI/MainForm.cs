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
        int green_value = 40;
        PieChart chart;
        public MainForm()
        {
            InitializeComponent();
            chart = new PieChart();
            this.Controls.Add(chart);
            chart.Size = new Size(225, 225);
            chart.Colors = new Color[] { Color.Salmon, Color.Orange, Color.Lime };
            chart.Values = new float[] { 10, 20, 40 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            green_value += 2;
            chart.Values = new float[] { 10, 20, green_value };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            green_value -= 2;
            chart.Values = new float[] { 10, 20, green_value };
        }
    }
}
