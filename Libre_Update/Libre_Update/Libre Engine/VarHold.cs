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
    public class VarHold
    {
        public static string DatabaseName;
    	/// <summary>
    	/// Connection String, Primary Connection String
    	/// </summary>
    	public static string connectionString = "DataSource=" + Environment.CurrentDirectory + "\\DatabasePack\\" + DatabaseName +";Version=3";

        /// <summary>
        /// DatabaseConnection
        /// </summary>
        public SQLiteConnection databaseConnection = new SQLiteConnection(connectionString);

        /// <summary>
        /// DataTable to hold data
        /// </summary>
        public static DataTable dataTableHolder = new DataTable();

      



    	/// <summary>
    	/// Column Names in the curretn database
    	/// </summary>
    	public static string[] columnNames = {"PKID", "ID", "ResourceN", "ResourceLoc", "Author", "GradeLevel", "w_tags", "code_accss", "File"};

    	/// <summary>
    	/// Table Names
    	/// </summary>
    	public static string[] tableNames = {"ResourceDB", "SandboxDB", "BLOBTable"};

 

        public static void AssignName()
        {
            connectionString = "DataSource=" + Environment.CurrentDirectory + "\\DatabasePack\\" + DatabaseName + ";Version=3";
        }

    }
}