using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _02LogicadeNegocios;
using _04Entidades;

namespace _01Presentacion
{
    public partial class Administrador_Usuario : Form
    {
        public Administrador_Usuario()
        {
            InitializeComponent();
        }

        #region Metodo Limpiar
        public void Limpiar()
        {
            txtIdUsuario.Text = "";
            txtNombre.Text = "";
            txtAlias.Text = "";
            txtPassword.Text = "";
            txtTipoUserCB.Text = "";
            txtEstadoCB.Text = "";
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarUsuarios()
        {
            try
            {
                List<USUARIOS> lstUsuarios = Logica.obtUsuarios();
                this.dataGrid.DataSource = lstUsuarios;
                this.dataGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar From Administrador_Usuario
        public USUARIOS processoBase()
        {
            USUARIOS user = new USUARIOS();
            user.IDUSUARIO = Convert.ToInt16(txtIdUsuario.Text.Trim());
            user.NOMBRE = txtNombre.Text.Trim();
            user.ALIAS = txtAlias.Text.Trim();
            user.PASS = txtPassword.Text.Trim();
            user.TIPO_USUARIO = txtTipoUserCB.Text.Trim();
            user.ESTADO_USUARIO = txtEstadoCB.Text.Trim();
            return user;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIOS user = new USUARIOS();
                user.NOMBRE = txtNombre.Text.Trim();
                user.ALIAS = txtAlias.Text.Trim();
                user.PASS = txtPassword.Text.Trim();
                user.TIPO_USUARIO = txtTipoUserCB.Text.Trim();
                user.ESTADO_USUARIO = txtEstadoCB.Text.Trim();
                _02LogicadeNegocios.Logica.GuardarDato(user);
                MessageBox.Show("Usuario Agregado");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar Datos en Tabla Destino" + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //Agregar proceso
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Buscar Datos de Tabla Destino" + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                _02LogicadeNegocios.Logica.ModificarDato(processoBase());
                MessageBox.Show("Usuario Editado");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Editar Datos de Tabla Destino" + ex.Message);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                _02LogicadeNegocios.Logica.EliminarDato(processoBase());
                MessageBox.Show("Usuario Borrado");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Elminar Datos de Tabla Destino" + ex.Message);
            }
        }
        #endregion

        #region Evento Cargar Al Abrir
        private void Administrador_Usuario_Load(object sender, EventArgs e)
        {
            this.CargarUsuarios();
        }
        #endregion

        #region EventoDatagrid
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtIdUsuario.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtNombre.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtAlias.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.txtPassword.Text = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.txtTipoUserCB.Text = dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.txtEstadoCB.Text = dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                /*Preguntar al profe como llenar un combo con datos directos desde la base 
                 y no quemados*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
