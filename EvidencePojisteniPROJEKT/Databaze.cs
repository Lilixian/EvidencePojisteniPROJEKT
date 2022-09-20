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
        /// <summary>
        /// Přidá nového pojištěného
        /// </summary>
        /// <param name="jmeno">Jméno</param>
        /// <param name="prijmeni">Příjmení</param>
        /// <param name="vek">Věk</param>
        /// <param name="telefonniCislo">Telefonní číslo</param>
        public void PridejPojistence(string jmeno, string prijmeni, int vek, int telefonniCislo)        
        {
            pojistenci.Add(new PojisteneOsoby(jmeno, prijmeni, vek, telefonniCislo));
        }

        /// <summary>
        /// Vyhledá jednoho pojištěného podle jména a příjmení
        /// </summary>
        /// <param name="jmeno">Jméno</param>
        /// <param name="prijmeni">Příjmení</param>
        public void NajdiPojistence(string jmeno, string prijmeni)
        {
            PojisteneOsoby mujPojistenec = new PojisteneOsoby("", "", 0, 0);  
            
            foreach (PojisteneOsoby pojistenec in pojistenci)
            {
                if (pojistenec.Jmeno == jmeno.ToUpper().Trim() && pojistenec.Prijmeni == prijmeni.ToUpper().Trim())
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
        /// <summary>
        /// Vypíše všechny pojištěné
        /// </summary>
        /// <returns>Všechny pojištěné osoby</returns>
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
