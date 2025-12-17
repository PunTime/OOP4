using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    /* Клас Коло — нащадок Figure */
    public class Circle : Figure
    {
        /* Радіус кола */
        private int radius;

        public Circle(int x, int y, int r, Graphics g, FormCanvas canvas)
            : base(x, y, g, canvas)
        {
            /* Задаємо радіус */
            radius = r;
        }

        /* Малювання кола чорним кольором */
        public override void DrawBlack()
        {
            g.DrawEllipse(Pens.Black,
                x - radius,
                y - radius,
                radius * 2,
                radius * 2);
        }

        /* Стирання кола кольором фону */
        public override void HideDrawingBackGround()
        {
            g.DrawEllipse(canvas.BackPen,
                x - radius,
                y - radius,
                radius * 2,
                radius * 2);
        }
    }
}
