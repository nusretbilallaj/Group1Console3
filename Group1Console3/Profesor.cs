using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1Console3
{
    internal class Profesor
    {
        public Profesor(string emri, string mbiemri)
        {
            Emri = emri;
            Mbiemri = mbiemri;
        }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }

        public void Pershendete()
        {
            Console.WriteLine($"Tungjatjeta profesor {Emri},{Mbiemri}");
        }
    }
}
