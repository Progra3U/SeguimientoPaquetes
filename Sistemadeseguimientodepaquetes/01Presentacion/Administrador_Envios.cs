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
        #region Metodo Limpiar
        public void Limpiar()
        {
            this.txtIdEnvio.Text = "";
            this.txtDesc.Text = "";
            this.txtPrecio.Text = "";
            
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarEnvios()
        {
            try
            {
                List<ENVIO> lstEnvio = Logica.obtEnvio();
                this.dataGrid.DataSource = lstEnvio;
                this.dataGrid.Refresh();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

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
                MessageBox.Show("Envio Borrado");
                Limpiar(); this.Close();
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
                MessageBox.Show("Envio Editado");
                Limpiar(); this.Close();
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
                if (!txtIdEnvio.Text.Equals(""))
                {
                    ENVIO pedidoIdUser = new ENVIO();
                    pedidoIdUser.IDENVIO = Convert.ToInt32(txtIdEnvio.Text.Trim());
                    List<ENVIO> lstPedidos = _02LogicadeNegocios.Logica.BuscarDatoA(pedidoIdUser);
                    this.dataGrid.DataSource = lstPedidos;
                    this.dataGrid.Refresh();

                }
                else if (!txtDesc.Text.Equals(""))
                {
                    ENVIO pedidoIdUser = new ENVIO();
                    pedidoIdUser.DESC_ENVIO = txtDesc.Text.Trim();
                    List<ENVIO> lstPedidos = _02LogicadeNegocios.Logica.BuscarDatoB(pedidoIdUser);
                    this.dataGrid.DataSource = lstPedidos;
                    this.dataGrid.Refresh();
                }
                else if (txtIdEnvio.Text.Equals("") && txtDesc.Text.Equals(""))
                {
                    CargarEnvios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Buscar Datos de Tabla Envios" + ex.Message);
            }
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ENVIO envio = new ENVIO();
                //envio.IDENVIO = Convert.ToInt16(txtIdEnvio.Text.Trim());
                envio.DESC_ENVIO = txtDesc.Text.Trim();
                envio.PRECIO_ENVIO = Convert.ToInt32(txtPrecio.Text.Trim());
                _02LogicadeNegocios.Logica.GuardarDato(envio);
                MessageBox.Show("Envio Agregado");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar Datos en Tabla Envio" + ex.Message);
            }
        }
        #endregion
       
        #region Evento Cargar Al Abrir
        private void Administrador_Envio_Load(object sender, EventArgs e)
        {
            this.CargarEnvios();
        }
        #endregion

        #region EventoDatagrid
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtIdEnvio.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtDesc.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtPrecio.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
