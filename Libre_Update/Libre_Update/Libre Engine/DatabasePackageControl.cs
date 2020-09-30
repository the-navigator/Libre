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

    public class DatabasePackageControl
    {
    	public static string databaseName {get; set;}

    	public static void CheckDatabaseName()
    	{
    		string pathToCheck = Environment.CurrentDirectory + "\\DatabasePack";
    		var dbNameFromJSON = JsonConvert.DeserializeObject<DatabaseNameObj>(File.ReadAllText(pathToCheck));
    		var NameHolder n = New NameHolder();
    		Libre_Engine.VarHold.
    	}
    }

    public class DatabaseName 
    {
    	public string objName {set; get;}
    	public string dbName {set; get;}
    }

    public class DatabaseNameObj
    {
    	public Dictionary<string, DatabaseName> NameHolder {set; get;}
    }
    }
}