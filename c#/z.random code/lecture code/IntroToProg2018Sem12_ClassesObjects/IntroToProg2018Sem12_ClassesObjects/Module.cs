using System;
namespace IntroToProg2018Sem12_ClassesObjects
{
    public class Module
    {
        /// <summary>
        /// The name.
        /// </summary>
        private string name;
        /// <summary>
        /// The code.
        /// </summary>
        private string code;

        public string Name
        {
            // operates like a method with string return type
            get {
                // ...
                return name;
            }
            // operates like a void method
            set {
                name = value;
            }
        }

        public string Code
        {
            // operates like a method with string return type
            get
            {
                return code;
            }
            // operates like a void method
            set
            {
                string v = value.ToUpper();
                code = v;
            }
        }

        public Module()
        {
        }

        /// <summary>
        /// Presents the module in string form.
        /// </summary>
        /// <returns>The module in string form.</returns>
        public string PresentMyself()
        {
            return Code + " / " + Name;
        }
    }
}
