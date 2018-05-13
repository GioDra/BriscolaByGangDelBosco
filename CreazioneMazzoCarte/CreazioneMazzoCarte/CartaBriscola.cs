using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreazioneMazzoCarte
{
    class CartaBriscola : Carta
    {
        private int score;

        public CartaBriscola(Carta c)
        {
            this.value = c.getValue();
            this.name = c.getName();
            this.seed = c.getSeed();

            switch (this.value)
            {
                case 1:
                    score = 11;
                    break;
                case 3:
                    score = 10;
                    break;
                case 8:
                    score = 2;
                    break;
                case 9:
                    score = 3;
                    break;
                case 10:
                    score = 4;
                    break;
                default:
                    score = 0;
                    break;
            }
        }

        public override string ToString()
        {
            return base.ToString()+" "+score;
        }
    }
}
