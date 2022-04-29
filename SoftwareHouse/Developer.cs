using System;

namespace SoftwareHouse_StatePattern
{
    // Reprezentuje developera - we wzorcu "State" pełni rolę "Context"
    // Obiekt typu Developer zawiera referencje do jednego obiektu typu DeveloperType.
    // Obiekt typu Developer może zmienić "stan" poprzez zmianę skojarzonego z nim obiektu DeveloperType.
    public class Developer
    {
        private string _name;

        public string Name 
        {
            get { return this._name; }
            set { this._name = value; }
        }

        private decimal _balance;
        public decimal Balance
        {
            get { return this._balance; }
            set { this._balance = value; }   // docelowo należy "opakować" lub użyć "Proxy"
        }

         // "Stan" - reprezentuje rodzaj konta (Junior, Standard, VIP).
        private DeveloperType _developerType;
        public DeveloperType DeveloperType
        {
            get { return this._developerType; }
            set { this._developerType = value; }
        }

        public Developer(string name)
        {
            this._name = name;
            this._developerType = new JuniorDeveloperType();
        }



    }
}