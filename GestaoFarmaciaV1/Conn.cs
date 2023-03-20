using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFarmaciaV1
{
    class Conn
    {
        private static string server = @"(localdb)\v11.0";
        private static string dataBase = "db_farmacia";
        private static string user = "";
        private static string password = "";

        public static string StrCon
        {
            get { return "Data Source=" + server + "; Integrated Security=false;Initial Catalog=" + dataBase + "; User ID=" + user + "; Password=" + password; }
        }
    }
}
