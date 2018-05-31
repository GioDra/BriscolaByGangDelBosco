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
            Mazzo m = new Mazzo();

            Partita(m);

            Console.ReadLine();
        }

    }
} 
