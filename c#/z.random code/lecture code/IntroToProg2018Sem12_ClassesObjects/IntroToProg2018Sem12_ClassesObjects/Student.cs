using System;
namespace IntroToProg2018Sem12_ClassesObjects
{
    public class Student
    {
        private const int MAX_MODULES = 2;

        public int MaxModules
        {
            get
            {
                return MAX_MODULES;
            }
        }

        private Module[] modules = new Module[MAX_MODULES];

        private int moduleCounter = 0;

        /// <summary>
        /// The student ID.
        /// </summary>
        public string ID;

        /// <summary>
        /// The name.
        /// </summary>
        public string name;

        /// <summary>
        /// The email.
        /// </summary>
        public string email;

        /// <summary>
        /// The private attribute.
        /// </summary>
        private string noRead = "PRIVATE";

        /// <summary>
        /// Initializes a new instance of the <see cref="T:IntroToProg2018Sem12_ClassesObjects.Student"/> class.
        /// </summary>
        /// <param name="_ID">Student ID.</param>
        /// <param name="_name">Name.</param>
        /// <param name="_email">Email.</param>
        public Student(string _ID, string _name, string _email)
        {
            ID = _ID;
            name = _name;
            email = _email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:IntroToProg2018Sem12_ClassesObjects.Student"/> class.
        /// </summary>
        public Student() { }

        /// <summary>
        /// Presents the myself.
        /// </summary>
        /// <returns>The current student in string form.</returns>
        public string PresentMyself()
        {
            return ID + " / " + name + " / " + email + " / " + noRead;
        }

        public void AssignModule(Module module)
        {
            if (MAX_MODULES == moduleCounter)
            {
                Console.WriteLine("Student has reached the Maximum number of Modules!");
                return;
            }

            for (int i = 0; i < MAX_MODULES; i++)
            {
                if (modules[i] == null)
                {
                    modules[i] = module;
                    break;
                }
            }

            moduleCounter++;

            Console.WriteLine("Module '{0}' has been added!", module.PresentMyself());
        }

        public string ShowModules()
        {
            string list = "";

            for (int i = 0; i < MAX_MODULES; i++)
            {
                list += modules[i].PresentMyself() + "\n";
            }

            return list;
        }
    }
}
