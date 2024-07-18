using outil_de_gestion_des_mots;
using outil_de_presentation;


namespace outil_de_cheminement
{
    public class Choice
    {


        public static string UserChoice(string userName)
        {
            Afficheur afficheur = new Afficheur();
            afficheur.PresentationMethode();

            Console.WriteLine($"A ce stade tu souhaites");
            Console.WriteLine("\n\tChoix '1' : Ajouter des mots ");
            Console.WriteLine("\n\tChoix '2' : Faire un Quiz ");

            string choix = "";
            bool choixValide = false;

            while (!choixValide)
            {
                Console.Write("\n Inscrit ton choix : 1 ou 2 ? ");
                choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        //GestionMots.DemanderNombreDeMots();
                        choixValide = true;
                        break;
                    case "2":
                        Console.WriteLine("ok pour un quiz");
                        choixValide = true;
                        break;
                    default:
                        Console.WriteLine("Choix non reconnu. Veuillez saisir 1 ou 2.");
                        break; // Redemande le choix à l'utilisateur
                }
            }

            return choix;
        }
    }
}
