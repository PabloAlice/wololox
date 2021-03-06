﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class Pantalla_Creacion_Usuario : Form
    {
        public Pantalla_Creacion_Usuario()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            comboBox1.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && comboBox1.Text == "")
            {
                MessageBox.Show("Ingresa usuario,contraseña y rol");

            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Ingresa usuario y contraseña");

            }
            else if (textBox1.Text == "" && comboBox1.Text == "")
            {
                MessageBox.Show("Ingresa usuario y rol");

            }
            else if (textBox2.Text == "" && comboBox1.Text == "")
            {
                MessageBox.Show("Ingresa contraseña y rol");

            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Ingresa usuario");

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Ingresa contraseña");

            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Selecciona rol");

            }
            else if (comboBox1.Text == "Cliente")
            {
                Pantalla_Datos_Cliente pantallaDatosCliente = new Pantalla_Datos_Cliente(textBox1.Text,textBox2.Text);
                pantallaDatosCliente.ShowDialog();

            }
            else if (comboBox1.Text == "Empresa")
            {
                Pantalla_Datos_Empresa pantallaDatosEmpresa = new Pantalla_Datos_Empresa(textBox1.Text,textBox2.Text);
                pantallaDatosEmpresa.ShowDialog();

            }
            else
            {
               Pantalla_Datos_Rol_Generico pantallaDatos = new Pantalla_Datos_Rol_Generico(textBox1.Text, textBox2.Text, Convert.ToString(comboBox1.SelectedValue));
                pantallaDatos.ShowDialog();
            }

        }

        private void Pantalla_Creacion_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2016DataSet.roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.gD1C2016DataSet.roles);

        }

    }

}