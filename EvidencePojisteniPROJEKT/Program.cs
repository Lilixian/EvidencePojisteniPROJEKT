using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteniPROJEKT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // instance evidence
            Evidence evidence = new Evidence();
            char volba = '0';

            // hlavní cyklus pro volbu operace
            while (volba != '4')
            {
                evidence.VypisUvodniObrazovku();
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();

                // reakce na volbu
                switch (volba)
                {
                    case '1':
                        evidence.PridejPojistence();
                        break;
                    case '2':
                        evidence.VypisPojistence();    
                        break;
                    case '3':
                        evidence.VyhledejPojisteneho();
                        break;
                    case '4':
                        Console.WriteLine("Libovolnou klávesou ukončíte program.");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}