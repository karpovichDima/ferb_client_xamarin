using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1.Data
{
    public interface ISQlite
    {
        SQLiteConnection GetConnection();
    }
}
