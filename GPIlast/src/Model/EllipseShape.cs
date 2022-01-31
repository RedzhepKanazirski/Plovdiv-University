using System;
using System.Drawing;

namespace Draw
{
	/// --------------------------------------------Класът ЕЛИПСА е основен примитив, който е наследник на базовия Shape.-------------------------------------
	public class EllipseShape : Shape
	{
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		#region Constructor

		public EllipseShape(RectangleF rect) : base(rect)
		{
		}

		public EllipseShape(RectangleShape rectangle) : base(rectangle)
		{
		}
		#endregion
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Проверка за принадлежност на точка point към ЕЛИПСА.
		/// В случая на ЕЛИПСА този метод може да не бъде пренаписван, защото
		/// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
		/// дали точката е в обхващащия ЕЛИПСА на елемента (а той съвпада с
		/// елемента в този случай).
		public override bool Contains(PointF point)
		{
			if (base.Contains(point))
			{
				// Проверка дали е в обекта само, ако точката е в обхващащия ЕЛИПСА.
				// В случая на ЕЛИПСА - директно връщаме true
				float a = Width / 2;
				float b = Height / 2;
				float x0 = Location.X + a;
				float y0 = Location.Y + b;

				return Math.Pow((point.X - x0) / a, 2) + Math.Pow((point.Y - y0) / b, 2) - 1 <= 0;
			}
			else
				// Ако не е в обхващащия ЕЛИПСА, то неможе да е в обекта и => false
				return false;
		}
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Частта, визуализираща конкретния примитив.
		/// 
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawEllipse(new Pen(StrokeColor, (float)StrokeThickness), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

			
			
			//work
		//	grfx.DrawLine(new Pen(StrokeColor, (float)StrokeThickness), Rectangle.X, Rectangle.Y, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height);
			//grfx.DrawLine(new Pen(StrokeColor, (float)StrokeThickness), Rectangle.Y, Rectangle.X, Rectangle.X + Rectangle.Height+10, Rectangle.Y + Rectangle.Width);
			//grfx.DrawLine(new Pen(StrokeColor, (float)StrokeThickness), Rectangle.Y, Rectangle.X, Rectangle.Y + Rectangle.Width, Rectangle.X + Rectangle.Height);
			//grfx.DrawLine(new Pen(StrokeColor, (float)StrokeThickness), Rectangle.X, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height, Rectangle.Y);


			//?
			//grfx.DrawLine(new Pen(StrokeColor, (float)StrokeThickness), Rectangle.Y, Rectangle.X, Rectangle.Y + Rectangle.Height, Rectangle.X + Rectangle.Width);

			//fon-wrong
			//grfx.DrawRectangle(Pens.Black, Rectangle.X, Rectangle.X, Rectangle.Width, Rectangle.Width);

			//?
			//grfx.DrawLine(new Pen(StrokeColor, (float)StrokeThickness), Rectangle.X, Rectangle.Y, Rectangle.X + Rectangle.Height, Rectangle.Y + Rectangle.Width);




















			//grfx.DrawEllipse(Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
		}
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
	}
}

