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
        [Fact]
        public void VerificarPrimo()
        {
            //Arrange
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Audrey";
            pessoa.Idade = 27;
            pessoa.resultado = "Não é primo";

            Mock<IPessoa> mock = new Mock<IPessoa>();
            mock.Setup(m => m.VerificarPrimo(pessoa)).Returns("Não é primo");

            Pessoa verificar = new Pessoa();

            //Act
            var resultadoEsperado = mock.Object.VerificarPrimo(pessoa);
            var resultado = verificar.VerificarPrimo(pessoa);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);

        }
    }
}
