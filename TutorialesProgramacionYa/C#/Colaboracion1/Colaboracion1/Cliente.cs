using System;

namespace Colaboracion1
{
    class Cliente
    {
        private string _nombreCliente;
        private float _montoCliente;

        public Cliente(string nombre)
        {
            _nombreCliente = nombre;
            _montoCliente = 0;
        }

        public void Depositar(float montoDeposito)
        {
            _montoCliente += montoDeposito;
        }
         
        public void Extraer(float montoExtraccion)
        {
            _montoCliente -= montoExtraccion;
        }

        public float RetornarMonto()
        {
            return _montoCliente;
        }            

        public void Imprimir()
        {
            Console.WriteLine($"{_nombreCliente} tiene en su cuenta la suma de ${_montoCliente}.");
        }
    }
}
