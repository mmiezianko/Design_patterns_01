using System;

namespace SoftwareHouse_StatePattern
{
    // Reprezentuje rodzaj konta VIP - we wzorcu State pełni rolę "Concrete State"
    public class JuniorDeveloperType : DeveloperType
    {
        protected const decimal salary = 5000;
        public override void PaySalary(Developer developer, decimal extrahours)
        {
            developer.Earnings += salary;
            Console.WriteLine("{0} was payed to {1} Junior developer. The earnings amount to {2}", salary, developer.Name, developer.Earnings);
        }

        public override void ChangeDeveloperType(Developer developer)
        {
            developer.DeveloperType = new SeniorDeveloperType();
            Console.WriteLine("Junior developer: {0} is promoted to Senior developer", developer.Name);
        }

    }
}