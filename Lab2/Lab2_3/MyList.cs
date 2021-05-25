using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_1
{
    public class MyList<T>
    {
        private T[] myCustomList = null;
        public T this[int index]
        {
            get { return myCustomList[index]; } set { myCustomList[index] = value; }
        }
        public MyList()
        {
            this.myCustomList = new T[1];
        }
        public MyList(int cnt)
        {
            this.myCustomList = new T[cnt];
        }
        public void Add(T val)
        {
            T[] temp = new T[myCustomList.Length + 1];
            temp[myCustomList.Length - 1] = val;
            myCustomList = temp;
        }
        public int Capacity { get { return myCustomList.Length; } }

    }
}
