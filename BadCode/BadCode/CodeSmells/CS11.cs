using System;

namespace BadCode.CodeSmells
{
    internal class CS11
    {
        private class Bad
        {
            private class Person
            {
                public Person(Role role)
                {
                    Role = role;
                }

                private Role Role { get; set; }

                private int getTaxForSalary(int salary)
                {
                    switch (Role)
                    {
                        case Role.Teacher:
                            return salary;
                        case Role.Assistent:
                            return salary/2;
                        case Role.Student:
                            return 0;
                        default:
                            throw new NotSupportedException();
                    }
                }
            }
        }

        /// <summary>
        /// Switch statements
        /// </summary>
        private class Good
        {
            public interface ITaxCalculator
            {
                int Calculate(int salary);
            }

            public class AssistentTaxCalculator : ITaxCalculator
            {
                public int Calculate(int salary)
                {
                    return salary/2;
                }
            }

            public class StudentTaxCalculator : ITaxCalculator
            {
                public int Calculate(int salary)
                {
                    return 0;
                }
            }

            public class TeacherTaxCalculator : ITaxCalculator
            {
                public int Calculate(int salary)
                {
                    return salary;
                }
            }

            public static class TaxCalculatorFactory
            {
                public static ITaxCalculator GetAlgorithm(Role role)
                {
                    switch (role)
                    {
                        case Role.Teacher:
                            return new TeacherTaxCalculator();
                        case Role.Assistent:
                            return new AssistentTaxCalculator();
                        case Role.Student:
                            return new StudentTaxCalculator();
                        default:
                            throw new NotSupportedException();
                    }
                }
            }

            private class Person
            {
                private readonly ITaxCalculator taxCalculator;

                public Person(Role role)
                {
                    Role = role;
                    taxCalculator = TaxCalculatorFactory.GetAlgorithm(role);
                }

                private Role Role { get; set; }

                protected virtual int getTaxForSalary(int salary)
                {
                    return taxCalculator.Calculate(salary);
                }
            }
        }

        #region Utils

        private enum Role
        {
            Student,
            Teacher,
            Assistent
        }

        #endregion
    }
}