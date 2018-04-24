using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace UiTestSample.Model
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
