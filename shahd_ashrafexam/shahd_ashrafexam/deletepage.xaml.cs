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
    /// Interaction logic for deletepage.xaml
    /// </summary>
    public partial class deletepage : Page
    {
        examfaceEntities db = new examfaceEntities();
        public deletepage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            adminn admin = new adminn();
            exam10  ex=new exam10();
            ex = db.exam10.FirstOrDefault(x=>x.phonenum==numphone.Text);
            db.exam10.Remove(ex);
            db.SaveChanges();
            dg.ItemsSource=db.exam10.ToList();




        }
    }
}
