using temperature;
using static temperature.Thermometer;

namespace temperature
{
    public delegate void temperature_change_event(double new_temperature);
    public class Thermometer
    {
        private double temperature;
        public event temperature_change_event Temperature_change;
        public double Temperature
        {
            get { return temperature; }
            set
            {
                if (temperature != value)
                {
                    temperature = value; On_temperature_change(temperature);
                }
            }
        }
        protected virtual void On_temperature_change(double new_temperature) { Temperature_change?.Invoke(new_temperature); }
        public class Air_conditioner { public void adjust_temperature(double new_temperature) { Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"[air conditioner] - adjusting to maintain temperature. current: {new_temperature}°C"); Console.ResetColor(); } }
        public class Warning_system { public void alert(double new_temperature) { Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"[warning system] - temperature is now {new_temperature}°C"); Console.ResetColor(); } }

    }
}
public static class Console_color_extensions
{
    public static void write_temperature(double temperature)
    {
        if (temperature >= 15 && temperature <= 25) { Console.ForegroundColor = ConsoleColor.Green; }
        else if (temperature < 15) { Console.ForegroundColor = ConsoleColor.Blue; }
        else { Console.ForegroundColor = ConsoleColor.Red; }
        Console.Write($"{temperature}°C");
        Console.ResetColor();
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Thermometer thermometer = new Thermometer();
            Air_conditioner air_conditioner = new Air_conditioner();
            Warning_system warning_System = new Warning_system();
            thermometer.Temperature_change += air_conditioner.adjust_temperature;
            thermometer.Temperature_change += warning_System.alert;
            thermometer.Temperature_change += (new_temperature) =>
            {
                Console.Write("current temperature is: ");
                Console_color_extensions.write_temperature(new_temperature); Console.WriteLine();
            };
            thermometer.Temperature = 20;
            thermometer.Temperature = 10;
            thermometer.Temperature = 30;
            thermometer.Temperature = 22;
        }
    }

}