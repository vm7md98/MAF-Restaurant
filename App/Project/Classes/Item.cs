using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Project_v1.Classes
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string CoverPhoto { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }





        public static DataTable GetItemName(string ItemName)

        {

            //Open a Database connection

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = Config.GetConnectionStr();

            conn.Open();



            //prepare sql command

            string sql = "select * from Items where ItemName like @item_name";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("item_name", "%" + ItemName + "%");



            //create data adapter

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);



            conn.Close();

            da.Dispose();


            return dt;

        }



        public static List<Item> GetAllItems()
        {
            XDocument doc = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/items.xml"));

            var Items = from r in doc.Descendants("item")
                        select new Item
                        {
                            ItemId = int.Parse( r.Element("itemid").Value),
                            ItemName = r.Element("itemname").Value,
                            CoverPhoto = r.Element("coverphoto").Value,
                            Price = int.Parse(r.Element("price").Value),
                            CategoryId = int.Parse(r.Element("categoryid").Value)
                        };

            return Items.ToList();
        }

        public static List<Item> GetItemByPrice(double min, double max)
        {
            XDocument doc = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/items.xml"));

            //double Price = Convert.ToDouble(doc.Element("price").Value);

            var Items = from r in doc.Descendants("item")
                        where double.Parse(r.Element("price").Value) >= min && Convert.ToDouble(r.Element("price").Value) <= max
                        select new Item
                        {
                            ItemId = int.Parse(r.Element("itemid").Value),
                            ItemName = r.Element("itemname").Value,
                            CoverPhoto = r.Element("coverphoto").Value,
                            Price = int.Parse(r.Element("price").Value),
                            CategoryId = int.Parse(r.Element("categoryid").Value)

                        };

            return Items.ToList();
        }



    }
}