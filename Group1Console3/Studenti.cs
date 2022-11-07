using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1Console3
{
    internal class Studenti
    {
        public Studenti(string emri,string mbiemri,int mosha)
        {
            Emri = emri;
            Mbiemri = mbiemri;
            Mosha = mosha;
        }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }

        public int Mosha { get; set; }

        public void Pershendete()
        {
            Console.WriteLine($"Tungjatjeta {Emri},{Mbiemri}");
        }

    }
}
