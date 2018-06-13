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
    public partial class Administrador_Destino : Form
    {
        public Administrador_Destino()
        {
            InitializeComponent();
        }

        
        #region  Botones_Guardar_Buscar_Editar_Eliminar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DESTINO destino = new DESTINO();
                destino.PAIS = txtPais.Text.Trim();
                destino.CIUDAD = txtCiudad.Text.Trim();
                destino.IMPUESTO = Convert.ToInt16(txtImpuesto.Text.Trim());
                _02LogicadeNegocios.Logica.GuardarDato(destino);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar Datos de Destino" + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
