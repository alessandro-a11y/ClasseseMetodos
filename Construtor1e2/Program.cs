using System;
namespace Construtor1e2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("Alessandro");
            Aluno aluno2 = new Aluno( 18, "Masculino", "Sim");

            Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
            Console.WriteLine(aluno.Idade == 0 ? "não há valor" : aluno2.Idade);
            Console.WriteLine(aluno.Sexo == null ? "null" : aluno2.Sexo);
            Console.WriteLine(aluno.Aprovado == null ? "null" : aluno2.Aprovado);
        }
    }
    public class Aluno
    {
        public Aluno(string nome)
        {
          Nome = nome;
        }
        public Aluno(int idade, string sexo, string aprovado)
        {
            Idade = idade;
            Sexo = sexo;
            Aprovado = aprovado;
        }
        public string? Nome;
        public int Idade;
        public string? Sexo;
        public string? Aprovado;
    }
}