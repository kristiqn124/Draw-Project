using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    class EllipseShape : Shape
    {
        
        #region Constructors
        public EllipseShape()
        {
         
        }

        public EllipseShape(RectangleF ellipse) : base(ellipse)
        {
        }

        public EllipseShape(EllipseShape ellipse) : base(ellipse)
        {
        }
        #endregion

        public override bool Contains(PointF point)
        {
            return base.Contains(point);
        }

        public override void DrawSelf(Graphics grfx)
        {
            Pen Border = new Pen(BorderColor, Borderwidth);
            base.DrawSelf(grfx);
            PointF point1 = new PointF(Rectangle.X+100,Rectangle.Y);
            PointF point2 = new PointF(Rectangle.Left+100,Rectangle.Bottom);
            PointF point3 = new PointF(Rectangle.X, Rectangle.Y+100);
            PointF point4 = new PointF(Rectangle.Right , Rectangle.Bottom-100);
            PointF point5 = new PointF(Rectangle.Left, Rectangle.Bottom -50);
            PointF point6 = new PointF(Rectangle.Right, Rectangle.Bottom-50 );
            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(Border, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawLine(new Pen(Color.Black),point1,point2 );
            grfx.DrawLine(new Pen(Color.Black), point3, point4);
            grfx.DrawLine(new Pen(Color.Black), point5, point6);
        }
    }
}
