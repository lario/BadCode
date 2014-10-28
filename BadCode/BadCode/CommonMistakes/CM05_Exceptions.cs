using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode.CommonMistakes
{
    class CM05
    {
        public void Bad(string filename)
        {
            try
            {
                File.ReadAllText(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show("File doesn't exist");
            }
        }

        public void Bad2()
        {
            try
            {
                //some code that can throw exception [...]
            }
            catch (Exception ex)
            {
                //some exception logic [...]
                throw ex;
            }
        }
    }

    class MessageBox
    {
        public static void Show(string message)
        {
        }
    }
}
