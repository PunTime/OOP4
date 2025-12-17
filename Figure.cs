using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    /* Абстрактний клас "Фігура"
      Від нього наслідуються всі конкретні фігури */
    public abstract class Figure
    {
        /* Координати центра фігури */
        protected int x;
        protected int y;

        /* Кут повороту фігури */
        protected float angle;

        /* Об'єкт для малювання */
        protected Graphics g;

        /* Посилання на форму, щоб знати її розміри */
        protected FormCanvas canvas;

        protected Figure(int x, int y, Graphics g, FormCanvas canvas)
        {
            /* Ініціалізація координат та об'єктів */
            this.x = x;
            this.y = y;
            this.g = g;
            this.canvas = canvas;
            angle = 0;
        }

        /* Абстрактний метод малювання чорним кольором */
        public abstract void DrawBlack();

        /* Абстрактний метод "стирання" фігури кольором фону */
        public abstract void HideDrawingBackGround();

        /* Метод руху вправо
           Реалізований ТІЛЬКИ в базовому класі */
        public void MoveRight()
        {
            for (int i = 0; i < 10; i++)
            {
                /* Стираємо старе положення */
                HideDrawingBackGround();

                /* Змінюємо координату */
                x += 2;

                /* Малюємо в новому місці */
                DrawBlack();

                /* Невелика пауза для плавності руху */
                Thread.Sleep(20);
            }
        }

        /* Загальний метод руху по осях */
        public void Move(int dx, int dy)
        {
            /* Стираємо фігуру */
            HideDrawingBackGround();

            /* Змінюємо координати з обмеженням по межах форми */
            x = Math.Clamp(x + dx, 30, canvas.Width - 30);
            y = Math.Clamp(y + dy, 30, canvas.Height - 30);

            /* Малюємо знову */
            DrawBlack();
        }

        /* Метод повороту фігури */
        public void Rotate(float da)
        {
            /* Стираємо фігуру */
            HideDrawingBackGround();

            /* Змінюємо кут */
            angle += da;

            /* Малюємо з новим кутом */
            DrawBlack();
        }
    }
}
