using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
          A obA = new A();
          obA.TEST();
        }
    }

    class A
    {
      static void Test()
      {
          Console.WriteLine("こんにちは");
      }
    }
}
