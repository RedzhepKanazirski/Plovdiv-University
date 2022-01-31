using System;
using System.Windows.Forms;

namespace Draw
{
	///---------------------------------------------------- Клас с входната точка на програмата.----------------------------------------------------------------------
	internal sealed class Program
	{
		/// Входна точка. Създава и показва главната форма на програмата.
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

	}
}
