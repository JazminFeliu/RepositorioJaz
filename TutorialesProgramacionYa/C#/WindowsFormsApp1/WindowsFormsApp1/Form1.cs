﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private object label1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hola Mundo";
            //button19.Text = "Hola Mundo";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
