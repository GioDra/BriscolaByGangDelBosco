using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreazioneMazzoCarte
{
    class Turno
    {
        private enumSeed.seed briscola;
        public List<CartaBriscola> tavolo = new List<CartaBriscola>();

        public enumSeed.seed getBriscola()
        {
            return briscola;
        }

        //public void setSeed(enumSeed.seed value)
        //{
        //    this.briscola = briscola;
        //}

        public Turno(enumSeed.seed briscola)
        {
            this.briscola = briscola;
        }

        public int checkTavolo()
        {
            CartaBriscola winner = new CartaBriscola();
            int i = 0;  //Indice aggiornato di ogni carta
            int j = 0;     //Indice restituito con la posizione della carta
            foreach(CartaBriscola c in tavolo)
            {
                if(winner == null)
                {
                    winner = c;
                    j = i;
                }
                else
                {
                    if ((winner.getSeed() != briscola && c.getSeed() == briscola) || (((winner.getValue() < c.getValue() && winner.getScore().Equals(c.getScore()) )|| winner.getScore() < c.getScore()) && winner.getSeed().Equals(c.getSeed())))
                    {
                        winner = c;
                        j = i;
                    }
                }
                i++;
            }
            return j;
        }
        public void assegnazioneCarte(Player p)
        {
            Console.WriteLine("Complimenti {0} hai vinto questa mano", p.nome);
            foreach (CartaBriscola c in tavolo)
            {
                p.cartePrese.Add(c);
            }
            tavolo = new List<CartaBriscola>();
        }

        public string getTavolo()
        {
            string msg = "";
            if (tavolo != null)
            {
                foreach(CartaBriscola c in tavolo)
                {
                    msg += c.StringVideo() + "\t";
                }
                return msg;
            }
            return msg;
        }

        public void cartaTurno(List<Player> giocatori, List<CartaBriscola> mazzo, int tempIndex)
        {
            int i = 0;
            while (!giocatori[tempIndex].turno && mazzo.Count()>0)
            {
                if (mazzo!=null)
                {
                    //Console.WriteLine(mazzo.Count());
                    giocatori[tempIndex].mano.Add(mazzo[0]);
                    mazzo.RemoveAt(0);
                }
                giocatori[tempIndex].turno = true;
                tempIndex++;
                //i++;
                if (tempIndex >= giocatori.Count())
                    tempIndex = 0;
            }

            for (int k = 0; k < giocatori.Count(); k++)
                giocatori[k].turno = false;
        }

    }
}
