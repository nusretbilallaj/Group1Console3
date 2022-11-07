using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1Console3
{
    internal class Studenti:Person
    {
        public Studenti(string emri,string mbiemri,int mosha):base(emri,mbiemri)
        {
            Mosha = mosha;
        }


        public int Mosha { get; set; }

        public override void Pershendete()
        {
            Console.WriteLine($"Tungjatjeta student {Emri},{Mbiemri}");
        }

    }
}
