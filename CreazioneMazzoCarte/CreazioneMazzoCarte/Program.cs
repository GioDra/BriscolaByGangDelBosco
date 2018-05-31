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


        static void Partita(Mazzo m)
        {

            CartaBriscola briscola = m.getBriscola();
            int tempIndex = 0;              //Indice temporaneo
            
            //Inizializzazione giocatori e distribuzione carte

            List<Player> giocatori = new List<Player>();

            Player p1 = new Player();
            Player p2 = new Player();
            p1.nome = "Giocatore 1";
            p2.nome = "Giocatore 2";

            giocatori.Add(p1);
            giocatori.Add(p2);

            for (int i = 0; i < 3; i++)
            {
                p1.Pesca(m.MazzoB);
                p2.Pesca(m.MazzoB);
            }

            Console.WriteLine("Il mazzo è stato mescolato e le carte sono state distribuite, inizia la partita");

            Turno t = new Turno(briscola.getSeed());

            //Inizio alternanza turni
            while (p1.mano.Count() != 0 || p2.mano.Count() != 0 || m.MazzoB.Count() != 0)
            {
                Console.WriteLine("La briscola è {0}", briscola.StringVideo());

                tempIndex = t.checkTavolo();
                while (!giocatori[tempIndex].turno)
                {
                    Console.WriteLine(t.getTavolo());
                    giocatori[tempIndex].Cala(t.tavolo);
                    giocatori[tempIndex].turno = true;
                    tempIndex++;
                    if (tempIndex >= giocatori.Count())
                        tempIndex = 0;
                }
                for (int i = 0; i < giocatori.Count(); i++)
                    giocatori[i].turno = false;
                tempIndex = t.checkTavolo();
                t.assegnazioneCarte(giocatori[tempIndex]);

                t.cartaTurno(giocatori, m.MazzoB, tempIndex);

            }

            for (int i = 0; i < giocatori.Count(); i++)
                Console.WriteLine(giocatori[i].getFinalScoreStr());
        }
    }
} 
