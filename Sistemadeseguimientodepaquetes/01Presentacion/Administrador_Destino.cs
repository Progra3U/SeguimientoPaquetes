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


        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_Destino
        public DESTINO processoBase()
        {
            DESTINO destino = new DESTINO();
            destino.IDDESTINO = Convert.ToInt16(txtIdDestino.Text.Trim());
            destino.PAIS = txtPais.Text.Trim();
            destino.CIUDAD = txtCiudad.Text.Trim();
            destino.IMPUESTO = Convert.ToInt16(txtImpuesto.Text.Trim());
            //_02LogicadeNegocios.Logica.GuardarDato(destino);
            return destino;
        }

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
