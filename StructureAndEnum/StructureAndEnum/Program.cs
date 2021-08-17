using System;

namespace StructureAndEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book(12354,"C# 4.0","Marsh Donis"); 
            Console.WriteLine(myBook.Display());
            Console.ReadLine();
        }
    }
}
