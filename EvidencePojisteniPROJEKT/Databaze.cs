/// Testování nového projektu
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

        public Databaze()   // v objektu Databáze budou záznamy uloženy
        {
            pojistenci = new List<PojisteneOsoby>();
        }

        public void PridejPojistence(string jmeno, string prijmeni, int vek, int telefonniCislo)        
        {
            pojistenci.Add(new PojisteneOsoby(jmeno, prijmeni, vek, telefonniCislo));
        }

        


        public void NajdiPojistence(string jmeno, string prijmeni)  // jednoho, dle jména a příjmení
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

        public List<PojisteneOsoby> VypisPojistence()    // ?? nevím, zda jsou správně údaje v závorkách ?
        {
            List<PojisteneOsoby> vsichniPojistenci = new List<PojisteneOsoby>(); // ?? tohle taky nevím, jestli tu má být?? 
            foreach (PojisteneOsoby p in pojistenci)
            {
                vsichniPojistenci.Add(p);
            }
            return pojistenci;
            
        }
    }
}
