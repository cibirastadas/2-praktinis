using System.Collections.Generic;
using System.Data.SQLite;



namespace _2_praktinis
{
    public class Order : Login
    {
        
        public List<string> itemName = new List<string>();
        public List<string> itemPrice = new List<string>();
       
       

       
        public void AddToListData()//Pridedama i Data
        {

            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=2 praktinis.db");
            dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand("insert into Krepselis values(@user,@productName, @price)", dbConnection);
            for (int i = 0; i < itemName.Count; i++)
            {       
                cmd.Parameters.AddWithValue("@user", Name);
                cmd.Parameters.AddWithValue("@productName", itemName[i]);
                cmd.Parameters.AddWithValue("@price", itemPrice[i]);
                cmd.ExecuteNonQuery();
            }
            dbConnection.Close();


        }



    }
}
