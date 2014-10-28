using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode.CommonMistakes
{
    class CM08_Nplus1
    {
        class Employee
        {
            public int Id { get; set; }

            public Contract Contract { get; set; }
        }

        class Contract
        {
            public int Id { get; set; }

            public decimal Amount { get; set; }
        }

        public void Test()
        {
            var employees = EmployeeRepository.GetAllEmployees();

            decimal sum = 0;

            foreach (var employee in employees)
            {
                sum += employee.Contract.Amount;
            }
        }

        #region ...

        class EmployeeRepository
        {
            public static List<Employee> GetAllEmployees() { return null; }
        }

        #endregion
    }

}
