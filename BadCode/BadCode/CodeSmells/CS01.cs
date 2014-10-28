using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode.CodeSmells
{
    class CS01
    {
        private List<Employee> _employes;

        #region Bad
        public Employee FindAManager()
        {
            foreach (var item in _employes)
            {
                if (item.Role == Role.Manager)
                    return item;
            }
            return null;
        }

        public Employee FindASUpervisor()
        {
            foreach (var item in _employes)
            {
                if (item.Role == Role.Supervisor)
                    return item;
            }
            return null;
        }

        public Employee FindAWorker()
        {
            foreach (var item in _employes)
            {
                if (item.Role == Role.Worker)
                    return item;
            }
            return null;
        } 
        #endregion

        #region Good


        public Employee FindAManagerGood()
        {
            return FindAnEmployee(Role.Manager);
        }

        public Employee FindASUpervisorGood()
        {
            return FindAnEmployee(Role.Supervisor);
        }

        public Employee FindAWorkerGood()
        {
            return FindAnEmployee(Role.Worker);
        }

        public Employee FindAnEmployee(Role role)
        {
            foreach (var item in _employes)
            {
                if (item.Role == role)
                    return item;
            }
            return null;
        } 

        #endregion
    }

    class Employee
    {
        public Role Role { get; set; }
    }

    enum Role
    {
        Manager,
        Supervisor,
        Worker
    }
}
