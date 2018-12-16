using System;
using System.IO;
using App1.Data;
using App1.iOS.Data;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteIOS))]

namespace App1.iOS.Data
{
    public class SQLiteIOS : ISQlite
    {
        public SQLiteIOS()
        {
        }

        public SQLiteConnection GetConnection()
        {
            var fileName = "TestDB.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }


    }
}