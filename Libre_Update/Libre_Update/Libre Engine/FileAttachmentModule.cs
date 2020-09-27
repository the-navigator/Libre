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
	/// <summary>
	/// Stores all data to be stored in JSON file
	/// </summary>
	public class DataHolderClass
    {
      private List<FileObject> allObj = new List<FileObject>;
    }

    /// <summary>
    /// A File Object
    /// Stores Data of a FileObject to be stored in a JSON file
    /// Data includes Name, Extension, DateCreated and Special Characters
    /// </summary>
    public class FileObject
    {

    	public static string fileObjName {get;}
    	public static string fileObjExtension {get;}
    	public static string fileObjDateCreated {get;}
    	public static string fileObjSpecialCharacters {get;}

    	public static FileInfo fileInfoOfSelectedObj = new FileInfo(fileObjName);

    	/// <summary>
    	/// Constructor Used to define this Object
    	/// </summary>
    	public FileObject(string _fileObjName, string _fileObjExtension, string _fileObjDateCreated, string _fileObjSpecialCharacters)
    	{
    		this.fileObjName = _fileObjName;
    		this.fileObjExtension = _fileObjExtension;
    		this.fileObjDateCreated = _fileObjDateCreated;
    		this.fileObjSpecialCharacters = _fileObjSpecialCharacters;
    	}

    	public void AddFileAsObj (string filePath)
    	{
    		fileObjName = filePath;

    	}

    }

   
}