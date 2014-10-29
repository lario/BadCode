using System;

namespace BadCode.CommonMistakes
{
    internal class CM04
    {
        internal class MyClass
        {
            public MyClass(int n)
            {
                Number = n;
            }

            public int Number { get; set; }
        }

        private static void Test(string[] args)
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

        private static void ChangeValue1(MyClass cls)
        {
            cls = new MyClass(1);
        }

        private static void ChangeValue2(MyClass cls)
        {
            cls.Number = 2;
        }

        private static void ChangeValue3(ref MyClass cls)
        {
            cls = new MyClass(3);
        }
    }
}