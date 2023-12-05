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
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
        examfaceEntities db = new examfaceEntities();
        public signup()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login log=new login();
            this.NavigationService.Navigate(log);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
            exam10 em=new exam10();
            em.username = usernametx.Text;
            int f = int.Parse(agetxt.Text);
            em.age = f;
            em.phonenum = phonetxt.Text;
            var h = citycom.SelectedItem.ToString().Split(' ');
            string k = h.Last();
            if (k== "giza")
            {
                em.city = "giza";
            }else if (k== "cairo")
            {
                em.city = k;
            }else if (k== "alex")
            {
                em.city= k;
            }


            var p = combogen.SelectedItem.ToString().Split(' ');
            string q = p.Last();

            if (q == "female")
            {
                em.gender = q;
            }
            else if (q == "male")
            {
                em.gender = "male";
            }

            if (passtxt.Password.Length>8&&Regex.IsMatch(passtxt.Password,@"^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*(?><])"))
            {
                em.passwordd = passtxt.Password;
                db.exam10.Add(em);
                db.SaveChanges();

                login si = new login();
                this.NavigationService.Navigate(si);

            }
            else
            {
                MessageBox.Show(" the password must be char and digit");
            }
           
          
        }
    }
}
