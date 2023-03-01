using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gridview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogData log_list = new LogData();
        public MainWindow()
        {
            InitializeComponent();

            foreach (string line in System.IO.File.ReadLines(@".\data.txt"))
            {
                log_list.Add (new Log(line.Substring(0, 19), line.Substring(20)));
            }

            Binding myBinding = new Binding();
            myBinding.Source = log_list;
            // Bind the new data source to the myText TextBlock control's Text dependency property.
            list1.SetBinding(ListView.ItemsSourceProperty, myBinding);
        }
    }
}
