﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Presentacion
{
    public partial class Cliente_DoPedido : Form
    {
        public Cliente_DoPedido(string codigo)
        {
            InitializeComponent();
            txtIdUsuario.Text = codigo;
        }

    }
}
