//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using SQLite;

//using Carry_In.View.Register.Models;


//namespace Carry_In.Data
//{
//    public class CarryInDatabase
//    {
//        static object locker = new object();

//        SQLiteConnection database;

//        string DatabasePath
//        {
//            get
//            {
//                var sqliteFilename = "CarryInSQLite.db3";
//#if __IOS__
//				string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
//				string libraryPath = Path.Combine (documentsPath, "..", "Library"); // Library folder
//				var path = Path.Combine(libraryPath, sqliteFilename);
//#else
//#if __ANDROID__
//                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
//                var path = Path.Combine(documentsPath, sqliteFilename);
//#else
//				// WinPhone
//				var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, sqliteFilename);;
//#endif
//#endif
//                return path;
//            }
//        }

//        /// <summary>
//        /// Initializes a new instance of the <see cref="Tasky.DL.TaskDatabase"/> TaskDatabase. 
//        /// if the database doesn't exist, it will create the database and all the tables.
//        /// </summary>
//        /// <param name='path'>
//        /// Path.
//        /// </param>
//        public CarryInDatabase()
//        {
//            database = new SQLiteConnection(DatabasePath);
//            // create the tables
//            //database.CreateTable<RegisterModel>();

//            database.CreateTable<RegisterModel>();
//        }

//        public IEnumerable<RegisterModel> GetUsers()
//        {
//            lock (locker)
//            {
//                return (from i in database.Table<RegisterModel>() select i).ToList();
//            }
//        }

//        public bool UserExists(string email)
//        {
//            lock (locker)
//            {
//                return database.Table<RegisterModel>().FirstOrDefault(user => user.Email == email) != null;
//            }
//        }

//        public RegisterModel GetUser(string email, string password)
//        {
//            lock (locker)
//            {
//                var user = database.Table<RegisterModel>().FirstOrDefault(x => x.Email == email && x.Password == password);

//                return user;
//            }
//        }

//        public int SaveUser(RegisterModel user)
//        {
//            lock (locker)
//            {
//                if (user.ID != 0)
//                {
//                    database.Update(user);
//                    return user.ID;
//                }
//                else
//                {
//                    return database.Insert(user);
//                }
//            }
//        }

//        public int DeleteUser(int id)
//        {
//            lock (locker)
//            {
//                return database.Delete<RegisterModel>(id);
//            }
//        }
//    }
//}

