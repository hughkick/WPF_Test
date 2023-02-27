using System.Windows;
using System.Windows.Input;

namespace combo_eidt_box
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void combo_heandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                box1.Items.Add(box1.Text);

                box1.SelectedIndex = box1.Items.Count - 1;
            }
        }
    }
}
