﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Calificar
{
    public partial class Pantalla_Calificacion_Principal : Form
    {
        public Pantalla_Calificacion_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantalla_Calificar_Publicacion pantallaCalificar = new Pantalla_Calificar_Publicacion();
            this.Hide();
            pantallaCalificar.Show();
        }
    }
}
