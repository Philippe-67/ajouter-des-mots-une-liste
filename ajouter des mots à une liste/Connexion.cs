using outil_de_presentation;
using outil_de_cheminement;

namespace outil_de_connexion
{
    public class Connexion
    {
        //-1 //  cette méthode réclame le nameUser
        public static string DemanderUserName()
        {
            //instanciation de la classe Afficheur pour appeler la méthode PresentationMethode
            Afficheur afficheur = new Afficheur();
            afficheur.PresentationMethode();

            Console.Write("entre ton prénom: ");
            string userName = Console.ReadLine();

            //Afficheur.Latence();
            Afficheur.CompteARebours();
            return userName;
        }

        // -2 // cette méthode vérifie l'existance d'un fichier 
        public static void VerifierExistanceFichier(string userName)
        {
            //instanciation de la classe Afficheur pour appeler la méthode PresentationMethode
            Afficheur afficheur = new Afficheur();
            afficheur.PresentationMethode();

            string filePath = "C:\\repos\\";
            string fileName = ($"{userName}dictionary.txt");
            string cheminFichier = Path.Combine(filePath, fileName);

            if (File.Exists(cheminFichier))
            {
                Console.WriteLine($"il existe bien un dictionnaire nommé : {userName} dictionary");
            }
            else
            {
                Console.WriteLine($"Le fichier {fileName} n'existe pas dans le répertoire {filePath}. Enregistre tes premiers mots et nous en créerons un.");
            }
            //Afficheur.Latence();
            Afficheur.CompteARebours();

        }
        // Méthode  lit les mots existants dans le  fichier User
        public static List<string> LireLesMotsExistants(string cheminFichier)
        {
            List<string> listeMotsExistants = new List<string>();

            if (File.Exists(cheminFichier))
            {
                using (StreamReader sr = new StreamReader(cheminFichier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        listeMotsExistants.Add(line);
                        // Console.Write(line + "\t");
                    }
                    Console.WriteLine();
                }
            }

            return listeMotsExistants;
        }
        public static void AfficherLesMots(List<string> listeMotsExistants)
        {
            //instanciation de la classe Afficheur pour appeler la méthode PresentationMethode
            Afficheur afficheur = new Afficheur();
            afficheur.PresentationMethode();

            Console.WriteLine("Voici les mots enregistrés :");
            Console.WriteLine();
            Afficheur.CompteARebours();
            foreach (string mot in listeMotsExistants)
            {
                Console.Write(mot + "\t");
            }
            
        }
    }
}
