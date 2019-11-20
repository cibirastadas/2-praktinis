using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace _2_praktinis
{
    public static class DynamicList
    {
        public static List<Furniture> furn = new List<Furniture>();

       public static void ItemFullListAdd()//Uzpildomas listas Duomenimis apie baldus
        {
            
            
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=2 praktinis.db");
            string sql = "select * from Baldai";
            dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                
                    Furniture furnitures = new Furniture();
                    furnitures.price = Convert.ToString(reader[0]);
                    furnitures.name = Convert.ToString(reader[1]);
                    furnitures.description = Convert.ToString(reader[2]);
                    furnitures.images = Convert.ToString(reader[3]);
                    furnitures.type = Convert.ToString(reader[4]);
                    furn.Add(furnitures);
                
               
            }
            dbConnection.Close();
        }


    }
}

