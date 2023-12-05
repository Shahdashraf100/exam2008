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

namespace shahd_ashrafexam
{
    /// <summary>
    /// Interaction logic for adminfeacher.xaml
    /// </summary>
    public partial class adminfeacher : Page
    {
        public adminfeacher()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            deletepage de= new deletepage();
            this.NavigationService.Navigate(de);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            wheree se= new wheree();
            this.NavigationService.Navigate(se);
        }
    }
}
