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
namespace ConsoleUpgrades
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Process_Click(object sender, RoutedEventArgs e)
        {
            double totalRemining = 0;
            double quart_Result = 0;
            double dim_Result = 0;
            double nick_Result = 0;
            double penn_Result = 0;

            try
            {
                string itemCostStr = ctxb.Text;
                double itemCost = double.Parse(itemCostStr);
                string costumerPaymentStr = ptxb1.Text;
                double costumerPayment = double.Parse(costumerPaymentStr);
                totalRemining = costumerPayment - itemCost;
                if (totalRemining < 0)
                {
                    MessageBox.Show("The item cost is more than the costumer payment");
                }
                else
                {
                    double totalRemininginPnns = totalRemining * 100;
                    double reminingPnnsfromQuart = totalRemininginPnns % 25;
                    quart_Result = Math.Floor(totalRemininginPnns / 25);
                    double reminingPnnsfromDims = reminingPnnsfromQuart % 10;
                    dim_Result = Math.Floor(reminingPnnsfromQuart / 10);
                    double reminingPnnsfromNick = reminingPnnsfromDims % 5;
                    nick_Result = Math.Floor(reminingPnnsfromDims / 5);
                    penn_Result = Math.Floor(reminingPnnsfromNick);
                    totalRemining = totalRemining * 100;
                    totalRemining = Math.Floor(totalRemining);
                    totalRemining = totalRemining / 100;
                    ttxb.Text = totalRemining.ToString();
                    qtxb.Text = quart_Result.ToString();
                    dtxb.Text = dim_Result.ToString();
                    ntxb.Text = nick_Result.ToString();
                    ptxb.Text = penn_Result.ToString();
                    ctxb.Clear();
                    ptxb1.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You had entered a non intger value & your " +ex.Message.ToLower());
            }
        }

        private void ttxb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}







