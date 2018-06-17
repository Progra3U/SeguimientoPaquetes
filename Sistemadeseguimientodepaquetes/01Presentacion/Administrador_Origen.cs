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
    public partial class Administrador_Origen : Form
    {
        public Administrador_Origen()
        {
            InitializeComponent();
        }
        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_Origen

        public ORIGEN processoBase()
        {
            ORIGEN origen = new ORIGEN();
            origen.IDORIGEN = Convert.ToInt16(texori.Text.Trim());
            origen.PAIS = tpais.Text.Trim();
            origen.CIUDAD = cuidad.Text.Trim();
            return origen;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ORIGEN origen = new ORIGEN();
                origen.IDORIGEN = Convert.ToInt16(texori.Text.Trim());
                origen.PAIS = tpais.Text.Trim();
                origen.CIUDAD = cuidad.Text.Trim();
                _02LogicadeNegocios.Logica.GuardarDato(origen);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar Datos en Tabla Origen" + ex.Message);
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
                MessageBox.Show("Error al Buscar Datos de Tabla Origen" + ex.Message);
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
                MessageBox.Show("Error al Editar Datos de Tabla Origen" + ex.Message);
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
                MessageBox.Show("Error al Elminar Datos de Tabla Origen" + ex.Message);
            }

        }
        #endregion
    }
}
