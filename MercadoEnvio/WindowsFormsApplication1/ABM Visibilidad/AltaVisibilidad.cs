﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class AltaVisibilidad : Form
    {
        public AltaVisibilidad()
        {
            InitializeComponent();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "0";
            }
        }

        private void limpiarTexto()
        {
            Action<Control.ControlCollection> funcion = null;

            funcion = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        funcion(control.Controls);
            };

            funcion(Controls);
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = "0";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Text = "0";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double valorPorTipo;
            double valorPorEnvio;
            double valorPorProducto;
            double costo;
            
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {

                if (double.TryParse(textBox2.Text, out costo))
                {
                    if (double.TryParse(textBox3.Text, out valorPorTipo))
                    {
                        if (double.TryParse(textBox4.Text, out valorPorProducto))
                        {
                            if (double.TryParse(textBox5.Text, out valorPorEnvio))
                            {
                                //Enviar a BD
                                MessageBox.Show("Visibilidad creada correctamente");
                            }
                            else
                            {
                                MessageBox.Show("Ingrese una comisión por envío numérica");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese una comisión por producto numérica");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una comisión por tipo de publicación numérica");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un costo numérico");
                } 
            }
            else
            {
                MessageBox.Show("Ingrese una descripción");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarTexto();
        }
    }
}
