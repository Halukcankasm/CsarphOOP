using System;

namespace CSarph_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arc = new int[10] { 1, 20, 3, 4, 50, 6, 7, 80, 9, 10 };
            Console.WriteLine(arc.Length);
            Console.WriteLine("index of number 3:"+Array.IndexOf(arc,3));
            Array.Sort(arc);
            Console.WriteLine("---Sort---");
            foreach (var item in arc){Console.WriteLine(item);}
            Array.Reverse(arc);
            Console.WriteLine("---Reverse---");
            foreach (var item in arc) { Console.WriteLine(item); }
            Console.WriteLine("Rank:", arc.Rank);
            Console.WriteLine("Get Length(0.Rank):"+arc.GetLength(0));

            Array.Clear(arc,0,1);
            Console.WriteLine("clear afte 0.index");
            foreach (var item in arc) { Console.WriteLine(item); }


            int[,] matris = {
                                {1,3,5},
                                {9,2,7},
                                {12,89,100},
                                {19,300,50}
                            };

            Console.WriteLine("matris[2, 1]" + matris[2, 1]);
            Console.WriteLine(matris.Rank);
            Console.WriteLine(matris.GetLength(0));
            Console.WriteLine(matris.GetLength(1));



            ///Jagged Array

            int[][] arr = new int[3][]; // arr have 3 element(array)
            Console.WriteLine("arr rank:"+arr.Rank);
            arr[0] = new int[4] { 1, 2, 3, 4 };
            arr[1] = new int[4] { 5, 6, 7, 8 };
            arr[2] = new int[4] { 9, 10, 11, 12 };

            Console.WriteLine("-----------for----------------");


            for (int i = 0; i <= arr.Length-1 ; i++)
            {
                for (int a = 0; a <= arr[i].Length-1; a++)
                {
                    Console.WriteLine(arr[i][a]);
                }
            }

            Console.WriteLine("-----------foreach----------------");

            foreach (var item in arr)
            {
                foreach (var value in item)
                {
                    Console.WriteLine(value);
                }
            }

     



        }
    }
}
