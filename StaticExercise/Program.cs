namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FarenheitToCelsius(72);
            Console.WriteLine($"Here is the requested temperature converted from 72 degrees Farenheit to Celsius: {celsius}");
            Console.WriteLine("");
            var farenheit = TempConverter.CelsiusToFarenheit(22.22222222222222);
            Console.WriteLine($"Here is the requested temperature converted from 22.2222222 degrees Celsius to Farenheit: {farenheit}"); 
        }
    }
}
