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
        static string[] InString = new string[10000];
        static int[,] Output = new int[3000, 3000];

        static void Main(string[] args)
        {
            Einlesen();


        }

        static public int[,] Einlesen(string path)
        {
            string Input;


            StreamReader reader = new StreamReader(path);

            Input = reader.ReadToEnd();
            reader.Close();

            InString = Input.Split('\n');

            for (int i = 1; InString[i + 1] != null; i++)
            {
                string s = InString[i];

                string[] s1 = new string[1000];

                s1 = s.Split(' ');

                for (int j = 0; s1[j + 1] != null; j++)
                {
                    Output[i, j] = Convert.ToInt16(s1[j]);
                }
            }

            return Output;
        }
    }
}
