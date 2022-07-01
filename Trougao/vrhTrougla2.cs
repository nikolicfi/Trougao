using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Trougao
{
    class vrhTrougla2 : Trougao
    {
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


        #region konstruktori
        public vrhTrougla2()
            : base()
        {

        }

        public vrhTrougla2(Point o)
            : base(o)
        {

        }

        public vrhTrougla2(Point o, int a)
            : base(o, a)
        {

        }
        #endregion
    }
}
