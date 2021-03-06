using System;
using System.Drawing;

namespace Draw
{
	///------------------------------------------ Класът КРЪГ е основен примитив, който е наследник на базовия Shape.---------------------------------------
	public class CircleShape : Shape
	{
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		#region Constructor

		public CircleShape(RectangleF rect) : base(rect)
		{
		}

		public CircleShape(RectangleShape rectangle) : base(rectangle)
		{
		}
		#endregion
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Проверка за принадлежност на точка point към КРЪГ.
		/// В случая на КРЪГ този метод може да не бъде пренаписван, защото
		/// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
		/// дали точката е в обхващащия КРЪГ на елемента (а той съвпада с
		/// елемента в този случай).
		/// 
		public override bool Contains(PointF point)
		{
			if (base.Contains(point))
				// Проверка дали е в обекта само, ако точката е в обхващащия КРЪГ.
				// В случая на КРЪГ - директно връщаме true
				return true;
			else
				// Ако не е в обхващащия КРЪГ, то неможе да е в обекта и => false
				return false;
		}
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Частта, визуализираща конкретния примитив.

		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawEllipse(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
		}
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
	}
}