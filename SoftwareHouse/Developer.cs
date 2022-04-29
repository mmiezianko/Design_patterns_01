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






    }
}