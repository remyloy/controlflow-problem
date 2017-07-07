using System;
using System.Linq;
using System.Windows.Forms;

namespace BlogControlFlowSamples
{
    public partial class SampleForm2 : Form
    {
        private Data _data;

        public SampleForm2()
        {
            InitializeComponent();
            _data = new Data(0.0, 0.0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var incremented = Inc(_data);
            Add(incremented);
            Store(incremented);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var incremented = Inc(_data);
            Store(incremented);
            Add(incremented);
        }

        private void Store(IncrementedData data)
        {
            _data = new Data(data.X, data.Y);
        }

        private void Add(IncrementedData data)
        {
            var series = chart.Series.Any(s => s.Name == "Points")
                ? chart.Series["Points"]
                : chart.Series.Add("Points");
            series.Points.AddXY(data.X, data.Y);
        }

        private static IncrementedData Inc(Data data)
        {
            return new IncrementedData(data.X + 1.0, data.Y + 1.0);
        }
    }

    internal class Data
    {
        public Data(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }

        public double Y { get; }
    }

    internal class IncrementedData
    {
        public IncrementedData(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }

        public double Y { get; }
    }
}