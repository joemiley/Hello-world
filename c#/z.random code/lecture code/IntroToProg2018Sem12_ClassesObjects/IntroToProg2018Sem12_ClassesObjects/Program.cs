using System;

namespace IntroToProg2018Sem12_ClassesObjects
{
    class MainClass
    {
        // constants
        const int MAX_STUDENTS = 3;

        // global variables
        // array of students
        static Student[] students = new Student[MAX_STUDENTS];

        // student counter
        static int noOfStudents = 0;

        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        public static void Main()
        {
            // prepare array
            PrepareStorage();

            // local variables
            char userChoice;

            do
            {

                Console.Clear();

                // present menu
                ShowMenu();

                // get user choice
                userChoice = GetUserChoice("Please choose one: ");

                Console.Clear();

                // handle choice
                switch (userChoice)
                {

                    // 1. add student
                    case '1':

                        AddStudent();

                        break;

                    // 2. delete student
                    case '2':

                        DeleteStudent();

                        break;

                    // 3. edit student
                    case '3':

                        EditStudent();

                        break;

                    // 4. view students
                    case '4':

                        ViewStudents();

                        break;

                    // x. Exit
                    case 'x':

                        Exit();

                        break;

                    default:

                        Console.WriteLine();
                        Console.WriteLine("Wrong option... Try again.");

                        break;

                }

                Console.WriteLine();
                Console.WriteLine("Press any key to return to the Menu ...");
                Console.ReadKey();

            } while (userChoice != 'x');

            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();

        }

        /// <summary>
        /// Shows the menu.
        /// </summary>
        static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Delete Student");
            Console.WriteLine("3. Edit Student");
            Console.WriteLine("4. View Students");
            Console.WriteLine();
            Console.WriteLine("x. Exit");
            Console.WriteLine();

        }

        /// <summary>
        /// Prepares the storage arrays for initial use.
        /// </summary>
        static void PrepareStorage()
        {
            for (int i = 0; i < MAX_STUDENTS; i++)
            {
                students[i] = null;
            }
        }

        /// <summary>
        /// Gets the user choice.
        /// </summary>
        /// <returns>The user choice.</returns>
        /// <param name="message">Message.</param>
        static char GetUserChoice(string message)
        {
            Console.WriteLine();
            Console.Write(message);
            return Console.ReadKey().KeyChar;
        }

        /// <summary>
        /// Gets the first available empty position within the storage array.
        /// </summary>
        /// <returns>The first available position or -1 if none available.</returns>
        static int GetFirstAvailablePosition()
        {
            for (int i = 0; i < MAX_STUDENTS; i++)
            {
                if (students[i] == null)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Adds a student.
        /// </summary>
        static void AddStudent()
        {
            Console.WriteLine();
            Console.WriteLine("You've chosen to Add a new Student.");
            Console.WriteLine();

            // check if we still have room
            if (noOfStudents == MAX_STUDENTS)
            {
                Console.WriteLine();
                Console.WriteLine("Capacity reached. Please delete a Student!");
                return;
            }

            // figure out which position is EMPTY
            int position = GetFirstAvailablePosition();

            if (position == -1)
            {
                Console.WriteLine();
                Console.WriteLine("Capacity reached. Please delete a Student!");
            }

            // get name and ID and store them at the discovered position
            Student student = new Student();

            Console.Write("Student Name: ");
            student.name = Console.ReadLine();

            Console.Write("Student ID: ");
            student.ID = Console.ReadLine();

            Console.Write("Student Email: ");
            student.email = Console.ReadLine();

            for (int i = 0; i < student.MaxModules; i++)
            {

                // create and assign modules
                Module module = new Module();

                Console.Write("Module Code:");
                module.Code = Console.ReadLine();

                Console.Write("Module Name:");
                module.Name = Console.ReadLine();

                // establish relationship
                student.AssignModule(module);

            }

            // add newly created student object to students array
            students[position] = student;

            // increment counter
            noOfStudents++;

            Console.WriteLine();
            Console.WriteLine("Student was added successfully!");

        }

        /// <summary>
        /// Deletes a student.
        /// </summary>
        static void DeleteStudent()
        {
            Console.WriteLine();
            Console.WriteLine("You've chosen to delete a Student.");
            Console.WriteLine();

            // check if we have any
            if (noOfStudents == 0)
            {
                Console.WriteLine();
                Console.WriteLine("No Students available. Please add a Student!");
                return;
            }

            // present list of existing students
            ViewStudents();

            Console.WriteLine();
            Console.Write("Please pick one to Delete: ");

            // NOTE: if invalid, it will be 0
            // potentially, ViewStudents() could be changed to 
            // show indices starting with 1, so if position ends
            // up being 0, then it's invalid
            // but, doing it this way, you need to remember to
            // reduce the user's value by 1
            Int32.TryParse(Console.ReadLine(), out int position);

            // delete student
            students[position] = null;

            // decrement counter
            noOfStudents--;

            Console.WriteLine();
            Console.WriteLine("Student was deleted successfully!");

        }

        /// <summary>
        /// Edits a student.
        /// </summary>
        static void EditStudent()
        {
            Console.WriteLine();
            Console.WriteLine("You've chosen to Edit an existing Student.");
            Console.WriteLine();

            // check if we still have any students
            if (noOfStudents == 0)
            {
                Console.WriteLine();
                Console.WriteLine("No Students available. Please add a Student!");
                return;
            }

            // present list of available students
            ViewStudents();

            Console.WriteLine();
            Console.Write("Please pick one to Edit: ");

            // NOTE: if invalid, it will be 0
            // NOTE: see comment at line 246 above
            Int32.TryParse(Console.ReadLine(), out int position);

            // get name and ID and store them at the discovered position
            Console.Write("Student Name: ");
            students[position].name = Console.ReadLine();

            Console.Write("Student ID: ");
            students[position].ID = Console.ReadLine();

            Console.Write("Student Email: ");
            students[position].email = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Student was edited successfully!");
        }

        static void ViewStudents()
        {
            Console.WriteLine();
            Console.WriteLine("You've chosen to View all Students.");
            Console.WriteLine();

            // check if we still have any students
            if (noOfStudents == 0)
            {
                Console.WriteLine();
                Console.WriteLine("No Students available. Please add a Student!");
                return;
            }

            Console.WriteLine("Pos. SID / Name");

            for (int i = 0; i < MAX_STUDENTS; i++)
            {

                if (students[i] == null)
                {
                    // terminates current loop (not the entire for)
                    continue;
                }

                // array index
                Console.Write("{0}. ", i);

                // ask the student to present itself 
                // i.e. get string with the student's data
                Console.Write("{0}", students[i].PresentMyself());

                Console.WriteLine();
                Console.WriteLine("Modules:");
                Console.WriteLine(students[i].ShowModules());

                Console.WriteLine();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Exit this program.
        /// </summary>
        static void Exit()
        {
            Console.WriteLine();
            Console.WriteLine("Sorry to see you go... Bye!");
        }

    }
}
