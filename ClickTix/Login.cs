﻿using ClickTix.Empleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            validarUsuario(txt_user.Text, txt_pw.Text);

            // Index_User index = new Index_User();            


            Index_Admin index = new Index_Admin();
            index.Show();



            this.Hide();    
        }

        private void validarUsuario(string user, string pw)
        {
            Trace.WriteLine(user + " " + pw);
            txt_user.Text = user;
            txt_pw.Text = pw;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}