﻿namespace WindowsFormsApplication1.ABM_Rol
{
    partial class PantallaModificarRol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grupo_Modificar_Rol = new System.Windows.Forms.GroupBox();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Modificar_Rol_Texto_Rol = new System.Windows.Forms.Label();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboFunc = new System.Windows.Forms.ComboBox();
            this.listFunc = new System.Windows.Forms.ListBox();
            this.Grupo_Modificar_Rol.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grupo_Modificar_Rol
            // 
            this.Grupo_Modificar_Rol.Controls.Add(this.comboFunc);
            this.Grupo_Modificar_Rol.Controls.Add(this.label3);
            this.Grupo_Modificar_Rol.Controls.Add(this.comboRol);
            this.Grupo_Modificar_Rol.Controls.Add(this.listFunc);
            this.Grupo_Modificar_Rol.Controls.Add(this.textNombre);
            this.Grupo_Modificar_Rol.Controls.Add(this.label2);
            this.Grupo_Modificar_Rol.Controls.Add(this.label1);
            this.Grupo_Modificar_Rol.Controls.Add(this.Modificar_Rol_Texto_Rol);
            this.Grupo_Modificar_Rol.Location = new System.Drawing.Point(13, 3);
            this.Grupo_Modificar_Rol.Name = "Grupo_Modificar_Rol";
            this.Grupo_Modificar_Rol.Size = new System.Drawing.Size(359, 247);
            this.Grupo_Modificar_Rol.TabIndex = 0;
            this.Grupo_Modificar_Rol.TabStop = false;
            this.Grupo_Modificar_Rol.Text = "Datos del rol";
            // 
            // comboRol
            // 
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Location = new System.Drawing.Point(175, 19);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(100, 21);
            this.comboRol.TabIndex = 6;
            this.comboRol.SelectedIndexChanged += new System.EventHandler(this.comboRol_SelectedIndexChanged);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(175, 64);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rol:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de funcionalidades actual:";
            // 
            // Modificar_Rol_Texto_Rol
            // 
            this.Modificar_Rol_Texto_Rol.AutoSize = true;
            this.Modificar_Rol_Texto_Rol.Location = new System.Drawing.Point(75, 67);
            this.Modificar_Rol_Texto_Rol.Name = "Modificar_Rol_Texto_Rol";
            this.Modificar_Rol_Texto_Rol.Size = new System.Drawing.Size(94, 13);
            this.Modificar_Rol_Texto_Rol.TabIndex = 0;
            this.Modificar_Rol_Texto_Rol.Text = "Nuevo nombre rol:";
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.Location = new System.Drawing.Point(297, 265);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Modificar.TabIndex = 1;
            this.Boton_Modificar.Text = "Guardar";
            this.Boton_Modificar.UseVisualStyleBackColor = true;
            this.Boton_Modificar.Click += new System.EventHandler(this.Boton_Modificar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Location = new System.Drawing.Point(13, 265);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Cancelar.TabIndex = 2;
            this.Boton_Cancelar.Text = "Atras";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quitar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Funcionalidades a agregar:";
            // 
            // comboFunc
            // 
            this.comboFunc.FormattingEnabled = true;
            this.comboFunc.Location = new System.Drawing.Point(175, 106);
            this.comboFunc.Name = "comboFunc";
            this.comboFunc.Size = new System.Drawing.Size(100, 21);
            this.comboFunc.TabIndex = 8;
            // 
            // listFunc
            // 
            this.listFunc.FormattingEnabled = true;
            this.listFunc.Location = new System.Drawing.Point(175, 150);
            this.listFunc.Name = "listFunc";
            this.listFunc.Size = new System.Drawing.Size(165, 82);
            this.listFunc.TabIndex = 5;
            // 
            // PantallaModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 302);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.Grupo_Modificar_Rol);
            this.Name = "PantallaModificarRol";
            this.ShowIcon = false;
            this.Text = "Modificar rol";
            this.Grupo_Modificar_Rol.ResumeLayout(false);
            this.Grupo_Modificar_Rol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo_Modificar_Rol;
        private System.Windows.Forms.Label Modificar_Rol_Texto_Rol;
        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.ComboBox comboFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listFunc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}