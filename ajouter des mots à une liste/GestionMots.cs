using ajouter_des_mots_à_une_liste.classe;
using outil_de_presentation;

namespace outil_de_gestion_des_mots;

public class GestionMots
{
    public static int DemanderNombreDeMots()
    {
        //appel à la méthode Presentation
        Afficheur afficheur = new Afficheur();
        afficheur.PresentationMethode();

        //input nbre de mots
        Console.Write("Combien de nouveaux mots souhaites tu entrer: ");

        

        return int.Parse(Console.ReadLine());
    }



    public static void CollationnerLesMots(int nombreDeMots, string userName, List<string> listeMotsExistants)
    {
        string filePath = "C:\\repos\\";
        string fileName = $"{userName}dictionary.txt";
        string cheminFichier = Path.Combine(filePath, fileName);
        List<Mot> mots = new List<Mot>();

        Afficheur afficheur = new Afficheur();
        afficheur.PresentationMethode();

        for (int i = 0; i < nombreDeMots; i++)
        {
            Console.WriteLine($"Mot numéro {i + 1} - Veuillez entrer un mot en français  :");
            string motFrancais = Console.ReadLine();

            {
                Mot nouveauMot = new Mot();
                nouveauMot.MotFrancais = motFrancais;

                Console.WriteLine("Entrez la traduction en anglais :");
                nouveauMot.MotAnglais = Console.ReadLine();

                Console.WriteLine("Entrez la traduction en espagnol :");
                nouveauMot.MotEspagnol = Console.ReadLine();


                mots.Add(nouveauMot);


            }

            using (StreamWriter sw = new StreamWriter(cheminFichier, true))
            {
                foreach (var mot in mots)
                {
                    sw.WriteLine($"{mot.MotFrancais}\t{mot.MotAnglais}\t{mot.MotEspagnol} - ");
                }
            }
            Afficheur.Latence();
            Console.WriteLine("Les mots et leurs traductions ont été enregistrés dans le fichier mots.txt.");
        }
    }
}

