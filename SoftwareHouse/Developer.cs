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

        private decimal _earnings;
        public decimal Earnings
        {
            get { return this._earnings; }
            set { this._earnings = value; }   // docelowo należy "opakować" lub użyć "Proxy"
        }

         // "Stan" - reprezentuje rodzaj dev
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


        public void PaySalary(decimal extrahours)
        {
            // Deleguje wykonanie operacji do obiektu typu DeveloperType,
            // wywołując na nim polimorficzną metodę PaySalary().
            this._developerType.PaySalary(this, extrahours);
        }

        // operacja zmiany "stanu" (rodzaju konta)
        public void ChangeDeveloperType()
        {
            // Deleguje wykonanie operacji do obiektu typu DeveloperType,
            // wywołując na nim polimorficzną metodę ChangeState().
            this._developerType.ChangeDeveloperType(this);
        }


    }
}