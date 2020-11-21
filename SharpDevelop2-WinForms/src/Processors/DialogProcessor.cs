using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Draw
{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на диалога.
	/// </summary>
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		
		public DialogProcessor()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// Избран елемент.
		/// </summary>
		private List<Shape> selection = new List<Shape>();
		public List<Shape> Selection
		{
			get { return selection; }
			set { selection = value; }
		}

		/// <summary>
		/// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
		/// </summary>
		private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}
		
		/// <summary>
		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}
		
		#endregion
		
		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomRectangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);
			
			RectangleShape rect = new RectangleShape(new Rectangle(x,y,100,200));
			rect.FillColor = Color.White;
			rect.BorderColor = Color.Black;

			ShapeList.Add(rect);
		}

		/// <summary>
		/// Добавя примитив - Кръг на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomEllipse()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 200, 200));
			ellipse.FillColor = Color.White;
			ellipse.BorderColor = Color.Black;
			//ell.BorderColor = Color.Black;

			ShapeList.Add(ellipse);
		}


		/// <summary>
		/// Добавя примитив - Линия на произволно място върху клиентската област.
		/// </summary>
		public void AddLine(float x1, float y1, float x2, float y2)
		{
			var line = new Line(new PointF(x1, y1), new PointF(x2, y2));

			ShapeList.Add(line);
		}


		/// <summary>
		/// Проверява дали дадена точка е в елемента.
		/// Обхожда в ред обратен на визуализацията с цел намиране на
		/// "най-горния" елемент т.е. този който виждаме под мишката.
		/// </summary>
		/// <param name="point">Указана точка</param>
		/// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
		public Shape ContainsPoint(PointF point)
		{
			for(int i = ShapeList.Count - 1; i >= 0; i--){
				if (ShapeList[i].Contains(point)){
					//ShapeList[i].FillColor = Color.Red;
						
					return ShapeList[i];
				}	
			}
			return null;
		}
		
		/// <summary>
		/// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
		/// </summary>
		/// <param name="p">Вектор на транслация.</param>
		public void TranslateTo(PointF p)
		{
			foreach (var item in Selection)
			{

				item.Relocate(p.X - lastLocation.X, p.Y - lastLocation.Y);

			}
			lastLocation = p;
		}


		/// <summary>
		///Оцветяване
		/// </summary>
		public void FillColor(Color color)
		{
			//if(Selection != null)
			foreach (var item in Selection)
			{
				item.FillColor = color;
			}
		}

		/// <summary>
		/// Цвят на очертания
		/// </summary>
		public void BorderColors(Color color)
		{
			foreach (var item in Selection)
			{
				item.BorderColor = color;
			}
		}


		/// <summary>
		/// Дебелина на очертания
		/// </summary>
		public void BorderWidth (float border)
		{
			foreach(var item in Selection)
			{
				item.Borderwidth = border;
			}
		}

		public void BiggerSize()
		{
			foreach (var item in Selection)
			{
				item.Width += 20;
				item.Height += 20;
			}
		}

		public void SmallerSize()
		{
			foreach (var item in Selection)
			{
				item.Width -= 20;
				item.Height -= 20;
			}
		}

		public void DeleteShape()
		{
			foreach(var item in Selection)
			{
				ShapeList.Remove(item);
			}
			Selection.Clear();
		}


	}
}
