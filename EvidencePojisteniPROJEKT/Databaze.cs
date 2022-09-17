using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteniPROJEKT
{
    internal class Databaze // třída slouží pro manipulaci s daty
    {
        private List<PojisteneOsoby> pojistenci;

        /// <summary>
        /// V objektu Databáze budou záznamy uloženy
        /// </summary>
        public Databaze()
        {
            pojistenci = new List<PojisteneOsoby>();
        }

        public void PridejPojistence(string jmeno, string prijmeni, int vek, int telefonniCislo)        
        {
            pojistenci.Add(new PojisteneOsoby(jmeno, prijmeni, vek, telefonniCislo));
        }

        /// <summary>
        /// Vyhledá jednoho pojištěného podle jména a příjmení
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        public void NajdiPojistence(string jmeno, string prijmeni)
        {
            PojisteneOsoby mujPojistenec = new PojisteneOsoby("", "", 0, 0);  
            
            foreach (PojisteneOsoby pojistenec in pojistenci)
            {
                if (pojistenec.Jmeno == jmeno && pojistenec.Prijmeni == prijmeni)
                {
                    mujPojistenec = pojistenec;
                }
            }

            if (mujPojistenec != null)
            {
                Console.WriteLine(mujPojistenec);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Pojištěnec nenalezen");
                Console.ReadKey();
            }
                
        }

        public List<PojisteneOsoby> VypisPojistence()  
        {
            List<PojisteneOsoby> vsichniPojistenci = new List<PojisteneOsoby>();
            foreach (PojisteneOsoby p in pojistenci)
            {
                vsichniPojistenci.Add(p);
            }
            return pojistenci;
            
        }
    }
}
