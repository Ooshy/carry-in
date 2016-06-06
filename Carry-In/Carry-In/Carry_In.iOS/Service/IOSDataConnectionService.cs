using Carry_In.Services.Data.Connection;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carry_In.iOS.Service
{
    public class IOSDataConnectionService : DataConnectionService
    {
        public static readonly string SqlFilename = "CarryInSQLite.db3";
        public static readonly string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
        public static readonly string libraryPath = System.IO.Path.Combine(documentsPath, "..", "Library"); // Library folder

        private SQLiteConnection _Connection;
        public SQLiteConnection Connection
        {
            get
            {
                return _Connection ??
                      (_Connection = new SQLiteConnection(System.IO.Path.Combine(libraryPath, SqlFilename), true));

            }
        }
    }
}
