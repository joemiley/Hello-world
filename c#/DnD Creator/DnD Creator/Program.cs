using System;

namespace DnD_Creator
{
    class Program
    {
        static Random rng = new Random();


        static void Main(string[] args)
        {

            /*
             * races:
             * 1.aarakocra (bird dude) dex+2   Wis+1
             * 2.aasimar (half bird half dude)  cha+2
             * 3.bugbears (big goblins) str+2   dex+1
             * 4.centaur (half horse person) str+2    dex or con+1
             * 5.changling (shape shifter)    cha+2   dex or int+1
             * 6.dragon born (lizard person) str+2  cha+1
             * 7.dwarf con+2
             * 8.elf   dex+2
             * 9.firbolg (cow dude) wis+2 str+1
             * 10.genasi (genie)   con+2
             * 11.genasi (elemental genie) water  wis+1
             * 12.genasi (elemental genie) stone   str+1
             * 13.genasi (elemental genie) fire    int+1
             * 14.genasi (elemental genie) air     dex+1
             * 15.githyanki (emo elve) str+1
             * 16.githzerai (emo elve) wis+1
             * 17.gnome    int+2
             * 18.goblin   dex+1   con+1
             * 19.goliaths (stone giant)   str+2   con+1
             * 20.half elf     cha+2   +1to 2 stats
             * 21.half orc     str+2   con+1
             * 22.halfling     dex+2
             * 23.human        +1 to all
             * 24.hob goblin (religous or militant goblin)     con+2   int+1
             * 25.kenku (small bird person)    dex+2   wis+1
             * 26.kobold (little fox people)   dex+2   str-2
             * 27.lizard folk (lizard erson)   con+2   wis+1
             * 28.loxodan (elephant person)  con+2  wis+1  
             * 29.locathah (just a fish)   str+2  dex+1
             * 30.minotaur     str+1
             * 31.orks         str+2   con+1   int-2
             * 32.tabaxi (cat humanoid)    dex+2   cha+1
             * 33.tiefling (demon person)  int+1   cha+2
             * 34.tortle (turtle)  str+2   wis+1
             * 35.triton (aquatic elf)     str+1   con+1   cha+1
             * 36.yuan-ti pure blood (snakey person)   cha+2    int+1
             * 37.kalashtar (half spirit half human)       wis+1   cha+1 one other choice+1
             * 38.shifter (furry)  dex+1
             * 39.simic hybrids (random sealife human e.g. crab or squid)    con+2   one choice+1
             * 40.war forged (robot)       con+2 and one other of choice +1
             * 41.vedalken (blue cat person)  int+2    wis+1
             *  
             *  classes and hit dice:
             *  barbarian (str) d12
             *  bard (cha) d8
             *  cleric (wis) d8
             *  druid (wis) d8
             *  fighter (str or dex) d10
             *  monk (dex & wis) d8
             *  paladin (str & cha) d10
             *  ranger (dex & wis) d10
             *  rogue (dex) d8
             *  sorcerer (chr) d6
             *  warlock (chr) d8
             *  wizard (int) d6
             *  
             *  
             */

            //ask for race
            //ask for job
            //name
            //choose a weapon
            //role dice 7 times
            string inputrace;
            string inputclass;
            string modifier = "";
            string race = "";
            string Class = "";
            string hitdice = "";
            string mainAttribute = "";
            string saves = "";

            int racenumber;
            int classnumber;
            do
            {
                Console.Clear();

                Console.WriteLine("these are your race options:");
                Console.WriteLine("");
                Console.WriteLine("1.aarakocra (bird dude)                  22.halfling");
                Console.WriteLine("2.aasimar (half bird half dude)          23.human");
                Console.WriteLine("3.bugbears (big goblins)                 24.hob goblin (religous or militant goblin)");
                Console.WriteLine("4.centaur (half horse person)            25.kenku (small bird person)");
                Console.WriteLine("5.changling (shape shifter)              26.kobold (little fox people)");
                Console.WriteLine("6.dragon born (lizard person)            27.lizard folk (lizard erson)");
                Console.WriteLine("7.dwarf                                  28.loxodan (elephant person)");
                Console.WriteLine("8.elf                                    29.locathah (just a fish)");
                Console.WriteLine("9.firbolg (cow dude)                     30.minotaur");
                Console.WriteLine("10.genasi (genie)                        31.orks");
                Console.WriteLine("11.genasi (elemental genie)water         32.tabaxi (cat humanoid)");
                Console.WriteLine("12.genasi (elemental genie)stone         33.tiefling (demon person)");
                Console.WriteLine("13.genasi (elemental genie)fire          34.tortle (turtle)");
                Console.WriteLine("14.genasi (elemental genie)air           35.triton (aquatic elf)");
                Console.WriteLine("15.githyanki (emo elve1)                 36.yuan-ti pure blood (snakey person)");
                Console.WriteLine("16.githzerai (emo elve)                  37.kalashtar (half spirit half human)");
                Console.WriteLine("17.gnome                                 38.shifter (furry)");
                Console.WriteLine("18.goblin                                39.simic-hybrids(sealife human e.g.crab-man)");
                Console.WriteLine("19.goliaths(stone giant)                 40.war forged (robot)");
                Console.WriteLine("20.half elf                              41.vedalken (blue cat person)");
                Console.WriteLine("21.half orc");
                Console.WriteLine();
                Console.WriteLine("what will your race be? (please input the number)");

                inputrace = Console.ReadLine();
                racenumber = Int32.Parse(inputrace);

            } while (racenumber <= 0 || racenumber > 41);


            switch (racenumber)
            {
                case 1:
                    race = "aarakocra (bird dude)";
                    modifier = "dex+2, wis+1";
                    break;

                case 2:
                    race = "aasimar (half bird half dude)";
                    modifier = "cha+2";
                    break;

                case 3:
                    race = "Bugbear";
                    modifier = "str+2   dex+1";
                    break;

                case 4:
                    race = "centaur";
                    modifier = "str+2   dex or con+1";
                    break;

                case 5:
                    race = "changling  ";
                    modifier = "cha+2   dex or int+1";
                    break;

                case 6:
                    race = "dragon born";
                    modifier = "str+2   cha+1    ";
                    break;

                case 7:
                    race = "dwarf";
                    modifier = "cont+2 ";
                    break;

                case 8:
                    race = "elf  ";
                    modifier = "dex+2    ";
                    break;

                case 9:
                    race = "firbolg  ";
                    modifier = "wis+2   str+1    ";
                    break;

                case 10:
                    race = "genasi  ";
                    modifier = "con+2   ";
                    break;

                case 11:
                    race = "genasi water  ";
                    modifier = "wis+1    ";
                    break;

                case 12:
                    race = "genasi stone  ";
                    modifier = "str+1    ";
                    break;

                case 13:
                    race = "genasi fire  ";
                    modifier = "int+1    ";
                    break;

                case 14:
                    race = "genasi air  ";
                    modifier = "dex+1    ";
                    break;

                case 15:
                    race = "githyanki  ";
                    modifier = "str+1    ";
                    break;

                case 16:
                    race = "githzerai  ";
                    modifier = "wis+1    ";
                    break;

                case 17:
                    race = "gnome  ";
                    modifier = "int+2    ";
                    break;

                case 18:
                    race = "goblin  ";
                    modifier = "dex+1    ";
                    break;

                case 19:
                    race = "goliaths  ";
                    modifier = "str+2   con+1    ";
                    break;

                case 20:
                    race = "half-elf  ";
                    modifier = "cha+1   +1 to 2 stats    ";
                    break;

                case 21:
                    race = "half-ork  ";
                    modifier = "str+2   con+1    ";
                    break;

                case 22:
                    race = "halfling  ";
                    modifier = "dex+2    ";
                    break;

                case 23:
                    race = "human  ";
                    modifier = "all stats +1    ";
                    break;

                case 24:
                    race = "hob-goblin  ";
                    modifier = "con+2   int+1    ";
                    break;

                case 25:
                    race = "kenku  ";
                    modifier = "dex+2   wis+1   ";
                    break;

                case 26:
                    race = "kobold  ";
                    modifier = "dex+2   str-2    ";
                    break;

                case 27:
                    race = "lizard-folk  ";
                    modifier = "con+2    wis+1    ";
                    break;

                case 28:
                    race = "loxodon ";
                    modifier = "con+2  wis+1     ";
                    break;

                case 29:
                    race = "locathah  ";
                    modifier = "str+2   dex+1    ";
                    break;

                case 30:
                    race = "minotaur  ";
                    modifier = "str+1    ";
                    break;

                case 31:
                    race = "ork  ";
                    modifier = "str+2   con+1   int-2    ";
                    break;

                case 32:
                    race = "tabaxi  ";
                    modifier = "dex+2   cha+1    ";
                    break;

                case 33:
                    race = "tiefling  ";
                    modifier = "int+1   cha+2    ";
                    break;

                case 34:
                    race = "tortle  ";
                    modifier = "str+2   wis+1    ";
                    break;

                case 35:
                    race = "triton  ";
                    modifier = "str+1    con+1   cha+1    ";
                    break;

                case 36:
                    race = "yuan-ti pure blood  ";
                    modifier = "cha+2   int+1    ";
                    break;

                case 37:
                    race = "kalashtar  ";
                    modifier = "wis+1   cha+1   +1 to any stat";
                    break;

                case 38:
                    race = "shifter  ";
                    modifier = "dex+1    ";
                    break;

                case 39:
                    race = "simic hybrids   ";
                    modifier = "con+2  +1 to any stat";
                    break;

                case 40:
                    race = "war-forged  ";
                    modifier = "con+2   +1 to any stat";
                    break;

                case 41:
                    race = "vedalken  ";
                    modifier = "int+2 wis+1    ";
                    break;

                                                                                    
            }

            do
            {
                Console.Clear();
                Console.WriteLine("these are your clas options");
                Console.WriteLine();
                Console.WriteLine("1.Barbarian");   //hit dice: d12  main attribute:str    saves:str and con
                Console.WriteLine("2.Bard");        //hit dice:d8   main attribute:cha    saves:dex and cha
                Console.WriteLine("3.Cleric");      //hit dice:d8   main attribute:wis    saves:wis and cha
                Console.WriteLine("4.Druid");       //hit dice:d8   main attribute:wis    saves:int and wis
                Console.WriteLine("5.Fighter");     //hit dice:d10   main attribute:str or dex    saves:str and con   
                Console.WriteLine("6.Monk");        //hit dice:d8   main attribute:dex and wis    saves:str and dex
                Console.WriteLine("7.Paladin");     //hit dice:d10   main attribute:str and cha    saves:wis and cha
                Console.WriteLine("8.Ranger");      //hit dice:d10   main attribute:dex and wis    saves:str and dex
                Console.WriteLine("9.Rogue");       //hit dice:d8   main attribute:dex    saves:dex and int
                Console.WriteLine("10.Sorcerer");   //hit dice:d6   main attribute:cha    saves:con and cha
                Console.WriteLine("11.Warlock");    //hit dice:d8   main attribute:cha    saves:wis and cha
                Console.WriteLine("12.Wizard");     //hit dice:d6   main attribute:int    saves:int and wis
                Console.WriteLine();
                Console.WriteLine("what is your class? (please enter the number)");
                inputclass = Console.ReadLine();

                classnumber = Int32.Parse(inputclass);

            } while (classnumber == 0 || classnumber > 13);

            switch (classnumber)
            {
                case 1:
                    Class = "Barbarian";
                    hitdice = "d12 ";
                    mainAttribute = "str ";
                    saves = "int and wis ";
                    break;

                case 2:
                    Class = "Bard";
                    hitdice = "d8 ";
                    mainAttribute = "cha ";
                    saves = "dex and cha ";
                    break;

                case 3:
                    Class = "Cleric";
                    hitdice = "d8 ";
                    mainAttribute = "wis ";
                    saves = "wis and cha ";
                    break;

                case 4:
                    Class = "Druid";
                    hitdice = "d8 ";
                    mainAttribute = "wis ";
                    saves = "int and wis ";
                    break;

                case 5:
                    Class = "Fighter";
                    hitdice = "d10 ";
                    mainAttribute = "str or dex ";
                    saves = "str and con ";
                    break;

                case 6:
                    Class = "Monk";
                    hitdice = "d8 ";
                    mainAttribute = "dex and wis ";
                    saves = "str and dex ";
                    break;

                case 7:
                    Class = "Paladin";
                    hitdice = "d10 ";
                    mainAttribute = "str and cha ";
                    saves = "wis and cha ";
                    break;

                case 8:
                    Class = "Ranger";
                    hitdice = "d10 ";
                    mainAttribute = "dex and wis ";
                    saves = "str and dex ";
                    break;

                case 9:
                    Class = "Rogue";
                    hitdice = "d8 ";
                    mainAttribute = "dex ";
                    saves = "dex and int ";
                    break;

                case 10:
                    Class = "Sorcerer";
                    hitdice = "d6 ";
                    mainAttribute = "cha ";
                    saves = "con and cha ";
                    break;

                case 11:
                    Class = "Warlock";
                    hitdice = "d8 ";
                    mainAttribute = "cha ";
                    saves = "wis and cha ";
                    break;

                case 12:
                    Class = "Wizard";
                    hitdice = "d6 ";
                    mainAttribute = "int ";
                    saves = "int and wis ";
                    break;

            }
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("race = " + race);
            Console.WriteLine("class = " + Class);
            Console.WriteLine("hit dice = " + hitdice);
            Console.WriteLine("Main Attribute = "+ mainAttribute);
            Console.WriteLine("proficency bonus = " + rng.Next(1, 4));
            Console.WriteLine("your saving throw proficencies = "+ saves);
            Console.WriteLine();
            Console.WriteLine("stats (assign them to your attributes str,dex,con,wis,int,cha):");
            
            for(int i = 0; i < 7; i++)
            {
                Console.Write(rng.Next(1, 19) + ",  ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("modifier = " + modifier);
            Console.ReadLine();

        }
    }
}
