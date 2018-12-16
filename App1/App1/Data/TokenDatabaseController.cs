using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App1.Models;
using SQLite;
using Xamarin.Forms;

namespace App1.Data
{
    public class TokenDatabaseController
    {
        private static object locker = new object();
        private SQLiteConnection database;

        public TokenDatabaseController()
        {
            database = DependencyService.Get<ISQlite>().GetConnection();
            database.CreateTable<Token>();
        }

        public Token GetToken()
        {
            lock (locker)
            {
                if (!database.Table<Token>().Any())
                {
                    return null;
                }
                else
                {
                    return database.Table<Token>().First();
                }

            }
        }

        public int SaveToken(Token user)
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

        public int DeleteToken(int id)
        {
            lock (locker)
            {
                return database.Delete<Token>(id);
            }
        }
    }
}
