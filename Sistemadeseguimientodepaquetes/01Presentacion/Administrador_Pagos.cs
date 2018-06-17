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
    public partial class Administrador_Pagos : Form
    {
        public Administrador_Pagos()
        {
            InitializeComponent();
        }

        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_Pago
        public PAGO processoBase()
        {
            PAGO pago = new PAGO();
            pago.IDPAGO = Convert.ToInt16(txtpag.Text.Trim());
            pago.DESC_PAGO = texdes.Text.Trim();
            return pago;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                PAGO pago = new PAGO();
                pago.IDPAGO = Convert.ToInt16(txtpag.Text.Trim());
                pago.DESC_PAGO = texdes.Text.Trim();
                _02LogicadeNegocios.Logica.GuardarDato(pago);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar Datos en Tabla Pago" + ex.Message);
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
                MessageBox.Show("Error al Buscar Datos de Tabla Pago" + ex.Message);
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
                MessageBox.Show("Error al Editar Datos de Tabla Pago" + ex.Message);
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
                MessageBox.Show("Error al Elminar Datos de Tabla Pago" + ex.Message);
            }

        }
        #endregion
    }
}