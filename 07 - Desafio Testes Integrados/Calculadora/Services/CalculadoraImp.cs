using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public bool EhPar(int num){
            return num % 2 == 0;
        }
    }
}