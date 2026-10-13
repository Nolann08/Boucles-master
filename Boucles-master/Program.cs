namespace Boucles;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : faire un compteur qui va de 1 à 10
        int counter = 0;

        while (counter < 10)
        {
            counter++;
            Console.WriteLine(counter); 
        }
        Console.WriteLine("Etape 2 :");
        // Etape 2 : faire un décompte qui va de 5 à 1 puis qui dit "Bonne année !"
        counter = 6;

        while (counter > 0 )
        {
            counter--;
            Console.WriteLine(counter);
        }
        Console.WriteLine("Bonne année ! ");
        Console.WriteLine("Etape 3 :");
        // Etape 3 : faire un compteur qui va de -4 à 2
        counter = -5;

        while (counter < 2)
        {
            counter++;
            Console.WriteLine(counter);
        }
        Console.WriteLine("Etape 4 :");
        // Etape 4 : faire un compteur qui compte 2 par 2 de 0 à 15
        counter = 0;

        while (counter < 15)
        {
            Console.WriteLine(counter);
            counter += 2;
        }

        Console.WriteLine(15);

        Console.WriteLine("Etape 5 :");
        // Etape 5 : faire une boucle qui se répète à chaque fois que l'utilisateur écrit autre chose que "oui"
        Console.WriteLine("Dit oui ou non");
        string oui = Console.ReadLine();

        while (oui == "oui")
        {
            oui = Console.ReadLine();
        }
        Console.WriteLine("Fin");
        
        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}