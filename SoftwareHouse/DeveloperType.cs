namespace SoftwareHouse_StatePattern
{
    // Represents Account Type - it playes a role of "State"  class in State pattern
    // AccountType contains abstract methods,
    // These methods are used by Account object
    // Inhereited classes contain concrete implementation of these methods
    public abstract class AccountType
    {
        // witdrawal operation - will be overriden in inherited classes
        public abstract void Withdraw(Account account, decimal amount);


        // used to change account type - 
        public abstract void ChangeAccountType(Account account);
    }
}
