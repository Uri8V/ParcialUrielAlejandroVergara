using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUrielAlejandroVergara.Entidades
{
    public class Elipses
    {

        public int SemiEjeMayor { get; set; }
        public int SemiEjeMenor { get; set; }
        public Trazo Trazo { get; set; }
        public Elipses()
        {

        }

        public Elipses(int Mayor, int Menor)
        {
            SemiEjeMayor = Mayor;
            SemiEjeMenor = Menor;
        }

        public int GetPerimetro()
        {
            var p = 2 * Math.PI * Math.Sqrt(((Math.Pow(SemiEjeMayor, 2) + Math.Pow(SemiEjeMenor, 2)) / 2));
            return (int)p;
        }

        public int GetArea()
        {
            var a = Math.PI * SemiEjeMenor * SemiEjeMayor;
            return (int)a;
        }
    }
}
