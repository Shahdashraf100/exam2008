using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for forgetpass.xaml
    /// </summary>
    public partial class forgetpass : Page
    {
        examfaceEntities db = new examfaceEntities();
        public forgetpass()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            exam10 ex = new exam10();
            ex = db.exam10.FirstOrDefault(x => x.phonenum == phonetxt.Text);
         
                if (newpass.Password == conpass.Password&&Regex.IsMatch(newpass.Password, @"^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*(?><])"))
                {
                    ex.passwordd = newpass.Password;
                    db.exam10.AddOrUpdate(ex);
                    db.SaveChanges();


                }
         
          

             else
             {
                    MessageBox.Show("thepassnot eqlue confirm");
                
             }
            
            
            login log=new login();
            this.NavigationService.Navigate(log);
        }
    }
}
