using System;
namespace ParametrosOpcionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            email.Enviar("figueiredoalessandro73@gmail.com");
        }
    }
    public class Email
    {
        public void Enviar(string destino, string titulo = "Reunião", string assunto = "avalição técnica")
        {
            Console.WriteLine($"{destino}\t{titulo}\t {assunto}");
        }
    }
}