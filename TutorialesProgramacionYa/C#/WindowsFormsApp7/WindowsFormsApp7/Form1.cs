using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(textBox1.Text);
            int valor2 = int.Parse(textBox2.Text);

            if (radioButton1.Checked  == true)
            {
                int resultado = valor1 + valor2;
                textBox3.Text = resultado.ToString();
                Text = textBox3.Text;
            }
            else
            {
                int resultado = valor1 - valor2;
                textBox3.Text = resultado.ToString();
                Text = textBox3.Text;
            }
        }
    }
}
