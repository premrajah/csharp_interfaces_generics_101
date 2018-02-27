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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RandomNumberGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyRandomizer mr = new MyRandomizer();
        string str;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void gen_btn_Click(object sender, RoutedEventArgs e)
        {
            if (number_tb.Text != string.Empty)
            {
                    str = number_tb.Text;

                    try
                    {
                        double upperBound = Double.Parse(str);
                        result_tbl.Text = String.Format("{0:0.##}", mr.GetRandomNum(upperBound)).ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                

            }
        }
    }
}
