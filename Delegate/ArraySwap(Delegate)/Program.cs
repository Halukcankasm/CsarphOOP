using System;

namespace ArraySwap_Delegate_
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 6, 2, 32, 4, 51, 12 };

            Shorting shorting = new Shorting();

            shorting.Short(arr, new DelegateSwap(shorting.Swap));

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
