using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    class Line : Shape
    {
        #region Constructor
        public Line( PointF x1, PointF y1)
        {
            x = x1;
            y = y1;
        }

        public Line(RectangleF line) : base(line)
        {
        }

        public Line(Line line) : base(line)
        {
        }
        #endregion
        #region Properties
        public PointF x { get; set; }
        public PointF y { get; set; }

        #endregion

        public override bool Contains(PointF point)
        {
            return base.Contains(point);
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);
            grfx.DrawLine(new Pen(Color.Black), x.X, x.Y, y.X, y.Y);
        }
    }
}
