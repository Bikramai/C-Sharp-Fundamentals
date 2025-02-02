using System;
using Hello_World.Math;

namespace Classes
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var Bikram = new Person();
            Bikram.FirstName = "Bikram";
            Bikram.LastName = "Limbu";
            Bikram.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

        }
    }

}
