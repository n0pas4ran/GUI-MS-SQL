using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace client
{
    public class CircleButton : Button// Наследуем класс кнопки и регенерируем решение, чтобы увидеть меня
    {
        protected override void OnPaint(PaintEventArgs e)// Сбрасываем форму переопределения защиты от управления re
        {
            base.OnPaint(e);// Рекурсия Этот метод выполняется каждый раз, когда он повторяется, чтобы убедиться, что его форма является настраиваемой.
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(2, 2, this.Width - 6, this.Height - 6);
            Graphics g = e.Graphics;
            Rectangle rec = new Rectangle(2, 2, Width - 6, Height - 6);
            g.DrawEllipse(new Pen(Color.Black, 2),rec);
            g.FillEllipse(new SolidBrush(Color.Coral), rec);
            Region = new Region(path);
        }
    }

}