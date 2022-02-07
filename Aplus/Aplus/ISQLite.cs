using System;
using System.Collections.Generic;
using System.Text;

namespace Aplus
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
