using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCC_29
{
    class Program
    {
        class Point
        {
            public int x;
            public int y;
            public Point(int X, int Y)
            {
                x = X;
                y = Y;
            }
        }
        static int[] Daten = new int[1000];

        static void Main(string[] args)
        {
            string Input;

            int i = 0;
            while (i < 3)
            {
                StreamReader reader = new StreamReader($"level3_{i}.in");
                Point[] points = new Point[20000];
                StreamWriter writer = new StreamWriter($"level3_{i}.out");
                {
                    reader.ReadLine();
                    while ((Input = reader.ReadLine()) != null)
                    {
                        string[] input = Input.Split(' ');
                        double r1 = Convert.ToInt32(input[0]);
                        double c1 = Convert.ToInt32(input[1]);
                        double r2 = Convert.ToInt32(input[2]);
                        double c2 = Convert.ToInt32(input[3]);
                        int x;
                        int y;
                        int pointCounter = 0;
                        double ratio = 0;
                        while (ratio < 1)
                        {
                            ratio += 0.001;
                            x = Convert.ToInt32(Math.Floor(r1 + ratio * (r2 - r1)+0.5));
                            y =Convert.ToInt32(Math.Floor(c1 + ratio * (c2 - c1)+0.5));
                            points[pointCounter] = new Point(x, y);
                            pointCounter++;
                        }
                        pointCounter = 0;
                        while(points[pointCounter+1] != null)
                        {
                            if($"{points[pointCounter].x} {points[pointCounter].y}" != $"{points[pointCounter+1].x} {points[pointCounter+1].y}")
                            {
                                writer.Write($"{points[pointCounter].x} {points[pointCounter].y} ");
                                Console.Write($"{points[pointCounter].x} {points[pointCounter].y}");
                            }
                            pointCounter++;
                        }
                        writer.WriteLine($"{points[pointCounter].x} {points[pointCounter].y} ");
                    }
                    reader.Close();
                    writer.Close();
                    i++;
                }
            }

        }
    }
}
 