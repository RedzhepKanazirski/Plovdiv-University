using System;
using System.Drawing;

namespace Draw
{
	///--------------------------------------- Класът КВАДРАТ е основен примитив, който е наследник на базовия Shape.-----------------------------------------
	public class PolygonSimple : Shape
	{
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		#region Constructor

		public PolygonSimple(RectangleF rect) : base(rect)
		{
		}

		public PolygonSimple(RectangleShape rectangle) : base(rectangle)
		{
		}

        public PolygonSimple(Shape shape) : base(shape)
        {
        }

        public PolygonSimple(Point point1, Point point2, Point point3, int v1, int v2)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            V1 = v1;
            V2 = v2;
        }

        public Point Point1 { get; }
        public Point Point2 { get; }
        public Point Point3 { get; }
        public int V1 { get; }
        public int V2 { get; }

        #endregion
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        /// Проверка за принадлежност на точка point към КВАДРАТ.
        /// В случая на правоъгълник този метод може да не бъде пренаписван, защото
        /// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
        /// дали точката е в обхващащия КВАДРАТ на елемента (а той съвпада с
        /// елемента в този случай).
        /// </summary>
        public override bool Contains(PointF point)
		{
			if (base.Contains(point))
				// Проверка дали е в обекта само, ако точката е в обхващащия КВАДРАТ.
				// В случая на правоъгълник - директно връщаме true
				return true;
			else
				// Ако не е в обхващащия КВАДРАТ, то неможе да е в обекта и => false
				return false;
		}
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Частта, визуализираща конкретния примитив.
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			Point[] p =
			{
				new Point((int)Rectangle.X+((int)Rectangle.Width),(int)Rectangle.Y),
				new Point((int)Rectangle.X,(int)(Rectangle.Y+Rectangle.Height)),
			    new Point((int)(Rectangle.X + Rectangle.Width), (int)(Rectangle.Y+ Rectangle.Height))
			};

			grfx.FillPolygon(new SolidBrush(FillColor),p);
			grfx.DrawPolygon(new Pen(StrokeColor, (float)StrokeThickness), p);
			
			
			//grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			//grfx.DrawRectangle(new Pen(StrokeColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

			//grfx.DrawLine(new Pen(StrokeColor, (float)StrokeThickness), Rectangle.X, Rectangle.Y, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height);

		}
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
	}
}
