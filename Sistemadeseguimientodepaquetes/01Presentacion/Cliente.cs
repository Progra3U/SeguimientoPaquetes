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
    public partial class Cliente : Form
    {
        public Cliente(string nombre)
        {
            InitializeComponent();
            lblTipoUsuario.Text = nombre;
        }
    }
}
