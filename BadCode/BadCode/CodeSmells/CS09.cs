using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode.CodeSmells
{
    class CS09
    {
        class Rectangle
        {
            public int Width { get; set; }

            public int Height { get; set; }
        }

        class Canvas
        {
            private Rectangle Shape { get; set; }

            void DoWork()
            {
                var area = Shape.Height * Shape.Width;
            }
        }
    }


    class CS09Good
    {
        // feature envy
        class Rectangle
        {
            public int Width { get; set; }

            public int Height { get; set; }

            public int Area()
            {
                return Height * Width;
            }
        }

        class Canvas
        {
            private Rectangle Shape { get; set; }

            void DoWork()
            {
                var area = Shape.Area();
            }
        }
    }
}
