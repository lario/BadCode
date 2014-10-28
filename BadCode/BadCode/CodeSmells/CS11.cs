using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode.CodeSmells
{
    class CS11Bad
    {
        enum Role
        {
            Student,
            Teacher, 
            Assistent
        }

        class Person
        {
            public Person(Role role)
            {
                this.Role = role;
            }

            private Role Role { get; set; }

            int getTaxForSalary(int salary)
            {
                switch (this.Role)
                {
                    case CS11Bad.Role.Teacher:
                        return salary;
                    case CS11Bad.Role.Assistent:
                        return salary / 2;
                    case CS11Bad.Role.Student:
                        return 0;
                    default:
                        throw new NotSupportedException();
                }
            }

        }
    }

    class CS11Good
    {
        enum Role
        {
            Student,
            Teacher,
            Assistent
        }

        class Person
        {
            interface ITaxCalculator
            {
                int Calculate(int salary);
            }

            class TeacherTaxCalculator : ITaxCalculator
            {
                public int Calculate(int salary)
                {
                    return salary;
                }
            }

            class AssistentTaxCalculator : ITaxCalculator
            {
                public int Calculate(int salary)
                {
                    return salary/2;
                }
            }

            class StudentTaxCalculator : ITaxCalculator
            {
                public int Calculate(int salary)
                {
                    return 0;
                }
            }

            static class TaxCalculatorFactory
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


            private ITaxCalculator taxCalculator;


            public Person(Role role)
            {
                this.Role = role;
                this.taxCalculator = TaxCalculatorFactory.GetAlgorithm(role);
            }

            private Role Role { get; set; }

            protected virtual int getTaxForSalary(int salary)
            {
                return this.taxCalculator.Calculate(salary);
            }

        }
    }
}
