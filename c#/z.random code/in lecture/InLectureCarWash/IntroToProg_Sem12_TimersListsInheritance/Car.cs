using System;
namespace IntroToProg_Sem12_TimersListsInheritance
{
    public class Car : Vehicle
    {
        private int backSeatsCount;

        public int BackSeatsCount
        {
            get
            {
                return backSeatsCount;
            }
            set
            {
                backSeatsCount = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:IntroToProg_Sem12_TimersListsInheritance.Car"/> class.
        /// The Plate Number and Cleanliness Level are passed to Vehicle's constructor.
        /// </summary>
        /// <param name="pn">Plate Number.</param>
        /// <param name="cl">Cleanliness Level.</param>
        /// <param name="bsc">Back Seat Count.</param>
        public Car(string pn, int cl, int bsc) : base(pn, cl)
        {
            BackSeatsCount = bsc;
        }
    }
}
