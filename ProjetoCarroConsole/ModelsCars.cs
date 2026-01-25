using System;

namespace Metodos
{
    internal class ModelsCars
    {
        static void Main(string[] args)
        {
            Car chevrolet = new Car("Sedan", "Chevrolet", "Onix", 2016, 110);
            Car ford = new Car("SUV", "Ford", "EcoSport", 2018, 130);

            int potenciaAtual = chevrolet.Power;

            ExibirDados(chevrolet);
            ExibirDados(ford);

            chevrolet.Accelerating(chevrolet.Mark);
            ford.Accelerating(ford.Mark);

            Console.WriteLine(
                $"\nVelocidade máxima do Onix: " +
                $"{chevrolet.VelocidadeMaxima(chevrolet.Power)} km/h"
            );

            Console.WriteLine(
                $"\nVelocidade máxima do EcoSport: " +
                $"{ford.VelocidadeMaxima(ford.Power)} km/h"
            );

            chevrolet.AumentarPotencia(chevrolet.Power);
            ford.AumentarPotencia(ford.Power);

            Console.WriteLine($"\nPotência do Onix aumentada: {chevrolet.Power}");
            Console.WriteLine($"Potência do EcoSport aumentada: {ford.Power}");

            int novaPotencia = chevrolet.AumentarPotencia(ref potenciaAtual);

            Console.WriteLine($"\nPotência após método por referência: {potenciaAtual}");
            Console.WriteLine($"Valor retornado pelo método: {novaPotencia}");
        }

        static void ExibirDados(Car car)
        {
            Console.WriteLine(
                $"Modelo: {car.Model}\n" +
                $"Montadora: {car.MarManufacturer}\n" +
                $"Marca: {car.Mark}\n" +
                $"Ano: {car.Year}\n" +
                $"Potência: {car.Power}\n"
            );
        }
    }

    public class Car
    {
        public string? Model;
        public string? MarManufacturer;
        public string? Mark;
        public int Year;
        public int Power;

        public Car() { }

        public Car(string model, string manufacturer)
        {
            Model = model;
            MarManufacturer = manufacturer;
        }

        public Car(string model, string manufacturer, string mark, int year, int power)
        {
            Model = model;
            MarManufacturer = manufacturer;
            Mark = mark;
            Year = year;
            Power = power;
        }

        public void AumentarPotencia(int potencia)
        {
            Power = potencia + 3;
        }

        public int AumentarPotencia(ref int potencia)
        {
            potencia += 5;
            return potencia;
        }

        public int VelocidadeMaxima(int potencia)
        {
            return (int)(potencia * 1.75);
        }

        public void Accelerating(string mark)
        {
            Console.WriteLine($"Acelerando o meu {mark}");
        }
    }
}
