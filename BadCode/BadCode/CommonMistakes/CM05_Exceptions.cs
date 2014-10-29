using System;
using System.IO;

namespace BadCode.CommonMistakes
{
    internal class CM05
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

        #region Utils
        private class MessageBox
        {
            public static void Show(string message)
            {
            }
        }
        #endregion
    }
}