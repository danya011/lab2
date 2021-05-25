using System;

namespace Lab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> IntType = new MyClass<int>();
            MyClass<char> CharType = new MyClass<char>();
            MyClass<float> FloatType = new MyClass<float>();
            foreach(dynamic elem in new dynamic[] { IntType, CharType, FloatType})
            {
                Console.WriteLine(elem.ToString());
            }
            
        }
    }
}
