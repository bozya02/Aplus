using System;
using Aplus.Droid;
using System.IO;
using Xamarin.Forms;
using Aplus.LocalDB;

[assembly: Dependency(typeof(Aplus_Android))]
namespace Aplus.Droid
{
    public class Aplus_Android : ISQLite
    {
        public Aplus_Android() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            return path;
        }
    }
}