
using System.ComponentModel.Design;

namespace Quetes_boucle
{
    internal class Program
    {
        
         
static void Main(string[] args)
        
            {
            string msgError = "";
            int stockResult = 0;
           

/* ///////////////////////////////////////////////////////////////////////Déclaration des fonctions///////////////////////////////////////////////////////////////////////// */
/* Cette partie consiste à declarer mes fonctions
  * Comme expliqué dans le challenge 
    * on aura la fonction 
      * Add : pour l'addition
        * Substract : pour la soustraction
         * Multiply : pour la multiplication
           * Divide : pour la division
             * Modulo : pour le modulo
               */

            static int Add(int a, int b) // Déclaration de la fonction addition
            {
                return a + b;
            }
            static int Substract(int a, int b) // Déclaration de la fonction  soustraction
            {
                return a - b;
            }
            static int Multiply(int a, int b) // Déclaration de la fonction  multiplication
            {
                return a * b;
            }
            static int Divide(int a, int b) // Déclaration de la fonction Division
            {
                return a / b;
            }
            static int Modulo(int a, int b) // Déclaration de la fonction Modulo
            {
                return a % b; 
            }

            /* ///////////////////////////////////////////////////////////////////////Debut de l'exucution du code///////////////////////////////////////////////////////////////////////// */


            while (true)
            {
                
                Console.WriteLine($"Resultat : {stockResult} {msgError}");
                        stockResult = 0;
                        msgError = "";
                Console.Write("Appuyez sur Entrée pour continuer...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Saisissez la valeur 1 :");
                int maValeur1;
               
                    while(!int.TryParse(Console.ReadLine(), out maValeur1 )) 
                    {
                    Console.Clear();
                    Console.WriteLine("les caracteres ne sont pas accepter, Veuillez Saisir un nombre !");
                    }
                Console.Clear();
                Console.WriteLine("Saisissez la valeur 2 :");
                int maValeur2;
                
                    while (!int.TryParse(Console.ReadLine(), out maValeur2))
                    {
                    Console.Clear();
                    Console.WriteLine("les caracteres ne sont pas accepter, Veuillez Saisir un nombre !");
                    }
                Console.Clear();
                Console.WriteLine("Quelle operation souhaitez-vous effectuer ?  ");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("=> Add pour Addition ");
                Console.WriteLine("=> Substract pour Soustraction ");
                Console.WriteLine("=> Multiply pour Multiplication ");
                Console.WriteLine("=> Divide pour Division ");
                Console.WriteLine("=> Modulo pour Modulo ");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine(" ");
                string monOperation = Console.ReadLine();


                    /* Cette partie est pour la convertion  
                      * de format des données entrées
                        * celles-ci est de type string car il est directement saisi par le IS
                          * et donc je fais le STR to INT
                            */

                    int maValeurInt1 = maValeur1;
                    int maValeurInt2 = maValeur2;

                    if (monOperation.ToLower() == "add")
                    {
                        int resultAdd = Add(maValeurInt1, maValeurInt2);
                        stockResult = resultAdd;
                    Console.Clear();
                    } else if (monOperation.ToLower() == "substract")
                    {
                        int resultSubstract = Substract(maValeurInt1, maValeurInt2);
                        stockResult = resultSubstract;
                    Console.Clear();
                    } else if (monOperation.ToLower() == "multiply")
                    {
                        int resultMultiply = Multiply(maValeurInt1, maValeurInt2);
                        stockResult = resultMultiply;
                     Console.Clear();
                    } else if (monOperation.ToLower() == "divide")
                    {
                        int resultDivide = Divide(maValeurInt1, maValeurInt2);
                        stockResult = resultDivide;
                     Console.Clear();
                    } else if (monOperation.ToLower() == "modulo")
                    {
                        int resultModulo = Modulo(maValeurInt1, maValeurInt2);
                        stockResult = resultModulo;
                     Console.Clear();
                    }  else
                    {
                        Console.Clear();
                        msgError = "Vous avez saisi une mauvaise operation !";
                    }
            }
 
         }

        }
    }

