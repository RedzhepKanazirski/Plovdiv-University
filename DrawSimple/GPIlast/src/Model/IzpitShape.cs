using System;
using System.Drawing;

namespace Draw
{
	///--------------------------------------- Класът КВАДРАТ е основен примитив, който е наследник на базовия Shape.-----------------------------------------
	public class IzpitShape : Shape
	{
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		#region Constructor

		public IzpitShape(RectangleF rect) : base(rect)
		{
		}

		public IzpitShape(RectangleShape rectangle) : base(rectangle)
		{
		}

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



			// Point[] p1 = { new Point(100, 100), new Point(200, 100), new Point(200, 50), new Point(50, 0) };

			Point[] p = {
				new Point((int)Rectangle.X + ((int)Rectangle.Width / 2), (int)Rectangle.Y),
				new Point((int)Rectangle.X, (int)(Rectangle.Y + Rectangle.Height)),
				new Point((int)(Rectangle.X + Rectangle.Width ), (int)(Rectangle.Y + Rectangle.Height )),
				new Point((int)(Rectangle.X + Rectangle.Width ),(int)Rectangle.Y  )
				};


			grfx.FillPolygon(new SolidBrush(FillColor), p);
			grfx.DrawPolygon(new Pen(StrokeColor, (float)StrokeThickness), p);
			
			grfx.DrawLine(new Pen(StrokeColor, (float)StrokeThickness), Rectangle.X + Rectangle.Height, Rectangle.Y + Rectangle.Height, Rectangle.X + (Rectangle.Width / 4), Rectangle.Y + (Rectangle.Height / 4));
			grfx.DrawLine(new Pen(StrokeColor, (float)StrokeThickness), Rectangle.X, Rectangle.Y, Rectangle.X + (Rectangle.Width / 4), Rectangle.Y + (Rectangle.Height / 4));
			grfx.DrawLine(new Pen(StrokeColor, (float)StrokeThickness), Rectangle.X + Rectangle.Height, Rectangle.Y + (Rectangle.Width / 4), Rectangle.X + (Rectangle.Width), Rectangle.Y + (Rectangle.Height / 4));


			grfx.ResetTransform();
		}
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
	}
}

