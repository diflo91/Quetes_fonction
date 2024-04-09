namespace Quetes_boucle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String[] moves = new String[32]; 

            for (int i = 0; i < moves.Length; i++) 
            
            {

                Console.WriteLine("Saisissez");
                string pas = Console.ReadLine();
                      
                   if (pas == "done")
                {
                    break;
                } else if (pas != "done")
                {   
                    moves[i] = pas;
                    Console.WriteLine("Saisisser le nombre d'iteration");
                    String iterationInput = Console.ReadLine();
                    int iterationOutput = Convert.ToInt32(iterationInput);

                    for (int y = 1; y < iterationOutput; y++)
                    {
                        Console.WriteLine("Saisissez");
                        string pasDeux = Console.ReadLine();

                        if (pasDeux == "done")
                        {
                            break;
                        } else if (pasDeux != "done") { 

                        moves[i] = pasDeux;
                            Console.WriteLine($"La Danse saisi est : {moves[i]}");
                    }

                    }
                    
                    
                }
            }



        }
    }
}
