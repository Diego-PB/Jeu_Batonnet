using System;

namespace console_game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initalise :
            // the a variable to know if the game is running
            bool gameRunning = true;

            // the menu choice
            string menuChoice = "";

            // While the game running execute the game : else exit the game
            while (gameRunning)
            {
                // Display the game menu and get the user input
                menuChoice = printInputMenu();

                // Check the user input and execute the corresponding action
                switch (menuChoice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        Console.WriteLine("Exiting the game...");
                        gameRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static string printInputMenu()
        {
            Console.WriteLine(@"
_______________________________________________

 _____   _____   _____   _____   _   __  _____ 
/  ___| |_   _| |_   _| /  __ \ | | / / /  ___|
\ `--.    | |     | |   | /  \/ | |/ /  \ `--. 
 `--. \   | |     | |   | |     |    \   `--. \
/\__/ /   | |    _| |_  | \__/\ | |\  \ /\__/ /
\____/    \_/    \___/   \____/ \_| \_/ \____/ 
                                               
                                               
    _____    ___   ___  ___  _____   _____     
   |  __ \  / _ \  |  \/  | |  ___| /  ___|    
   | |  \/ / /_\ \ | .  . | | |__   \ `--.     
   | | __  |  _  | | |\/| | |  __|   `--. \    
   | |_\ \ | | | | | |  | | | |___  /\__/ /    
    \____/ \_| |_/ \_|  |_/ \____/  \____/     
             
_______________________________________________

Menu :

1. Play against the computer
2. Play against another player (local)
3. Settings
4. Exit

_______________________________________________

Input the number corresponding to your choice :");

            // Get the user input
            string option = Console.ReadLine();

            // Check the user input, while invalid input, ask the user to input a valid option
            bool validOption = false;
            while (!validOption)
            {
                switch (option)
                {
                    case "1":
                        // Play against the computer
                        validOption = true;
                        break;
                    case "2":
                        // Play against another player
                        validOption = true;
                        break;
                    case "3":
                        // Display the settings
                        validOption = true;
                        break;
                    case "4":
                        // Exit the game
                        validOption = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        option = Console.ReadLine();
                        break;
                }
            }

            return option; // Add this line to return the value
        }
    }
}

