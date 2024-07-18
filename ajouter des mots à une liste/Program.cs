//See https://aka.ms/new-console-template for more information


using ajouter_des_mots_à_une_liste.classe;
using outil_de_cheminement;
using outil_de_connexion;
using outil_de_gestion_des_mots;
using outil_de_presentation;
using System.Linq;

string userName = Connexion.DemanderUserName();
Console.WriteLine();
Console.WriteLine($"\t\tBonjour {userName}");

Connexion.VerifierExistanceFichier(userName);

string filePath = "C:\\repos\\";
string fileName = $"{userName}dictionary.txt";
string cheminFichier = Path.Combine(filePath, fileName);
List<string> motsPresents = Connexion.LireLesMotsExistants(cheminFichier);
Connexion.AfficherLesMots(motsPresents);

Choice.UserChoice(userName);
int nombreDeMots = GestionMots.DemanderNombreDeMots();
//Console.WriteLine($"Nous allons entrer {nombreDeMots} mots");

List<string> motsExistants = Connexion.LireLesMotsExistants(cheminFichier);
GestionMots.CollationnerLesMots(nombreDeMots, userName, motsExistants);











