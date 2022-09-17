using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteniPROJEKT
{
    internal class Evidence     // třída Evidence bude obsahovat metody pro komunikaci s uživatelem
    {
        private Databaze databaze; 

        public Evidence()
        {
            databaze = new Databaze();
        }

        /// <summary>
        /// Přidá nového pojištěnce
        /// </summary>
        public void PridejPojistence()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = Console.ReadLine();       
            Console.WriteLine("Zadejte telefonní číslo:");
            int telefonniCislo = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Zadejte věk:");
            int vek = int.Parse(Console.ReadLine());
            databaze.PridejPojistence(jmeno, prijmeni, telefonniCislo, vek);    
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
            Console.ReadLine();
        }

        /// <summary>
        /// Vypíše všechny pojištené
        /// </summary>
        public void VypisPojistence() 
        {
            
            List<PojisteneOsoby> pojistenci = databaze.VypisPojistence();   // přepsáno z NajdiPojistence na VypisPojistence a v Databazi vymazan obsah závorky za VypisPojistence a pka to nebylo červené
            foreach (PojisteneOsoby p in pojistenci)
                Console.WriteLine(p);
            Console.ReadLine();
        }

        // metoda VyhledejPojisteneho(), která vyzve uživatele k zadání jména a příjmení
        public void VyhledejPojisteneho()   
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = Console.ReadLine();
            databaze.NajdiPojistence(jmeno, prijmeni);                             
        }

        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Evidence pojistenych");
            Console.WriteLine("------------------------------\n");
        }
    }
}
