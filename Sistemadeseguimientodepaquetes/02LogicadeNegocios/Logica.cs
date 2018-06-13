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

        #region Tablas

        #region Metodos Para Tabla DESTINO 
        public static void GuardarDato(DESTINO destino) //Metodo para Agregar informacion a la tabla DESTINO
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"INSERT INTO DESTINO VALUES ('" + destino.PAIS + "','" + destino.CIUDAD + "','" + destino.IMPUESTO + "')";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void ModificarDato(DESTINO destino) //Metodo para Modificar informacion en la tabla DESTINO
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"UPDATE DESTINO SET PAIS='" + destino.PAIS + "', CIUDAD='" + destino.CIUDAD + "', IMPUESTO='" + destino.IMPUESTO + "' WHERE IDDESTINO='" + destino.IDDESTINO + "'";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void EliminarDato(DESTINO destino) //Metodo para Eliminar informacion en la tabla DESTINO
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"DELETE FROM DESTINO WHERE IDDESTINO='" + destino.IDDESTINO + "'";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void BuscarDato(DESTINO destino) //Metodo para Buscar informacion en la tabla DESTINO
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }

        #endregion

        #region Metodos Para Tabla ENVIO 
        #endregion

        #region Metodos Para Tabla ESTADO 
        #endregion

        #region Metodos Para Tabla ORIGEN 
        #endregion

        #region Metodos Para Tabla PAGO 
        #endregion

        #region Metodos Para Tabla PEDIDOS 
        public static void GuardarDato(PEDIDO destino) //Metodo para Agregar informacion a la tabla DESTINO
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"INSERT INTO PEDIDOS VALUES ('" + destino.IDUSUARIO + "','" + destino.IDORIGEN + "','" + destino.IDDESTINO + "','" + destino.IDPAGO + "','" + destino.IDENVIO + "','" + destino.IDESTADO + "',,'" + destino.TOTAL + "',,'" + destino.DESCRIPCION + "')";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void ModificarDato(PEDIDO destino) //Metodo para Modificar informacion en la tabla DESTINO
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"UPDATE PEDIDOS SET IDUSUARIO='" + destino.IDUSUARIO + "', IDORIGEN='" + destino.IDORIGEN + "', IDDESTINO='" + destino.IDDESTINO + "', IDPAGO='" + destino.IDPAGO + "', IDENVIO='" + destino.IDENVIO + "', IDESTADO='" + destino.IDESTADO + "', TOTAL='" + destino.TOTAL + "', DESCRIPCION='" + destino.DESCRIPCION + "' WHERE IDPEDIDO='" + destino.IDPEDIDO + "'";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void EliminarDato(PEDIDO destino) //Metodo para Eliminar informacion en la tabla DESTINO
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"DELETE FROM PEDIDOS WHERE IDPEDIDO='" + destino.IDPEDIDO + "'";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void BuscarDato(PEDIDO destino) //Metodo para Buscar informacion en la tabla DESTINO
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        #endregion

        #region Metodos Para Tabla USUARIO
        public static void GuardarDato(USUARIO destino) //Metodo para Agregar informacion a la tabla DESTINO
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"INSERT INTO USUARIOS VALUES ('" + destino.NOMBRE + "','" + destino.ALIAS + "','" + destino.PASS+ "','" + destino.TIPO_USUARIO + "','" + destino.ESTADO_USUARIO + "')";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void ModificarDato(USUARIO destino) //Metodo para Modificar informacion en la tabla DESTINO
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"UPDATE USUARIOS SET NOMBRE='" + destino.NOMBRE + "', ALIAS='" + destino.ALIAS + "', PASS='" + destino.PASS + "', TIPO_USUARIO='" + destino.TIPO_USUARIO + "', ESTADO_USUARIO='" + destino.ESTADO_USUARIO + "' WHERE IDUSUARIO='" + destino.IDUSUARIO + "'";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void EliminarDato(USUARIO destino) //Metodo para Eliminar informacion en la tabla DESTINO
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"DELETE FROM USUARIOS WHERE IDUSUARIO='" + destino.IDUSUARIO + "'";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void BuscarDato(USUARIO destino) //Metodo para Buscar informacion en la tabla DESTINO
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        #endregion

        #endregion
    }
}
