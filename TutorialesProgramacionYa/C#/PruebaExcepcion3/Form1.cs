using System;
using System.Windows.Forms;

namespace PruebaExcepcion3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = int.Parse(textBox1.Text);
                var num2 = int.Parse(textBox2.Text);
                var resu = num1 / num2;
                Text = $"La división de {num1} y {num2} es {resu}"; 
            }
            catch (FormatException ex)
            {
                Text = "Debe ingresar un valor entero";
            }
            catch(DivideByZeroException ex)
            {
                Text = "No se puede dividir por cero";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
