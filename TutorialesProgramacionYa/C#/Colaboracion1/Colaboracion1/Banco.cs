using System;

namespace Colaboracion1
{
    class Banco
    {
        private Cliente _cliente1;
        private Cliente _cliente2;
        private Cliente _cliente3;

        public Banco()
        {
            _cliente1 = new Cliente("Sebastian");
            _cliente2 = new Cliente("Jazmin");
            _cliente3 = new Cliente("Santiago");
        }

        public void Operar()
        {
            _cliente1.Depositar(150000);
            _cliente2.Depositar(88074);
            _cliente3.Depositar(740000);
            
            _cliente3.Extraer(20000);
            _cliente2.Extraer(800);
            _cliente1.Extraer(150);

        }

        public void CalcularDepositosTotales()
        {
            float totaldia = _cliente1.RetornarMonto() + _cliente2.RetornarMonto() + _cliente3.RetornarMonto();

            Console.WriteLine($"La cantidad de dinero depositado en el banco al final del dia es de {totaldia}");
        }

        public void ImprimirSaldosPorCuenta()
        {
            _cliente1.Imprimir();
            _cliente2.Imprimir();
            _cliente3.Imprimir();
        }


    }
}
