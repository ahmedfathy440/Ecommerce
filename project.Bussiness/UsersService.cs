using Azure;
using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace project.Bussiness
{
    public class UsersService
    {
        DBContext dBContext;

        public UsersService()
        {
            dBContext = new DBContext();
        }

        public DataTable LoginVaild(string email , string password)
        {
            string command = $"Select User_Id, Email ,Password , Role,User_Name  from Users where Email='{email}' and Password='{password}'";
            return dBContext.ExecuteQuery(command);
        }
        public DataTable GetUsers()
        {
            string command = "Select User_Id,User_Name , Password , Email ,Age ,Address , Role from Users";
            return dBContext.ExecuteQuery(command);
        }
     
        public DataTable GetRole()
        {
            string command = $"Select Role from Users ";
            return dBContext.ExecuteQuery(command);
        }
        public int AddUsers(string name, string password, string email, int age, string address, string role)
        {
            string command = $"INSERT INTO Users(User_Name, Password, Email, Age, Address, Role) SELECT '{name}', '{password}', '{email}', { age}, '{address}', '{role}' WHERE NOT EXISTS(  SELECT 1 FROM Users WHERE Email = '{email}' OR Password = '{password}');";
            return dBContext.ExecuteNonQuery(command);
        }
        public int UpdateUsers(int id, string name, string password, string email, int age, string address, string role)
        {
            string command = $"update Users set User_Name='{name}' , Password='{password}' , Email='{email}' ,Age={age} ,Address='{address}',Role='{role}' where User_id ={id}";
            return dBContext.ExecuteNonQuery(command);
        }
        public int DeleteUsers(int id)
        {
            string command = $"delete from Users where User_id ={id}";
            return dBContext.ExecuteNonQuery(command);
        }
    }
}
