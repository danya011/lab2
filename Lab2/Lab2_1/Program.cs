using System;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> intList = new MyList<int>();
            int iter = 0;
            foreach(int val in new int[3] { 1, 3, 5 })
            {
                intList.Add(val);
                Console.WriteLine(intList[iter]);
                iter++;
            }
        }
    }
}
