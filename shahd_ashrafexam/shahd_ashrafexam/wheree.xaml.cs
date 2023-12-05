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
    /// Interaction logic for wheree.xaml
    /// </summary>
    public partial class wheree : Page
    {
        examfaceEntities db = new examfaceEntities();
        public wheree()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            exam10 ex = new exam10();
            dg.ItemsSource = db.exam10.Where(x=>x.city==city.Text).ToList();

        }
    }
}
