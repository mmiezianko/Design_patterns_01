// Płaca osoby na stanowisku Expert składa się z trzech składników: wynagrodzenie podstawowe w
// wysokości 15000zł, wynagrodzenie za nadgodziny ze stawką 100 zł za jedną nadgodzinę oraz premia
// w wysokości 3% od wynagrodzenia podstawowego i nadgodzin 

using System;

namespace SoftwareHouse_StatePattern
{

 public class Expert : DeveloperType
    {

        protected const decimal salary = 15000;
        public override void PaySalary(Developer developer, decimal extrahours)
        {
            var percentage = 0.03;
            var basesalary = salary + extrahours * 100;
            var bonus = (decimal)percentage * basesalary;
            var wholeSalary = basesalary + bonus;
            developer.Earnings += (decimal) wholeSalary;
            Console.WriteLine("{0} was payed to {1} Senior developer. The earnings amount to {2}", wholeSalary, developer.Name, developer.Earnings);
        }

         public override void ChangeDeveloperType(Developer developer)
        {
        
            Console.WriteLine(" No further way for personal development of the Expert {0}", developer.Name);
        }

    }
}