using System;
namespace IntroToProg_Sem12_TimersListsInheritance
{
    public class Transaction
    {
        private double cost;
        private Vehicle vehicle;

        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }

        public Vehicle Vehicle
        {
            get
            {
                return vehicle;
            }
            set
            {
                vehicle = value;
            }
        }

        public Transaction()
        {
        }
    }
}
