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
using System.Windows.Shapes;

namespace _2_praktinis
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        
        public Window2()
        {
           
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Ar tikrai norite atsaukti pakeitimus?",
                  "Prisijungimas", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                
                MainWindow main = new MainWindow();
                this.Hide();
                main.ShowDialog();

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Login login = new Login();
            try
            {
                login.Name = textbox1.Text;
                login.Password = passwordbox1.Password;
                login.UserSearch();
                MainWindow main = new MainWindow();
                Window3 win3 = new Window3(textbox1.Text);
                main.labelUser.Content = textbox1.Text;
                main.labelLog.Content = "Prisijunges:";
                this.Hide();
                main.ShowDialog();
                
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
                textbox1.Clear();
                passwordbox1.Clear();
            }
            
        }
    }
}
