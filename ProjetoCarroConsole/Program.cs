using System;
namespace Metodos
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Car chevrolet = new Car("Sedan", "Chevrolet", "Onix", 2016, 110);
            Car ford = new Car("SUV", "Ford", "EcoSport", 2018, 130);

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
            

            Console.WriteLine($"Modelo: {chevrolet.Model}\nMontadora: {chevrolet.MarManufacturer}\nMarca: {chevrolet.Mark}\nYear: {chevrolet.Year}\nPotência: {chevrolet.Power}");
            Console.WriteLine($"\nModelo: {ford.Model}\nMontadora: {ford.MarManufacturer}\nMarca: {ford.Mark}\nYear: {ford.Year}\nPotência: {ford.Power}\n");
            chevrolet.Accelerating(chevrolet.Mark);
            ford.Accelerating(ford.Mark);

        }
    }
    public class Car
    {
        public string? Model;
        public string? MarManufacturer;
        public string? Mark;
        public int Year;
        public int Power;

        // Construtor
        public Car(string model, string manufacturer, string mark, int year, int power)
        {
            this.Model = model;
            this.MarManufacturer = manufacturer;
            this.Mark = mark;
            this.Year = year;
            this.Power = power;
        }


        public void Accelerating(string Mark)
        {
            Console.WriteLine($"Acelerando o meu {Mark}");
        }


    }
}