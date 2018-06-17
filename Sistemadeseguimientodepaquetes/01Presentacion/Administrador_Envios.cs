using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _04Entidades;
using _02LogicadeNegocios;

namespace _01Presentacion
{
    public partial class Administrador_Envios : Form
    {
        public Administrador_Envios()
        {
            InitializeComponent();
        }
        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_Envio
        public ENVIO processoBase()
        {
            ENVIO envio = new ENVIO();
            envio.IDENVIO = Convert.ToInt16(txtIdEnvio.Text.Trim());
            envio.DESC_ENVIO = txtDesc.Text.Trim();
            envio.PRECIO_ENVIO = Convert.ToInt32(txtPrecio.Text.Trim());
            return envio;
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                _02LogicadeNegocios.Logica.EliminarDato(processoBase());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Elminar Datos de Tabla Envio" + ex.Message);
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
                MessageBox.Show("Error al Editar Datos de Tabla Envio" + ex.Message);
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
                MessageBox.Show("Error al Buscar Datos de Tabla Envio" + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ENVIO envio = new ENVIO();
                envio.IDENVIO = Convert.ToInt16(txtIdEnvio.Text.Trim());
                envio.DESC_ENVIO = txtDesc.Text.Trim();
                envio.PRECIO_ENVIO = Convert.ToInt32(txtPrecio.Text.Trim());
                _02LogicadeNegocios.Logica.GuardarDato(envio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar Datos en Tabla Envio" + ex.Message);
            }
        }
        #endregion
    }
}
