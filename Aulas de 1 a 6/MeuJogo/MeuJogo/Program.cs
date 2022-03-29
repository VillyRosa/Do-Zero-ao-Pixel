using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(f(2) + "\n");
            deixarLike();
        }

        static int f(int x)
        {
            return x + 1;
        }
        static void deixarLike()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Você deixou o " + (i + 1) + "º like!\n");
            }
        }
    }
}