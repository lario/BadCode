using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using NUnit.Framework;

namespace BadCode.CommonMistakes
{
    [TestFixture]
    class CM10_Const
    {
        [Test]
        public static void Test()
        {
            var data = File.ReadAllText(Class.FILENAME);

            Console.WriteLine(data);
        }
    }
}
