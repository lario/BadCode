﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode.CommonMistakes
{
    class CM06
    {
        #region Bad
        public void Bad()
        {
            SqlConnection connection = new SqlConnection("");

            connection.Open();

            // use the connection

            connection.Close();
        } 
        #endregion

        #region Good
        public void Good()
        {
            using (SqlConnection connection = new SqlConnection(""))
            {
                connection.Open();

                // use the connection
            }
        } 
        #endregion
    }
}
