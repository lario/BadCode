using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode.CommonMistakes
{
    class CM11_Conditions
    {
        private const DateTime SUMMER_START = new DateTime(2014, 6, 1);
        private const DateTime SUMMER_END = new DateTime(2014, 9, 1);

        private decimal _winterRate;
        private decimal _summerRate;
        private decimal _winterServiceCharge;

        #region Bad
        public void Bad(int quantity)
        {
            var date = DateTime.Now;
            decimal charge = 0;

            if (date < SUMMER_START || date > SUMMER_END)
            {
                charge = quantity * _winterRate + _winterServiceCharge;
            }
            else
            {
                charge = quantity * _summerRate;
            }
        } 
        #endregion

        #region Good
        public void Good(int quantity)
        {
            decimal charge = 0;

            if (NotSummer(DateTime.Now))
            {
                charge = quantity * _winterRate + _winterServiceCharge;
            }
            else
            {
                charge = quantity * _summerRate;
            }
        }

        private bool NotSummer(DateTime date)
        {
            return date < SUMMER_START || date > SUMMER_END;
        } 
        #endregion
    }
}
