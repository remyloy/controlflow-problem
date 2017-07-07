using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BlogControlFlowSamples
{
    public partial class SampleForm3 : Form
    {
        private DataPoint _data;

        public SampleForm3()
        {
            InitializeComponent();
            _data = new DataPoint(0.0, 0.0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var incremented = Inc(_data);
            Add(incremented);
            _data = incremented;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var incremented = Inc(_data);
            _data = incremented;
            Add(incremented);
        }

        private void Add(DataPoint data)
        {
            var series = chart.Series.Any(s => s.Name == "Points")
                ? chart.Series["Points"]
                : chart.Series.Add("Points");
            series.Points.Add(data);
        }

        private static DataPoint Inc(DataPoint data)
        {
            return new DataPoint(data.XValue + 1.0, data.YValues.First() + 1.0);
        }
    }
}