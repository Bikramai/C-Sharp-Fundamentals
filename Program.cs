using System;

namespace Strings
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Bikram";
            var lastName = "Limbu";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Ayusha", "Mangi", "Hangsu" };
            var formattedNames = string.Join(",", names);

            var text = @"Hi Bikram
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }

}
