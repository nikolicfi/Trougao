using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trougao
{
    internal class Trougao
    {
        #region atributi
        public Point o;
        public int a;
        #endregion

        #region svojstva
        public Point O
        {
            get { return o; }
        }
        public int A
        {
            get { return a; }
            set
            {
                if (value < 0)
                    throw new Exception("Duzina stranice mora da bude >0");
                else a = value;
            }
        }
        public Double Acm
        {
            get { return a / 37.8; }
        }
        public virtual Point[] P
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

        #region konstruktori
        public Trougao()
        {
            o.X = 0;
            o.Y = 0;
            a = 0;
        }
        public Trougao(Point o)
        {
            this.o = new Point(o.X, o.Y);
            a = 0;
        }
        public Trougao(Point o, int a)
        {
            this.o = new Point(o.X, o.Y);
            A = a;
        }
        #endregion

        #region metode 
        public void Crtaj(Graphics g, Color boja)
        {
            Pen olovka = new Pen(boja, 2);
            g.DrawPolygon(olovka, P);
        }
        public void Boji(Graphics g, Color boja)
        {
            SolidBrush cetka = new SolidBrush(boja);
            g.FillPolygon(cetka, P);
        }
        #endregion
    }
}
