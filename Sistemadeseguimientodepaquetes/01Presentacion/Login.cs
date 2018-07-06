﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //para poder mover la ventana
using System.Data.SqlClient; //para conexion de db quitar despues de las pruebas
using _04Entidades; //referencio la solucion Entidades para pasar el nombre por parametro

namespace _01Presentacion
{
    public partial class FormLogin : Form
    {
        //referenciamos las librerias de Entidades y Logica de negocions
        _04Entidades.SQLSentencia objE = new _04Entidades.SQLSentencia();
        _02LogicadeNegocios.Logica objLN = new _02LogicadeNegocios.Logica();

        public FormLogin()
        {
            InitializeComponent();
        }
        #region BotonesBarraArriba
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region CodigoMoverVentana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /*buscamos en la barra de arriba el evento MouseDown, le damos
         doble click y se agrega:
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        */
        private void BarraPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region CodigoLoginELIMINARPOSTERIORMENTE
        /*SqlConnection con = new SqlConnection(@"Server=JPRR1ER\SQLSERVER;Database=SeguimientoPaquetesTest;Trusted_Connection=True;");
        public void login(string usuario, string password)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_usuario FROM Usuarios Where Usuario = @Usuario AND password = @Password", con);
                cmd.Parameters.AddWithValue("Usuario", usuario);
                cmd.Parameters.AddWithValue("Password", password);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        new Administrador(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "User")
                    {
                        new Usuario(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Client")
                    {
                        new Cliente(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña Invalidos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }*/
        #endregion

        #region Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                #region ProcesoLogin
                DataTable dt = new DataTable();
                objE.iduser = txtUsuario.Text;
                objE.password = txtPassword.Text;
                //objE.typeuser = comboTipo.Text;
                dt = objLN.LNlogin(objE);

                //creo objeto Usuario
                USUARIOS user = new USUARIOS();
                user.NOMBRE = dt.Rows[0][1].ToString(); //asigno el elemento [0][1] del dt al objeto use en su atributo nombre
                user.IDUSUARIO = Convert.ToInt32(dt.Rows[0][0].ToString());

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][4].ToString() == "ADMIN" && dt.Rows[0][5].ToString() == "ACTIVO")
                    {
                        new Administrador(user).Show();
                    }
                    else if (dt.Rows[0][4].ToString() == "USER" && dt.Rows[0][5].ToString() == "ACTIVO")
                    {
                        new Usuario(user).Show();
                    }
                    else if (dt.Rows[0][4].ToString() == "CLIENT" && dt.Rows[0][5].ToString() == "ACTIVO")
                    {
                        new Cliente(user).Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario Inactivo",
                                   "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Show();
                    }
                }
                /*else
                {
                    MessageBox.Show("Usuario o contraseña Invalidos");
                }*/
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuario o contraseña Invalidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
