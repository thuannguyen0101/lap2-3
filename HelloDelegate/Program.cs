using System;

namespace HelloDelegate
{
    internal class Program
    {
        public  delegate void Increment(ref int x);

        public static void Add2(ref int x)
        {
            x += 2;
        }
        public static void Add3(ref int x)
        {
            x += 3;
        }
        public static void Main(string[] args)
        {
            Increment functionDelegate = Add2;
            functionDelegate += Add3;
            functionDelegate += Add2;
            int x = 5;
            functionDelegate(ref x);
            Console.WriteLine(x);
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);

            thermostat.OnTemperatureChange +=
                heater.OnTemperatureChanged;
            Heater heaterCuong = new Heater(100);
            thermostat.OnTemperatureChange +=
                heaterCuong.OnTemperatureChanged;
            Cooler cooler = new Cooler(80);
            thermostat.OnTemperatureChange +=
                cooler.OnTemperatureChanged;
            string temperature;
            Console.Write("Enter temperature: ");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature = int.Parse(temperature);
            Console.ReadLine();
        }
        
    }
}