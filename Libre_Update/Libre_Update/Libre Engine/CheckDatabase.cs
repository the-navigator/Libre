using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;
using Newtonsoft.Json;


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

        public   SQLiteConnection dbcn = new SQLiteConnection();

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


        
    }
    /// <summary>
    /// Advanced Search Class
    /// Responsible for Advance Filters and operations to be executed for specific results.
    /// 
    /// </summary>
    public class QuickSearch
    {
        /// <summary>
        /// Quickly Searches the database for name
        /// </summary>
        /// <param name="searchItem">What to Search?</param>
        public void SearchName(string searchItem)
        {
            SQLiteConnection dc = new SQLiteConnection(VarHold.connectionString);
            dc.Open();
            using (dc)
            {
                string tableNameSearchName = Libre_Engine.VarHold.tableNames[0];
                SQLiteCommand _sqlCmn = new SQLiteCommand("SELECT * FROM " + tableNameSearchName + " WHERE ResourceN Like '%" + searchItem + "%'" , dc);
                SQLiteDataAdapter _sqlDa = new SQLiteDataAdapter(_sqlCmn);
                //VarHold.dataTableHolder.Clear();
                _sqlDa.Fill(VarHold.dataTableHolder);
                dc.Close();
            }


        }

        public void SearchWithGradeLevel(string gradeLevel, string categoryOfSearch, string searchItem)
        {
        }



    }
    //public static class SQLiteBlob : System.IO.Stream
    
    public class OpenResource
    {
        
        static string pathToExtract = Environment.CurrentDirectory + @"\ExtractFiles\";
       
        static string _file;
        static string ID;

        SQLiteConnection databaseConnection = new SQLiteConnection(VarHold.connectionString);
         static SQLiteCommand databaseCommand = new SQLiteCommand("SELECT * FROM BLOBTable WHERE ID=" + ID);

        SQLiteDataReader databaseReader = databaseCommand.ExecuteReader(System.Data.CommandBehavior.Default);
       
        public OpenResource(string _id)
        {   
            ID = _id;
        }
        
        public void OpenFile()
        {
             databaseConnection.Open();
       
            try 
            {
     
                while (databaseReader.Read())
                {
                    SQLiteBlob outputBlob = databaseReader.GetBlob(databaseReader.GetOrdinal("File"), readOnly:true);
                    SQLiteDataReader sqlDataRead = databaseCommand.ExecuteReader();

                    Int32 fileSize = databaseReader.GetInt32(databaseReader.GetOrdinal("File"));
                    byte[] fileData = new byte[fileSize];
                    databaseReader.GetBytes(databaseReader.GetInt32(databaseReader.GetOrdinal("File")), 0, fileData, 0, (int)fileSize);

                    string fileName = databaseReader.GetString(databaseReader.GetOrdinal("ResourceName"));
                    string fileExt = databaseReader.GetString(databaseReader.GetOrdinal("ResourceExt"));
                    string fullPath = pathToExtract + "\\" + fileName + fileExt;
                    FileStream fs = new FileStream(fullPath, FileMode.OpenOrCreate);
                    fs.Write(fileData, 0, (int)fileSize);
                    System.Diagnostics.Process.Start(fullPath);
                    

                    //BinaryWriter br = new BinaryWriter(fs);
                    //br.Write(
                }
            } finally{

            }
            
        }
    }
    



    }
     

}
       
    


            
		
        
	
    
      
