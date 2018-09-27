using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjackfinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int inventaire = 100;
            Console.WriteLine("Bienvenue au simulateur de black jack, appuyer sur une touche pour commencer.");
            Console.ReadKey();
            Cycle();
            void Cycle()
            {
                Console.WriteLine("Début de la manche");
                Console.ReadKey();
                Random aleatoire = new Random();
                int typeCarte1J = aleatoire.Next(1, 5);
                int valeurCarte1J = aleatoire.Next(1, 14);
                int typeCarte2J = aleatoire.Next(1, 5);
                int valeurCarte2J = aleatoire.Next(1, 14);
                int typeCarte1C = aleatoire.Next(1, 5);
                int valeurCarte1C = aleatoire.Next(1, 14);
                int typeCarte2C = aleatoire.Next(1, 5);
                int valeurCarte2C = aleatoire.Next(1, 14);
                int typeCarte3J = aleatoire.Next(1, 5);
                int valeurCarte3J = aleatoire.Next(1, 14);
                int typeCarte3C = aleatoire.Next(1, 5);
                int valeurCarte3C = aleatoire.Next(1, 14);
                int mise = 0;
                int resultatJoueur = valeurCarte1J + valeurCarte2J + valeurCarte3J;
                int resultatOrdinateur = valeurCarte1C + valeurCarte2C + valeurCarte3C;
                string nomTypeCarte1 = "";
                string nomSousTypeCarte1 = "";
                string nomTypeCarte2 = "";
                string nomSousTypeCarte2 = "";
                string nomTypeCarte3 = "";
                string nomSousTypeCarte3 = "";
                string nomTypeCarte4 = "";
                string nomSousTypeCarte4 = "";
                string nomTypeCarte5 = "";
                string nomSousTypeCarte5 = "";
                string nomTypeCarte6 = "";
                string nomSousTypeCarte6 = "";
                switch (typeCarte1J)
                {
                    case 1:
                        nomTypeCarte1 = "coeur";
                        break;
                    case 2:
                        nomTypeCarte1 = "carreau";
                        break;
                    case 3:
                        nomTypeCarte1 = "trèfle";
                        break;
                    case 4:
                        nomTypeCarte1 = "pique";
                        break;
                }
                switch (valeurCarte1J)
                {
                    case 1:
                        nomSousTypeCarte1 = "as(11)";
                        valeurCarte1J = 11;
                        break;
                    case 2:
                        nomSousTypeCarte1 = "2";
                        break;
                    case 3:
                        nomSousTypeCarte1 = "3";
                        break;
                    case 4:
                        nomSousTypeCarte1 = "4";
                        break;
                    case 5:
                        nomSousTypeCarte1 = "5";
                        break;
                    case 6:
                        nomSousTypeCarte1 = "6";
                        break;
                    case 7:
                        nomSousTypeCarte1 = "7";
                        break;
                    case 8:
                        nomSousTypeCarte1 = "8";
                        break;
                    case 9:
                        nomSousTypeCarte1 = "9";
                        break;
                    case 10:
                        nomSousTypeCarte1 = "10";
                        break;
                    case 11:
                        nomSousTypeCarte1 = "valet(10)";
                        valeurCarte1J = 10;
                        break;
                    case 12:
                        nomSousTypeCarte1 = "reine(10)";
                        valeurCarte1J = 10;
                        break;
                    case 13:
                        nomSousTypeCarte1 = "roi(10)";
                        valeurCarte1J = 10;
                        break;
                }
                switch (typeCarte2J)
                {
                    case 1:
                        nomTypeCarte2 = "coeur";
                        break;
                    case 2:
                        nomTypeCarte2 = "carreau";
                        break;
                    case 3:
                        nomTypeCarte2 = "trèfle";
                        break;
                    case 4:
                        nomTypeCarte2 = "pique";
                        break;
                }
                switch (valeurCarte2J)
                {
                    case 1:
                        nomSousTypeCarte2 = "as(11)";
                        valeurCarte2J = 11;
                        break;
                    case 2:
                        nomSousTypeCarte2 = "2";
                        break;
                    case 3:
                        nomSousTypeCarte2 = "3";
                        break;
                    case 4:
                        nomSousTypeCarte2 = "4";
                        break;
                    case 5:
                        nomSousTypeCarte2 = "5";
                        break;
                    case 6:
                        nomSousTypeCarte2 = "6";
                        break;
                    case 7:
                        nomSousTypeCarte2 = "7";
                        break;
                    case 8:
                        nomSousTypeCarte2 = "8";
                        break;
                    case 9:
                        nomSousTypeCarte2 = "9";
                        break;
                    case 10:
                        nomSousTypeCarte2 = "10";
                        break;
                    case 11:
                        nomSousTypeCarte2 = "valet(10)";
                        valeurCarte2J = 10;
                        break;
                    case 12:
                        nomSousTypeCarte2 = "reine(10)";
                        valeurCarte2J = 10;
                        break;
                    case 13:
                        nomSousTypeCarte2 = "roi(10)";
                        valeurCarte2J = 10;
                        break;
                }
                switch (typeCarte1C)
                {
                    case 1:
                        nomTypeCarte3 = "coeur";
                        break;
                    case 2:
                        nomTypeCarte3 = "carreau";
                        break;
                    case 3:
                        nomTypeCarte3 = "trèfle";
                        break;
                    case 4:
                        nomTypeCarte3 = "pique";
                        break;
                }
                switch (valeurCarte1C)
                {
                    case 1:
                        nomSousTypeCarte3 = "as(11)";
                        valeurCarte1C = 11;
                        break;
                    case 2:
                        nomSousTypeCarte3 = "2";
                        break;
                    case 3:
                        nomSousTypeCarte3 = "3";
                        break;
                    case 4:
                        nomSousTypeCarte3 = "4";
                        break;
                    case 5:
                        nomSousTypeCarte3 = "5";
                        break;
                    case 6:
                        nomSousTypeCarte3 = "6";
                        break;
                    case 7:
                        nomSousTypeCarte3 = "7";
                        break;
                    case 8:
                        nomSousTypeCarte3 = "8";
                        break;
                    case 9:
                        nomSousTypeCarte3 = "9";
                        break;
                    case 10:
                        nomSousTypeCarte3 = "10";
                        break;
                    case 11:
                        nomSousTypeCarte3 = "valet(10)";
                        valeurCarte1C = 10;
                        break;
                    case 12:
                        nomSousTypeCarte3 = "reine(10)";
                        valeurCarte1C = 10;
                        break;
                    case 13:
                        nomSousTypeCarte3 = "roi(10)";
                        valeurCarte1C = 10;
                        break;
                }
                switch (typeCarte2C)
                {
                    case 1:
                        nomTypeCarte4 = "coeur";
                        break;
                    case 2:
                        nomTypeCarte4 = "carreau";
                        break;
                    case 3:
                        nomTypeCarte4 = "trèfle";
                        break;
                    case 4:
                        nomTypeCarte4 = "pique";
                        break;
                }
                switch (valeurCarte2C)
                {
                    case 1:
                        nomSousTypeCarte4 = "as(11)";
                        valeurCarte2C = 11;
                        break;
                    case 2:
                        nomSousTypeCarte4 = "2";
                        break;
                    case 3:
                        nomSousTypeCarte4 = "3";
                        break;
                    case 4:
                        nomSousTypeCarte4 = "4";
                        break;
                    case 5:
                        nomSousTypeCarte4 = "5";
                        break;
                    case 6:
                        nomSousTypeCarte4 = "6";
                        break;
                    case 7:
                        nomSousTypeCarte4 = "7";
                        break;
                    case 8:
                        nomSousTypeCarte4 = "8";
                        break;
                    case 9:
                        nomSousTypeCarte4 = "9";
                        break;
                    case 10:
                        nomSousTypeCarte4 = "10";
                        break;
                    case 11:
                        nomSousTypeCarte4 = "valet(10)";
                        valeurCarte2C = 10;
                        break;
                    case 12:
                        nomSousTypeCarte4 = "reine(10)";
                        valeurCarte2C = 10;
                        break;
                    case 13:
                        nomSousTypeCarte4 = "roi(10)";
                        valeurCarte2C = 10;
                        break;
                }
                switch (typeCarte3J)
                {
                    case 1:
                        nomTypeCarte5 = "coeur";
                        break;
                    case 2:
                        nomTypeCarte5 = "carreau";
                        break;
                    case 3:
                        nomTypeCarte5 = "trèfle";
                        break;
                    case 4:
                        nomTypeCarte5 = "pique";
                        break;
                }
                switch (valeurCarte3J)
                {
                    case 1:
                        nomSousTypeCarte5 = "as(11)";
                        valeurCarte3J = 11;
                        break;
                    case 2:
                        nomSousTypeCarte5 = "2";
                        break;
                    case 3:
                        nomSousTypeCarte5 = "3";
                        break;
                    case 4:
                        nomSousTypeCarte5 = "4";
                        break;
                    case 5:
                        nomSousTypeCarte5 = "5";
                        break;
                    case 6:
                        nomSousTypeCarte5 = "6";
                        break;
                    case 7:
                        nomSousTypeCarte5 = "7";
                        break;
                    case 8:
                        nomSousTypeCarte5 = "8";
                        break;
                    case 9:
                        nomSousTypeCarte5 = "9";
                        break;
                    case 10:
                        nomSousTypeCarte5 = "10";
                        break;
                    case 11:
                        nomSousTypeCarte5 = "valet(10)";
                        valeurCarte3J = 10;
                        break;
                    case 12:
                        nomSousTypeCarte5 = "reine(10)";
                        valeurCarte3J = 10;
                        break;
                    case 13:
                        nomSousTypeCarte5 = "roi(10)";
                        valeurCarte3J = 10;
                        break;
                }
                switch (typeCarte3C)
                {
                    case 1:
                        nomTypeCarte6 = "coeur";
                        break;
                    case 2:
                        nomTypeCarte6 = "carreau";
                        break;
                    case 3:
                        nomTypeCarte6 = "trèfle";
                        break;
                    case 4:
                        nomTypeCarte6 = "pique";
                        break;
                }
                switch (valeurCarte3C)
                {
                    case 1:
                        nomSousTypeCarte6 = "as(11)";
                        valeurCarte3C = 11;
                        break;
                    case 2:
                        nomSousTypeCarte6 = "2";
                        break;
                    case 3:
                        nomSousTypeCarte6 = "3";
                        break;
                    case 4:
                        nomSousTypeCarte6 = "4";
                        break;
                    case 5:
                        nomSousTypeCarte6 = "5";
                        break;
                    case 6:
                        nomSousTypeCarte6 = "6";
                        break;
                    case 7:
                        nomSousTypeCarte6 = "7";
                        break;
                    case 8:
                        nomSousTypeCarte6 = "8";
                        break;
                    case 9:
                        nomSousTypeCarte6 = "9";
                        break;
                    case 10:
                        nomSousTypeCarte6 = "10";
                        break;
                    case 11:
                        nomSousTypeCarte6 = "valet(10)";
                        valeurCarte3C = 10;
                        break;
                    case 12:
                        nomSousTypeCarte6 = "reine(10)";
                        valeurCarte3C = 10;
                        break;
                    case 13:
                        nomSousTypeCarte6 = "roi(10)";
                        valeurCarte3C = 10;
                        break;
                }
                void DrawJoueur()
                {
                    Console.WriteLine("Vos cartes pigées sont le " + nomSousTypeCarte1 + " de " + nomTypeCarte1 + " et le " + nomSousTypeCarte2 + " de " + nomTypeCarte2 + ". Votre adversaire possède un " + nomSousTypeCarte3 + " de " + nomTypeCarte3 + "");
                }
                void DrawwJoueur()
                {
                    Console.WriteLine("Vous avez pigé un " + nomSousTypeCarte5 + " de " + nomTypeCarte5 + "");
                    Console.ReadKey();
                    ActionAdversaire();
                }
                void Inventaire()
                {
                    Console.WriteLine("Vous possédez " + inventaire + "jetons.");
                }
                void ActionAdversaire()
                {
                    if ((valeurCarte1C + valeurCarte2C) < resultatJoueur)
                    {
                        Console.WriteLine("Votre adversaire pige une carte supplémentaire");
                        Console.ReadKey();
                        Console.WriteLine("Votre adversaire joue un " + nomSousTypeCarte3 + " de " + nomTypeCarte3 + ", un " + nomSousTypeCarte4 + " de " + nomTypeCarte4 + " et un " + nomSousTypeCarte6 + " de " + nomTypeCarte6 + "");
                        Console.ReadKey();
                        Bilan();
                    }
                    else if ((valeurCarte1C + valeurCarte2C) >= resultatJoueur)
                    {
                        valeurCarte3C = 0;
                        Console.WriteLine("Votre adversaire ne pige pas de carte");
                        Console.ReadKey();
                        Console.WriteLine("Votre adversaire joue un " + nomSousTypeCarte3 + " de " + nomTypeCarte3 + " et un " + nomSousTypeCarte4 + " de " + nomTypeCarte4 + "");
                        Console.ReadKey();
                        Bilan();
                    }
                }
                void Bilan()
                {
                    if (resultatJoueur > resultatOrdinateur && resultatJoueur < 22 || resultatOrdinateur > 21)
                    {
                        Console.WriteLine("Vous gagnez la manche! Vous gagnez votre mise!");
                        inventaire = inventaire + mise;
                        Console.ReadKey();
                        Cycle();
                    }
                    else if (resultatOrdinateur > resultatJoueur && resultatOrdinateur < 22 || resultatJoueur > 21)
                    {
                        Console.WriteLine("Votre adversaire gagne la manche! Vous perdez votre mise!");
                        inventaire = inventaire - mise;
                        Console.ReadKey();
                        Cycle();
                    }
                    else
                    {
                        Console.WriteLine("Match nul! Aucun changement sur votre mise!");
                        Console.ReadKey();
                        Cycle();
                    }
                }
                void Action()
                {
                    Console.WriteLine("Appuyez sur une touche pour choisir l'action à effectuer");
                    Console.WriteLine("1- Piger une nouvelle carte");
                    Console.WriteLine("2- Arrêter");
                    char touche = Console.ReadLine()[0];
                    if (touche == '1')
                    {
                        DrawwJoueur();
                    }
                    if (touche == '2')
                    {
                        valeurCarte3J = 0;
                        ActionAdversaire();
                    }
                }
                Inventaire();
                Console.WriteLine("Combien de jetons misez-vous pour cette manche?");
                mise = Convert.ToInt32(Console.ReadLine());
                if (mise > inventaire)
                {
                    Console.WriteLine("Impossible, vous n'avez pas assez de jetons.");
                    Console.ReadKey();
                    Inventaire();
                }
                Console.WriteLine("Appuyez sur une touche pour piger vos cartes");
                Console.ReadKey();
                DrawJoueur();
                Console.ReadKey();
                Action();
            }
        }
    }
}
