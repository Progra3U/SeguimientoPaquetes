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

        #region MetodosGuardarDatosEnTablas
        public static void GuardarDato(DESTINO destino) //Metodo para agregar usuario
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"INSERT INTO Usuarios VALUES ('" + destino.PAIS + "','" + destino.CIUDAD + "','" + destino.IMPUESTO + "')";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        #endregion
    }
}
