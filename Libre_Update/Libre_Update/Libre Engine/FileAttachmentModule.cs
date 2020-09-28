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
    /*
	/// <summary>
	/// Stores all data to be stored in JSON file
	/// </summary>
	public class DataHolderClass
    {
      private List<FileObject> allObj = new List<FileObject>;
    }
     * */

    /// <summary>
    /// A File Object
    /// Stores Data of a FileObject to be stored in a JSON file
    /// Data includes Name, Extension, DateCreated and Special Characters
    /// </summary>
    public class FileObject
    {

    	public static string fileObjName {get; set;}
    	public static string fileObjExtension {get ;set;}
    	public static string fileObjDateCreated {get; set;}
    	public static string fileObjSpecialCharacters {get; set;}

    	public static FileInfo fileInfoOfSelectedObj = new FileInfo(fileObjName);

    	/// <summary>
    	/// Constructor Used to define this Object
    	/// </summary>
    	public FileObject(string _fileObjName, string _fileObjExtension, string _fileObjDateCreated, string _fileObjSpecialCharacters)
    	{
    		fileObjName = _fileObjName;
    		fileObjExtension = _fileObjExtension;
    		fileObjDateCreated = _fileObjDateCreated;
    		fileObjSpecialCharacters = _fileObjSpecialCharacters;
    	}

    	public void AddFileAsObj (string filePath)
    	{
    		fileObjName = filePath;

    	}

    }

   
}