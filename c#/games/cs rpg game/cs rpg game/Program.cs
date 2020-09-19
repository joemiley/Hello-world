using System;


namespace cs_rpg_game
{
    class Program
    {
        static string playerName;
        static int playerGold = 200;
        
        static void Main(string[] args)
        {
            /*you are playing a game. in this game you play as an adventurer
             * you are tasked with taking battlement supples from a small town
             * built and inhabited by dwarfs. you are thrown into the middle of 
             * haggling with a dwarf for the wagon of goods.
             * you expect to make 1500gold for the shipment at the end 
             * but you only have 200gold now
             */
            prolog();

            Console.WriteLine("please enter your adventurer name");
            playerName = Console.ReadLine();

            

        }

        public static void prolog()
        {
            Console.WriteLine("     you are playing a game. in this game you play as an adventurer");
            Console.WriteLine("     you are tasked with taking battlement supples from a small town");
            Console.WriteLine("     built and inhabited by dwarfs. you are thrown into the middle of ");
            Console.WriteLine("     haggling with a dwarf for the wagon of goods.");
            Console.WriteLine("     you expect to make 1500gold for the shipment at the end ");
            Console.WriteLine("     but you only have 200gold now");
            Console.ReadKey();
        }

        public static void TheHaggle()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"Dwarf:
                   LISTEN HERE YOU ARAGONT TALL FUCK!?
                   It takes 400gold just to build all 
                   this shit and not counting my time to
                   make it which is far more than you can 
                                afford
                                ");
            Console.ReadKey();

            Console.WriteLine(playerName + ": shit i dnt have enough. what do i do");
            Console.WriteLine("A. Aggressive (you shout at the little man in the hopes he'll back down");
            Console.WriteLine("B. Understanding (talk him down grently");
            Console.WriteLine("C. hard ball (you haggle hard and threaten to leave)");
            Console.WriteLine("D. wild card (whatever pops into your head)");
            Console.WriteLine("E. Attack the dwarf");

        }
    }
}
