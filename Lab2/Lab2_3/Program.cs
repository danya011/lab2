using System;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> intList = new MyList<int>(5);
            for (int i = 0; i < intList.Capacity; i++) {
                intList[i] = i;
                Console.WriteLine(intList.GetArray()[i]);
            }
        }
    }
    public static class StaticClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] tmp = new T[list.Capacity];
            for(int i = 0; i < list.Capacity; i++)
            {
                tmp[i] = list[i];
            }
            return tmp;
        }
    }
}
