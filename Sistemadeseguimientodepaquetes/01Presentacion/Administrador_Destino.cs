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

        #region Metodo Limpiar
        public void Limpiar()
        {
            this.txtIdDestino.Text = "";
            this.txtPais.Text = "";
            this.txtCiudad.Text = "";
            this.txtImpuesto.Text = "";
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarDestinos()
        {
            try
            {
                List<DESTINO> lstDestino = Logica.obtDestinos();
                this.dataGrid.DataSource = lstDestino;
                this.dataGrid.Refresh();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_Destino
        public DESTINO processoBase()
        {
            DESTINO destino = new DESTINO();
            destino.IDDESTINO = Convert.ToInt16(txtIdDestino.Text.Trim());
            destino.PAIS = txtPais.Text.Trim();
            destino.CIUDAD = txtCiudad.Text.Trim();
            destino.IMPUESTO = Convert.ToInt16(txtImpuesto.Text.Trim());
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
                MessageBox.Show("Usuario Agregado");
                Limpiar(); this.Close();
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
                Limpiar(); this.Close();
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
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Elminar Datos de Tabla Destino" + ex.Message);
            }

        }
        #endregion

        #region Evento Cargar Al Abrir
        private void Administrador_Destino_Load(object sender, EventArgs e)
        {
            this.CargarDestinos();
        }
        #endregion

        #region EventoDatagrid
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtIdDestino.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtPais.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtCiudad.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.txtImpuesto.Text = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
