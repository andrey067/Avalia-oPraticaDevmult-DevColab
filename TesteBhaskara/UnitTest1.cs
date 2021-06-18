using Avaliação_Prática;
using Avaliação_Prática.Contract;
using Moq;
using Xunit;

namespace TesteBhaskara
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, -3, 15, -1)]
        [InlineData(2, -10, 8, 16)]
        [InlineData(1, -5, 6, 3)]
        [InlineData(4, -5, 10, -1)]
        public void BhaskaraTeste(double A, double B, double C, double valorEsperado)
        {
            //Arrange
            Bhaskara bhaskara = new Bhaskara();

            //Act
            var resultado = bhaskara.CalcularBhaskara(A, B, C);

            //Assert
            Assert.Equal(resultado, valorEsperado);
        }

        [Theory]
        [InlineData("Audrey", 27, "Não é primo")]
        //[InlineData("Leandro", -10, 8, 16)]
        //[InlineData("Rafael", -5, 6, 3)]
        //[InlineData("Diego", -5, 10, -1)]
        public void VerificarPrimo(string nome, int idade, string resultadoEsperado)
        {
            //Arrange
            Pessoa pessoa = new Pessoa(nome, idade);

            Mock<IPessoa> mock = new Mock<IPessoa>();
            mock.Setup(m => m.VerificarPrimo(pessoa)).Returns(resultadoEsperado);

            Pessoa verificar = new();

            //Act
            var v = mock.Object.VerificarPrimo(pessoa);
            var resultado = verificar.VerificarPrimo(pessoa);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }
    }
}
