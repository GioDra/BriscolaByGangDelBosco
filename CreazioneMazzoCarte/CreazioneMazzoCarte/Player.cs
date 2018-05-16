using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreazioneMazzoCarte
{
    class Player
    {
        public List<CartaBriscola> mano = new List<CartaBriscola>();
        public List<CartaBriscola> cartePrese = new List<CartaBriscola>();
        private int finalScore;

        public void getMano()
        {
            foreach (CartaBriscola c in mano)
            {
                Console.Write(c.StringVideo());
            }
            Console.WriteLine();
        }

        public void getPrese()
        {
            foreach (CartaBriscola c in cartePrese)
            {
                Console.WriteLine(c.StringVideo());
            }
        }

        public Player()
        {
        }

        public void Pesca(List<CartaBriscola> Mazzo)
        {
            mano.Add(Mazzo[0]);
            if (mano.Count() < 4)
                Mazzo.RemoveAt(0);
            else
            {
                Console.WriteLine("Non puoi pescare mano piena");
                mano.RemoveAt(3);
            }
        }

        public int calcScore()
        {
            foreach (CartaBriscola c in cartePrese)
            {
                finalScore += c.getScore();
            }
            return 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
