using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Draw
{
	///---------------------------- Върху главната форма е поставен потребителски контрол, в който се осъществява визуализацията--------------------------------------
	public partial class MainForm : Form
	{
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		private DialogProcessor dialogProcessor = new DialogProcessor();
	
//##########################################################################################################################################
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
//##########################################################################################################################################
		/// Изход от програмата. Затваря главната форма, а с това и програмата.
	
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
//##########################################################################################################################################	
		/// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}
//##########################################################################################################################################
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomRectangle();
			
			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";
			
			viewPort.Invalidate();
		}
//##########################################################################################################################################
		/// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		/// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		/// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
		/// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		
		void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (pickUpSpeedButton.Checked) 
			{
				Shape sel = dialogProcessor.ContainsPoint(e.Location);
				if (sel != null) 
				{
					if (dialogProcessor.Selection.Contains(sel)) 
						dialogProcessor.Selection.Remove(sel);
					else
							dialogProcessor.Selection.Add(sel);
				}
				statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
				dialogProcessor.IsDragging = true;
				dialogProcessor.LastLocation = e.Location;
				viewPort.Invalidate();
			}
		}
//##########################################################################################################################################
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (dialogProcessor.IsDragging) {
				if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
				dialogProcessor.TranslateTo(e.Location);
				viewPort.Invalidate();
			}
		}
//##########################################################################################################################################
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
	
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;
		}
//##########################################################################################################################################
		private void toolStripButton1_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomEllipse();

			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

			viewPort.Invalidate();
		}
//##########################################################################################################################################
		private void toolStripButton2_Click(object sender, EventArgs e)
        {
			if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
				dialogProcessor.SelectionF.FillColor = colorDialog1.Color;
				viewPort.Invalidate();
            }
			
        }
//##########################################################################################################################################
		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomCircle();

			statusBar.Items[0].Text = "Последно действие: Рисуване на кръг";

			viewPort.Invalidate(); 
		}
//##########################################################################################################################################
		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomSquare();

			statusBar.Items[0].Text = "Последно действие: Рисуване на квадрат";

			viewPort.Invalidate();
		}
//##########################################################################################################################################
		private void toolStripButton5_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomLine();

			statusBar.Items[0].Text = "Последно действие: Рисуване на отсечка";

			viewPort.Invalidate();
		}
//##########################################################################################################################################
		private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }
//##########################################################################################################################################
		private void toolStripButton9_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomDot();

			statusBar.Items[0].Text = "Последно действие: Рисуване на точка";

			viewPort.Invalidate();
		}


//##########################################################################################################################################
		Bitmap bm;
		Graphics g;
		bool paint = false;
		Point px, py;
		Pen p = new Pen(Color.Black, 1);
		Pen Eraser = new Pen(Color.White, 10);
		int index;
		int x, y, sx, sy, cx, cy;

       

        Color New_Color;
		ColorDialog cd = new ColorDialog();

		/*private void toolStripButton10_Click(object sender, EventArgs e)
        {
			var sfd = new SaveFileDialog();
			sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
			
			 Save(sfd.FileName, ImageFormat.Jpeg);
			}
		}*/

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var sfd = new SaveFileDialog();
			sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
			if (sfd.ShowDialog() == DialogResult.OK)
			{

				Save(sfd.FileName, ImageFormat.Jpeg);
			}
		}


		private void Save(string fileName, ImageFormat jpeg)
        {
            throw new NotImplementedException();
        }
		//##########################################################################################################################################
		private void toolStripButton11_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomPolygon();

			statusBar.Items[0].Text = "Последно действие: Рисуване на точка";

			viewPort.Invalidate();
		}
		private void toolStripButton10_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomizpit();

			statusBar.Items[0].Text = "Последно действие: Рисуване на точка";

			viewPort.Invalidate();
		}
		private void toolStripButton11_Click_1(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomPolygon();

			statusBar.Items[0].Text = "Последно действие: Рисуване на точка";

			viewPort.Invalidate();
		}
	}
}
