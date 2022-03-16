using System;
using System.Collections.Generic;
using System.Text;

namespace Farmacie
{
    class Medicament
    {
        
        public string nume { get; set; }
        public string tip { get; set; }
        public int nr_buc { get; set; }
        public string data_expirare { get; set; }
        public int pret { get; set; }




        public Medicament(int nr_bucati, string _nume, string _tip, int _pret, string data_exp)
        {

            nume = _nume;
            tip = _tip;
            nr_buc = nr_bucati;
            data_expirare = data_exp;
            pret = _pret;
        }

        public void AdaugaMedicament()
        {
            Medicament medicament0 = new Medicament(40, "Nurofen", "Analgezic", 20, "13.05.2031");
            Medicament medicament1 = new Medicament(48, "Ceai de galbenele", "Plafar", 15, "25.12.2040");
            Medicament medicament2 = new Medicament(89, "Coldrex", "Raceala si gripa", 23, "03.05.2031");


            List<Medicament> Medicament = new List<Medicament>
            {
                medicament0, medicament1, medicament2
            };
        }

        public void Stergere_Medicament()
        {

        }

        public void Modifica_Medicament()
        {

        }




    }
}
