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
using System.Data.SQLite;

namespace _2_praktinis
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Ar tikrai norite atsaukti pakeitimus?",
                  "Registracija", MessageBoxButton.YesNo);
                        if (result == MessageBoxResult.Yes)
                                  {
                
                MainWindow wnd1 = new MainWindow();
                                  this.Hide();
                wnd1.ShowDialog();
                
                             }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Name = textbox1.Text;
            registration.Password = passwordbox1.Password;
            registration.Password2 = passwordbox1.Password;
            registration.RegistrationFill();

            
MainWindow wpf = new MainWindow();
                         this.Hide();
            wpf.ShowDialog();
                
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
