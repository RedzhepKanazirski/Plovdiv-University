using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Draw
{
	///-------------------------------------------- Класът, който ще бъде използван при управляване на диалога.-------------------------------------------------------------------------------
	
	public class DialogProcessor : DisplayProcessor
	{
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		#region Constructor
		public DialogProcessor()
		{

		}
		#endregion

		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		#region Properties

		/// Избран елемент. faking
		private Shape selectionF;
		public Shape SelectionF
		{
			get { return selectionF; }
			set { selectionF = value; }
		}

		/// Избран елемент.
		private List<Shape> selection = new List<Shape>();
		public List<Shape> Selection 
		{
			get { return selection; }
			set { selection = value; }
		}

		/// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
		private bool isDragging;
		public bool IsDragging 
		{
			get { return isDragging; }
			set { isDragging = value; }
		}

		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		private PointF lastLocation;
		public PointF LastLocation 
		{
			get { return lastLocation; }
			set { lastLocation = value; }
		}
		#endregion
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		public void AddRandomRectangle( )
		{
			Random rnd = new Random();
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);
			PointF rotatePoint = new PointF(150.0f, 50.0f);

			RectangleShape rect = new RectangleShape(new Rectangle(x,y,100,200));
			rect.FillColor = Color.White;
			rect.StrokeColor = Color.Red;
			rect.StrokeThickness = 8;

			ShapeList.Add(rect);
		}
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Добавя примитив - elipsa на произволно място върху клиентската област.
		public void AddRandomEllipse()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 100, 200));
			ellipse.FillColor = Color.White;
			ellipse.StrokeColor = Color.Green;
			ellipse.StrokeThickness = 5;

			ShapeList.Add(ellipse);
		}
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Добавя примитив - кръг на произволно място върху клиентската област.
		public void AddRandomCircle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 1000);

			EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 100, 100));
			ellipse.FillColor = Color.MediumAquamarine;
			ellipse.StrokeColor = Color.Yellow;
			

			ShapeList.Add(ellipse);
		}
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Добавя примитив - точка на произволно място върху клиентската област.
		public void AddRandomDot()
		{
			Random rnd = new Random();
			int x = rnd.Next(2, 500);
			int y = rnd.Next(2, 500);

			EllipseShape dot = new EllipseShape(new Rectangle(x, y, 2, 2));
			//ellipse.FillColor = Color.MediumAquamarine;
			dot.StrokeColor = Color.Black;


			ShapeList.Add(dot);
		}
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Добавя примитив - квадрат на произволно място върху клиентската област.
		/// 
		public void AddRandomSquare()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 1000);

			RectangleShape square = new RectangleShape(new Rectangle(x, y, 200, 200));
			//rect.FillColor = Color.White;
			square.StrokeColor = Color.Black;
			//square.StrokeThickness = 8;



			ShapeList.Add(square);
		}
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%64565645645645654645645546546456%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Добавя примитив - квадрат на произволно място върху клиентската област.
		/// 
		public void AddRandomizpit()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 1000);

			IzpitShape square = new IzpitShape(new Rectangle(x, y, 200, 200));
			//rect.FillColor = Color.White;
			square.StrokeColor = Color.Black;
			//square.StrokeThickness = 8;



			ShapeList.Add(square);
		}
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Добавя примитив - TRIANGLE на произволно място върху клиентската област.
		/// 
		public void AddRandomPolygon()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			PolygonSimple tri = new PolygonSimple(new Rectangle(x, y, 100, 200));
			tri.FillColor = Color.SkyBlue;

			ShapeList.Add(tri);
		}
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Добавя примитив - линия на произволно място върху клиентската област.

		public void AddRandomLine()
		{
			Random rnd = new Random();
			int x = rnd.Next(2, 200);
			int y = rnd.Next(2, 200);

			RectangleShape rect = new RectangleShape(new Rectangle(x, y, 2, 250));
			rect.FillColor = Color.Black;

			ShapeList.Add(rect);	

		}
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		/// Проверява дали дадена точка е в елемента.
		/// Обхожда в ред обратен на визуализацията с цел намиране на
		/// "най-горния" елемент т.е. този който виждаме под мишката.

		/// <param name="point">Указана точка</param>
		/// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>

		public Shape ContainsPoint(PointF point)
		{
			for(int i = ShapeList.Count - 1; i >= 0; i--)
			{
				if (ShapeList[i].Contains(point))
				{
					ShapeList[i].FillColor = Color.PaleVioletRed;
						
					return ShapeList[i];
				}	
			}
			return null;
		}
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

		/// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
		/// <param name="p">Вектор на транслация.</param>
		public void TranslateTo(PointF p)
		{
			//if (selection != null)
		//	{
		//		selectionF.Location = new PointF(selectionF.Location.X + p.X - lastLocation.X, selectionF.Location.Y + p.Y - lastLocation.Y);
		//		lastLocation = p;
		//	}
			
				
		  foreach (Shape item in Selection)
			   item.Location = new PointF(item.Location.X + p.X - lastLocation.X, item.Location.Y + p.Y - lastLocation.Y);
		
			lastLocation = p;		
		}
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
		public void RotateRectangle(Graphics g, Rectangle r, float angle)
		{
			using (Matrix m = new Matrix())
			{
				m.RotateAt(angle, new PointF(r.Left + (r.Width / 2),
										     r.Top  + (r.Height / 2)));
				g.Transform = m;
				g.DrawRectangle(Pens.Black, r);
				g.ResetTransform();
			}
		}
		//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

	}
}
