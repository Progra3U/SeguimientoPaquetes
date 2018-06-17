﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //namespace para ADO.NET
using _04Entidades; //namespace que referencia a capa de entidades
using System.Data;

namespace _03AccesoDatos
{
    public class Acceso
    {
        #region Atributos

        private string cadenaConexion = Properties.Settings.Default.Conexion;
        private SqlConnection objConexion;


        #endregion

        #region Constructor

        public Acceso()
        {
            try
            {
                //iniciamos la conexion con la base de datos
                objConexion = new SqlConnection(cadenaConexion);
                ABRIR(); //Llamamos el metodo Abrir para abrirr la conexion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR(); //Llamamos el metodo Cerrar para cerrar la conexion
            }
        }

        #endregion

        #region Metodos para Abrir y cerrar Conexion

        private void ABRIR() //metodo para verificar si la conexion esta cerrada y abrirla
        {
            if (objConexion.State == System.Data.ConnectionState.Closed)
            {
                objConexion.Open();
            }
        }
        private void CERRAR()//metodo para verificar si la conexion esta abierta y cerrarla
        {
            if (objConexion.State == System.Data.ConnectionState.Open)
            {
                objConexion.Close();
            }
        }
        #endregion

        #region Metodo para enjecutar de Logica(update,delete,add)
        public int EjecutarSentencia(SQLSentencia objPeticion)
        {
            /*Este metodo se puede utilizar para actualizar, insertar o eliminar info en las tablas de la db*/
            try
            {
                SqlCommand cmd = new SqlCommand(); //instaciamos configuracion para hace4r peticiones por medio del  SqlCommand
                cmd.Connection = objConexion; //asgnacion de la conexion
                cmd.CommandText = objPeticion.PETICION; //Asignamos la peticion a ejecutar
                cmd.CommandType = System.Data.CommandType.Text; //determinamos el tipo de data
                ABRIR(); //abrimos la conexion
                return cmd.ExecuteNonQuery(); //Ejecutamos la peticion almacenada en cmd.CommandText
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
        }
        #endregion

        #region Metod para obtener Informacion de las Tablas
            #region Administrador_Destino
            public List<DESTINO> Obtener_Destino(SQLSentencia objsentencia)
            {
                List<DESTINO> lstDestino = new List<DESTINO>();
                System.Data.DataTable dt = new System.Data.DataTable();
                try
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = objsentencia.PETICION;
                    cmd.Connection = objConexion;
                    cmd.CommandType = System.Data.CommandType.Text;

                    SqlDataAdapter objcarga = new SqlDataAdapter(cmd);
                    objcarga.Fill(dt);

                    foreach (System.Data.DataRow item in dt.Rows)
                    {
                        DESTINO objDestino = new DESTINO();
                        objDestino.IDDESTINO = Convert.ToInt16(item.ItemArray[0].ToString());
                        objDestino.PAIS = item.ItemArray[1].ToString();
                        objDestino.CIUDAD = item.ItemArray[2].ToString();
                        objDestino.IMPUESTO = Convert.ToInt32(item.ItemArray[3].ToString());
                        lstDestino.Add(objDestino);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.CERRAR();
                }

                return lstDestino;
            }
            #endregion

            #region Administrador_Envios
            #endregion

            #region Administrador_Estados
            #endregion

            #region Administrador_Origen
            #endregion

            #region Administrador_Pagos
            #endregion

            #region Administrador_Pedido
            public List<PEDIDOS> Obtener_Pedidos(SQLSentencia objSentencia)
            {
                List<PEDIDOS> lstPedidos = new List<PEDIDOS>();
                System.Data.DataTable dt = new System.Data.DataTable();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = objSentencia.PETICION;
                    cmd.Connection = objConexion;
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataAdapter objcarga = new SqlDataAdapter(cmd);
                    objcarga.Fill(dt);
                    foreach (System.Data.DataRow item in dt.Rows)
                    {
                        PEDIDOS objPedido = new PEDIDOS();
                        objPedido.IDPEDIDO = Convert.ToInt32(item.ItemArray[0].ToString());
                        objPedido.IDUSUARIO = Convert.ToInt32(item.ItemArray[1].ToString());
                        objPedido.IDORIGEN = Convert.ToInt32(item.ItemArray[2].ToString());
                        objPedido.IDDESTINO = Convert.ToInt32(item.ItemArray[3].ToString());
                        objPedido.IDPAGO = Convert.ToInt32(item.ItemArray[4].ToString());
                        objPedido.IDENVIO = Convert.ToInt32(item.ItemArray[5].ToString());
                        objPedido.IDESTADO = Convert.ToInt32(item.ItemArray[6].ToString());
                        objPedido.TOTAL = Convert.ToInt32(item.ItemArray[7].ToString());
                        objPedido.DESCRIPCION = item.ItemArray[8].ToString();
                        lstPedidos.Add(objPedido);
                    }

                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    CERRAR();
                }
                return lstPedidos;
            }
            #endregion

            #region Administrador_Usuario
            public List<USUARIOS> Obtener_Usuarios(SQLSentencia objSentencia)
            {
                List<USUARIOS> lstUsuarios = new List<USUARIOS>();
                System.Data.DataTable dt = new System.Data.DataTable();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = objSentencia.PETICION;
                    cmd.Connection = objConexion;
                    cmd.CommandType = System.Data.CommandType.Text;
                    SqlDataAdapter objcarga = new SqlDataAdapter(cmd);
                    objcarga.Fill(dt);
                    foreach (System.Data.DataRow item in dt.Rows)
                    {
                        USUARIOS objUsuario = new USUARIOS();
                        objUsuario.IDUSUARIO = Convert.ToInt32(item.ItemArray[0].ToString());
                        objUsuario.NOMBRE = item.ItemArray[1].ToString();
                        objUsuario.ALIAS = item.ItemArray[2].ToString();
                        objUsuario.PASS = item.ItemArray[3].ToString();
                        objUsuario.TIPO_USUARIO = item.ItemArray[4].ToString();
                        objUsuario.ESTADO_USUARIO = item.ItemArray[5].ToString();
                        lstUsuarios.Add(objUsuario);
                    }

                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    CERRAR();
                }
                return lstUsuarios;
            }
            #endregion
        #endregion

        #region ProcesoLogin
        public DataTable ADLogin(_04Entidades.SQLSentencia objE)
        {
            SqlCommand cmd = new SqlCommand("LOGIN", objConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDUSER", objE.iduser);
            cmd.Parameters.AddWithValue("@PASSW", objE.password);
            //cmd.Parameters.AddWithValue("@TIPO_USER", objE.typeuser);
            //cmd.Parameters.AddWithValue("@NOMBREUSER", objE.nameUser);
            //cmd.Parameters.AddWithValue("@TIPO_USER", objE.typeuser);
            //cmd.Parameters.AddWithValue("@ESTADO_USER", objE.stateUser);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);
            return datatable;
        }
        #endregion

    }
}
