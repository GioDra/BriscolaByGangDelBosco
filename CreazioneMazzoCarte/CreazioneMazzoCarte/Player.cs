using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreazioneMazzoCarte
{
    class Player
    {
        public String name="";
        public List<CartaBriscola> mano = new List<CartaBriscola>();
        public List<CartaBriscola> cartePrese = new List<CartaBriscola>();
        public bool turno = false;
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

        public void Cala(List<CartaBriscola> tavolo)
        {
            if (mano != null)
            {
                int input = -1;
                while (input < 0 || input > 2)
                {
                    Console.WriteLine(name);
                    Console.WriteLine("Scegli quale carta giocare digitando un numero da 1 a 3");
                    getMano();
                    input = (Convert.ToInt32(Console.ReadLine()))-1;
                }
                tavolo.Add(mano[input]);
                mano.RemoveAt(input);
            }
        }

        public int getFinalScore()
        {
            int x = 0;
            foreach (CartaBriscola c in cartePrese)
                x += c.getScore();
            return x;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        
    }
}
