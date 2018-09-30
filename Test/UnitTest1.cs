using System;
using Xunit;
using ConsoleApp;

namespace Test
{
    public class UnitTest1
    {

        //Funcoes _f = new Funcoes();

        [Theory]
        [InlineData("ab1c")]
        [InlineData("ab1d")]
        [InlineData("1234")]
        [InlineData("abcdef")]
        public void StringInvalida(string valor)
        {
            int result = Funcoes.valorValido(valor); 
            Assert.True(result == 0, $"{valor} � v�lido");
        }

        [Theory]
        [InlineData("abc")]
        public void StringValida(string valor)
        {
            int result = Funcoes.valorValido(valor);  
            Assert.True(result > 0, $"{valor} � inv�lido");
        }

        [Theory]
        [InlineData("dc")]
        [InlineData("cat")]
        public void StringInvalidaContexto(string valor)
        {
            int result = Funcoes.valorValido(valor);  
            Assert.True(result == 0, $"{valor} � v�lido");
        }

        [Theory]
        [InlineData("a")]
        public void StringValidaContexto_a(string valor)
        {
            int result = Funcoes.valorValido(valor);
            Assert.True(result == 1, $"{valor} � inv�lido");
        }

        [Theory]
        [InlineData("bc")]
        public void StringValidaContexto_bc(string valor)
        {
            int result = Funcoes.valorValido(valor);
            Assert.True(result == 52, $"{valor} � inv�lido");
        }

        [Theory]
        [InlineData("ac")]
        public void StringValidaContexto_ac(string valor)
        {
            int result = Funcoes.valorValido(valor);
            Assert.True(result == 28, $"{valor} � inv�lido");
        }

        [Theory]
        [InlineData("vwxyz")]
        public void StringValidaContexto_macx(string valor)
        {
            int result = Funcoes.valorValido(valor);
            Assert.True(result == 83681, $"{valor} � inv�lido");
        }


    }
}
