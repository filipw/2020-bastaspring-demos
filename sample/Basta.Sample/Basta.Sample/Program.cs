using System;

namespace Basta.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "foo";
            var allowedName = "foo";
            var veryLongAndUnusuallyComplicatedName = "foo";

            Console.WriteLine($"{name}{allowedName}{veryLongAndUnusuallyComplicatedName}");
        }
    }
}
