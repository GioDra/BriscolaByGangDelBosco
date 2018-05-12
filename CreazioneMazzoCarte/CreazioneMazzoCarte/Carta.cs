using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CreazioneMazzoCarte
{
    //Classe per la crezione di una carta base
    
    class Carta 
    {
        private int value;             //Valore nominale della carta
        private String name { get; set; }           //Nome della carta
        private enumSeed.seed seed { get; set; }    //Seme della carta


        public int getValue()
        {
            return value;
        }
        public void setValue(int value)
        {
            this.value = value;
        }

        public Carta()
        {
        }

        public Carta(int value, string name, enumSeed.seed seed)
        {
            this.value = value;
            this.name = name;
            this.seed = seed;
        }

        public override string ToString()
        {
            return value.ToString()+" "+name+" "+seed.ToString();
        }
    }
}
