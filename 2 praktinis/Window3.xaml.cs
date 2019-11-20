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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        string user;
        
        public Window3(string userName)
        {
            user = userName;
            InitializeComponent();
            ItemListAdd();
            
            
           
            

        }
        public void ItemListAdd()//ItemDynamic listo uzpyldimas
        {          
            string type="";
            int a = 0;
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=2 praktinis.db");
            string sql = "select * from Baldai";
            dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();
          
                
            
            while (reader.Read())
            {
                
                if (a == 0)
                {
                    type = Convert.ToString(reader[4]);
                    ItemDynamic item = new ItemDynamic(type,user);
                    typePanel.Children.Add(item);
                    a++;

                }
                else if (type != Convert.ToString(reader[4]) ) 
                {
                    type = Convert.ToString(reader[4]);
                    ItemDynamic item = new ItemDynamic(type,user);
                    typePanel.Children.Add(item);
                }
            }

            
            dbConnection.Close();
        }

    }
}
