using System;

namespace NombreSecret
{
    class Program
    {
        static void Main(string[] args)
        {
            const int nbrSecret = 56;
            bool gagne = false;
            int saisie = 0;
            int essais = 0;
            var generator = new Random();
            Console.WriteLine("règle...");

            while(gagne!=true)
            {
                saisie = Convert.ToInt32(Console.ReadLine());
                essais += 1;
                if(saisie==nbrSecret)
                {
                    Console.WriteLine("gagne !!!");
                    Console.WriteLine("vous avez trouvé en ", essais, " essais");
                    gagne = true;
                }
                else
                {
                    if(saisie<nbrSecret)
                    {
                        Console.WriteLine("le nombre a trouvé est supérieur");
                    }
                    else
                    {
                        if(saisie>nbrSecret)
                        {
                            Console.WriteLine("le nombre a trouvé est inférieur");
                        }
                    }
                }
            }
            Console.WriteLine("à la prochaine");
        }
    }
}