using System;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<string, int> Ages = new MyDict<string, int>();
            Ages.Add("danya", 20);
            Console.WriteLine(Ages["danya"]);

        }
    }
}
