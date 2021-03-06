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
        /// Also Includes all needed connection properties
        /// </summary>
        static string cnString = Libre_Engine.VarHold.connectionString;

        public static SQLiteConnection dbCn = new SQLiteConnection(cnString);

        public SQLiteConnection dbcn = new SQLiteConnection();

        public static SQLiteDataAdapter da = new SQLiteDataAdapter();

        /// <summary>
        /// DataTable Variable to hold Data for each operation
        /// </summary>
        public static DataTable dt = new DataTable();

        /// <summary>
        /// Table Names Added for Parameters to avoid SQL Injection
        /// </summary>

        //   static string[] columnNames = ("PKID" , "ID", "ResourceN", "ResourceLoc", "Author", "GradeLevel", "w_tags", "code_accss", "File");

        //commands

        static string _initiaLoad = "SELECT * FROM ResourceDB";

        //holder
        /// <summary>
        /// A universal string from this class that can be used as a message for exceptions
        /// </summary>
        public static string message;
        public static string _connectionStatus;
        public string connectionStatus()
        {
            if (dbCn.State == ConnectionState.Open)
            {
                return _connectionStatus = "Active";
            }
            else
            {
                return _connectionStatus = "Inactive";
            }
        }
        public static void InitialLoad()
        {
            string tableNameSearchName = Libre_Engine.VarHold.tableNames[0];
            string selectQuery = (_initiaLoad);
            SQLiteCommand sqlInitialLoadCommand = new SQLiteCommand(selectQuery, dbCn);
            try
            {
                dbCn.Open();
                da = new SQLiteDataAdapter(sqlInitialLoadCommand);
                da.Fill(dt);
                dbCn.Close();
            }
            catch (Exception e)
            {


            }
        }


        /// <summary>
        /// Advanced Search Class
        /// Responsible for Advance Filters and operations to be executed for specific results.
        /// 
        /// </summary>
    }
    public static class AdvanceSearch
    {

        static string connectionString = Libre_Update.Libre_Engine.VarHold.connectionString;
        static SQLiteConnection db_cn = new SQLiteConnection(connectionString);
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
            string tableNameSearchName = Libre_Engine.VarHold.tableNames[0];

            string selectQuery = ("SELECT * FROM " + tableNameSearchName);
            SQLiteCommand sqlInitialLoadCommand = new SQLiteCommand(selectQuery, db_cn);
            db_cn.Open();
            da = new SQLiteDataAdapter("SELECT * FROM ResourceDB WHERE ResourceN like '%" + _searchName + "%'", db_cn);
            dt.Clear();
            da.Fill(dt);
            DataView dv = new DataView(dt);


        }

    }
}
       
    


            
		
        
	
    
      
