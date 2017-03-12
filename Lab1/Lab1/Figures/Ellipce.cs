﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab1
{
    [Serializable]
    public class Ellipce : Figure, ISelectable, IEditable, IFillingable
    {
        public Ellipce(Pen pens, int x1, int y1, int x2, int y2) : base(pens, x1, y1, x2, y2)
        {
            isFilled = false;
            isSelected = false;

        }

        public override void Draw(Graphics gr)
        {
            var pn = new Pen(pen.color, pen.Width);
            gr.DrawEllipse(pn, new Rectangle(X1, Y1, X2 - X1, Y2 - Y1));
        }

        public void Fill(Graphics gr)
        {
            SolidBrush br = new SolidBrush(pen.color);
            gr.FillEllipse(br, X1, Y1, (X2 - X1), (Y2 - Y1));
        }

        public bool isFilled { get; set; }
        public bool isSelected { get; set; }
    }
}
