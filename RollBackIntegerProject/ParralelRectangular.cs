using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollBackIntegerProject
{
    class ParralelRectangular
    {
        public Point leftTop;
        public Point rightBottom;

        public ParralelRectangular(Point leftTop, Point rightBottom)
        {
            this.leftTop = leftTop;
            this.rightBottom = rightBottom;
        }

        public bool IsInsideOf(ParralelRectangular rect)
        {
            if(((leftTop.X >= rect.leftTop.X) && (leftTop.Y <= rect.leftTop.Y)) 
                && ((rightBottom.X <= rect.rightBottom.X) && (rightBottom.Y >= rect.rightBottom.Y)))
            {
                return true;
            }
            return false;
        }

        public bool DoesCross(ParralelRectangular rect)
        {
            if (leftTop.Y < rect.rightBottom.Y || rightBottom.Y > rect.leftTop.Y ||
                rightBottom.X < rect.leftTop.X || leftTop.X > rect.rightBottom.X)
            {
                return false;
            }

            return true;
        }
    }
}
