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
    	//public static string Table {get; set;}
    	//public static string Query {get; set;}
    	//public static string[] Columns {get; set;}
		//static string default_path = Environment.CurrentDirectory;

        /// <summary>
        /// **Connection String**
        /// </summary>
		static string connectionString = "DataSource=" + Environment.CurrentDirectory + "\\LEARNAV.DB;Version=3";
		static SQLiteConnection dbCn = new SQLiteConnection(connectionString);
		static SQLiteDataAdapter da = new SQLiteDataAdapter();

        /// <summary>
        /// DataTable Variable to hold Data for each operation
        /// </summary>
		public static DataTable dt = new DataTable();
        

		//commands
        
		static string _initiaLoad = "SELECT * FROM ResourceDB";

        //holder
        public static string message;

		
        /// <summary>
        /// Initializes Loading of Data into Dashboard's ListView
        /// </summary>
		public static void InitialLoad()
		{
			try 
			{
			dbCn.Open();
            da = new SQLiteDataAdapter("SELECT * FROM ResourceDB", dbCn);
			da.Fill(dt);
			dbCn.Close();
			} catch (System.Exception e) 
			{  
					message = ("Error With Initial Load! \n Message: " + e.Message);
			}
		}
        }

		

    }
    /// <summary>
    /// Advanced Search Class
    /// Responsible for Advance Filters and operations to be executed for specific results.
    /// 
    /// </summary>
    public static class AdvanceSearch
    {
    	static string connection_string = "DataSource=" + Environment.CurrentDirectory + "\\LEARNAV.DB;Version=3";
		static SQLiteConnection db_cn = new SQLiteConnection(connection_string);
		static SQLiteDataAdapter da = new SQLiteDataAdapter();
		public static DataTable dt = new DataTable();
        /// <summary>
        /// Experimental DataTable for showing Filtered Name
        /// </summary>
        public static DataTable dtFilteredName = new DataTable();
        public static string _searchQuery
        {
            get;
            set;
        }

        /// <summary>
        /// Search the Database for specific Name
        /// <param name="_search_name" String Varialbe to place search string
        /// </summary>
        public static void searchName(string _searchName)
        {

            
        
        	dbCn.Open();
        	da = new SQLiteDataAdapter("SELECT * FROM ResourceDB WHERE ResourceN like '%" + _searchName + "%'" , db_cn);
            dt.Clear();
        	da.Fill(dt);
        	DataView dv = new DataView(dt);
           // dv.RowFilter = string.Format ("ID LIKE")

        }

      


}