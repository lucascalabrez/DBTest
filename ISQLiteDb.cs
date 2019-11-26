using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DBTest
{
    interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
