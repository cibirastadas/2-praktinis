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

namespace _2_praktinis
{
    /// <summary>
    /// Interaction logic for ItemDynamic.xaml
    /// </summary>
    public partial class ItemDynamic : UserControl
    {
        string user;
        public ItemDynamic(string type, string userName)
        {
            user = userName;
            InitializeComponent();
            label1.Content = type;
        }



        private void typeButton_Click(object sender, RoutedEventArgs e)
        {
            
            Window4 win4 = new Window4(Convert.ToString(label1.Content),user);
           
            var myWindow = Window.GetWindow(this);//Uzdaromas 
            myWindow.Close();
            win4.ShowDialog();
         


        }
    }
}
