using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace BadCode.CommonMistakes
{
    class CM10_Const
    {
        public void Test()
        {
            var data = File.ReadAllText(Class.FILENAME);

            // use data
        }
    }
}
