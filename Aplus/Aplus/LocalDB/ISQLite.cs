using System;
using System.Collections.Generic;
using System.Text;

namespace Aplus.LocalDB
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
