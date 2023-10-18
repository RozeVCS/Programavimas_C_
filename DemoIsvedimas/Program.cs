using System;

namespace DemoIsvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var currentConsoleOutputEncoding = Console.OutputEncoding;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Labas, pasauli");
            Console.WriteLine("Ačiū!");
            Console.WriteLine();// tuscia eilute

            //Frazes isvedimas be kintamuju
            Console.WriteLine("Mano amžius: 35, o mano ūgis: 1.91");

            //Frazs su kintamaisiais 
            int amzius = 35;
            float ugis = 1.91f;

            Console.Write("Mano amžius: ");
            Console.Write(amzius);
            Console.Write(", o mano ūgis: ");
            Console.WriteLine(ugis);
            Console.WriteLine(".");

            //String + non string = string
            Console.WriteLine("Mano amžius: " + amzius + ", o mano ūgis: " + ugis + ".");

            // Java way
            Console.WriteLine("Mano amžius: {0}, o mano ūgis: {1}.", amzius, ugis);

            // The smart way: sun-glasses:
            Console.WriteLine($"Mano amžius: {amzius}, o mano ūgis: {ugis}.");





        }
    }
}
