using System;
namespace IntroToProg_Sem12_TimersListsInheritance
{
    public abstract class Vehicle
    {
        private string plateNumber;
        private int cleanlinessLevel;

        public string PlateNumber
        {
            get
            {
                return plateNumber;
            }
            set
            {
                plateNumber = value;
            }
        }

        public int CleanlinessLevel
        {
            get
            {
                return cleanlinessLevel;
            }
            set
            {
                cleanlinessLevel = value;
            }
        }

        public Vehicle(string pn, int cl)
        {
            PlateNumber = pn;
            CleanlinessLevel = cl;
        }
    }
}
