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

        #region Metodo Limpiar
        public void Limpiar()
        {
            this.txtIdOrigen.Text = "";
            this.txtPais.Text = "";
            this.txtCiudad.Text = "";           
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarOrigen()
        {
            try
            {
                List<ORIGEN> lstOrigen = Logica.obtOrigen();
                this.dataGrid.DataSource = lstOrigen;
                this.dataGrid.Refresh();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_Origen

        public ORIGEN processoBase()
        {
            ORIGEN origen = new ORIGEN();
            origen.IDORIGEN = Convert.ToInt16(txtIdOrigen.Text.Trim());
            origen.PAIS = txtPais.Text.Trim();
            origen.CIUDAD = txtCiudad.Text.Trim();
            return origen;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ORIGEN origen = new ORIGEN();
                //origen.IDORIGEN = Convert.ToInt16(txtIdOrigen.Text.Trim());
                origen.PAIS = txtPais.Text.Trim();
                origen.CIUDAD = txtCiudad.Text.Trim();
                _02LogicadeNegocios.Logica.GuardarDato(origen);
                MessageBox.Show("Origen Agregado");
                Limpiar(); this.Close();
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
                if (!txtIdOrigen.Text.Equals(""))
                {
                    ORIGEN pedidoIdUser = new ORIGEN();
                    pedidoIdUser.IDORIGEN = Convert.ToInt32(txtIdOrigen.Text.Trim());
                    List<ORIGEN> lstPedidos = _02LogicadeNegocios.Logica.BuscarDatoA(pedidoIdUser);
                    this.dataGrid.DataSource = lstPedidos;
                    this.dataGrid.Refresh();

                }
                else if (!txtPais.Text.Equals(""))
                {
                    ORIGEN pedidoIdUser = new ORIGEN();
                    pedidoIdUser.PAIS = txtPais.Text.Trim();
                    List<ORIGEN> lstPedidos = _02LogicadeNegocios.Logica.BuscarDatoB(pedidoIdUser);
                    this.dataGrid.DataSource = lstPedidos;
                    this.dataGrid.Refresh();
                }
                else if (txtIdOrigen.Text.Equals("") && txtPais.Text.Equals(""))
                {
                    CargarOrigen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Buscar Datos de Tabla Origen" + ex.Message);
            }
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                _02LogicadeNegocios.Logica.ModificarDato(processoBase());
                MessageBox.Show("Origen Editado");
                Limpiar(); this.Close();
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
                MessageBox.Show("Origen Eliminado");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Elminar Datos de Tabla Origen" + ex.Message);
            }
        }
        #endregion

        #region Evento Cargar Al Abrir
        private void Administrador_Origen_Load(object sender, EventArgs e)
        {
            this.CargarOrigen();
        }
        #endregion

        #region EventoDatagrid
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtIdOrigen.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtPais.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtCiudad.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();     
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}