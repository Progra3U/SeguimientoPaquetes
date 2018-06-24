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
    public partial class Cliente_Pedido : Form
    {
        public Cliente_Pedido(string codigo)
        {
            InitializeComponent();
            txtIdUsuario.Text = codigo;
        }

        #region Metodo Limpiar
        public void Limpiar()
        {
            txtIdUsuario.Text = "";
            txtIdUsuario.Text = "";
            txtIdPaisOrigen.Text = "";
            txtIdPaisDestino.Text = "";
            txtIdPago.Text = "";
            txtIdEnvio.Text = "";
            txtIdEstado.Text = "";
            txtTotal.Text = "";
            txtDescripcion.Text = "";
            txtIdCiudadDestino.Text = "";
            txtIdCiudadOrigen.Text = "";
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarPedidos()
        {
            try
            {
                /*Se crea objeto pedido y a este en su parametro  IDUSUARIO se le asigna
                 variable de texto, y se le pasa al metodo creado el la logica para 
                 despues retornar el resultado y cargarlo al datagrid*/
                PEDIDOS pedidoIdUser = new PEDIDOS();
                pedidoIdUser.IDUSUARIO = Convert.ToInt32(txtIdUsuario.Text.Trim());
                List<PEDIDOS> lstPedidos = Logica.BuscarDatoU(pedidoIdUser);

                this.dataGrid.DataSource = lstPedidos;
                this.dataGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region  Boton_Eliminar 
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                PEDIDOS pedido = new PEDIDOS();
                pedido.IDPEDIDO = Convert.ToInt32(txtIdPedido.Text.Trim());
                pedido.IDUSUARIO = Convert.ToInt32(txtIdUsuario.Text.Trim());
                pedido.IDPAISORIGEN = txtIdPaisOrigen.Text.Trim();
                pedido.IDPAISDESTINO = txtIdPaisDestino.Text.Trim();
                pedido.IDPAGO = txtIdPago.Text.Trim();
                pedido.IDENVIO = txtIdEnvio.Text.Trim();
                pedido.IDESTADO = txtIdEstado.Text.Trim();
                pedido.TOTAL = Convert.ToInt32(txtTotal.Text.Trim());
                pedido.DESCRIPCION = txtDescripcion.Text.Trim();
                pedido.IDCIUDADDESTINO = txtIdCiudadDestino.Text.Trim();
                pedido.IDCIUDADORIGEN = txtIdCiudadOrigen.Text.Trim();
                _02LogicadeNegocios.Logica.EliminarDato(pedido);
                MessageBox.Show("Pedido Borrado");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Elminar Datos de Tabla Destino" + ex.Message);
            }
        }
        #endregion

        private void Cliente_Pedido_Load(object sender, EventArgs e)
        {
            CargarPedidos();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdPedido.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtIdUsuario.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtIdPaisOrigen.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtIdPaisDestino.Text = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtIdPago.Text = dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtIdEnvio.Text = dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtIdEstado.Text = dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtTotal.Text = dataGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtDescripcion.Text = dataGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtIdCiudadDestino.Text = dataGrid.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtIdCiudadOrigen.Text = dataGrid.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdPedido.Text.Equals(""))
                {
                    CargarPedidos();
                }
                else
                {
                    PEDIDOS pedidoIdUser = new PEDIDOS();
                    pedidoIdUser.IDPEDIDO = Convert.ToInt32(txtIdPedido.Text.Trim());
                    List<PEDIDOS> lstPedidos = _02LogicadeNegocios.Logica.BuscarDatoP(pedidoIdUser);
                    this.dataGrid.DataSource = lstPedidos;
                    this.dataGrid.Refresh();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Buscar el Id pedido" + ex.Message);
            }
        }
    }
}
