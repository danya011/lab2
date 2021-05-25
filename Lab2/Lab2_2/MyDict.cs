using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_2
{
    class MyDict<key, val>
    {
        private int cnt = 0;
        private key[] keysArray = null;
        private val[] valArray = null;
        public int Counter { get { return cnt; } }
        public void Add(key k, val v)
        {
            cnt += 1;
            Array.Resize(ref keysArray, cnt);
            Array.Resize(ref valArray, cnt);
            keysArray[cnt - 1] = k;
            valArray[cnt - 1] = v;
        }
        public val this[key k]
        {
            get
            {
                int index = 0;
                for(int i = 0; i < keysArray.Length; i++)
                {
                    if (k.Equals(keysArray[i])) index = i;
                }
                return valArray[index];
            }
        }
    }
}
