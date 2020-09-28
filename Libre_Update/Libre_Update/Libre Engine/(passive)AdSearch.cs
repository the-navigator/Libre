  /// <summary>
        /// Advanced Search Class
        /// Responsible for Advance Filters and operations to be executed for specific results.
        /// 
        /// </summary>

    public static class AdvanceSearch
    {
        
        private string connectionString = Libre_Update.Libre_Engine.VarHold.connectionString;
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
            private string tableNameSearchName = Libre_Engine.VarHold.tableNames[0];

            string selectQuery = ($"SELECT * FROM {tableNameSearchName}");
            SQLiteCommand sqlInitialLoadCommand = new SQLiteCommand(selectQuery, dbCn);
            try 
            {
              dbCn.Open();
            da = new SQLiteDataAdapter("SELECT * FROM ResourceDB WHERE ResourceN like '%" + _searchName + "%'" , db_cn);
            dt.Clear();
            da.Fill(dt);
            DataView dv = new DataView(dt);  
            } catch {System.Exception ae) 
            {
                
            } 

        }