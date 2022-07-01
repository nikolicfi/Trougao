using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Trougao
{
    class vrhTrougla1 : Trougao
    {
        #region konstruktori
        public vrhTrougla1()
            : base()
        {

        }

        public vrhTrougla1(Point o)
            : base(o)
        {

        }

        public vrhTrougla1(Point o, int a)
            : base(o, a)
        {

        }
        #endregion
        #region svojstva
        public override Point[] P
        {
            get
            {
                Point[] p = new Point[3];
                p[0] = new Point(o.X, (int)(o.Y - a * Math.Sqrt(3) / 3));
                p[1] = new Point(o.X + a / 2, (int)(o.Y + a * Math.Sqrt(3) / 6));
                p[2] = new Point(o.X - a / 2, (int)(o.Y + a * Math.Sqrt(3) / 6));
                return p;
            }
        }
        #endregion 
    }
}
