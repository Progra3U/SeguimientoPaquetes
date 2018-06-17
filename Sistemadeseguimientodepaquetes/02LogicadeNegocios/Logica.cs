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
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"INSERT INTO DESTINO VALUES ('" + destino.PAIS + "','" + destino.CIUDAD + "','" + destino.IMPUESTO + "')";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    objAcceso.EjecutarSentencia(sentencia);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            public static void ModificarDato(DESTINO destino) //Metodo para Modificar informacion en la tabla DESTINO
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"UPDATE DESTINO SET PAIS='" + destino.PAIS + "', CIUDAD='" + destino.CIUDAD + "', IMPUESTO='" + destino.IMPUESTO + "' WHERE IDDESTINO='" + destino.IDDESTINO + "'";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    objAcceso.EjecutarSentencia(sentencia);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            public static void EliminarDato(DESTINO destino) //Metodo para Eliminar informacion en la tabla DESTINO
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"DELETE FROM DESTINO WHERE IDDESTINO='" + destino.IDDESTINO + "'";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    objAcceso.EjecutarSentencia(sentencia);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            public static List<DESTINO> obtDestinos()
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT IDDESTINO, PAIS, CIUDAD, IMPUESTO FROM DESTINO";
                    Acceso objacceso = new Acceso();
                    return objacceso.Obtener_Destino(sentencia);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            } 
            public static void BuscarDato(DESTINO destino) //Metodo para Buscar informacion en la tabla DESTINO
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    objAcceso.EjecutarSentencia(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }

        #endregion

            #region Metodos Para Tabla ENVIO 
        public static void GuardarDato(ENVIO envio) //Metodo para Agregar informacion a la tabla Envio
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"INSERT INTO ENVIO VALUES ('" + envio.DESC_ENVIO + "','" + envio.PRECIO_ENVIO + "')";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void ModificarDato(ENVIO envio) //Metodo para Modificar informacion en la tabla envio

        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"UPDATE ENVIO SET IDENVIO='" + envio.IDENVIO + "', DESC_ENVIO='" + envio.DESC_ENVIO + "', , PRECIO_ENVIO='" + envio.PRECIO_ENVIO + "' WHERE IDENVIO='" + envio.IDENVIO + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static void EliminarDato(ENVIO envio) //Metodo para Eliminar informacion en la tabla envio

        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"DELETE FROM ENVIO WHERE IDENVIO='" + envio.IDENVIO + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<ENVIO> obtEnvio()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT IDENVIO, DESC_ENVIO, PRECIO_ENVIO FROM ENVIO";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Envio(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public static void BuscarDato(ENVIO envio) //Metodo para Buscar informacion en la tabla envio
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

            #region Metodos Para Tabla ESTADO 
        public static void GuardarDato(ESTADO estado) //Metodo para Agregar informacion a la tabla Estado
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"INSERT INTO ESTADO VALUES ('" + estado.DESC_ESTADO + "')";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarDato(ESTADO estado) //Metodo para Modificar informacion en la tabla Estado
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"UPDATE ESTADO SET IDESTADO='" + estado.IDESTADO + "', DESC_ESTADO='" + estado.DESC_ESTADO + "' WHERE IDESTADO='" + estado.IDESTADO + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EliminarDato(ESTADO estado) //Metodo para Eliminar informacion en la tabla Estado

        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"DELETE FROM ESTADO WHERE IDESTADO='" + estado.IDESTADO + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<ESTADO> obtEstado()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT IDESTADO, DESC_ESTADO  FROM ESTADO";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Estado(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void BuscarDato(ESTADO estado) //Metodo para Buscar informacion en la tabla Estado
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

            #region Metodos Para Tabla ORIGEN 
        public static void GuardarDato(ORIGEN origen) //Metodo para Agregar informacion a la tabla Origen
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"INSERT INTO ORIGEN VALUES ('" + origen.PAIS + "','" + origen.CIUDAD + "')";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarDato(ORIGEN origen) //Metodo para Modificar informacion en la tabla Origen
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"UPDATE ORIGEN SET IDORIGEN='" + origen.IDORIGEN + "', PAIS='" + origen.PAIS + "', CIUDAD='" + origen.CIUDAD + "' WHERE IDORIGEN='" + origen.IDORIGEN + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EliminarDato(ORIGEN origen) //Metodo para Eliminar informacion en la tabla origen
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"DELETE FROM ORIGEN WHERE IDORIGEN='" + origen.IDORIGEN + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<ORIGEN> obtOrigen()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT IDORIGEN, PAIS,CIUDAD FROM ORIGEN";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Origen(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void BuscarDato(ORIGEN origen) //Metodo para Buscar informacion en la tabla origen

        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

            #region Metodos Para Tabla PAGO
        public static void GuardarDato(PAGO pago) //Metodo para Agregar informacion a la tabla Pago
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"INSERT INTO PAGO VALUES ('" + pago.DESC_PAGO + "')";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public static void ModificarDato(PAGO pago) //Metodo para Modificar informacion en la tabla Pago
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"UPDATE PAGO SET IDPAGO='" + pago.IDPAGO + "', PAIS='" + pago.DESC_PAGO + "' WHERE IDPAGO='" + pago.IDPAGO + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EliminarDato(PAGO pago) //Metodo para Eliminar informacion en la tabla Pago
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"DELETE FROM PAGO WHERE IDPAGO='" + pago.IDPAGO + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<PAGO> obtPago()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT IDPAGO, DESC_PAGO FROM PAGO";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Pago(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void BuscarDato(PAGO pago) //Metodo para Buscar informacion en la tabla Pago
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

            #region Metodos Para Tabla PEDIDOS 
        public static void GuardarDato(PEDIDOS pedido) //Metodo para Agregar informacion a la tabla DESTINO
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"INSERT INTO PEDIDOS VALUES ('" + pedido.IDUSUARIO + "','" + pedido.IDORIGEN + "','" + pedido.IDDESTINO + "','" + pedido.IDPAGO + "','" + pedido.IDENVIO + "','" + pedido.IDESTADO + "',,'" + pedido.TOTAL + "',,'" + pedido.DESCRIPCION + "')";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    objAcceso.EjecutarSentencia(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            public static void ModificarDato(PEDIDOS pedido) //Metodo para Modificar informacion en la tabla DESTINO
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"UPDATE PEDIDOS SET IDUSUARIO='" + pedido.IDUSUARIO + "', IDORIGEN='" + pedido.IDORIGEN + "', IDDESTINO='" + pedido.IDDESTINO + "', IDPAGO='" + pedido.IDPAGO + "', IDENVIO='" + pedido.IDENVIO + "', IDESTADO='" + pedido.IDESTADO + "', TOTAL='" + pedido.TOTAL + "', DESCRIPCION='" + pedido.DESCRIPCION + "' WHERE IDPEDIDO='" + pedido.IDPEDIDO + "'";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    objAcceso.EjecutarSentencia(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            public static void EliminarDato(PEDIDOS pedido) //Metodo para Eliminar informacion en la tabla DESTINO
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"DELETE FROM PEDIDOS WHERE IDPEDIDO='" + pedido.IDPEDIDO + "'";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    objAcceso.EjecutarSentencia(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            public static List<PEDIDOS> obtPedidos()
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT IDPEDIDO, IDUSUARIO, IDORIGEN, IDDESTINO, IDPAGO, IDENVIO, IDESTADO, TOTAL, DESCRIPCION  FROM PEDIDOS";
                    Acceso objacceso = new Acceso();
                    return objacceso.Obtener_Pedidos(sentencia);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public static List<PEDIDOS> BuscarDatoU(PEDIDOS pedido) //Metodo para Buscar informacion en la tabla DESTINO
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT IDPEDIDO, IDUSUARIO, IDORIGEN, IDDESTINO, IDPAGO, IDENVIO, IDESTADO, TOTAL, DESCRIPCION  FROM PEDIDOS WHERE IDPEDIDO='"+ pedido.IDUSUARIO+ "'";
                    Acceso objacceso = new Acceso();
                    return objacceso.Obtener_Pedidos(sentencia);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public static List<PEDIDOS> BuscarDatoP(PEDIDOS pedido) //Metodo para Buscar informacion en la tabla DESTINO
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT IDPEDIDO, IDUSUARIO, IDORIGEN, IDDESTINO, IDPAGO, IDENVIO, IDESTADO, TOTAL, DESCRIPCION  FROM PEDIDOS WHERE IDPEDIDO='" + pedido.IDPEDIDO + "'";
                    Acceso objacceso = new Acceso();
                    return objacceso.Obtener_Pedidos(sentencia);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        #endregion

        #region Metodos Para Tabla USUARIO
        public static void GuardarDato(USUARIOS user) //Metodo para Agregar informacion a la tabla DESTINO
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"INSERT INTO USUARIOS VALUES ('" + user.NOMBRE + "','" + user.ALIAS + "','" + user.PASS + "','" + user.TIPO_USUARIO + "','" + user.ESTADO_USUARIO + "')";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    objAcceso.EjecutarSentencia(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            public static void ModificarDato(USUARIOS user) //Metodo para Modificar informacion en la tabla DESTINO
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"UPDATE USUARIOS SET NOMBRE='" + user.NOMBRE + "', ALIAS='" + user.ALIAS + "', PASS='" + user.PASS + "', TIPO_USUARIO='" + user.TIPO_USUARIO + "', ESTADO_USUARIO='" + user.ESTADO_USUARIO + "' WHERE IDUSUARIO='" + user.IDUSUARIO + "'";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    objAcceso.EjecutarSentencia(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            public static void EliminarDato(USUARIOS user) //Metodo para Eliminar informacion en la tabla DESTINO
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"DELETE FROM USUARIOS WHERE IDUSUARIO='" + user.IDUSUARIO + "'";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    objAcceso.EjecutarSentencia(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            public static List<USUARIOS> obtUsuarios()
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT IDUSUARIO, NOMBRE, ALIAS, PASS, TIPO_USUARIO, ESTADO_USUARIO FROM USUARIOS";
                    Acceso objacceso = new Acceso();
                    return objacceso.Obtener_Usuarios(sentencia);
            }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public static void BuscarDato(USUARIOS destino) //Metodo para Buscar informacion en la tabla DESTINO
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    objAcceso.EjecutarSentencia(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            #endregion

        #endregion
    }
}
