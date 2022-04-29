namespace SoftwareHouse_StatePattern
{
    // Represents DeveloperType- it playes a role of "State"  class in State pattern
    // DeveloperType contains abstract methods,
    // These methods are used by Developer object
    // Inhereited classes contain concrete implementation of these methods
    public abstract class DeveloperType
    {
        // witdrawal operation - will be overriden in inherited classes
        public abstract void PaySalary(Developer developer, decimal extrahours);


        // used to change dev type - 
        public abstract void ChangeDeveloperType(Developer developer);
    }
}
