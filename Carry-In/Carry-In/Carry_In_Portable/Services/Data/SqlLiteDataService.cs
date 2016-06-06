using Carry_In.View.Register.Models;
using Carry_In.Services.Data.Connection;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Carry_In.Model;
using Carry_In.Services.Data;

namespace Carry_In.Services.Data
{
    public class LocalSqlDataService
    {
        static object locker = new object();

        private SQLiteConnection Connection {  get { return _DataConnectionService.Connection; } }
        private DataConnectionService _DataConnectionService;
        /// <summary>
        /// Initializes a new instance of the <see cref="Tasky.DL.TaskDatabase"/> TaskDatabase. 
        /// if the database doesn't exist, it will create the database and all the tables.
        /// </summary>
        /// <param name='path'>
        /// Path.
        /// </param>
        public LocalSqlDataService(DataConnectionService dataConnectionService)
        {
            _DataConnectionService = dataConnectionService;

            Connection.CreateTable<RegisterModel>();
        }

        public IEnumerable<RegisterModel> GetUsers()
        {
            lock (locker)
            {
                return (from i in Connection.Table<RegisterModel>() select i).ToList();
            }
        }

        public bool UserExists(string email)
        {
            lock (locker)
            {
                return Connection.Table<RegisterModel>().FirstOrDefault(user => user.Email == email) != null;
            }
        }

        public RegisterModel GetUser(string email, string password)
        {
            lock (locker)
            {
                var user = Connection.Table<RegisterModel>().FirstOrDefault(x => x.Email == email && x.Password == password);

                return user;
            }
        }

        public int SaveUser(RegisterModel user)
        {
            lock (locker)
            {
                if (user.ID != 0)
                {
                    Connection.Update(user);
                    return user.ID;
                }
                else
                {
                    return Connection.Insert(user);
                }
            }
        }

        public int DeleteUser(int id)
        {
            lock (locker)
            {
                return Connection.Delete<RegisterModel>(id);
            }
        }

        public IEnumerable<Model.Food> Foods()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Food> Foods(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Location> Locations()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Location> Locations(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Restaurant> Restaurants()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Restaurant> Restaurants(long id)
        {
            throw new NotImplementedException();
        }
    }



}
