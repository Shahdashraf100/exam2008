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
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Page
    {
        examfaceEntities db =new examfaceEntities();
        public profile(string data)
        {
            InitializeComponent();
            dg.ItemsSource=db.exam10.ToList();
            dg.ItemsSource=db.exam10.Where(x=>x.username==data).ToList();
        

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login log=new login();
            this.NavigationService.Navigate(log);

        }
    }
}
