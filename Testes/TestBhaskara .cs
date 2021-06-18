using Avaliação_Prática;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Testes
{

    public class BhaskaraTeste
    {
        [Theory]
        [InlineData(2, -3, 15, -1)]
        public void TestBhaskara(double A, double B, double C, double valorEsperado)
        {
            //Arrange          
            Bhaskara bhaskar = new Bhaskara();

            //Act
            var resultado = bhaskar.CalcularBhaskara(A, B, C);


            //Assert
           Assert.Equal(expected: resultado, valorEsperado);
        }
    }
}
