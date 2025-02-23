using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Bussiness
{
    public class ProductsService
    {
        DBContext dBContext;

        public ProductsService()
        {
            dBContext = new DBContext();
        }

        public DataTable GetFavProducts(string productName)
        {
            string command = $"Select Product_Id from Products where Product_Name ='{productName}'";
            return dBContext.ExecuteQuery(command);
        }

        public DataTable GetProducts()
        {
            //string command = "select Product_name ,Price , Category_id from products";
            string command = "SELECT Products.Product_Id, Products.Product_Name, Products.Price, Categories.Category_Name FROM Products INNER JOIN Categories ON Products.Category_Id = Categories.Category_Id";
            return dBContext.ExecuteQuery(command);
        }

        public int AddProducts(string name,int price,int category_id) 
        {
            string command = $"insert into Products(Product_name ,Price,Category_id) Values('{name}',{price},{category_id})";
            return dBContext.ExecuteNonQuery(command);
        }

        public int UpdateProducts(int id , string name, int price, int category_id)
        {
            string command = $"update Products set Product_name='{name}',Price={price},Category_id={category_id} where Product_id={id}";
            return dBContext.ExecuteNonQuery(command);
        }
        public int DeleteProducts(int id) 
        {
            string command = $"delete from products where Product_id={id}";
            return dBContext.ExecuteNonQuery (command);
        }

    }
}
