using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Xml.Linq;
using System.Drawing;
using ADO.NET_WINFORM_ProdShop_HW_2.Model;
using Microsoft.SqlServer.Server;

namespace ADO.NET_WINFORM_ProdShop_HW_2
{
    public class Controller
    {
        public Product product = new Product();
        static SqlConnection connection;
        public Controller()
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbProdShop"].ConnectionString;
        }

        public List<string> GetCategories()
        {

            List<string> res = new List<string>();
            using (connection)
            {

                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = new SqlCommand("Select Type FROM Main  Group By type", connection);
                command.Transaction = transaction;

                SqlDataReader reader = command.ExecuteReader();
                int col = reader.FieldCount;
                while (reader.Read())
                {

                    res.Add(reader.GetValue(0).ToString());

                }

                reader.Close();

            }
            return res;
        }
        public List<string> SelectAllName()
        {
            List<string> res = new List<string>();
            using (connection)
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = new SqlCommand("Select Name FROM Main ", connection);
                command.Transaction = transaction;

                SqlDataReader reader = command.ExecuteReader();
                int col = reader.FieldCount;
                while (reader.Read())
                {

                    res.Add(reader.GetValue(0).ToString());

                }

                reader.Close();

            }
            return res;
        }

        public List<string> SelectType(string type)
        {
            List<string> res = new List<string>();
            using (connection)
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbProdShop"].ConnectionString;
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = new SqlCommand($"Select Name FROM Main Where Type = '{type}'", connection);
                command.Transaction = transaction;

                SqlDataReader reader = command.ExecuteReader();
                int col = reader.FieldCount;
                while (reader.Read())
                {

                    res.Add(reader.GetValue(0).ToString());

                }

                reader.Close();

            }
            return res;
        }

        public List<string> SelectInfoAboutProduct(string name)
        {
            List<string> res = new List<string>();
            using (connection)
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbProdShop"].ConnectionString;
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = new SqlCommand($"Select * FROM Main Where Name = '{name}'", connection);
                command.Transaction = transaction;

                SqlDataReader reader = command.ExecuteReader();
                int col = reader.FieldCount;
                if (col == 0) return null;
                while (reader.Read())
                {
                    for (int i = 1; i < col; i++)
                    {
                        res.Add(reader.GetName(i) + " " + reader.GetValue(i).ToString());
                    }

                }

                reader.Close();

            }
            return res;
        }
        public string GetColorSelectProduct(string name)
        {
            string colorName = "White";
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbProdShop"].ConnectionString;
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = new SqlCommand($"Select Color FROM Main Where Name = '{name}'", connection);
                command.Transaction = transaction;

                SqlDataReader reader = command.ExecuteReader();
                int col = reader.FieldCount;
                while (reader.Read())
                {
                    colorName = reader.GetValue(0).ToString();

                }

                reader.Close();

            }

            return colorName;

        }
        public string GetProductSelectColor(string color)
        {
            string colorName = "White";
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbProdShop"].ConnectionString;
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = new SqlCommand($"Select Color FROM Main Where Color = '{color}'", connection);
                command.Transaction = transaction;

                SqlDataReader reader = command.ExecuteReader();
                int col = reader.FieldCount;
                while (reader.Read())
                {
                    colorName = reader.GetValue(0).ToString();

                }

                reader.Close();

            }

            return colorName;

        }
        public List<string> GetProductSelectColorAndName(string color, string type)
        {
            List<string> res = new List<string>();
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbProdShop"].ConnectionString;
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = new SqlCommand($"Select Name FROM Main Where Color = '{color}' and Type = '{type}'", connection);
                command.Transaction = transaction;

                SqlDataReader reader = command.ExecuteReader();
                int col = reader.FieldCount;
                while (reader.Read())
                {

                    res.Add(reader.GetValue(0).ToString());

                }

                reader.Close();

            }

            return res;

        }


        public List<string> GetColors()
        {
            List<string> res = new List<string>();
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbProdShop"].ConnectionString;
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = new SqlCommand($"Select Color FROM Main Group By Color ", connection);
                command.Transaction = transaction;

                SqlDataReader reader = command.ExecuteReader();
                int col = reader.FieldCount;
                while (reader.Read())
                {
                    res.Add(reader.GetValue(0).ToString());

                }

                reader.Close();

            }

            return res;

        }


        public string GetCaloryFromAll(string value, string type = null, string color = null)
        {
            string res = "0";
            if (type != null)
            {
                res = $"Select {value} (Calory)From Main Where Type =  '{type}'";
                if (color != null) { res += $" and Color = '{color}'"; }
            }
            else
                res = $"Select {value} (Calory)From Main";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbProdShop"].ConnectionString;
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = new SqlCommand(res, connection);
                command.Transaction = transaction;
                SqlDataReader reader = command.ExecuteReader();
                int col = reader.FieldCount;
                while (reader.Read())
                {
                    res = reader.GetValue(0).ToString();

                }

                reader.Close();

            }

            return res;

        }

         public async void InsertNew()
        {

            using (SqlConnection connection = new SqlConnection())
            {
                

                //-----------------------------------------------


                string sql = $"Insert INTO Main(Name,Type,Color,Calory) VALUES('{product.Name}' , '{product.Type}' , '{product.Color}' , '{product.Calory}')";
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbProdShop"].ConnectionString;

                connection.Open();
               // SqlTransaction transaction = connection.BeginTransaction();   --wtf +301qw
               
                  SqlCommand command = new SqlCommand(sql,connection);
               // command.Transaction = transaction;     --wtf why not working with this row
                
                 SqlDataReader reader = await command.ExecuteReaderAsync();
              
                //-----------------------------------------------
               
                
            }
           
        }


        public async void DelProd(string name)
        {

            string sql = $"Delete FROM Main Where name = '{name}'";
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbProdShop"].ConnectionString;

            connection.Open();
        

            SqlCommand command = new SqlCommand(sql, connection);
           

            SqlDataReader reader = await command.ExecuteReaderAsync();



        }
    }
}
