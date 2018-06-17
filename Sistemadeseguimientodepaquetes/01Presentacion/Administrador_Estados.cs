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
    public partial class Administrador_Estados : Form
    {
        public Administrador_Estados()
        {
            InitializeComponent();
        }
       
        #region Metodo Limpiar
        public void Limpiar()
        {
            this.txtIdEstado.Text = "";
            this.txtDescEstado.Text = "";
          
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarEstados()
        {
            try
            {
                List<ESTADO> lstEstado = Logica.obtEstado();
                this.dataGrid.DataSource = lstEstado;
                this.dataGrid.Refresh();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_ESTADO
        public ESTADO processoBase()
        {
            ESTADO estado = new ESTADO();
            estado.IDESTADO = Convert.ToInt16(txtIdEstado.Text.Trim());
            estado.DESC_ESTADO = txtDescEstado.Text.Trim();
            return estado;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ESTADO estado = new ESTADO();
              //  estado.IDESTADO = Convert.ToInt16(txtIdEstado.Text.Trim());
                estado.DESC_ESTADO = txtDescEstado.Text.Trim();
                _02LogicadeNegocios.Logica.GuardarDato(estado);
                MessageBox.Show("Estado Agregado");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar Datos en Tabla Estado" + ex.Message);
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
                MessageBox.Show("Error al Buscar Datos de Tabla Estado" + ex.Message);
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
                MessageBox.Show("Error al Editar Datos de Tabla Estado" + ex.Message);
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
                MessageBox.Show("Error al Elminar Datos de Tabla Estado" + ex.Message);
            }
        }
        #endregion

        #region Evento Cargar Al Abrir
        private void Administrador_Estado_Load(object sender, EventArgs e)
        {
            this.CargarEstados();
        }
        #endregion

        #region EventoDatagrid
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtIdEstado.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtDescEstado.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
