using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteniPROJEKT
{
    internal class PojisteneOsoby
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }

        public int TelefonniCislo { get; set; }

        /// <summary>
        /// Inicializace instance
        /// </summary>
        /// <param name="jmeno">Jméno</param>
        /// <param name="prijmeni">Příjmení</param>
        /// <param name="vek">Věk</param>
        /// <param name="telefonniCislo">Telefonní číslo</param>
        public PojisteneOsoby(string jmeno, string prijmeni, int vek, int telefonniCislo)
        {
            Jmeno = jmeno.ToUpper().Trim();
            Prijmeni = prijmeni.ToUpper().Trim();
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }
        /// <summary>
        /// Vrátí textovou reprezentaci 
        /// </summary>
        /// <returns>Textová reprezentace pojištěné osoby</returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Jmeno, Prijmeni, Vek, TelefonniCislo);
        }

    }
}
