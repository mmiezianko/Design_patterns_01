// Na płacę osoby na stanowisku Senior Developer składa się wynagrodzenie podstawowe w wysokości
// 9000zł oraz wynagrodzenie za nadgodziny ze stawką 50 zł za jedną nadgodzinę

using System;

namespace SoftwareHouse_StatePattern
{

 public class SeniorDeveloperType : DeveloperType
    {

        protected const decimal salary = 9000;
        public override void PaySalary(Developer developer, decimal extrahours)
        {
            decimal wholeSalary;
            wholeSalary = (decimal)salary + (decimal) extrahours * 50;
            developer.Earnings += (decimal)wholeSalary;
            Console.WriteLine("{0} was payed to {1} Senior developer. The earnings amount to {2}", wholeSalary, developer.Name, developer.Earnings);
        }

        public override void ChangeDeveloperType(Developer developer)
        {
            developer.DeveloperType = new Expert();
            Console.WriteLine("Senior developer: {0} is promoted to Expert role", developer.Name);
        }

    }
}