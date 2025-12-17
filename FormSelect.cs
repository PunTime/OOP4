using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    /* Форма вибору фігури */
    public class FormSelect : Form
    {
        public FormSelect()
        {
            Text = "Вибір фігури";
            Width = 300;
            Height = 250;

            /* Кнопки вибору */
            var btnCircle = new Button { Text = "Коло", Top = 30, Width = 200, Left = 40 };
            var btnSquare = new Button { Text = "Квадрат", Top = 80, Width = 200, Left = 40 };
            var btnRhomb = new Button { Text = "Ромб", Top = 130, Width = 200, Left = 40 };

            /* Обробники натискання */
            btnCircle.Click += (_, __) => OpenCanvas("circle");
            btnSquare.Click += (_, __) => OpenCanvas("square");
            btnRhomb.Click += (_, __) => OpenCanvas("rhomb");

            Controls.AddRange(new[] { btnCircle, btnSquare, btnRhomb });
        }

        /* Відкриття форми з малюванням */
        void OpenCanvas(string type)
        {
            Hide();
            new FormCanvas(type, this).Show();
        }
    }
}
