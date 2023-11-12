using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTeste
    {
        private ValidacoesString _val;

        public ValidacoesStringTeste()
        {
            _val = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3(){
            // Arrange
            string texto = "ola";
            // Act 
            int resultado = _val.ContarCaracteres(texto);
            // Assert
            Assert.Equal(3,resultado);
        }
        

    }
}