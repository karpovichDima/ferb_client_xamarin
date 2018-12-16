using System.Linq;
using App1.Models;
using SQLite;
using Xamarin.Forms;

namespace App1.Data
{
    public class UserDatabaseController
    {
        private static object locker = new object();
        private SQLiteConnection database;

        public UserDatabaseController()
        {
            database = DependencyService.Get<ISQlite>().GetConnection();
            database.CreateTable<User>();
        }

        public User GetUser()
        {
            lock (locker)
            {
                if (!database.Table<User>().Any())
                {
                    return null;
                }
                else
                {
                    return database.Table<User>().First();
                }

            }
        }
        
        public int SaveUser(User user)
        {
            lock (locker)
            {
                if (user.Id != 0)
                {
                    database.Update(user);
                    return user.Id;
                }
                else
                {
                    return database.Insert(user);
                }
            }
        }

        public int DeleteUser(int id)
        {
            lock (locker)
            {
                return database.Delete<User>(id);
            }
        }
    }
}