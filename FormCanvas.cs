using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    /* Форма для малювання та керування фігурою */
    public class FormCanvas : Form
    {
        private Figure fig;
        private FormSelect backForm;

        /* Ручка для стирання кольором фону */
        public Pen BackPen { get; }

        public FormCanvas(string type, FormSelect back)
        {
            backForm = back;

            Width = 800;
            Height = 600;

            /* Увімкнення плавного малювання */
            DoubleBuffered = true;

            /* Дозволяє формі ловити натискання клавіш */
            KeyPreview = true;

            Text = "Рух фігури (WASD, Q/E)";

            /* Створюємо ручку кольору фону */
            BackPen = new Pen(BackColor, 2);

            /* Кнопка повернення */
            var btnBack = new Button { Text = "Назад", Left = 10, Top = 10 };
            btnBack.Click += (_, __) => { Close(); backForm.Show(); };
            Controls.Add(btnBack);

            /* Отримуємо об'єкт для малювання */
            var g = CreateGraphics();

            /* Створення фігури залежно від вибору */
            fig = type switch
            {
                "circle" => new Circle(400, 300, 40, g, this),
                "square" => new Square(400, 300, 80, g, this),
                _ => new Rhomb(400, 300, 100, 60, g, this)
            };

            /* Малюємо фігуру */
            fig.DrawBlack();

            /* Обробка натискань клавіш */
            KeyDown += OnKey;
        }

        /* Реакція на клавіші */
        void OnKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) fig.Move(0, -5);
            if (e.KeyCode == Keys.S) fig.Move(0, 5);
            if (e.KeyCode == Keys.A) fig.Move(-5, 0);
            if (e.KeyCode == Keys.D) fig.Move(5, 0);
            if (e.KeyCode == Keys.Q) fig.Rotate(-5);
            if (e.KeyCode == Keys.E) fig.Rotate(5);
        }
    }
}
