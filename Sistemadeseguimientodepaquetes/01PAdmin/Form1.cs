using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //para poder mover la ventana

namespace _01PAdmin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        #region Codigo Para mover Ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        /*buscamos en la barra de arriba el evento MouseDown, le damos
         doble click y se agrega:
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        */

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Metodo Para convertir y acoplar un Fom como y en un panel
        private void AbrirFormularioHijo(object formulario)
        {
            /*aqui se crea un metodo el cual pregunta si existe algun control
             en el interior del panelContenedor, de ser asi se elimina para que funcione la 
             sobreposicion de form (paneles)*/
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form formHijo = formulario as Form; /*En ersta linea se crea un formulario con un nombre
                en este caso va a ser igual al objeto que recibe la funcion con el parametro "object Formulario"
                y este objeto se convierte en un formulario con la palabra "AS"*/
            formHijo.TopLevel = false; /*con esto indicamos que no es un formulario
                convirtiendolo en un form secundario*/
            formHijo.Dock = DockStyle.Fill; /*con esto permitimos que el formulario se acople a todo el panel*/
            this.panelContenedor.Controls.Add(formHijo);/*Se agrega el formulario al panel por medio de esta instruccion*/
            this.panelContenedor.Tag = formHijo; /*Se establece la instancia como controlador de datos de nuestro panel*/
            formHijo.Show(); /*Se procede a mostrar el formulario*/
        }
        #endregion

        #region Botones inicio_productos_Usuarios_pedidos_clientes
        private void btnPorductos_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new _01PAdmin_Productos());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new _01PAdmin_Inicio());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new _01PAdmin_Usuarios());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new _01PAdmin_Pedidos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new _01PAdmin_Clientes());
        }

        
        #endregion
    }
}
