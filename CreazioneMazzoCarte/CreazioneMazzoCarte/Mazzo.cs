using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreazioneMazzoCarte
{
    class Mazzo 
    {
        private List<Carta> CardsPack = new List<Carta>();
        public List<CartaBriscola> MazzoB = new List<CartaBriscola>();

        public Mazzo()
        {
            RaccoltaCarte(CardsPack);

            Mescola(CardsPack);
            foreach (Carta ci in CardsPack)
            {
                MazzoB.Add(new CartaBriscola(ci));
            }

            CartaBriscola c;
            for (int i = 0; i < MazzoB.Count(); i++)
            {
                c = MazzoB[i];
                if (c.getValue() == 3)
                {
                    c.setValue(11);
                    MazzoB[i] = c;

                }

                if (c.getValue() == 1)
                {
                    c.setValue(12);
                    MazzoB[i] = c;
                }
                i++;
            }
        }


        public CartaBriscola getBriscola()
        {
            CartaBriscola briscola = new CartaBriscola();

            int index = 0;

            //Estrazione della briscola
            Random rnd = new Random();
            index = rnd.Next(0, (CardsPack.Count() - 1));
            briscola = MazzoB[index];
            MazzoB.RemoveAt(index);
            MazzoB.Add(briscola);

            return briscola;
        }





        public void RaccoltaCarte(List<Carta> CardsPack)
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

        }

        public void Mescola(List<Carta> CardsPack)
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
    }
}
