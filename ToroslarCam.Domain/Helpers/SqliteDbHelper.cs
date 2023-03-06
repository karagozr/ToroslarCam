using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToroslarCam.Domain.Helpers
{
    public static class SqliteDbHelper
    {
        public static string GetConnection(string dbName)
        {
            var path = DirectoryHelper.GetLocalDataPath("database");
            var res =  @$"DataSource={path}\\{dbName}.db";
            return res;
        }
    }
}
