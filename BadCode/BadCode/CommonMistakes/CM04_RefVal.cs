using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode.CommonMistakes
{
    class MyClass
    {
        public MyClass(int n)
        {
            this.Number = n;
        }

        public int Number { get; set; }
    }

    class CM04
    {
        static void Test(string[] args)
        {
            var obj = new MyClass(0);

            ChangeValue1(obj);
            Console.WriteLine(obj.Number);

            ChangeValue2(obj);
            Console.WriteLine(obj.Number);

            ChangeValue3(ref obj);
            Console.WriteLine(obj.Number);

            ChangeValue3(ref new MyClass(5));
            Console.WriteLine(obj.Number);
        }

        static void ChangeValue1(MyClass cls)
        {
            cls = new MyClass(1);
        }

        static void ChangeValue2(MyClass cls)
        {
            cls.Number = 2;
        }

        static void ChangeValue3(ref MyClass cls)
        {
            cls = new MyClass(3);
        }
    }

}
