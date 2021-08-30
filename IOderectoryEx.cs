using System;
using System.IO;

namespace IoDirctorirdDEmo
{
    class IOderectoryEx
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"D:\TEST");

            DirectoryInfo D1 = new DirectoryInfo(@"D:\TEST");

            D1.CreateSubdirectory("TEST2");
            File.Create(@"D:\TEST\SIM.txt");

            FileInfo f1 = new FileInfo(@"D:\TEST\SIM.txt");
            Console.WriteLine(f1.Exists);
            Console.WriteLine(f1.Extension);

            Console.WriteLine("WELCOME TO SVAGTECH");
            Console.WriteLine("HOW CAN WE HELP YOU");
            Console.WriteLine("THANKS FOR VISITING");
        }
    }
}
