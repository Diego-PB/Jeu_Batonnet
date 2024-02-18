using System;
using System.ComponentModel.Design;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
            string choix = Console.ReadLine();
        }

        static void menu()
        {
            Console.WriteLine(@"
  ____            _                                    _   
 |  _ \          | |                                  | |  
 | |_) |   __ _  | |_    ___    _ __    _ __     ___  | |_ 
 |  _ <   / _` | | __|  / _ \  | '_ \  | '_ \   / _ \ | __|
 | |_) | | (_| | | |_  | (_) | | | | | | | | | |  __/ | |_ 
 |____/   \__,_|  \__|  \___/  |_| |_| |_| |_|  \___|  \__|
                                                           

1. Jouer contre l'ordinateur
2. Jouer contre un ami (local)
3. Options
4. Quitter
\n
Choix:
");
        }
    }
}
