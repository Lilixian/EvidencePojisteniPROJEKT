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

        public void PridejPojistence()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = Console.ReadLine();       // ?? má tu být takto string ?
            Console.WriteLine("Zadejte telefonní číslo:");
            int telefonniCislo = int.Parse(Console.ReadLine()); // parsování opsáno
            Console.WriteLine("Zadejte věk:");
            int vek = int.Parse(Console.ReadLine());
            databaze.PridejPojistence(jmeno, prijmeni, telefonniCislo, vek);    // opsáno
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
            Console.ReadLine();
        }

        

        public void VypisPojistence()   //všechny 
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
            //List<PojisteneOsoby> pojistenci = databaze.NajdiPojistence(jmeno, prijmeni, false);
            //if (pojistenci.Count > 0)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("Nalezen pojištěnec: ");
            //    foreach (PojisteneOsoby p in pojistenci)
            //        Console.WriteLine(p);
            //}
            //else
            //    Console.WriteLine("");
            //Console.WriteLine("Pojištěnec nebyl nalezen");
                                           
        }

        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Evidence pojistenych");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }
    }
}
