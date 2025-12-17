using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    /* Клас Квадрат — нащадок Figure */
    public class Square : Figure
    {
        /* Довжина сторони квадрата */
        private int side;

        public Square(int x, int y, int side, Graphics g, FormCanvas canvas)
            : base(x, y, g, canvas)
        {
            this.side = side;
        }

        /* Малювання квадрата */
        public override void DrawBlack()
        {
            g.DrawRectangle(Pens.Black,
                x - side / 2,
                y - side / 2,
                side,
                side);
        }

        /* Стирання квадрата */
        public override void HideDrawingBackGround()
        {
            g.DrawRectangle(canvas.BackPen,
                x - side / 2,
                y - side / 2,
                side,
                side);
        }
    }
}
