using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Libre_Update.Database_Modules
{
    public static class Libre_Engine
    {
        //PreRequisites
        public static string conection_String;
        static DataTable input_dt = new DataTable();
        public static DataTable out_dt = new DataTable();
        private static SQLiteDataAdapter da = new SQLiteDataAdapter();

        //LoadData Command
        public static string _da_load_data = "SELECT * FROM ResourceDB";

        //FilterByName
        public static string _da_filter_name_out;
        public static string filter_name(string filter_data)
        {
            return _da_filter_name_out = "SELECT * FROM ResourceDB WHERE RName LIKE '%" + filter_data + "%'";
        }


        
    }
}
