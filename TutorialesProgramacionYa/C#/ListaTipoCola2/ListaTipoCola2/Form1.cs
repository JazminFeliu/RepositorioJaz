using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTipoCola2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ale = new Random();
            int estado = 0;
            int llegada = 2 + ale.Next(0, 2);
            int salida = -1;
            int cantAtendidas = 0;

            var cola = new Cola();
            
            for (int minuto = 0; minuto<600; minuto++)
            {
                if (llegada == minuto)
                {
                    if (estado == 0)
                    {
                        estado = 1;
                        salida = minuto + 2 + ale.Next(0, 3);
                    }
                    else
                    {
                        cola.Insertar(minuto);
                    }
                    llegada = minuto + 2 + ale.Next(0, 3);
                }

                if (salida == minuto)
                {
                    estado = 0;
                    cantAtendidas++;
                    
                    if (!cola.Vacia())
                    {
                        cola.Extraer();
                        estado = 1;
                        salida = minuto + 2 + ale.Next(0, 3);
                    }
                }
            }

            label1.Text = "Atendidos: " + cantAtendidas.ToString();
            label2.Text = "En Cola: " + cola.Cantidad().ToString();
            label3.Text = "Minuto llegada: " + cola.Extraer().ToString();
        }
    }
}
