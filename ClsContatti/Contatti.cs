using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsContatti
{
    public class Contatti
    {
        //Getter Setter properties
        public int ContactID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set;}
        public string Contatto { get; set; }
        public string Indirizzo { get; set; }
        public string Genere { get; set; }


        //Acts as Data Carrier in Our Application
    }
}
