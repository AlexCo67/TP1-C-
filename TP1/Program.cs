using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TP1
{
    class Program
    {

        //6 Fonction pour mettre le nom en forme.
        public static string NomPrenom(string nom, string prenom)
        {
            string result=string.Empty;
            nom=nom.ToUpper();
            prenom = prenom.ToLower();
            result = prenom + " " + nom;
            return result;
        }
        //7 Fonction de retour d'IMC
        public static float IMC(int taille, int poids)
        {
            float result=0;
            float p = (float)poids;
            float t = (float)taille/100;
            result = p / (t*t);
            return result;
        }

        //9 Fonction de commentaires de l'IMC
        public static void Comment(float IMC)
        {
            const string ANOREXIE = "Attention à l'anorexie !";
            const string MAIGRICHON ="Vous êtes un peu maigrichon !";
            const string NORMAL = "Vous êtes de corpulence normale !";
            const string SURPOIDS = "Vous êtes en surpoids !";
            const string OBESE = "Obésité modérée !";
            const string SEVERE = "Obésité sévère !";
            const string MORBIDE = "Obésité morbide !";

            if (IMC < 16.5)
            {
                Console.WriteLine(ANOREXIE);
            }
            else if (IMC < 18.5 && IMC >= 16.5)
            {
                Console.WriteLine(MAIGRICHON);
            }
            else if (IMC >= 18.5 && IMC < 25)
            {
                Console.WriteLine(NORMAL);
            }
            else if (IMC < 30 && IMC >= 25)
            {
                Console.WriteLine(SURPOIDS);
            }
            else if (IMC >= 30 && IMC < 35)
            {
                Console.WriteLine(OBESE);
            }
            else if (IMC >= 35 && IMC < 40)
            {
                Console.WriteLine(SEVERE);
            }
            else if (IMC >=40)
            {
                Console.WriteLine(MORBIDE);
            }

            return;
        }

        //10 Fonction de gestion capillaire
        public static void NbCheveux()
        {
            Console.WriteLine("A votre avis, combien de cheveux avez-vous ?");
            int nb = 0;
            string input = string.Empty;
            while (nb < 100000 || nb > 150000)
            {
                Console.WriteLine("Entrez une valeur capillaire : ");
                input = Console.ReadLine();
                if(int.TryParse(input, out nb))
                {
                    if (nb > 150000)
                    {
                        Console.WriteLine("Vous n'avez pas plus de 150 000 cheveux !!!");
                    }
                    else if (nb < 100000)
                    {
                        Console.WriteLine("Désolé pour les chauves, mais vous devez avoir plus de 100 000 cheveux !");
                    }
                }
                else
                {
                    Console.WriteLine("Ce serait sympa de mettre des vraies valeurs numériques, pas des trucs éclatés.");
                }   
            }
            Console.WriteLine("Félicitations, vous avez " + nb.ToString() + " cheveux !!!!");
            return;
        }

        static void Main(string[] args)
        {
            bool sortieProgramme = true;

            do
            {
                //1
                Console.WriteLine("Bonjour et bienvenue.");
                //2 et 11 Entrée nom/prenom
                string nom = string.Empty;
                string prenom = string.Empty;
                Console.WriteLine("Veuillez entrer votre nom :");
                do
                {
                    nom = Console.ReadLine();
                    if (nom.Any(char.IsDigit))
                    {
                        Console.WriteLine("Attention, pas de valeur numérique dans le nom");
                    }
                } while (nom.Any(char.IsDigit));
                Console.WriteLine("Veuillez entrer votre prénom :");
                do
                {
                    prenom = Console.ReadLine();
                    if (prenom.Any(char.IsDigit))
                    {
                        Console.WriteLine("Attention, pas de valeur numérique dans le prénom");
                    }
                } while (prenom.Any(char.IsDigit));
                //3
                //Console.WriteLine("Bonjour "+nom+" "+prenom+" !");
                Console.WriteLine("Bonjour " + NomPrenom(nom, prenom) + " !");
                //4 Entrée de la taille
                Console.WriteLine("Veuillez entrer votre taille en cm :");
                int taille;
                do
                {
                    if (int.TryParse((Console.ReadLine()), out taille))
                    {
                        if (taille <= 0)
                        {
                            Console.WriteLine("Soit un grand garçon.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Met une véritable valeur stp");
                    }
                } while (taille <= 0);


                Console.WriteLine("Veuillez entrer votre poids en kg :");
                int poids;
                do
                {
                    if (int.TryParse((Console.ReadLine()), out poids))
                    {
                        if (poids <= 0)
                        {
                            Console.WriteLine("Soit LOURDS, montre que tu pèses.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Met une véritable valeur stp.");
                    }
                } while (poids <= 0);

                Console.WriteLine("Veuillez entrer votre age :");

                int age;
                do
                {
                    if (int.TryParse((Console.ReadLine()), out age))
                    {
                        if (age <= 0)
                        {
                            Console.WriteLine("Soit une véritable personne avec un vrai âge.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Met une véritable valeur stp");
                    }
                } while (age <= 0);

                //5 Gestion des mineurs
                if (age < 18)
                {
                    Console.WriteLine("Dégage sale mioche.");
                }
                //8 Impression écran de l'IMC
                float imc = IMC(taille, poids);
                string imcString = string.Format("{0:0.0}", imc);
                Console.WriteLine("Votre IMC est de : " + imcString);
                Comment(imc);
                //10 Invocation capillaire
                NbCheveux();

                bool sortieMenu = false;

                do
                {
                    Console.WriteLine("Pour quitter, tapez 1.");
                    Console.WriteLine("Pour recommencer, tapez 2.");
                    Console.WriteLine("Pour compter jusqu'à 10, tapez 3.");
                    Console.WriteLine("Pour appeler Tata Jaqueline, tapez 4.");
                    Console.WriteLine("Que voulez vous faire ? ");

                    string option = string.Empty;

                    option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            sortieMenu = true;
                            sortieProgramme = true;
                            Console.WriteLine("Merci et au revoir !");
                            Thread.Sleep(3000);
                            break;
                        case "2":
                            Console.WriteLine("On y retourne !");
                            sortieMenu = true;
                            sortieProgramme = false;
                            break;
                        case "3":
                            Console.WriteLine("Il est temps de faire un coooooooompte à rebouuuuurd");
                            for (int i=10; i > 0; --i)
                            {
                                Console.WriteLine(i);
                                Thread.Sleep(1000);
                            }
                            Console.WriteLine("Au revoir !");
                            Thread.Sleep(3000);
                            sortieMenu = true;
                            sortieProgramme = true;
                            break;
                        case "4":
                            Console.WriteLine("On va poser quelques bases ici : c'est un début de programme en C# avec zéro connaissances, donc on est déjà content que ça tourne sans planter. Honnêtment, je vois pas comment caser cette fonction. C'est un code de 200 lignes, ça me parait assez ambitieux de penser qu'il y a une fonction qui permet d'appeler des gens. C'est une bonne idée quand même remarque.");
                            Thread.Sleep(10000);                           
                            Console.WriteLine("Oui j'ai fait un Writeline extrêmement long à lire.");
                            Thread.Sleep(2000);
                            Console.WriteLine("C'est un choix artistique.");
                            Thread.Sleep(2000);
                            Console.WriteLine("J'ai quand même laissé un timer pour lire donc ça va.");
                            Thread.Sleep(2000);
                            Console.WriteLine("Du coup, on ferme le programme normalement.");
                            Thread.Sleep(3000);
                            sortieMenu = true;
                            sortieProgramme = true;
                            break;
                        default:
                            Console.WriteLine("Instruction inconnue, on repart pour un tour.");
                            break;
                    }

                } while (!sortieMenu);
            } while (!sortieProgramme);
            return;
        }
    }
}
