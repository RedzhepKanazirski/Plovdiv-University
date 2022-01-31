using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
	/// ---------------------------------------Базовия клас на примитивите, който съдържа общите характеристики на примитивите.-----------------------------------------
	public abstract class Shape
	{
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		#region Constructors

		public Shape()
		{
		}

		public Shape(RectangleF rect)
		{
			rectangle = rect;
		}


		public Shape(TriangleF trngl)
		{
			triangle = trngl;
		}

		public Shape(Shape shape)
		{
			this.Height = shape.Height;
			this.Width = shape.Width;
			this.Location = shape.Location;
			this.rectangle = shape.rectangle;

			this.FillColor = shape.FillColor;
		}
		#endregion
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		#region Properties

		/// Обхващащ правоъгълник на елемента.
		private RectangleF rectangle;
		public virtual RectangleF Rectangle
		{
			get { return rectangle; }
			set { rectangle = value; }
		}

		private TriangleF triangle;
		public virtual TriangleF Triangle
		{
			get { return triangle; }
			set { triangle = value; }
		}

		/// Широчина на елемента.
		public virtual float Width
		{
			get { return Rectangle.Width; }
			set { rectangle.Width = value; }
		}

		/// Височина на елемента.
		public virtual float Height
		{
			get { return Rectangle.Height; }
			set { rectangle.Height = value; }
		}

		/// Горен ляв ъгъл на елемента.
		public virtual PointF Location
		{
			get { return Rectangle.Location; }
			set { rectangle.Location = value; }
		}
		//-------------------------------------------------------------------------
		Matrix myMatrix = new Matrix();
		//-----------------------------------------------------------------------------------------

		/// Цвят на елемента.
		private Color fillColor;
		public virtual Color FillColor
		{
			get { return fillColor; }
			set { fillColor = value; }
		}

		private Color strokeColor;
		public virtual Color StrokeColor
		{
			get { return strokeColor; }
			set { strokeColor = value; }
		}

		private double strokeThickness;
		public double StrokeThickness
		{
			get { return strokeThickness; }
			set { strokeThickness = value; }
		}

		#endregion
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Проверка дали точка point принадлежи на елемента.

		/// <param name="point">Точка</param>
		/// <returns>Връща true, ако точката принадлежи на елемента и
		/// false, ако не пренадлежи</returns>

		public virtual bool Contains(PointF point)
		{
			return Rectangle.Contains(point.X, point.Y);
		}
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Визуализира елемента.
		/// <param name="grfx">Къде да бъде визуализиран елемента.</param>

		public virtual void DrawSelf(Graphics grfx)
		{
			//shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);
		}
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		

	}
}
