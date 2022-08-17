using System;
using System.Collections.Generic;
using System.Text;

namespace ThrowFuseExample_Event_
{
    public delegate void DlgFuse(int instanceCurrent);
    public class FuseBox
    {
        private event DlgFuse ThrowFuseEvent;
        private string Type { get; set; }
        private int FuseCurrent { get; set; }

        public FuseBox(string _type, int _fuseCurrent)
        {
            Type = _type;
            FuseCurrent = _fuseCurrent;
        }

        public void CheckCureent(int _instanceCurrent)
        {
            ThrowFuseEvent += new DlgFuse(Throw_Fuse);

            if (_instanceCurrent > FuseCurrent)
            {
                if (ThrowFuseEvent != null)
                {
                    ThrowFuseEvent.Invoke(_instanceCurrent);
                    //ThrowFuseEvent();
                } 
            }
            else
            {
                Console.WriteLine($"{Type}, {_instanceCurrent}");
            }
        }

        private void Throw_Fuse(int instanceCurrent)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Throw Fuse {instanceCurrent}, {Type}");
            Console.ResetColor();
        }
    }
}
