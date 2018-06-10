using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _02LogicadeNegocios
{
    public class Logica
    {
        #region Login
        _03AccesoDatos.Acceso objd = new _03AccesoDatos.Acceso();

        public DataTable LNlogin(_04Entidades.SQLSentencia obj)
        {
            return objd.ADLogin(obj);
        }
        #endregion
    }
}
