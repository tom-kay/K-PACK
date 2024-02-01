using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Business.Models.Dao
{
    internal class DbContext
    {
        protected SqlConnection Conexion = new SqlConnection(
            "Server=DESKTOP-4FVONF2;DataBase=Practica_Patrones;Integrated Security=true");
    }
}
