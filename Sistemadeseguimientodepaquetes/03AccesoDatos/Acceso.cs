﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //namespace para ADO.NET
using _04Entidades; //namespace que referencia a capa de entidades

namespace _03AccesoDatos
{
    public class Acceso
    {
        #region Atributos

        private string cadenaConexion; //pendiente el string de conexion a db
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
        #region Metodos

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
    }
}