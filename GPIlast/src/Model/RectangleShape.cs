using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Draw
{
	///--------------------------- Класът правоъгълник е основен примитив, който е наследник на базовия Shape.-------------------------------------------------------
	public class RectangleShape : Shape
	{
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		#region Constructor

		public RectangleShape(RectangleF rect) : base(rect)
		{
		}
		
		public RectangleShape(RectangleShape rectangle) : base(rectangle)
		{
		}

		#endregion
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Проверка за принадлежност на точка point към правоъгълника.
		/// В случая на правоъгълник този метод може да не бъде пренаписван, защото
		/// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
		/// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
		/// елемента в този случай).
		
		public override bool Contains(PointF point)
		{
			if (base.Contains(point))
				// Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
				// В случая на правоъгълник - директно връщаме true
				return true;
			else
				// Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
				return false;
		}//endcontains
		 //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%		

		/// Частта, визуализираща конкретния примитив.
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);
			//----------------------------------------------------------------
			//Matrix myMatrix = new Matrix();
			//myMatrix.Rotate(45, MatrixOrder.Append);

			/*Point[] myArray =
					 {
				 new Point(20, 20),
				 new Point(120, 20),
				 new Point(120, 120),
				 new Point(20, 120),
				 new Point(20,20)
			 };*/

			grfx.FillRectangle(new SolidBrush(FillColor),Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawRectangle(new Pen(StrokeColor, (float)StrokeThickness), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

		//	grfx.DrawLine(new Pen(StrokeColor, (float)StrokeThickness), Rectangle.X, Rectangle.Y, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height);


			//grfx.Transform = myMatrix;
		}


		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/*	public override void DrawSelf(Graphics grfx)
			{
				base.DrawSelf(grfx);

				Matrix myMatrix = new Matrix();

				// Set world transform of graphics object to rotate.
				grfx.RotateTransform(100.0F);

				// Then to scale, appending to world transform.
				//grfx.ScaleTransform(3.0F, 1.0F, MatrixOrder.Append);

				// Draw rotated, scaled rectangle to screen.
				//grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
				//grfx.DrawRectangle(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

				grfx.DrawRectangle(new Pen(Color.Blue, 9), 50, 0, 100, 40);
			}*/
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
	}
	}
