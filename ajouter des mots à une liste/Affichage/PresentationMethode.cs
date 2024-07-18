using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outil_de_presentation
{
    public class Afficheur
    {
        public void PresentationMethode([System.Runtime.CompilerServices.CallerMemberName] string methodName = "")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******************** méthode " + methodName + " *************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public static void Latence()
        {
            //latence
            Thread.Sleep(1000);
           
        }
        public static void CompteARebours()
        {
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(i);
                
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Afficheur.Latence();

            }
        }
    }
}

