using System;

namespace Loop
{
    public class Student
    {
        public int id;
        public int age;
    }
    class Program
    {
        static int FindMax(int a, int b)
        {
            return ((a > b)) ? a : b;
        }
        static void Main(string[] args)
        {
            int i = 0;
            for (; i < 10;)
            {
                Console.WriteLine("Hello  ");
                i++;
            }
            Console.WriteLine("Max is: {0}", FindMax(5, 9));

            Student A = new Student();
            A.age = 10;
            A.id = 123;
            Console.WriteLine("A: {0}", A.age);
            Console.ReadKey();
        }
    }
}
