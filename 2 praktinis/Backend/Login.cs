using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Controls;
namespace _2_praktinis
{
    public class Login
    {
        private string name;
        private string password;
        


       

        public string Name//Uzpildomas vartotojo vardas
        {
            get { return name; }
            set { name = value; }
        }

        public string Password//Uzpildomas vartotojo slaptazois
        {
            get { return password; }
            set { password = value; }
        }



        public void UserSearch()//Nuskaitynas is duomenu bazes
        {
            
            int a = 0;
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=2 praktinis.db");
            string sql = "select * from Vartotojai";
            dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                if (name == Convert.ToString(reader[0]) && password == Convert.ToString(reader[1]))
                {
                    MessageBox.Show("Sekmingai prisijungete");
                    a++;
                }
                
            }
            if (a == 1)
            {
                a++;
            }
            else throw new Exception("Prisijungimas negalimas");
            
        }
       
    }
}
