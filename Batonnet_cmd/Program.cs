namespace Programmer;

internal class Jeu
{
    private static void Main(string[] args)
    {
        Console.Clear();
        AffichageMenu();
        
        // Saisie clavier
    }

    public static void AffichageMenu()
    {
        Console.WriteLine(@"
  ____        _                         _   
 | __ )  __ _| |_ ___  _ __  _ __   ___| |_ 
 |  _ \ / _` | __/ _ \| '_ \| '_ \ / _ \ __|
 | |_) | (_| | || (_) | | | | | | |  __/ |_ 
 |____/ \__,_|\__\___/|_| |_|_| |_|\___|\__|
                                            
-------------------------------------------------
|                   MENU                        |
-------------------------------------------------
| 1. Jouer                                     |
| 2. Options                                   |
| 3. Scores                                    |
| 4. Quitter                                   |
-------------------------------------------------
");
    }
}