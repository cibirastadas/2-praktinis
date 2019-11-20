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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        string typeNamee;
      double total;
        string user;
        
        public Window4(string typeName,string userName)
        {
            typeNamee = typeName;
            user = userName;
            InitializeComponent();
            DynamicList.ItemFullListAdd();
            ItemFullListView(typeName);
            



        }
        Order ord = new Order();
        public void ItemFullListView(string typeName)//Uzpildomas Baldo Apibudinimas
        {
            for (int i = 0; i < DynamicList.furn.Count; i++)
            {
                if (typeName == DynamicList.furn[i].type)
                {
                    ItemFullDynamic dynamic = new ItemFullDynamic(DynamicList.furn[i],typeName);
                    typePanel.Children.Add(dynamic);
                }
            }
        }
        
       
        public void BoxList(string name, string price)//Uzpildomas boxListas ! Prideti kaina
        {
            
            ord.itemName.Add(name);
            ord.itemPrice.Add(price);
            MessageBox.Show($"{name }, {price} €");
            string selected = String.Format("{0,-70}{1,-10}", $"{name}:", price);
            listBox.Items.Add(selected);
            
            String[] valueList = price.Split('.');
            string value1 = valueList[0];
            string value2 = valueList[1];
            
            total = total + Convert.ToDouble(value1);
            label2.Content = $"{Convert.ToString(total)}.{Convert.ToString(value2)}";



        }
   
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 win3 = new Window3(user);
            this.Hide();
            win3.ShowDialog();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (listBox.SelectedIndex != -1)
            {
                
                String[] valueList = ord.itemPrice[listBox.SelectedIndex].Split('.');
                ord.itemName.RemoveAt(listBox.SelectedIndex);
                ord.itemPrice.RemoveAt(listBox.SelectedIndex);
                string value1 = valueList[0];
                string value2 = valueList[1];
                total = total - Convert.ToDouble(value1);
                if (total == 0)
                {
                    label2.Content = "0";
                    listBox.Items.RemoveAt(listBox.SelectedIndex);
                    MessageBox.Show("Is krepselio sekmingai pasalinta");
                }
                else
                {
                    label2.Content = $"{Convert.ToString(total)}.{value2}";
                    listBox.Items.RemoveAt(listBox.SelectedIndex);
                    MessageBox.Show("Is krepselio sekmingai pasalinta");
                }

            }
            else MessageBox.Show("Niekas nepasirinkta!");

        }//Salinimas is krepselio

        private void Button_Click_2(object sender, RoutedEventArgs e)//Pridejima Krepselio i data
        {

                ord.Name = user;    
                ord.AddToListData();
                MessageBox.Show("Sekmingai patvirtintas krepselis");
                listBox.Items.Clear();
            label2.Content = "0";
            total = 0;
           
        }
    }
}
