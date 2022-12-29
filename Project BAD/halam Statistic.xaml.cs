using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;

namespace Project_BAD
{
    /// <summary>
    /// Interaction logic for halam_Statistic.xaml
    /// </summary>
    public partial class halam_Statistic : Window
    {
        public halam_Statistic()
        {
            InitializeComponent();
            PointLabel = ChartPoint => string.Format("{0}({1:P})", ChartPoint.Y, ChartPoint.Participation);

            DataContext = this;
        }
        public Func<ChartPoint, string> PointLabel { get; set; }

        private void PieChart_DataClick(object sender, LiveCharts.ChartPoint chartPoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartPoint.ChartView;
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;
            var selectedSeries = (PieSeries)chartPoint.SeriesView;
            selectedSeries.PushOut = 0;
        }

        private void btnKembali(object sender, RoutedEventArgs e)
        {
            Halam_Utama halUtama = new Halam_Utama();
            halUtama.Show();
            this.Close();
        }
    }
}
