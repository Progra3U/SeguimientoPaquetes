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

        #region  Botones_Guardar_Buscar_Editar_Eliminar From Administrador_Usuario
        public USUARIO processoBase()
        {
            USUARIO destino = new USUARIO();
            destino.IDUSUARIO = Convert.ToInt16(txtIdUsuario.Text.Trim());
            destino.NOMBRE = txtNombre.Text.Trim();
            destino.ALIAS = txtAlias.Text.Trim();
            destino.PASS = txtPassword.Text.Trim();
            destino.TIPO_USUARIO = txtTipoUserCB.Text.Trim();
            destino.ESTADO_USUARIO = txtEstadoCB.Text.Trim();
            return destino;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO destino = new USUARIO();
                destino.IDUSUARIO = Convert.ToInt16(txtIdUsuario.Text.Trim());
                destino.NOMBRE = txtNombre.Text.Trim();
                destino.ALIAS = txtAlias.Text.Trim();
                destino.PASS = txtPassword.Text.Trim();
                destino.TIPO_USUARIO = txtTipoUserCB.Text.Trim();
                destino.ESTADO_USUARIO = txtEstadoCB.Text.Trim();
                _02LogicadeNegocios.Logica.GuardarDato(destino);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Elminar Datos de Tabla Destino" + ex.Message);
            }

        }
        #endregion
    }
}
