using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkEnum
{
    static class ClassStatics
    {
        private static int _i = 0;

        public static string J { get; set; }

        public static void Method()
        {
            Console.WriteLine("Static Method");
        }
    }
}
