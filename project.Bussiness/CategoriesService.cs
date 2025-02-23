using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Bussiness
{
    public class CategoriesService
    {
        DBContext dBContext;

        public CategoriesService()
        {
            dBContext = new DBContext();
        }
        public DataTable GetCategories()
        {
            string command = "select Category_id , Category_Name from Categories";
            return dBContext.ExecuteQuery(command);
        }

        public int AddCategories(string name)
        {
            string command = $"Insert into Categories (Category_Name) Values('{name}')";
            return dBContext.ExecuteNonQuery(command);
        }
        public int UpdateCategories(int id,string name)
        {
            string command = $"Update  Categories set Category_Name='{name}' where Category_id={id}";
            return dBContext.ExecuteNonQuery(command);
        }
        public int DeleteCategories(int id)
        {
            //string command = $"Delete From Categories where Category_id={id}";
            string command = $"BEGIN TRANSACTION; DELETE FROM Products WHERE Category_Id = {id}; DELETE FROM Categories  WHERE Category_Id = {id};COMMIT;";
            return dBContext.ExecuteNonQuery(command);
        }
    }
}
