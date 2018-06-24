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
    public partial class Administrador_Pedido : Form
    {
        public Administrador_Pedido()
        {
            InitializeComponent();
        }

        #region Metodo Limpiar
        public void Limpiar()
        {
            txtIdUsuario.Text = "";
            txtIdUsuario.Text = "";
            txtIdOrigen.Text = "";
            txtIdDestino.Text = "";
            txtIdPago.Text = "";
            txtIdEnvio.Text = "";
            txtIdEstado.Text = "";
            txtTotal.Text = "";
            txtDescripcion.Text = "";
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
            pedido.IDORIGEN = txtIdOrigen.Text.Trim();
            pedido.IDDESTINO = txtIdDestino.Text.Trim();
            pedido.IDPAGO = txtIdPago.Text.Trim();
            pedido.IDENVIO = txtIdEnvio.Text.Trim();
            pedido.IDESTADO = txtIdEstado.Text.Trim();
            pedido.TOTAL = Convert.ToInt32(txtTotal.Text.Trim());
            pedido.DESCRIPCION = txtDescripcion.Text.Trim();
            return pedido;
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                _02LogicadeNegocios.Logica.EliminarDato(processoBase());
                MessageBox.Show("Pedido Borrado");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Elminar Datos de Tabla Destino" + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                PEDIDOS pedido = new PEDIDOS();
                pedido.IDUSUARIO = Convert.ToInt32(txtIdUsuario.Text.Trim());
                pedido.IDORIGEN = txtIdOrigen.Text.Trim();
                pedido.IDDESTINO = txtIdDestino.Text.Trim();
                pedido.IDPAGO = txtIdPago.Text.Trim();
                pedido.IDENVIO = txtIdEnvio.Text.Trim();
                pedido.IDESTADO = txtIdEstado.Text.Trim();
                pedido.TOTAL = Convert.ToInt32(txtTotal.Text.Trim());
                pedido.DESCRIPCION = txtDescripcion.Text.Trim();
                _02LogicadeNegocios.Logica.GuardarDato(pedido);
                MessageBox.Show("Pedido Agregado");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar Datos en Tabla Destino" + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                _02LogicadeNegocios.Logica.ModificarDato(processoBase());
                MessageBox.Show("Pedido Editado");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Editar Datos de Tabla Destino" + ex.Message);
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
        #endregion

        #region Evento Cargar Al Abrir
        private void Administrador_Pedido_Load(object sender, EventArgs e)
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
                txtIdOrigen.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtIdDestino.Text = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtIdPago.Text = dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtIdEnvio.Text = dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtIdEstado.Text = dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtTotal.Text = dataGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtDescripcion.Text = dataGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

    }
}
