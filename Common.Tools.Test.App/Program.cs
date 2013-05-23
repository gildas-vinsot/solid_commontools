using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Tools.Test.Hash;

namespace Common.Tools.Test.App
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTest test = new HashTest();
            test.TestMethodGetHashCode();
        }
    }
}
