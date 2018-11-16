using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCC_29
{
    class Program
    {
        static int[] Daten = new int[1000];

        static void Main(string[] args)
        {
            string Input;









            
            int i = 0;
            while(i < 5)
            {

            StreamReader reader = new StreamReader(readerpath);
            StreamWriter writer = new StreamWriter(writerpath);
            while ((Input = reader.ReadLine()) != null)
            {

                string[] input = Input.Split(' ');
                int r1 = Convert.ToInt32(input[0]);
                int r2 = Convert.ToInt32(input[3]);
                int c1 = Convert.ToInt32(input[1]);
                int c2 = Convert.ToInt32(input[4]);
                double ratio = Convert.ToDouble(input[5]);
                int x = Convert.ToInt32(r1 + ratio * (r2 - r1));
                int y = Convert.ToInt32(c1 + ratio * (c2 - c1));

                writer.WriteLine($"{x} {y}");

            }
            }
            Console.ReadKey();
        }

        static public Einlesen(string path)
        {
            

                
        }
    }
}
