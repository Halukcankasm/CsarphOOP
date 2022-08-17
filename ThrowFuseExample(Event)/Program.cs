using System;

namespace ThrowFuseExample_Event_
{
    class Program
    {
        static void Main(string[] args)
        {
            FuseBox fuseBox = new FuseBox("siemens", 10);
            for (int i = 0; i < 20; i++)
            {
                fuseBox.CheckCureent(i);
            }
        }
    }
}
