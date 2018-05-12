using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreazioneMazzoCarte
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carta> CardsPack = new List<Carta>();
            enumSeed.seed temp_seed = enumSeed.seed.B;
            String name = "";
            
            //Cicli per la creazione di n carte per differenti semi
            for (int i=0; i < 4; i++)
            {
                switch (i)
                {
                    case 1:
                        temp_seed = enumSeed.seed.O;
                        break;
                    case 2:
                        temp_seed = enumSeed.seed.S;
                        break;
                    case 3:
                        temp_seed = enumSeed.seed.C;
                        break;

                }
                for(int k=1; k <= 10; k++)
                {
                    switch (k)
                    {
                        case 1:
                            name = "Asso";
                            break;
                        case 8:
                            name = "Donna";
                            break;
                        case 9:
                            name = "Fante";
                            break;
                        case 10:
                            name = "Re";
                            break;
                        default:
                            name = k.ToString();
                            break;
                    }
                    CardsPack.Add(new Carta(k, name, temp_seed));
                }
            }

            //Stampa provvisoria per controllo set di carte
            foreach(Carta c in CardsPack)
            {
                Console.WriteLine(c.ToString());
            }
            
            Console.ReadLine();
        }
    }
}
