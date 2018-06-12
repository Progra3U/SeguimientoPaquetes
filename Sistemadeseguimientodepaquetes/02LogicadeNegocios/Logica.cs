using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03AccesoDatos;
using _04Entidades;
using System.Data;

namespace _02LogicadeNegocios
{
    public class Logica
    {
        #region ProcesoLogin
        _03AccesoDatos.Acceso objAD = new _03AccesoDatos.Acceso();

        public DataTable LNlogin(_04Entidades.SQLSentencia objE)
        {
            return objAD.ADLogin(objE);
        }
        #endregion
    }
}
