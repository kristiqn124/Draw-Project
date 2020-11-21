using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{
        /// <summary>
        /// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
        /// </summary>
        /// 
        #region Properties
        private DialogProcessor dialogProcessor = new DialogProcessor();
		public static Color fill;
		public static Color border;
		public static float borderWidth;
		private int X, Y;

		//For Drawin on ViewPort
		
		

		#endregion
		

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

		/// <summary>
		/// Изход от програмата. Затваря главната форма, а с това и програмата.
		/// </summary>
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		
		/// <summary>
		/// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		/// </summary>
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}
		
		/// <summary>
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomRectangle();
			
			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";
			
			viewPort.Invalidate();
		}

		/// <summary>
		/// Бутон, който поставя на произволно място кръг със зададените размери.
		/// </summary>
		private void DrawEllipseButton_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomEllipse();

			statusBar.Items[0].Text = "Последно действие: Рисуване на елипса.";

			viewPort.Invalidate();
		}
		/// <summary>
		/// Бутон, който чертае линия със зададените размери.
		/// </summary>
		private void DrawLineButton_Click(object sender, EventArgs e)
		{

			statusBar.Items[0].Text = "Последно действие: Чертаене на линия.";

			viewPort.Invalidate();
		}

		private void viewPort_MouseClick(object sender, MouseEventArgs e)
		{
			if (DrawLineButton.Checked)
			{
				float X1 = e.X;
				float Y1 = e.Y;

				dialogProcessor.AddLine(X, Y, X1, Y1);

				viewPort.Invalidate();
			}
		}



		/// <summary>
		/// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		/// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		/// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
		/// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		/// </summary>
		void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
			X = e.X;
			Y = e.Y;


			if (pickUpSpeedButton.Checked) {
				dialogProcessor.Selection.Clear();
				var selection = dialogProcessor.ContainsPoint(e.Location);
				if (selection != null) {
					dialogProcessor.Selection.Add(selection);
					statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
					dialogProcessor.IsDragging = true;
					dialogProcessor.LastLocation = e.Location;
					viewPort.Invalidate();
				}
			}

			/// <summary>
			///Оцветяване
			/// </summary>
			if (FillColor.Checked)
			{
				dialogProcessor.Selection.Clear();
				var selection = dialogProcessor.ContainsPoint(e.Location);
				if (selection != null)
				{
					dialogProcessor.Selection.Add(selection);
					dialogProcessor.FillColor(fill);
					statusBar.Items[0].Text = "Последно действие: Оцветяване на примитив";
					dialogProcessor.LastLocation = e.Location;
					viewPort.Invalidate();
				}
			}


			/// <summary>
			/// Цвят на очертания
			/// </summary>
			if (BorderColor.Checked)
			{
				dialogProcessor.Selection.Clear();
				var selection = dialogProcessor.ContainsPoint(e.Location);
				if (selection != null)
				{
					dialogProcessor.Selection.Add(selection);
					dialogProcessor.BorderColors(border);
					statusBar.Items[0].Text = "Последно действие: Цвят на очертания";
					dialogProcessor.LastLocation = e.Location;
					viewPort.Invalidate();
				}
			}

			/// <summary>
			/// Дебелина на очертания
			/// </summary>
			if (BorderPenSize.Checked)
			{
				dialogProcessor.Selection.Clear();
				var selection = dialogProcessor.ContainsPoint(e.Location);
				if (selection != null)
				{
					dialogProcessor.Selection.Add(selection);
					dialogProcessor.BorderWidth(borderWidth);
					statusBar.Items[0].Text = "Последно действие: Дебелина на очертания";
					dialogProcessor.LastLocation = e.Location;
					viewPort.Invalidate();
				}
			}


			/// <summary>
			/// Уголемяване на избрания примитив
			/// </summary>

			if (BiggerShapeSize.Checked)
			{
				dialogProcessor.Selection.Clear();
				var selection = dialogProcessor.ContainsPoint(e.Location);
				if (selection != null)
				{
					dialogProcessor.Selection.Add(selection);
					dialogProcessor.BiggerSize();
					statusBar.Items[0].Text = "Последно действие: Увеличване на размера";
					dialogProcessor.LastLocation = e.Location;
					viewPort.Invalidate();
				}
			}

			/// <summary>
			/// Намаляне на размера на избрания примитив
			/// </summary>
			if (SmallerShapeSize.Checked)
			{
				dialogProcessor.Selection.Clear();
				var selection = dialogProcessor.ContainsPoint(e.Location);
				if (selection != null)
				{
					dialogProcessor.Selection.Add(selection);
					dialogProcessor.SmallerSize();
					statusBar.Items[0].Text = "Последно действие: Намаляне на размера";
					dialogProcessor.LastLocation = e.Location;
					viewPort.Invalidate();
				}
			}


			if (DeleteButton.Checked)
			{
				dialogProcessor.Selection.Clear();
				var selection = dialogProcessor.ContainsPoint(e.Location);
				if (selection != null)
				{
					dialogProcessor.Selection.Add(selection);
					dialogProcessor.DeleteShape();
					statusBar.Items[0].Text = "Последно действие: Намаляне на размера";
					dialogProcessor.LastLocation = e.Location;
					viewPort.Invalidate();
				}
			}


		}

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{

	
			if (dialogProcessor.IsDragging) {
				if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
				dialogProcessor.TranslateTo(e.Location);
				viewPort.Invalidate();
			}
		}


		/// <summary>
		/// Избиране на цвят от ColorDialog
		/// </summary>
		private void ColorChoose_Click(object sender, EventArgs e)
		{
			DialogResult r = ColorDialog.ShowDialog();
			if (r == DialogResult.OK)
			{
				fill = ColorDialog.Color;

			}
			if (r == DialogResult.OK)
			{
				border = ColorDialog.Color;

			}

		}
		/// <summary>
		/// Избиране на дебелина на очертания 
		/// </summary>
		private void BorderSize_Scroll(object sender, EventArgs e)
		{
			borderWidth = BorderSize.Value;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			SaveAs();
			statusBar.Items[0].Text = "Последно действие: Запазване";
		}

		private void SaveAs()
		{
			Bitmap bmp = new Bitmap(viewPort.Width, viewPort.Height);
			Graphics g = Graphics.FromImage(bmp);
			Rectangle rect = viewPort.RectangleToScreen(viewPort.ClientRectangle);
			g.CopyFromScreen(rect.Location, Point.Empty, viewPort.Size);
			g.Dispose();
			SaveFileDialog s = new SaveFileDialog();
			s.Filter = "PNG|*.png|JPEG|*.jpg|Bitmap|*.bmp";
			if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				if (File.Exists(s.FileName))
				{
					File.Delete(s.FileName);
				}
				if (s.FileName.Contains(".jpg"))
				{
					bmp.Save(s.FileName, ImageFormat.Jpeg);
				}
				else if (s.FileName.Contains(".png"))
				{
					bmp.Save(s.FileName, ImageFormat.Png);
				}
				else if (s.FileName.Contains(".bmp"))
				{
					bmp.Save(s.FileName, ImageFormat.Bmp);
				}
			}
		}

		private void OpenFile_Click(object sender, EventArgs e)
		{
			var Openfile = new OpenFileDialog();
			Openfile.Filter = "All files |*.*|Png |*.png|jpeg |*jpg|bitmaps|*.bmp";

			if (Openfile.ShowDialog() == DialogResult.OK)
			{
				viewPort.BackgroundImage = (Image)Image.FromFile(Openfile.FileName).Clone();
			}
		}

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{


			dialogProcessor.IsDragging = false;
		}

		
		
	}
}
