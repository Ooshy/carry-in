using Carry_In.Services.Data.Connection;
using SQLite;

namespace Carry_In.Droid.Services
{
    public class AndroidDataConnectionService : DataConnectionService
    {
        private static readonly string SqlFilename = "CarryInSQLite.db3";
        private static readonly string DocumentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
        private static readonly string FullPath = System.IO.Path.Combine(DocumentsPath, SqlFilename);

        private SQLiteConnection _Connection;
        public SQLiteConnection Connection
        {
            get
            {
                return _Connection ?? 
                      (_Connection = new SQLiteConnection(FullPath, true));
            }
        }
    }
}