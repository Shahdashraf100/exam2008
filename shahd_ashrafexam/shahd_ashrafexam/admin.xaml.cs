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
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        examfaceEntities db=new examfaceEntities();
        public admin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            adminn admin = new adminn();
            admin = db.adminns.FirstOrDefault(x=>x.adminpass==pass.Text);
            if (username.Text==admin.adminname&&pass.Text==admin.adminpass)
            {
                adminfeacher admi=new adminfeacher();
                this.NavigationService.Navigate(admi);

            }else
            {
                MessageBox.Show("the name or pass incorrect");
            }

        }
    }
}
