using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode.CommonMistakes
{
    class CM01
    {
        #region Bad

        public void Bad1()
        {
            string input = Console.ReadLine();

            var result = int.Parse(input);
        } 

        #endregion

        #region Bad

        public void Bad2()
        {
            string input = Console.ReadLine();

            int result;
            try
            {
                result = int.Parse(input);
            }
            catch (Exception)
            {
                result = 0;
            }            
        } 

        #endregion

        #region Good

        public void Good()
        {
            string input = Console.ReadLine();

            int result;
            if (Int32.TryParse(input, out result))
            {
                // use the value
            }
        } 

        #endregion
    }
}
