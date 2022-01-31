using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Draw
{
	///--------------------------------------- Класът, който ще бъде използван при управляване на дисплейната система.-------------------------------------------------------
	public class DisplayProcessor
	{
//&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
		#region Constructor
		public DisplayProcessor()
		{
		}
		#endregion
//&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
		#region Properties
		/// Списък с всички елементи формиращи изображението.

		private List<Shape> shapeList = new List<Shape>();		
		public List<Shape> ShapeList 
		{
			get { return shapeList; }
			set { shapeList = value; }
		}
		#endregion
//&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
		#region Drawing
		/// Прерисува всички елементи в shapeList върху e.Graphics
		
		public void ReDraw(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Draw(e.Graphics);
		}

		//---------------------------------------------------------------------------
		/// Визуализация.
		/// Обхождане на всички елементи в списъка и извикване на визуализиращия им метод.
		/// <param name="grfx">Къде да се извърши визуализацията.</param>

		public virtual void Draw(Graphics grfx)
		{
			foreach (Shape item in ShapeList)
			{
				DrawShape(grfx, item);
			}
		}

		//---------------------------------------------------------------------------
		/// Визуализира даден елемент от изображението.
		/// <param name="grfx">Къде да се извърши визуализацията.</param>
		/// <param name="item">Елемент за визуализиране.</param>
		
		public virtual void DrawShape(Graphics grfx, Shape item)
		{
			item.DrawSelf(grfx);
		}

		#endregion
//&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
	}
}
