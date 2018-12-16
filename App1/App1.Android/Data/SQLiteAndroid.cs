using System.IO;
using App1.Data;
using App1.Droid.Data;
using SQLite;
using Xamarin.Forms;
using Environment = System.Environment;

[assembly: Dependency(typeof(SQLiteAndroid))]

namespace App1.Droid.Data
{
    public class SQLiteAndroid : ISQlite
    {
        public SQLiteAndroid()
        {
        }

        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "TestDB.db3";
            string documentsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}