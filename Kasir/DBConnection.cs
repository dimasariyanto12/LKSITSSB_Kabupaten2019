using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasir
{
    class DBConnection
    {
        public string MyConnection()
        {
            string Con = @"Data Source=DESKTOP-F99RU1A\DIMASSQL;Initial Catalog=dbkasir;Integrated Security=True";
            return Con;
        }
    }
}
