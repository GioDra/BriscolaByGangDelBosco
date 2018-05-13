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
            RaccoltaCarte(CardsPack);

            List<CartaBriscola> Mazzo = new List<CartaBriscola>();
            CreaMazzo(CardsPack, Mazzo);

            //Stampa provvisoria per controllo set di carte
            foreach (Carta ci in Mazzo)
            {
                Console.WriteLine(ci.ToString());
            }
            Console.ReadLine();
        }

        static void RaccoltaCarte(List<Carta> CardsPack)
        {
            enumSeed.seed temp_seed = enumSeed.seed.B;
            String name = "";

            //Cicli per la creazione di n carte per differenti semi
            for (int i = 0; i < 4; i++)
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
                for (int k = 1; k <= 10; k++)
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

            ////Stampa provvisoria per controllo set di carte
            //foreach(Carta c in CardsPack)
            //{
            //    Console.WriteLine(c.ToString());
            //}
            //Console.ReadLine();
        }

        static void Mescola(List<Carta> CardsPack)
        {
            Random rnd = new Random();
            Carta c = new Carta();
            int indiceA;
            int indiceB;
            for (int i = 0; i < 400; i++)
            {
                indiceA = rnd.Next(0, (CardsPack.Count() - 1));
                c = CardsPack[indiceA];
                indiceB = rnd.Next(0, (CardsPack.Count() - 1));
                CardsPack[indiceA] = CardsPack[indiceB];
                CardsPack[indiceB] = c;
            }
        }
        
        static void CreaMazzo(List<Carta> CardsPack, List<CartaBriscola> Mazzo)
        {
            Mescola(CardsPack);
            foreach (Carta ci in CardsPack)
            {
                Mazzo.Add(new CartaBriscola(ci));
            }

            CartaBriscola c;
            for (int i = 0; i < Mazzo.Count(); i++)
            {
                c = Mazzo[i];
                if (c.getValue() == 3)
                {
                    c.setValue(11);
                    Mazzo[i] = c;

                }

                if (c.getValue() == 1)
                {
                    c.setValue(12);
                    Mazzo[i] = c;
                }
                i++;
            }
        }

    }
}
