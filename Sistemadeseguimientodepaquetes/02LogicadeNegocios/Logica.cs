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
        public static void GuardarDato(ENVIO envio) //Metodo para Agregar informacion a la tabla Envio
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"INSERT INTO ENVIO VALUES ('" + envio.IDENVIO + "','" + envio.DESC_ENVIO + "','"+ "')";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void ModificarDato(ENVIO envio) //Metodo para Modificar informacion en la tabla envio
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"UPDATE ENVIO SET IDENVIO='" + envio.IDENVIO + "', DESC_ENVIO='" + envio.DESC_ENVIO+ "', IMPUESTO='" + "' WHERE IDENVIO='" + envio.IDENVIO + "'";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void EliminarDato(ENVIO envio) //Metodo para Eliminar informacion en la tabla envio
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"DELETE FROM ENVIO WHERE IDENVIO='" + envio.IDENVIO + "'";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void BuscarDato(ENVIO envio) //Metodo para Buscar informacion en la tabla envio
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }

        #endregion

        #region Metodos Para Tabla ESTADO 
        public static void GuardarDato(ESTADO estado) //Metodo para Agregar informacion a la tabla Estado
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"INSERT INTO ESTADO VALUES ('" + estado.IDESTADO + "','" + estado.DESC_ESTADO + "','" + "')";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void ModificarDato(ESTADO estado) //Metodo para Modificar informacion en la tabla Estado
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"UPDATE ESTADO SET IDESTADO='" + estado.IDESTADO + "', DESC_ESTADO='" + estado.DESC_ESTADO  + "' WHERE IDESTADO='" + estado.IDESTADO + "'";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void EliminarDato(ESTADO estado) //Metodo para Eliminar informacion en la tabla Estado
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"DELETE FROM ESTADO WHERE IDESTADO='" + estado.IDESTADO+ "'";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void BuscarDato(ESTADO estado) //Metodo para Buscar informacion en la tabla Estado
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }

        #endregion

        #region Metodos Para Tabla ORIGEN 
        public static void GuardarDato(ORIGEN origen) //Metodo para Agregar informacion a la tabla Origen
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"INSERT INTO ORIGEN VALUES ('" + origen.IDORIGEN + "','" + origen.PAIS + "','" +origen.CIUDAD +"')";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void ModificarDato(ORIGEN origen) //Metodo para Modificar informacion en la tabla Origen
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"UPDATE ORIGEN SET IDORIGEN='" + origen.IDORIGEN + "', PAIS='" + origen.PAIS + "', CIUDAD='" + origen.CIUDAD + "' WHERE IDORIGEN='" + origen.IDORIGEN + "'";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void EliminarDato(ORIGEN origen) //Metodo para Eliminar informacion en la tabla origen
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"DELETE FROM ORIGEN WHERE IDORIGEN='" + origen.IDORIGEN + "'";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void BuscarDato(ORIGEN origen) //Metodo para Buscar informacion en la tabla origen
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        #endregion

        #region Metodos Para Tabla PAGO 
        public static void GuardarDato(PAGO pago) //Metodo para Agregar informacion a la tabla Pago
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"INSERT INTO PAGO VALUES ('" + pago.IDPAGO + "','" + pago.DESC_PAGO + "','" + "')";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void ModificarDato(PAGO pago) //Metodo para Modificar informacion en la tabla Pago
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"UPDATE PAGO SET IDPAGO='" + pago.IDPAGO + "', PAIS='" + pago.DESC_PAGO + "' WHERE IDPAGO='" + pago.IDPAGO + "'";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void EliminarDato(PAGO pago) //Metodo para Eliminar informacion en la tabla Pago
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"DELETE FROM PAGO WHERE IDPAGO='" + pago.IDPAGO + "'";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
        public static void BuscarDato(PAGO pago) //Metodo para Buscar informacion en la tabla Pago
        {
            SQLSentencia sentencia = new SQLSentencia();
            sentencia.PETICION = @"";
            _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
            objAcceso.EjecutarSentencia(sentencia);
        }
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
