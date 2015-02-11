using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            var name = ClassLibrary1.Class1.GetName();
            System.Console.WriteLine(string.Format("Name: {0}"),name);

        }
    }
}
