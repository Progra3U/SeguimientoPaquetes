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

namespace _01Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_Maximizar.Visible = false;
            btn_Restaurar.Visible = true;
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Restaurar.Visible = false;
            btn_Maximizar.Visible = true;
            
        }

        private void brn_Minimizar_Click(object sender, EventArgs e)
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


    }
}
