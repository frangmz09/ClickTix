﻿namespace ClickTix.UserControls
{
    partial class ABM_SUCURSALES_UC
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
            this.add_sucursal = new System.Windows.Forms.Button();
            this.grid_sucursal = new System.Windows.Forms.DataGridView();
            this.Idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuitt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccionn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abreviatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(219, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(148, 25);
            this.title.TabIndex = 16;
            this.title.Text = "SUCURSALES";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_sucursal
            // 
            this.add_sucursal.Location = new System.Drawing.Point(439, 18);
            this.add_sucursal.Name = "add_sucursal";
            this.add_sucursal.Size = new System.Drawing.Size(108, 25);
            this.add_sucursal.TabIndex = 15;
            this.add_sucursal.Text = "Agregar";
            this.add_sucursal.UseVisualStyleBackColor = true;
            this.add_sucursal.Click += new System.EventHandler(this.add_sucursal_Click);
            // 
            // grid_sucursal
            // 
            this.grid_sucursal.AllowUserToAddRows = false;
            this.grid_sucursal.AllowUserToDeleteRows = false;
            this.grid_sucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sucursal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idd,
            this.Nombrev,
            this.Cuitt,
            this.Direccionn,
            this.Abreviatura,
            this.Salas,
            this.Borrar,
            this.Modificar});
            this.grid_sucursal.Location = new System.Drawing.Point(23, 52);
            this.grid_sucursal.Name = "grid_sucursal";
            this.grid_sucursal.ReadOnly = true;
            this.grid_sucursal.Size = new System.Drawing.Size(524, 303);
            this.grid_sucursal.TabIndex = 14;
            this.grid_sucursal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_sucursal_CellContentClick);
            // 
            // Idd
            // 
            this.Idd.HeaderText = "ID";
            this.Idd.Name = "Idd";
            this.Idd.ReadOnly = true;
            // 
            // Nombrev
            // 
            this.Nombrev.HeaderText = "Nombre";
            this.Nombrev.Name = "Nombrev";
            this.Nombrev.ReadOnly = true;
            // 
            // Cuitt
            // 
            this.Cuitt.HeaderText = "CUIT";
            this.Cuitt.Name = "Cuitt";
            this.Cuitt.ReadOnly = true;
            // 
            // Direccionn
            // 
            this.Direccionn.HeaderText = "Direccion";
            this.Direccionn.Name = "Direccionn";
            this.Direccionn.ReadOnly = true;
            // 
            // Abreviatura
            // 
            this.Abreviatura.HeaderText = "Abreviatura";
            this.Abreviatura.Name = "Abreviatura";
            this.Abreviatura.ReadOnly = true;
            // 
            // Salas
            // 
            this.Salas.HeaderText = "Salas";
            this.Salas.Name = "Salas";
            this.Salas.ReadOnly = true;
            this.Salas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Salas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Borrar.Width = 50;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modificar.Width = 50;
            // 
            // ABM_SUCURSALES_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.title);
            this.Controls.Add(this.add_sucursal);
            this.Controls.Add(this.grid_sucursal);
            this.Name = "ABM_SUCURSALES_UC";
            this.Size = new System.Drawing.Size(570, 373);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button add_sucursal;
        private System.Windows.Forms.DataGridView grid_sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuitt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccionn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abreviatura;
        private System.Windows.Forms.DataGridViewButtonColumn Salas;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
    }
}
