using System;
using System.Linq;

namespace MyQueueType
{
    public class MyQueue : MyQueueElementBase
    {
        public MyQueue(): base()
        {
        }
        public MyQueue(int _capasity,int _growFac): base(capasity:_capasity, growFac: _growFac)
        {
        }
        public override object Peek()
        {
            if (this.myArr[0] != null)
            {
                return this.myArr[0];
            }
            return null;
        }

        public void Enqueue(object element)
        {
            if (this.Count == this.Length - 2)
            {
                this.Resize();
            }
            this.myArr[this.index] = element;
            ++this.index;
        }

        public object Dequeue()
        {
            object obj =  this.myArr.First();

            for (int i = 0; i <= this.Count; i++)
            {
                this.myArr[i] = this.myArr[i + 1];
            }

            index--;

            return obj;
        }
    }
}
