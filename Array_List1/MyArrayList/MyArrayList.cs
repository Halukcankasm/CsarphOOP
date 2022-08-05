using System;

namespace CreateArrayList
{
    public class MyArrayList
    {
        private object[] myArrayList;
        private int index = 0;

        public int Length 
        {
            get { return myArrayList.Length; }
        }

        public int UnNullOfNumnerElemant //Uzunluk
        {
            get
            {
                var u = 0;
                for (int i = 0; i <= myArrayList.Length-1; i++)
                {
                    if (myArrayList[i] != null)
                    {
                        u++;
                    }
                }

                return u;
            }
        }

        public object this[int index] 
        {
            get { return myArrayList[index]; }
        }
        public MyArrayList()
        {
            myArrayList = new object[5];
        }

        public MyArrayList(int arrayLength)
        {
            myArrayList = new object[arrayLength-1];
        }


        public void Add(object eleman)
        {
            CheckLengthOfArray();
            myArrayList[index] = eleman;
            ++index;
        }


        private void CheckLengthOfArray()
        {
            if (index == (myArrayList.Length -1))
            {
                Array.Resize(ref myArrayList, (myArrayList.Length * 2));
            }
        }

        public bool Contains(object eleman)
        {
            bool flag = false;
            for (int i = 0; i < myArrayList.Length; i++)
            {
                if (eleman == myArrayList[i])
                {
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }

        public int IndexOf(object eleman)
        {
            int index = -1;
            for (int i = 0; i < myArrayList.Length; i++)
            {
                if (myArrayList[i] == eleman)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void DeleteEleman(object eleman)
        {
            int index = IndexOf(eleman);
            object[] tmp;

            if (index == -1)
            {
                return;
            }
            else
            {
                tmp = new object[myArrayList.Length - 1];

                for (int i = 0; i < index; ++i)
                {
                    tmp[i] = myArrayList[i];
                }

                for (int i = index; i < myArrayList.Length -1; ++i)
                {
                    tmp[i] = myArrayList[i+1];
                }
            }

            myArrayList = tmp;
        }

        public void Crop()
        {
            object[] tmp = new object[this.UnNullOfNumnerElemant];
            for (int i = 0; i <= this.UnNullOfNumnerElemant -1; ++i)
            {
                tmp[i] = myArrayList[i];
            }
            Array.Resize(ref myArrayList, this.UnNullOfNumnerElemant);
            myArrayList = tmp;
            
        }

        public void Reverse()
        {
            int index = 0;
            object[] tmp = new object[this.UnNullOfNumnerElemant];
            for (int i = this.UnNullOfNumnerElemant-1; i >= 0; --i)
            {
                tmp[index] = myArrayList[i];
                index++;
            }
            myArrayList = tmp;

        }
    }
}
