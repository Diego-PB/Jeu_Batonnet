namespace Programmer;

internal class Jeu
{
    private static void Main(string[] args)
    {
        Console.Clear();
        AffichageMenu();
        
        // Saisie clavier
		Console.Write("Votre choix : ");
        string choix = Console.ReadLine();
        
        // Traitement du choix
        switch (choix)
        {
            case "1":
                Console.WriteLine("Jouer");
                break;
            case "2":
                Console.WriteLine("Options");
                break;
            case "3":
                Console.WriteLine("Scores");
                break;
            case "4":
                Console.WriteLine("Quitter");
                break;
            default:
                Console.WriteLine("Choix invalide");
                break;
        }
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