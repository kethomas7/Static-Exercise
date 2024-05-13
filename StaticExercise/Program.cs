namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var Farenheit = TempConverter.CeliusToFahernheit(27.3);
            var Celius = TempConverter.FaherenheitToCelius(87.5);

            Console.WriteLine($"Here is the Celius Converted to Fehernheit:{Farenheit}F");
            Console.WriteLine($"Here is the Fahrenheit converted to Celius:{Celius}C");

        }
    }
}
