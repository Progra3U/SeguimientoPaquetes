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

        #region  Botones_Guardar_Buscar_Editar_Eliminar From Administrador_Pedido
        public PEDIDO processoBase()
        {
            PEDIDO destino = new PEDIDO();
            destino.IDPEDIDO = Convert.ToInt16(txtIdPedido.Text.Trim());
            destino.IDUSUARIO = Convert.ToInt16(txtIdUsuario.Text.Trim());
            destino.IDORIGEN = Convert.ToInt16(txtIdOrigen.Text.Trim());
            destino.IDDESTINO = Convert.ToInt16(txtIdDestino.Text.Trim());
            destino.IDPAGO = Convert.ToInt16(txtIdPago.Text.Trim());
            destino.IDENVIO = Convert.ToInt16(txtIdEnvio.Text.Trim());
            destino.IDESTADO = Convert.ToInt16(txtIdEstado.Text.Trim());
            destino.TOTAL = Convert.ToInt16(txtTotal.Text.Trim());
            destino.DESCRIPCION = txtDescripcion.Text.Trim();
            return destino;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                PEDIDO destino = new PEDIDO();
                destino.IDPEDIDO = Convert.ToInt16(txtIdPedido.Text.Trim());
                destino.IDUSUARIO = Convert.ToInt16(txtIdUsuario.Text.Trim());
                destino.IDORIGEN = Convert.ToInt16(txtIdOrigen.Text.Trim());
                destino.IDDESTINO = Convert.ToInt16(txtIdDestino.Text.Trim());
                destino.IDPAGO = Convert.ToInt16(txtIdPago.Text.Trim());
                destino.IDENVIO = Convert.ToInt16(txtIdEnvio.Text.Trim());
                destino.IDESTADO = Convert.ToInt16(txtIdEstado.Text.Trim());
                destino.TOTAL = Convert.ToInt16(txtTotal.Text.Trim());
                destino.DESCRIPCION = txtDescripcion.Text.Trim();
                _02LogicadeNegocios.Logica.GuardarDato(destino);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Elminar Datos de Tabla Destino" + ex.Message);
            }

        }
        #endregion
    }
}
