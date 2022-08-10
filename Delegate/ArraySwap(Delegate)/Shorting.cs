using System;
using System.Collections.Generic;
using System.Text;

namespace ArraySwap_Delegate_
{
    public delegate void DelegateSwap(ref int[] arr, int x, int y);
    public class Shorting
    {
        public void Swap(ref int[] arr, int x, int y)
        {
            var a = arr[x];
            arr[x] = arr[y];
            arr[y] = a;

        }

        public void Short(int[] arr, DelegateSwap del)
        {
            int t = 0;
            for (int i = 0; i < arr.Length ; ++i)
            {
                t = i;
                for (int index = i+1; index < arr.Length; ++index)
                {
                    if (arr[index] < arr[t])
                    {
                        t = index;
                    }
                }
                del.Invoke(ref arr, i, t);
            }
        }
    }
}
