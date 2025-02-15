using System;

namespace Foreachloops 
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Bikram Subba";
           
            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
        }

    }

}
