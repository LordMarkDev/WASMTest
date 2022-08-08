using System;
using System.IO;
using System.Resources;
using WASMClientLibrary.Properties;
using WebAssembly;
using WebAssembly.Runtime;

namespace WASMClientLibrary
{
    public class WASMReader
    {
        public int ExecuteWasSum(int a, int b)
        {
            using (MemoryStream memoryStream = new MemoryStream((byte[])new ResourceManager(typeof(Resources)).GetObject("TestWasm")))
            {
                ImportDictionary importDictionary = new ImportDictionary();

                Instance<dynamic> webAssemblyInstance = Compile.FromBinary<dynamic>(memoryStream)(importDictionary);

                return (int)webAssemblyInstance.Exports.add(a, b);
            }
        }
    }
}
