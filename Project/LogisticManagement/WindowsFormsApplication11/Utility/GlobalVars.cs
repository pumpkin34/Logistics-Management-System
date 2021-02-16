using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication11
{
    class GlobalVars
    {
        public static String DBConn
        {
            get { return ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString; }
        }
    }
}
