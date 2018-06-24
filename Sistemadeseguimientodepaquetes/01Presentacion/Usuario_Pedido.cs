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
            txtIdUsuario.Text = "";
            txtIdUsuario.Text = "";
            txtIdOrigen.Text = "";
            txtIdDestino.Text = "";
            txtIdPago.Text = "";
            txtIdEnvio.Text = "";
            txtIdEstadoCB.Text = "";
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
            pedido.IDESTADO = txtIdEstadoCB.Text.Trim();
            pedido.TOTAL = Convert.ToInt32(txtTotal.Text.Trim());
            pedido.DESCRIPCION = txtDescripcion.Text.Trim();
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
            if (txtEleccionCB.Text.Equals("Usuario")){
                _02LogicadeNegocios.Logica.BuscarDatoU(processoBase());
            }
            else
            {
                _02LogicadeNegocios.Logica.BuscarDatoP(processoBase());
            }
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
    }
}
