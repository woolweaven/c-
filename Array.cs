using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOnArrays
{
    class Program
    {
        static int[] x = new int[5] { 5,6,8,7,6};

        public static void Display()
        {
            Console.WriteLine("index\tvalue");
            for (int i = 0; i < 5; i++)
            {
                x[i] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("{0}\t{1}", i, x[i]);
            }
        }

        static void MaxnMin(int max, int min)
        {
            max = x.Max();
            min = x.Min();
            Console.WriteLine("Max: {0}, Min: {1}", max, min);
        }

        static void Sorting(int v)
        {
            int[] y = new int[5];
            switch (v)
            {
                case 1:                                     //reversing an array
                    for (int i = x.Length - 1; i >= 0; i--)
                    {
                        Console.WriteLine(x[i]);
                    }
                    break;

                case 2:                                     //sorting in ascending order
                    {
                        Array.Sort(x);
                        foreach (int a in x) Console.WriteLine(a + "\n");
                       
                        /*for (int i = 1; i <  x.Length; i++)
                    
                            int j = i;
                            int x1 = x[i];
                            while ((j > 0) && (x[j - 1] > x1))
                            {
                                x[j] = x[j - 1];
                                j--;
                            }
                            x[j] = x1;*/
                    }
                   
                    break;
            }
        }
        static void Main(string[] args)
        {
            // MaxnMin(0, 0);
            //Display();
            Sorting(2);
            Console.ReadKey();
        }

    }
}
