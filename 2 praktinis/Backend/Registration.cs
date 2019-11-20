using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace _2_praktinis
{
   public class Registration
    {
        private string name;
        private string password;
        private string password2;

       

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
            }
        }//Uzpyldomas name
        public string Password//uzpildomas passwordas
        {
            get { return password; }
            set
            {
                password = value;
            }
        }
        public string Password2//uzpildomas passwordas2
        {
            get { return password2; }
            set
            {
                password2 = value;
            }
        }

        public void RegistrationFill()//Uzpyldimas nauju naudotoju
        {
            int a = 0;
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=2 praktinis.db");
            dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand("insert into Vartotojai values(@name, @password, @password2)", dbConnection);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@password2", password2);
            cmd.ExecuteNonQuery();
            dbConnection.Close();
            a++;
        }
     
    }
}
