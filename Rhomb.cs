using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    /* Клас Ромб — нащадок Figure */
    public class Rhomb : Figure
    {
        /* Довжини діагоналей */
        private int hor;
        private int vert;

        public Rhomb(int x, int y, int h, int v, Graphics g, FormCanvas canvas)
            : base(x, y, g, canvas)
        {
            hor = h;
            vert = v;
        }

        /* Формуємо вершини ромба */
        private Point[] Points()
        {
            return new Point[]
            {
                new Point(x, y - vert / 2),
                new Point(x + hor / 2, y),
                new Point(x, y + vert / 2),
                new Point(x - hor / 2, y)
            };
        }

        /* Малювання ромба */
        public override void DrawBlack()
        {
            g.DrawPolygon(Pens.Black, Points());
        }

        /* Стирання ромба */
        public override void HideDrawingBackGround()
        {
            g.DrawPolygon(canvas.BackPen, Points());
        }
    }
}
