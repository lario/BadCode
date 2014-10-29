using System.Collections.Generic;

namespace BadCode.CodeSmells
{
    internal class CS01
    {
        private class Bad
        {
            private List<Employee> _employes;

            public Employee FindAManager()
            {
                foreach (Employee item in _employes)
                {
                    if (item.Role == Role.Manager)
                        return item;
                }
                return null;
            }

            public Employee FindASupervisor()
            {
                foreach (Employee item in _employes)
                {
                    if (item.Role == Role.Supervisor)
                        return item;
                }
                return null;
            }

            public Employee FindAWorker()
            {
                foreach (Employee item in _employes)
                {
                    if (item.Role == Role.Worker)
                        return item;
                }
                return null;
            }
        }

        /// <summary>
        /// Issue: Duplicated code
        /// </summary>
        private class Good
        {
            private List<Employee> _employes;

            public Employee FindAManagerGood()
            {
                return FindAnEmployee(Role.Manager);
            }

            public Employee FindASupervisorGood()
            {
                return FindAnEmployee(Role.Supervisor);
            }

            public Employee FindAWorkerGood()
            {
                return FindAnEmployee(Role.Worker);
            }

            private Employee FindAnEmployee(Role role)
            {
                foreach (Employee item in _employes)
                {
                    if (item.Role == role)
                        return item;
                }
                return null;
            }
        }

        #region Utils

        internal class Employee
        {
            public Role Role { get; set; }
        }

        internal enum Role
        {
            Manager,
            Supervisor,
            Worker
        }

        #endregion
    }
}