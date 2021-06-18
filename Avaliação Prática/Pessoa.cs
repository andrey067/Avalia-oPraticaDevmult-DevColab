using Avaliação_Prática.Contract;

namespace Avaliação_Prática
{
    public class Pessoa : IPessoa
    {

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string VerificarPrimo(Pessoa pessoa)
        {
            var resultado = (pessoa.Idade % 2) == 0 ? "É primo" : "Não é primo";
            return resultado;
        }
    }
}
