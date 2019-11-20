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
    /// Interaction logic for ItemFullDynamic.xaml
    /// </summary>
    public partial class ItemFullDynamic : UserControl
    {
        string typeNamee;
        public ItemFullDynamic(Furniture furr, string typeName)
        {
             typeNamee=typeName;
            InitializeComponent();
            
        
            labelDescription.Content = $"Aprasymas:\n{furr.description}"; 
            labelName.Content = furr.name;
            labelPrice.Content = furr.price;
            ImageSource itemImage = new BitmapImage(new Uri(Environment.CurrentDirectory + "\\Pictures\\" + furr.images));
            image.Source = itemImage;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

      
            Window4 win4 = Window.GetWindow(this) as Window4;//Prisijungiama prie Window4 formos
            win4.BoxList(Convert.ToString(labelName.Content), Convert.ToString(labelPrice.Content));//Paduodamos 2 reiksmes i Window4
            



        }
    }
}
