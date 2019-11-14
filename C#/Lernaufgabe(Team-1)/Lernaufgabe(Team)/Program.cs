using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernaufgabe_Team_
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 100; i <=200; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i + " ist durch 3 teilbar ohne einen Rest zu hinterlassen!");
                }
            }
            Console.ReadLine();
        }
    }
}
