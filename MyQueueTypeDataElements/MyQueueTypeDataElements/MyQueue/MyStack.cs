using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyQueueType
{
    public class MyStack : MyQueueElementBase
    {
        public MyStack(): base()
        {
        }

        public MyStack(int _capasity, int _growFac) : base(capasity: _capasity, growFac: _growFac)
        {
        }
        public override object Peek()
        {
            if (this.myArr[this.Count] != null)
            {
                return this.myArr[Count];
            }
            return null;
        }

        public void Push(object element)
        {
            if (this.Count == this.Length - 2)
            {
                this.Resize();
            }
            this.myArr[this.index] = element;
            ++this.index;
        }

        public object Pop()
        {
            object obj = this.myArr[Count-1];

            for (int i = 0; i <= this.Count-1; i++)
            {
                this.myArr[i] = this.myArr[i];
            }
            for (int i = this.Count - 1; i < this.myArr.Length -1; i++)
            {
                this.myArr[i] = null;
            }

            index--;

            return obj;
        }
    }
}
