using Avaliação_Prática.Contract;

namespace Avaliação_Prática
{
    public class Pessoa : IPessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string resultado { get; set; }

        public string VerificarPrimo(Pessoa pessoa)
        {
            pessoa.resultado = (pessoa.Idade % 2) == 0 ? "É primo" : "Não é primo";
            return pessoa.resultado;
        }
    }
}
