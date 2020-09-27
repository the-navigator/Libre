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
    	/// <summary>
    	/// Connection String, Primary Connection String
    	/// </summary>
    	public static string connectionString = "DataSource=" + Environment.CurrentDirectory + "\\LEARNAV.DB;Version=3";

    	/// <summary>
    	/// Column Names in the curretn database
    	/// </summary>
    	public static string[] columnNames = ["PKID", "ID", "ResourceN", "ResourceLoc", "Author", "GradeLevel", "w_tags", "code_accss", "File"];

    	/// <summary>
    	/// Table Names
    	/// </summary>
    	static string[] tableNames = ["ResourceDB", "SandboxDB"];

    }
}