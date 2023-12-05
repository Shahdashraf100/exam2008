using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        examfaceEntities db = new examfaceEntities();
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            signup siup = new signup();
            this.NavigationService.Navigate(siup);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            forgetpass pass= new forgetpass();
            this.NavigationService.Navigate(pass);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            exam10 ex = new exam10();
            ex = db.exam10.FirstOrDefault(x=>x.passwordd==pass.Password);

            if (usernametxt.Text==ex.username&& pass.Password==ex.passwordd)
            {
                string data = usernametxt.Text;
                profile pro = new profile(data);
                this.NavigationService.Navigate(pro);

            } else
            {
                MessageBox.Show("the user name or password in correct");
            }


           
        
         
          


            



        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            admin ad= new admin();
            this.NavigationService.Navigate(ad);
        }
    }
}
