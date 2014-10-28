using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode.CommonMistakes
{
    class CM07
    {
        public void Bad()
        {
            var list = new List<dynamic>();

            var exists = list.Where(x => x.Something == 1).Count() > 0;

            var first = list.Where(x => x.Somthing == 1).First();
        }

        public void Good()
        {
            // ...
        }
    }
}
