﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class Pantalla_Habilitacion_Rol : Form
    {
        GD1C2016DataSetTableAdapters.rolesTableAdapter rolAdapter = new GD1C2016DataSetTableAdapters.rolesTableAdapter();
        public Pantalla_Habilitacion_Rol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboRoles.Text == "")
            {
                MessageBox.Show("Ingresa rol a habilitar");
            }
            else
            {
                rolAdapter.habilitarRol((decimal)comboRoles.SelectedValue);
                MessageBox.Show("Rol habilitado");
            }
        }

        private void Pantalla_Habilitacion_Rol_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2016DataSet.roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.gD1C2016DataSet.roles);

        }
    }
}
