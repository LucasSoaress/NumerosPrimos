using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Primos p = new Primos();
            p.limiteDaLista = int.Parse(Console.ReadLine());

            p.escreveLista();
            p.printNumeros();
            p.marcaDeleta();
            Console.ReadKey();
            Console.WriteLine();
            p.printNumeros();
            Console.ReadKey();

            //static int x;
            //static int y;
            //static int i;
            //static List<string> lista = new List<string>();
            //static void Main(string[] args)
            //{

            //    y = 3;

            //    while(y <= 10)
            //    {
            //        for (i = 3; i <= 10; i++)
            //        {
            //           if(i % y != 0)
            //           {
            //               lista.Add(i.ToString());
            //           }
            //        }

            //        y++;
            //    }

            //    lista.Sort();
            //    Console.WriteLine(lista.Count);
            //    Console.ReadKey();
            //}
        }
    }
}
