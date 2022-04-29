using System;

namespace SoftwareHouse_StatePattern
{
    // Reprezentuje rodzaj konta VIP - we wzorcu State pełni rolę "Concrete State"
    public class JuniorDeveloperType : DeveloperType
    {
        protected const decimal salary = 5000;
        public override void PaySalary(Developer developer, decimal extrahours)
        {
            developer.Balance += salary;
            Console.WriteLine("{0} was payed to {1} Junior developer", salary, developer.Name);
        }



    }
}