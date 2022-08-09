using System;
using System.Collections;
using System.Text;

namespace MyQueueType
{
    public abstract class MyQueueElementBase : IMyQueueElement
    {
        protected object[] myArr;
        protected int index = 0;
        protected int growFac = 2;
        protected int count;

        public int GrowFac 
        {
            get
            {
                return growFac;
            }
            set
            {
                growFac = value;
            }
        }

        public int Length 
        {
            get { return myArr.Length; } 
        }

        public int Count 
        {
            get
            {
                count = 0;

                for (int i = 0; i < myArr.Length-1; ++i)
                {
                    if (myArr[i] != null)
                    {
                        count++;
                    }
                }

                return count;
            }
        }


        public MyQueueElementBase()
        {
            myArr = new object[5];
        }

        public MyQueueElementBase(int capasity, int growFac)
        {
            myArr = new object[capasity];
            this.growFac = growFac;
        }

        public void Clear()
        {
            if (growFac>0)
            {
                myArr = new object[growFac];
            }
            else
            {
                myArr = new object[5];
            }
        }

        public object[] Clone()
        {
            object[] newArr = new object[this.Count+1];

            for (int i = 0; i < Count; ++i)
            {
                newArr[i] = myArr[i];
            }

            return newArr;
        }

        public bool Contains(object obj)
        {
            bool flag = false;

            foreach (var element in myArr)
            {
                if (obj == element)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }

        public object IndexOf(int index)
        {
            object elements;
            if (index >= 0)
            {
                elements = myArr[index];
            }
            else
            {
                elements = null;
            }

            return elements;
        }

        public void Resize()
        {

            Array.Resize(ref myArr, (myArr.Length * growFac)); 
        }

        public abstract object Peek();
        

    }
}
