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
using DevExpress.Xpf.Core;

namespace Supermarket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow
    {
         List <clsInvoice> InvoiceItems  = new List <clsInvoice>();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btCash_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btTransaction_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHoldInv1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPriceCheck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHoldInv2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDiscLinePercent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVoidLine_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDiscLineValue_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVoidAll_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnQuick1_Click(object sender, RoutedEventArgs e)
        {
            clsInvoice item1 = new clsInvoice();
            item1.Name = "milk";
            item1.Price = 13;
            InvoiceItems.Add(item1);
            grdInvoice.ItemsSource = InvoiceItems;
            grdInvoice.RefreshData();
        }
    }
}
