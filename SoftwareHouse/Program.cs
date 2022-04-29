using System;

namespace SoftwareHouse_StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer johnDev = new Developer("John");
            Developer katieDev = new Developer("Katie");

            johnDev.PaySalary(2);
            katieDev.PaySalary(1);

            Console.WriteLine("----------");
            Console.ReadKey();
            johnDev.ChangeDeveloperType();

            Console.WriteLine("----------");
            Console.ReadKey();
            johnDev.PaySalary(10);
            katieDev.PaySalary(0);

            Console.WriteLine("----------");
            Console.ReadKey();
            johnDev.ChangeDeveloperType();
            katieDev.ChangeDeveloperType();

            Console.WriteLine("----------");
            Console.ReadKey();
            johnDev.PaySalary(100);

            Console.WriteLine("----------");
            Console.ReadKey();
            johnDev.ChangeDeveloperType();

            Console.WriteLine("----------");
            Console.ReadKey();
            katieDev.PaySalary(4);

            Console.WriteLine("----------");
            Console.ReadKey();
        }
    }
}
