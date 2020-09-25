using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Libre_Update.Libre_Engine
{
    public class CheckDatabase
    {
    	public static string Table {get; set;}
    	public static string Query {get; set;}
    	public static string[] Columns {get; set;}
		static string default_path = Environment.CurrentDirectory;
		public static string connection_string = "DataSource=" + default_path + "\\LEARNAV.DB;Version=3";
		static SQLiteConnection db_cn = new SQLiteConnection(connection_string);
		static SQLiteDataAdapter da = new SQLiteDataAdapter();
		public static DataTable dt = new DataTable();

		//commands
		static string _initial_load = "SELECT * FROM ResourceDB";

        //holder
        public static string message;

		

		public static void InitialLoad()
		{
			try 
			{
			db_cn.Open();
			da = new SQLiteDataAdapter(_initial_load, db_cn);
			da.Fill(dt);
			db_cn.Close();
			} catch (System.Exception e) 
			{
                
					message = ("Error With Initial Load! \n Message: " + e.Message);

			}
				

		}
        }

		

    }

    public class Search_Name
    {
        public static string _search_query
        {
            get;
            set;
        }

      


}