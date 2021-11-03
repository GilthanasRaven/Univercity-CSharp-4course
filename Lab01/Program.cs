using System;

using Lab01.Bridge;
using Lab01.SingleFactory;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            CorvetteSingleFactory mainfactory = CorvetteSingleFactory.getInstance();
            Corvette A1 = mainfactory.CreateCorvette();
            Corvette A2 = mainfactory.CreateCorvette();

            foreach(var part in A1.Parts)
            {
                Console.WriteLine(part.Name);
            }
            
        }
    }
}
