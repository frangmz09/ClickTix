﻿namespace ClickTix.UserControls
{
    partial class FORM_SUCURSALES_UC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.addsucursal_btn = new System.Windows.Forms.Button();
            this.label_titulo = new System.Windows.Forms.Label();
            this.input_nombre = new System.Windows.Forms.TextBox();
            this.label_direccion = new System.Windows.Forms.Label();
            this.input_direccion = new System.Windows.Forms.TextBox();
            this.label_cuit = new System.Windows.Forms.Label();
            this.input_cuit = new System.Windows.Forms.TextBox();
            this.back_pelicula = new System.Windows.Forms.Button();
            this.label_abr = new System.Windows.Forms.Label();
            this.input_abr = new System.Windows.Forms.TextBox();
            this.label_adv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(71, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(450, 25);
            this.title.TabIndex = 3;
            this.title.Text = "INGRESE DATOS PARA AGREGAR SUCURSAL";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // addsucursal_btn
            // 
            this.addsucursal_btn.Location = new System.Drawing.Point(223, 309);
            this.addsucursal_btn.Name = "addsucursal_btn";
            this.addsucursal_btn.Size = new System.Drawing.Size(111, 25);
            this.addsucursal_btn.TabIndex = 33;
            this.addsucursal_btn.Text = "Agregar";
            this.addsucursal_btn.UseVisualStyleBackColor = true;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(140, 88);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(52, 15);
            this.label_titulo.TabIndex = 58;
            this.label_titulo.Text = "Nombre";
            this.label_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_nombre
            // 
            this.input_nombre.Location = new System.Drawing.Point(143, 105);
            this.input_nombre.Name = "input_nombre";
            this.input_nombre.Size = new System.Drawing.Size(268, 20);
            this.input_nombre.TabIndex = 57;
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_direccion.Location = new System.Drawing.Point(140, 132);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(59, 15);
            this.label_direccion.TabIndex = 60;
            this.label_direccion.Text = "Direccion";
            this.label_direccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_direccion
            // 
            this.input_direccion.Location = new System.Drawing.Point(143, 149);
            this.input_direccion.Name = "input_direccion";
            this.input_direccion.Size = new System.Drawing.Size(268, 20);
            this.input_direccion.TabIndex = 59;
            // 
            // label_cuit
            // 
            this.label_cuit.AutoSize = true;
            this.label_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cuit.Location = new System.Drawing.Point(140, 181);
            this.label_cuit.Name = "label_cuit";
            this.label_cuit.Size = new System.Drawing.Size(28, 15);
            this.label_cuit.TabIndex = 62;
            this.label_cuit.Text = "Cuit";
            this.label_cuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_cuit
            // 
            this.input_cuit.Location = new System.Drawing.Point(143, 198);
            this.input_cuit.Name = "input_cuit";
            this.input_cuit.Size = new System.Drawing.Size(268, 20);
            this.input_cuit.TabIndex = 61;
            // 
            // back_pelicula
            // 
            this.back_pelicula.Location = new System.Drawing.Point(17, 16);
            this.back_pelicula.Name = "back_pelicula";
            this.back_pelicula.Size = new System.Drawing.Size(30, 30);
            this.back_pelicula.TabIndex = 66;
            this.back_pelicula.Text = "<";
            this.back_pelicula.UseVisualStyleBackColor = true;
            this.back_pelicula.Click += new System.EventHandler(this.back_pelicula_Click);
            // 
            // label_abr
            // 
            this.label_abr.AutoSize = true;
            this.label_abr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_abr.Location = new System.Drawing.Point(140, 231);
            this.label_abr.Name = "label_abr";
            this.label_abr.Size = new System.Drawing.Size(68, 15);
            this.label_abr.TabIndex = 68;
            this.label_abr.Text = "Abreviatura";
            this.label_abr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_abr
            // 
            this.input_abr.Location = new System.Drawing.Point(143, 248);
            this.input_abr.Name = "input_abr";
            this.input_abr.Size = new System.Drawing.Size(268, 20);
            this.input_abr.TabIndex = 67;
            // 
            // label_adv
            // 
            this.label_adv.AutoSize = true;
            this.label_adv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adv.ForeColor = System.Drawing.Color.Red;
            this.label_adv.Location = new System.Drawing.Point(130, 271);
            this.label_adv.Name = "label_adv";
            this.label_adv.Size = new System.Drawing.Size(296, 15);
            this.label_adv.TabIndex = 69;
            this.label_adv.Text = "No podrá ser cambiada o modificada posteriormente";
            this.label_adv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_adv.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FORM_SUCURSALES_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_adv);
            this.Controls.Add(this.label_abr);
            this.Controls.Add(this.input_abr);
            this.Controls.Add(this.back_pelicula);
            this.Controls.Add(this.label_cuit);
            this.Controls.Add(this.input_cuit);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.input_direccion);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.input_nombre);
            this.Controls.Add(this.addsucursal_btn);
            this.Controls.Add(this.title);
            this.Name = "FORM_SUCURSALES_UC";
            this.Size = new System.Drawing.Size(560, 373);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button addsucursal_btn;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.TextBox input_nombre;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.TextBox input_direccion;
        private System.Windows.Forms.Label label_cuit;
        private System.Windows.Forms.TextBox input_cuit;
        private System.Windows.Forms.Button back_pelicula;
        private System.Windows.Forms.Label label_abr;
        private System.Windows.Forms.TextBox input_abr;
        private System.Windows.Forms.Label label_adv;
    }
}
