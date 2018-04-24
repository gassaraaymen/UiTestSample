using System;
using System.IO;
using Android.OS;
using SQLite;
using Xamarin.Forms;

using UiTestSample.Model;

[assembly: Dependency(typeof(UiTestSample.Droid.SQLiteDb))]
namespace UiTestSample.Droid
{
    public  class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}