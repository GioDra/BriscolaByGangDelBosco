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
        protected int value;             //Valore nominale della carta
        protected String name { get; set; }           //Nome della carta
        protected enumSeed.seed seed { get; set; }    //Seme della carta


        public int getValue()
        {
            return value;
        }
        public void setValue(int value)
        {
            this.value = value;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public enumSeed.seed getSeed()
        {
            return seed;
        }
        public void setSeed(enumSeed.seed value)
        {
            this.seed = seed;
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
