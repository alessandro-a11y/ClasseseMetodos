using System;
using System.Runtime.Intrinsics.X86;
namespace Metodos
{
    internal class Program 
    {
        static void Main(string[] args)
        {


            //Car chevrolet = new Car();
            //chevrolet.Model = "Sedan";
            //chevrolet.MarManufacturer = "Chevrolet";
            //chevrolet.Mark = "Onix";
            //chevrolet.Year = 2016;
            //chevrolet.Power = 110;



            //Car ford = new Car();
            //ford.Model = "SUV";
            //ford.MarManufacturer = "Ford";
            //ford.Mark = "EcoSport";
            //ford.Year = 2018;
            //ford.Power = 130;

            Car chevrolet = new Car("Sedan", "Chevrolet", "Onix", 2016, 110);
            Car ford = new Car("SUV", "Ford", "EcoSport", 2018, 130);
            // chamar o metodo velocidade maxima
           

            Console.WriteLine(
                $"Modelo: {chevrolet.Model}\n" +
                $"Montadora: {chevrolet.MarManufacturer}\n" +
                $"Marca: {chevrolet.Mark}\n" +
                $"Ano: {chevrolet.Year}\n" +
                $"Potência: {chevrolet.Power}\n"
                );
            
            Console.WriteLine($"" +
                $"Modelo: {ford.Model}\n" +
                $"Montadora: {ford.MarManufacturer}\n" +
                $"Marca: {ford.Mark}\n" +
                $"Ano: {ford.Year}\n" +
                $"Potência: {ford.Power}\n"
                );
            
            chevrolet.Accelerating(chevrolet.Mark);
            ford.Accelerating(ford.Mark);
            Console.WriteLine($"\nA velocidade máxima do Onix é : {chevrolet.VelocidadeMaxima(chevrolet.Power)}km/h");
            Console.WriteLine($"\nA velocidade máxima do EcoSport é : {ford.VelocidadeMaxima(ford.Power)}km/h");
        }
    }
    public class Car
    {
        public string? Model;
        public string? MarManufacturer;
        public string? Mark;
        public int Year;
        public int Power;
        //Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não 
        //use a palavra-chave this)
        public int VelocidadeMaxima(int potencia)
        {
            double velMax = potencia * 1.75;
            return (int)velMax;
        }
        public Car(string model, string manufacturer)
        {
            Model = model;
            MarManufacturer = manufacturer;
        }
        // Construtor
        public Car(string model, string manufacturer, string mark, int year, int power)
        {
            Model = model;
            MarManufacturer = manufacturer;
            Mark = mark;
            Year = year;
            Power = power;
        }


        public void Accelerating(string Mark)
        {
            Console.WriteLine($"Acelerando o meu {Mark}");
        }


    }
}