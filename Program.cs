using System;

namespace CondicionalIF3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce la nota del primer parcial");

            float parcial1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la nota del segundo parcial");

            float parcial2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la nota del tercer parcial");

            float parcial3 = Int32.Parse(Console.ReadLine());

            if(parcial1>=5 || parcial2>=5 || parcial3>=5)

                Console.WriteLine($"La nota media es {(parcial1+parcial2+parcial3)/3}");

            else Console.WriteLine("Vuelve en diciembre");




        }
    }
}
