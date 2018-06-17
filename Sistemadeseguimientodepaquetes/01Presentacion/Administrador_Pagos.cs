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

        #region Metodo Limpiar
        public void Limpiar()
        {
            this.txtIdPago.Text = "";
            this.txtDescPago.Text = "";
           
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarPago()
        {
            try
            {
                List<PAGO> lstPago = Logica.obtPago();
                this.dataGrid.DataSource = lstPago;
                this.dataGrid.Refresh();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_Pago
        public PAGO processoBase()
        {
            PAGO pago = new PAGO();
            pago.IDPAGO = Convert.ToInt16(txtIdPago.Text.Trim());
            pago.DESC_PAGO = txtDescPago.Text.Trim();
            return pago;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                PAGO pago = new PAGO();
                //pago.IDPAGO = Convert.ToInt16(txtIdPago.Text.Trim());
                pago.DESC_PAGO = txtDescPago.Text.Trim();
                _02LogicadeNegocios.Logica.GuardarDato(pago);
                MessageBox.Show("Pago Agregado");
                Limpiar(); this.Close();
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

        #region Evento Cargar Al Abrir
        private void Administrador_Pago_Load(object sender, EventArgs e)
        {
            this.CargarPago();
        }
        #endregion

        #region EventoDatagrid
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtIdPago.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtDescPago.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}

    
