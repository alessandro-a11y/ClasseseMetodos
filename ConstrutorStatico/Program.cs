using System;
namespace ConstrutorStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Alessandro", 18);

            Console.WriteLine($"{p1.Nome} - {p1.idade}");
            Console.WriteLine($"Idade mínima: {Pessoa.IdadeMinima}");

        }
    }
    public class Pessoa
    {
        public static int IdadeMinima;
        public string Nome { get; set; } = string.Empty;
        public int idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Console.WriteLine("\nExecutando o construtor parametrizado");
            Nome = nome;
            this.idade = idade;
        }
        public Pessoa()
        { }
        static Pessoa()
        {
            Console.WriteLine("\nExecutando o construtor estático");
            Console.WriteLine("Inicializando o campo IdadeMinima");
            IdadeMinima = 18;
        }
    }
}