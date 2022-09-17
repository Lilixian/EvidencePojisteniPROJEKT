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
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telefonniCislo"></param>
        public PojisteneOsoby(string jmeno, string prijmeni, int vek, int telefonniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }
        /// <summary>
        /// Vrátí textovou reprezentaci 
        /// </summary>
        /// <returns>Textová reprezentace </returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Jmeno, Prijmeni, Vek, TelefonniCislo);
        }

    }
}
