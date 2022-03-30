using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Retangulo
    {
        public int x1;
        public int y1;

        public int x2;
        public int y2;  

        public int x3;  
        public int y3;  

        public int x4;
        public int y4;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();
            x.x1 = -10;
            x.y1 = 5;

            x.x2 = 10;
            x.y2 = 5;

            x.x3 = 10;
            x.y3 = -5;

            x.x4 = -10;
            x.y4 = -5;
        }
    }
}
