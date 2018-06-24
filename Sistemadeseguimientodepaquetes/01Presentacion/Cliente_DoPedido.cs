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
    public partial class Cliente_DoPedido : Form
    {
        public Cliente_DoPedido(string codigo)
        {
            InitializeComponent();
            txtIdUsuario.Text = codigo;
        }
        #region Metodo Limpiar
        public void Limpiar()
        {
            txtIdPedido.Text = "";
            txtIdUsuario.Text = "";
            comboOrigen.Text = "";
            comboDestino.Text = "";
            comboPago.Text = "";
            comboEnvio.Text = "";
            txtIdEstado.Text = "";
            txtTotal.Text = "";
            txtDescripcion.Text = "";
        }
        #endregion
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                PEDIDOS pedido = new PEDIDOS();
                //pedido.IDPEDIDO = Convert.ToInt16(txtIdPedido.Text.Trim());
                pedido.IDUSUARIO = Convert.ToInt32(txtIdUsuario.Text.Trim());
                pedido.IDORIGEN = comboOrigen.Text.Trim();
                pedido.IDDESTINO = comboDestino.Text.Trim();
                pedido.IDPAGO = comboPago.Text.Trim();
                pedido.IDENVIO = comboEnvio.Text.Trim();
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
    }
}
