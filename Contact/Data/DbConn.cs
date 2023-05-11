using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Data
{
    public class DbConn
    {
        public string myConnection = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
    }
}
