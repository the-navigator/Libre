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
    /// <summary>
    /// Enables Flexible Usage of Database
    /// </summary>
    public partial class DatabasePackageControl
    {
        /// <summary>
        /// Data Transferred to VarHold.databaseName for conection string
        /// </summary>
        public static string dbName;

      /// <summary>
      /// The Initial Code to run for checking and assigning databaseName for Connection String property
      /// </summary>
      public static void GetName()
      {
        string fileToRead =  System.IO.File.ReadAllText(Environment.CurrentDirectory + "\\DatabasePack\\databaseName.dbname");
     
        dbName = fileToRead;
        VarHold.DatabaseName = dbName;

      }

      public static void SelectNewDatabase()
      {
        string selectFolderToRead;
        
        //dbName = selectFolderToRead;
        
      }

     
    }

   
}