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
    public partial class Usuario_Pedido : Form
    {
        public Usuario_Pedido()
        {
            InitializeComponent();
        }

        #region Metodo Limpiar
        public void Limpiar()
        {
            txtIdPedido.Text = "";
            txtIdUsuario.Text = "";
            txtIdPaisOrigen.Text = "";
            txtIdPaisDestino.Text = "";
            txtIdPago.Text = "";
            txtIdEnvio.Text = "";
            txtIdEstadoCB.Text = "";
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
                List<PEDIDOS> lstPedidos = Logica.obtPedidos();
                this.dataGrid.DataSource = lstPedidos;
                this.dataGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar From Administrador_Pedido
        public PEDIDOS processoBase()
        {
            PEDIDOS pedido = new PEDIDOS();
            pedido.IDPEDIDO = Convert.ToInt32(txtIdPedido.Text.Trim());
            pedido.IDUSUARIO = Convert.ToInt32(txtIdUsuario.Text.Trim());
            pedido.IDPAISORIGEN = txtIdPaisOrigen.Text.Trim();
            pedido.IDPAISDESTINO = txtIdPaisDestino.Text.Trim();
            pedido.IDPAGO = txtIdPago.Text.Trim();
            pedido.IDENVIO = txtIdEnvio.Text.Trim();
            pedido.IDESTADO = txtIdEstadoCB.Text.Trim();
            pedido.TOTAL = Convert.ToInt32(txtTotal.Text.Trim());
            pedido.DESCRIPCION = txtDescripcion.Text.Trim();
            pedido.IDCIUDADDESTINO = txtIdCiudadDestino.Text.Trim();
            pedido.IDCIUDADORIGEN = txtIdCiudadOrigen.Text.Trim();
            return pedido;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _02LogicadeNegocios.Logica.ModificarDato(processoBase());
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar la traza del producto" + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*Se logra estandarizar los metodos de busqueda tanto por idUser, como por idPedido*/
            try
            {
                if (txtEleccionCB.Text.Equals("Usuario"))
                {
                    if (txtIdUsuario.Text.Equals(""))
                    {
                        CargarPedidos();
                    }
                    else
                    {
                        PEDIDOS pedidoIdUser = new PEDIDOS();
                        pedidoIdUser.IDUSUARIO = Convert.ToInt32(txtIdUsuario.Text.Trim());
                        List<PEDIDOS> lstPedidos = _02LogicadeNegocios.Logica.BuscarDatoU(pedidoIdUser);
                        this.dataGrid.DataSource = lstPedidos;
                        this.dataGrid.Refresh();
                    }
                }
                else if (txtEleccionCB.Text.Equals("Pedido"))
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Buscar Datos de Tabla Destino" + ex.Message);
            }
            Limpiar();
        }
        #endregion

        private void txtEleccionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEleccionCB.Text.Equals("Usuario"))
            {
                txtIdPedido.ReadOnly = true;
                txtIdUsuario.ReadOnly = false;
            }
            else
            {
                txtIdPedido.ReadOnly = false;
                txtIdUsuario.ReadOnly = true;
            }
            
        }

        #region Evento Cargar Al Abrir
        private void Usuario_Pedido_Load(object sender, EventArgs e)
        {
            CargarPedidos();
        }
        #endregion

        #region EventoDatagrid
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
                txtIdEstadoCB.Text = dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
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
        #endregion
    }
}
