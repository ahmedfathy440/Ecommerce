using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Bussiness
{
    public class FavoritesService
    {
        DBContext dBContext;

        public FavoritesService()
        {
            dBContext = new DBContext();
        }

        public DataTable GetFavorites(int userId)
        {
            string command = $"SELECT Users.User_Name, Products.Product_Name FROM Favorites INNER JOIN Products ON Favorites.Product_Id = Products.Product_Id INNER JOIN Users ON Favorites.User_ID = Users.User_ID where Favorites.User_ID ={userId}";
            return dBContext.ExecuteQuery(command);
        }

        public int AddToFavorites(int user_id,int product_id)
        { 
            string command = $"INSERT INTO Favorites(User_id, Product_id) SELECT {user_id}, {product_id} WHERE NOT EXISTS (SELECT * FROM Favorites WHERE User_ID = {user_id} and Product_Id = {product_id});";
            return dBContext.ExecuteNonQuery(command);
        }

       
        public int DeletefromFavorites(int user_id,string product_name)
        {
            
            string command = $"DELETE Favorites FROM Favorites JOIN Products ON Favorites.Product_id = Products.Product_id WHERE Products.Product_name = '{product_name}' and User_ID = {user_id};";
            return dBContext.ExecuteNonQuery(command);
        }
    }
}
