﻿namespace ClickTix.Empleado.UserControls
{
    partial class TICKET_UC
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
            this.button1 = new System.Windows.Forms.Button();
            this.nombre_pelicula_ticket = new System.Windows.Forms.Label();
            this.fila_ticket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fecha_ticket = new System.Windows.Forms.Label();
            this.hora_ticket = new System.Windows.Forms.Label();
            this.precio_ticket = new System.Windows.Forms.Label();
            this.nrosala_ticket = new System.Windows.Forms.Label();
            this.idioma_ticket = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_MenuPrincipal = new System.Windows.Forms.Button();
            this.text_error = new System.Windows.Forms.Label();
            this.adv_1 = new System.Windows.Forms.Label();
            this.error_sucursal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(389, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirmar e Imprimir Ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombre_pelicula_ticket
            // 
            this.nombre_pelicula_ticket.AutoSize = true;
            this.nombre_pelicula_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_pelicula_ticket.Location = new System.Drawing.Point(150, 103);
            this.nombre_pelicula_ticket.Name = "nombre_pelicula_ticket";
            this.nombre_pelicula_ticket.Size = new System.Drawing.Size(70, 25);
            this.nombre_pelicula_ticket.TabIndex = 2;
            this.nombre_pelicula_ticket.Text = "label1";
            // 
            // fila_ticket
            // 
            this.fila_ticket.AutoSize = true;
            this.fila_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fila_ticket.Location = new System.Drawing.Point(331, 223);
            this.fila_ticket.Name = "fila_ticket";
            this.fila_ticket.Size = new System.Drawing.Size(70, 25);
            this.fila_ticket.TabIndex = 4;
            this.fila_ticket.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fila y Columna:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pelicula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sala:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hora:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Precio:";
            // 
            // fecha_ticket
            // 
            this.fecha_ticket.AutoSize = true;
            this.fecha_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_ticket.Location = new System.Drawing.Point(223, 140);
            this.fecha_ticket.Name = "fecha_ticket";
            this.fecha_ticket.Size = new System.Drawing.Size(70, 25);
            this.fecha_ticket.TabIndex = 12;
            this.fecha_ticket.Text = "label8";
            // 
            // hora_ticket
            // 
            this.hora_ticket.AutoSize = true;
            this.hora_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_ticket.Location = new System.Drawing.Point(223, 179);
            this.hora_ticket.Name = "hora_ticket";
            this.hora_ticket.Size = new System.Drawing.Size(70, 25);
            this.hora_ticket.TabIndex = 13;
            this.hora_ticket.Text = "label9";
            // 
            // precio_ticket
            // 
            this.precio_ticket.AutoSize = true;
            this.precio_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_ticket.Location = new System.Drawing.Point(223, 291);
            this.precio_ticket.Name = "precio_ticket";
            this.precio_ticket.Size = new System.Drawing.Size(79, 25);
            this.precio_ticket.TabIndex = 14;
            this.precio_ticket.Text = "Precio:";
            // 
            // nrosala_ticket
            // 
            this.nrosala_ticket.AutoSize = true;
            this.nrosala_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrosala_ticket.Location = new System.Drawing.Point(191, 57);
            this.nrosala_ticket.Name = "nrosala_ticket";
            this.nrosala_ticket.Size = new System.Drawing.Size(70, 25);
            this.nrosala_ticket.TabIndex = 17;
            this.nrosala_ticket.Text = "label1";
            // 
            // idioma_ticket
            // 
            this.idioma_ticket.AutoSize = true;
            this.idioma_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idioma_ticket.Location = new System.Drawing.Point(223, 257);
            this.idioma_ticket.Name = "idioma_ticket";
            this.idioma_ticket.Size = new System.Drawing.Size(79, 25);
            this.idioma_ticket.TabIndex = 19;
            this.idioma_ticket.Text = "Precio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(142, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Idioma";
            // 
            // btn_MenuPrincipal
            // 
            this.btn_MenuPrincipal.Location = new System.Drawing.Point(336, 385);
            this.btn_MenuPrincipal.Name = "btn_MenuPrincipal";
            this.btn_MenuPrincipal.Size = new System.Drawing.Size(115, 42);
            this.btn_MenuPrincipal.TabIndex = 20;
            this.btn_MenuPrincipal.Text = "Volver al menu";
            this.btn_MenuPrincipal.UseVisualStyleBackColor = true;
            this.btn_MenuPrincipal.Click += new System.EventHandler(this.btn_MenuPrincipal_Click);
            // 
            // text_error
            // 
            this.text_error.AutoSize = true;
            this.text_error.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_error.ForeColor = System.Drawing.Color.Red;
            this.text_error.Location = new System.Drawing.Point(243, 318);
            this.text_error.Name = "text_error";
            this.text_error.Size = new System.Drawing.Size(0, 19);
            this.text_error.TabIndex = 21;
            // 
            // adv_1
            // 
            this.adv_1.AutoSize = true;
            this.adv_1.BackColor = System.Drawing.Color.Transparent;
            this.adv_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adv_1.ForeColor = System.Drawing.Color.Red;
            this.adv_1.Location = new System.Drawing.Point(155, 9);
            this.adv_1.Name = "adv_1";
            this.adv_1.Size = new System.Drawing.Size(519, 31);
            this.adv_1.TabIndex = 22;
            this.adv_1.Text = "Este ticket ya fue previamente impreso";
            this.adv_1.Visible = false;
            // 
            // error_sucursal
            // 
            this.error_sucursal.AutoSize = true;
            this.error_sucursal.BackColor = System.Drawing.Color.Transparent;
            this.error_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_sucursal.ForeColor = System.Drawing.Color.Red;
            this.error_sucursal.Location = new System.Drawing.Point(492, 140);
            this.error_sucursal.Name = "error_sucursal";
            this.error_sucursal.Size = new System.Drawing.Size(305, 20);
            this.error_sucursal.TabIndex = 23;
            this.error_sucursal.Text = "Este ticket pertenece a otra sucursal";
            this.error_sucursal.Visible = false;
            // 
            // TICKET_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.error_sucursal);
            this.Controls.Add(this.adv_1);
            this.Controls.Add(this.text_error);
            this.Controls.Add(this.btn_MenuPrincipal);
            this.Controls.Add(this.idioma_ticket);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nrosala_ticket);
            this.Controls.Add(this.precio_ticket);
            this.Controls.Add(this.hora_ticket);
            this.Controls.Add(this.fecha_ticket);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fila_ticket);
            this.Controls.Add(this.nombre_pelicula_ticket);
            this.Controls.Add(this.button1);
            this.Name = "TICKET_UC";
            this.Size = new System.Drawing.Size(800, 451);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nombre_pelicula_ticket;
        private System.Windows.Forms.Label fila_ticket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label fecha_ticket;
        private System.Windows.Forms.Label hora_ticket;
        private System.Windows.Forms.Label precio_ticket;
        private System.Windows.Forms.Label nrosala_ticket;
        private System.Windows.Forms.Label idioma_ticket;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_MenuPrincipal;
        private System.Windows.Forms.Label text_error;
        private System.Windows.Forms.Label adv_1;
        private System.Windows.Forms.Label error_sucursal;
    }
}
