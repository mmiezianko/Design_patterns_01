using System;

namespace BankAccount_StatePattern
{
// Represents Junior Account type - it playes a role of "Specific State" in State pattern
       public class JuniorAccountType : AccountType
    {
        protected const decimal withdrawLimit = 3000;


        // Operacja wypłaty dla konta Junior
        //
        // Obiekt Account wywoła tę wersję metody Withdraw(),
        // jeśli znajdzie się w "stanie" Junior
        public override void Withdraw(Account account, decimal amount)
        {
            if ((amount > withdrawLimit) || (account.Balance < amount))
            {
                Console.WriteLine("Withdrawal operation of {0} from Junior Account of {1} failed", amount, account.Owner);
                return;
            }

            account.Balance -= amount;
            Console.WriteLine("{0} was withdrowed from {1} Junior account", amount, account.Owner);
        }

         public override void ChangeAccountType(Account account)
        {
            account.AccountType = new StandardAccountType();
            Console.WriteLine("Junior account: {0} is changed to Standard", account.Owner);
        }


    }
}  