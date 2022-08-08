using System;
using WASMClientLibrary;

namespace WASMTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WASMReader wasmReader = new WASMReader();

            Console.WriteLine(wasmReader.ExecuteWasSum(1, 3));

            Console.ReadKey();
        }
    }
}
