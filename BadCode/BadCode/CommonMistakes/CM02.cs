using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode.CommonMistakes
{
    class CM02
    {
        #region Concaternation

        void Bad1()
        {
            string result = string.Empty;

            for (int i = 0; i < 10000; i++)
            {
                result += i;
            }
        }

        void Good()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 10000; i++)
            {
                result.Append(i.ToString());
            }
        }

        #endregion

        #region Format

        void Bad()
        {
            var elementType = "Employer";
            var id = 1;

            var result = "Are you sure you want to remove " + elementType + " with id: " + id + "?";
        }

        void Good()
        {
            var elementType = "Employer";
            var id = 1;

            var result = String.Format("Are you sure you want to remove {0} with id: {1}?", elementType, id);
        }

        #endregion

        #region ML String

        void Bad()
        {
            var result = "SELECT column_name, aggregate_function(column_name) " +
                            "FROM table_name " +
                            "WHERE column_name operator value " +
                            "GROUP BY column_name;";
        }

        void Good()
        {
            var result = @"SELECT column_name, aggregate_function(column_name)
                            FROM table_name
                            WHERE column_name operator value
                            GROUP BY column_name;";
        }

        #endregion

        #region Concat list

        void Bad()
        {
            var values = new string[]{"value1", "value2", "value3"};

            var result = String.Empty;

            for (int i = 0; i < values.Length; i++)
            {
                result += values[i];

                if (i < values.Length - 1)
                    result += ",";
            }
        }

        void Bad()
        {
            var values = new string[] { "value1", "value2", "value3" };

            var result = String.Empty;

            for (int i = 0; i < values.Length; i++)
            {
                result += values[i] + ",";
            }

            result.TrimEnd(',');
        }

        void Good()
        {
            var values = new string[] { "value1", "value2", "value3" };

            var result = String.Join(",", values);
        }

        #endregion

        #region Comparison

        //show in turkey

        #endregion
    }
}
