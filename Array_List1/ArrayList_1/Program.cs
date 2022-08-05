
using CreateArrayList;
using System;

namespace ArrayList_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList myArrayList = new MyArrayList();
            myArrayList.Add("test1");
            myArrayList.Add("test2");
            myArrayList.Add("test3");
            myArrayList.Add("test4");
            myArrayList.Add("test5");
            myArrayList.Add("test6");

            Console.WriteLine("----------------Create Default ArrayList--------------");

            for (int i = 0; i < myArrayList.Length; i++)
            {
                Console.WriteLine($"index[{i}]:{myArrayList[i]}");
            }

            Console.WriteLine("Length:"+myArrayList.Length);
            Console.WriteLine("Uzunluk:" + myArrayList.UnNullOfNumnerElemant);




            Console.WriteLine("----------------After Delte Comp.--------------");

            Console.WriteLine("Delete test5");
            myArrayList.DeleteEleman("test5");

            Console.WriteLine("Delete test3");
            myArrayList.DeleteEleman("test3");

            for (int i = 0; i < myArrayList.Length; i++)
            {
                Console.WriteLine($"index[{i}]:{myArrayList[i]}");
            }

            Console.WriteLine("test1 is index of:" + myArrayList.IndexOf("test1"));
            Console.WriteLine("test2 is index of:" + myArrayList.IndexOf("test2"));
            Console.WriteLine("test3 is index of:" + myArrayList.IndexOf("test3"));
            Console.WriteLine("test4 is index of:" + myArrayList.IndexOf("test4"));
            Console.WriteLine("test5 is index of:" + myArrayList.IndexOf("test5"));
            Console.WriteLine("test6 is index of:" + myArrayList.IndexOf("test6"));

            Console.WriteLine("Length" + myArrayList.Length);
            Console.WriteLine("Uzunluk" + myArrayList.UnNullOfNumnerElemant);

            Console.WriteLine("----------------After Contains Comp.--------------");

            Console.WriteLine("test1 have got : "+(myArrayList.Contains("test1") ? "have" : "have not"));
            Console.WriteLine("test3 have got : " + (myArrayList.Contains("test3") ? "have" : "have not"));
            Console.WriteLine("test2 is Contains: "+myArrayList.Contains("test2"));


            Console.WriteLine("----------------After ArrayList[0] Comp.--------------");
            Console.WriteLine("myArrayList[0]: "+myArrayList[0]);


            Console.WriteLine("----------------After Crop Comp.--------------");
            myArrayList.Crop();
            for (int i = 0; i < myArrayList.Length; i++)
            {
                Console.WriteLine($"index[{i}]:{myArrayList[i]}");
            }
            Console.WriteLine("Length: " + myArrayList.Length);
            Console.WriteLine("Uzunluk: " + myArrayList.UnNullOfNumnerElemant);



            Console.WriteLine("----------------After Reverse Comp.--------------");
            myArrayList.Reverse();
            Console.WriteLine("Length: " + myArrayList.Length);
            Console.WriteLine("Uzunluk: " + myArrayList.UnNullOfNumnerElemant);
            for (int i = 0; i < myArrayList.Length; i++)
            {
                Console.WriteLine($"index[{i}]:{myArrayList[i]}");
            }

            Console.WriteLine("----------------After Again Reverse Comp.--------------");
            myArrayList.Reverse();
            Console.WriteLine("Length: " + myArrayList.Length);
            Console.WriteLine("Uzunluk: " + myArrayList.UnNullOfNumnerElemant);
            for (int i = 0; i < myArrayList.Length; i++)
            {
                Console.WriteLine($"index[{i}]:{myArrayList[i]}");
            }

        }

    }
}
