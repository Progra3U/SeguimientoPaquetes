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

        #region CargarCombos Metodo
        private void CargarCombos()
        {
            try
            {
                //Listas de asignacion a combos
                List<DESTINO> lstDestino = _02LogicadeNegocios.Logica.obtDestinos();
                List<ORIGEN> lstOrigen = _02LogicadeNegocios.Logica.obtOrigen();
                List<PAGO> lstPago = _02LogicadeNegocios.Logica.obtPago();
                List<ENVIO> lstEnvio = _02LogicadeNegocios.Logica.obtEnvio();

                //Asigancion del listado a la fuente de datos del elemento
                comboPaisDestino.DataSource = lstDestino;
                comboCiudadDestino.DataSource = lstDestino;
                comboPaisOrigen.DataSource = lstOrigen;
                comboCiudadOrigen.DataSource = lstOrigen;
                comboPago.DataSource = lstPago;
                comboEnvio.DataSource = lstEnvio;
                comboImpuesto.DataSource = lstDestino;
                comboCostEnvio.DataSource = lstEnvio;

                //Especificacion de campos de la fuente de datos a cada caracteristica del
                //combo. El valuemember es el valor escondido
                comboPaisDestino.ValueMember = "IMPUESTO";
                comboPaisDestino.DisplayMember = "PAIS";
       

                comboCiudadDestino.ValueMember = "CIUDAD";
                comboCiudadDestino.DisplayMember = "CIUDAD";

                comboPaisOrigen.ValueMember = "PAIS";
                comboPaisOrigen.DisplayMember = "PAIS";
                comboCiudadOrigen.ValueMember = "CIUDAD";
                comboCiudadOrigen.DisplayMember = "CIUDAD";

                comboPago.ValueMember = "DESC_PAGO";
                comboPago.DisplayMember = "DESC_PAGO";

                comboEnvio.ValueMember = "PRECIO_ENVIO";
                comboEnvio.DisplayMember = "DESC_ENVIO";

                comboImpuesto.ValueMember = "IMPUESTO";
                comboImpuesto.DisplayMember = "IMPUESTO";

                comboCostEnvio.ValueMember = "PRECIO_ENVIO";
                comboCostEnvio.DisplayMember = "PRECIO_ENVIO";

                //intento de hacer que el textbox cambien
                //impuesto = Convert.ToInt32(comboImpuesto.Text);
                //CostEnvio = Convert.ToInt32(comboCostEnvio.Text);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Metodo Limpiar
        public void Limpiar()
        {
            txtIdPedido.Text = "";
            txtIdUsuario.Text = "";
            comboPaisOrigen.Text = "";
            comboPaisDestino.Text = "";
            comboPago.Text = "";
            comboEnvio.Text = "";
            txtIdEstado.Text = "";
            txtTotal.Text = "";
            txtDescripcion.Text = "";
        }
        #endregion

        #region Accion Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Desea Guardar el pedido", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (resultado == DialogResult.Yes)
                {
                    PEDIDOS pedido = new PEDIDOS();
                    //pedido.IDPEDIDO = Convert.ToInt16(txtIdPedido.Text.Trim());
                    pedido.IDUSUARIO = Convert.ToInt32(txtIdUsuario.Text.Trim());
                    pedido.IDPAISORIGEN = comboPaisOrigen.Text.Trim();
                    pedido.IDPAISDESTINO = comboPaisDestino.Text.Trim();
                    pedido.IDPAGO = comboPago.Text.Trim();
                    pedido.IDENVIO = comboEnvio.Text.Trim();
                    pedido.IDESTADO = txtIdEstado.Text.Trim();
                    pedido.TOTAL = Convert.ToInt32(txtTotal.Text.Trim());
                    pedido.DESCRIPCION = txtDescripcion.Text.Trim();
                    pedido.IDCIUDADDESTINO = comboCiudadDestino.Text.Trim();
                    pedido.IDCIUDADORIGEN = comboCiudadOrigen.Text.Trim();
                    _02LogicadeNegocios.Logica.GuardarDato(pedido);
                    MessageBox.Show("Pedido Agregado");
                    Limpiar(); this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar Datos en Tabla Destino" + ex.Message);
            }

        }
        #endregion

        #region Cargar combos
        private void Cliente_DoPedido_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }
        #endregion

        #region Calcular Precio
        private void btncalcular_Click(object sender, EventArgs e)
        {
            //intento hacer que txtTotal.Text se modifique con el precio
            int impuesto = Convert.ToInt32(comboImpuesto.Text);
            int CostEnvio = Convert.ToInt32(comboCostEnvio.Text);
            int Total = impuesto + CostEnvio;
            txtTotal.Text = Total.ToString();
        }
        #endregion
    }
}
