using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode.CodeSmells
{
    class CS10
    {
        class Canvas
        {
            public int X1;
            public int Y1;

            public int X2;
            public int Y2;

            public void DrawLine(int xFrom, int yFrom, int xTo, int yTo)
            {
                // 
            }

            public void DrawTringle(int x1, int y1, int x2, int y2, int x3, int y3)
            {
                //
            }
        }
    }

    class CS10Good
    {
        // data clumps
        class Point
        {
            int X { get; set; }
            int Y { get; set; }
        }

        class Canvas
        {
            public Point point1;
            public Point point2;

            public void DrawLine(Point from, Point to)
            {
                // 
            }

            public void DrawTringle(Point v1, Point v2, Point v3)
            {
            }
        }
    }
}
