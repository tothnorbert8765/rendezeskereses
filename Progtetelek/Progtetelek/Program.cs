using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Progtetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            //keresés
            /*int[] szamok = { 1, 2, 30, 4, 5, 3, 7, 8, 9, 40 };
            int ker = 30;
            int i = 0;
            while (i<szamok.Length && szamok[i] != ker)
            {
                i++;
            }
            if (i < szamok.Length)
            {
                Console.WriteLine($"Van ilyen az {i+1}. helyen");
            }
            else
            {
                Console.WriteLine("A keresett érték nem található");
            }
            */
            //kiválogatás
            
            List<int> szamok = new List<int>(30) { 1, 2, 30, 4, 5, 3, 7, 8, 9, 40 };
            var kisebbek = new List<int>();

            for (int i = 0; i < szamok.Count; i++)
            {
                
                if (szamok[i]<5)
                {
                    kisebbek.Add(szamok[i]);
                }
                Console.WriteLine("Annyira ki lett válogatva hogy az nagyon ki lett válogatva hogy a monok nem tudja felfogni azt hogy mennyire ki lett írva de ha vart írtam volna bele most megverne engem meg a fodort is szegénynek széttörné a fordját");

            }
            foreach (var item in kisebbek)
            {
                Console.Write(item + " ");
                
            }
            Console.ReadKey();
        }
    }
}
