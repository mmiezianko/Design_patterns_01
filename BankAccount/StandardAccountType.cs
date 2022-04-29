﻿using System;

namespace BankAccount_StatePattern
{
    // Represents Standard Account type - it playes a role of "Specific State" in State pattern
    public class StandardAccountType : AccountType
    {
        protected const decimal withdrawLimit = 5000;

        protected const decimal serviceFee = 3;

        // Operacja wypłaty dla konta Standard
        //
        // Obiekt Account wywoła tę wersję metody Withdraw(),
        // jeśli znajdzie się w "stanie" Standard
        public override void Withdraw(Account account, decimal amount)
        {
            if ((amount > withdrawLimit) || (account.Balance < amount + serviceFee))
            {
                Console.WriteLine("Withdrawal operation of {0} from Standard Account of {1} failed", amount, account.Owner);
                return;
            }

            account.Balance -= amount + serviceFee;
            Console.WriteLine("{0} was withdrowed from {1} Standard account", amount, account.Owner);
        }

        // Operacja zmiany rodzaju konta
        //
        // Obiekt Account wywoła tę wersję metody ChangeAccountType(),
        // jeśli znajdzie się w "stanie" StandardAccountState.
        public override void ChangeAccountType(Account account)
        {
            // jeśli saldo jest większe od 30000, konto Standard może być zmienione na VIP
            if (account.Balance > 30000)
            {
                account.AccountType = new VIPAccountType();
                Console.WriteLine("{0} Standard account was changed to VIP", account.Owner);
            }
            else
                Console.WriteLine("The operation of changing {0} Standard account type to VIP failed", account.Owner);
        }
    }
}
