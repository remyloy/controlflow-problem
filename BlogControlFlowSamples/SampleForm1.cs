using System;
using System.Linq;
using System.Windows.Forms;

namespace BlogControlFlowSamples
{
    public partial class SampleForm1 : Form
    {
        private double _x;
        private double _y;

        public SampleForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
            Inc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inc();
            Add();
        }

        private void Add()
        {
            var series = chart.Series.Any(s => s.Name == "Points")
                ? chart.Series["Points"]
                : chart.Series.Add("Points");
            series.Points.AddXY(_x, _y);
        }

        private void Inc()
        {
            _x += 1.0;
            _y += 1.0;
        }
    }
}