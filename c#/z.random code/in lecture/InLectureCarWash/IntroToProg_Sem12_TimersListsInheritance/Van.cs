using System;
namespace IntroToProg_Sem12_TimersListsInheritance
{
    public class Van : Vehicle
    {
        private int storageSpace;

        public int StorageSpace
        {
            get
            {
                return storageSpace;
            }
            set
            {
                storageSpace = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:IntroToProg_Sem12_TimersListsInheritance.Van"/> class.
        /// The Plate Number and Cleanliness Level are passed to Vehicle's constructor.
        /// </summary>
        /// <param name="pn">Plate Number.</param>
        /// <param name="cl">Cleanliness Level.</param>
        /// <param name="ss">Storage Space.</param>
        public Van(string pn, int cl, int ss) : base(pn, cl)
        {
            StorageSpace = ss;
        }
    }
}
