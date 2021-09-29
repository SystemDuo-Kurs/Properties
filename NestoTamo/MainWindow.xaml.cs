using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NestoTamo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		
		public MainWindow()
		{
			InitializeComponent();
			Radnik p = new Radnik();
			decimal pp = p.Plata2;
			Jen();
			p.Plata3 = 20;
			decimal ppp = p.Plata3;
		}

		public void Jen()
		{
			Dva();
		}

		public void Dva()
		{
			Tri();
		}
		public void Tri()
		{
			Sabirac s = new();
			s.Broj1 = 4;
			s.Broj2 = 6;
			
			MessageBox.Show($"Zbir je {s.Zbir}");
			s.Broj2 = 20;
			MessageBox.Show($"Zbir je {s.Zbir}");
		}
	}

	public class Sabirac
	{
		public int Broj1;
		public int Broj2;

		public int Zbir
		{
			get
			{
				return Broj1 + Broj2;
			}
		}
	}

	public class Radnik
	{
		public string Ime;


		private decimal _plata3;
		public decimal Plata3
		{
			get
			{
				return _plata3;
			}
			set
			{
				if (value > 100_000_000)
					_plata3 = value;
				 
			}
		}


		public decimal Plata2 { get; private set; }

		private decimal Plata = 100_000_000;

		public decimal GetPlatu()
		{
			return Plata;
		}

		public void SetPlatu(decimal plata)
		{
			if (plata > 100_000_000)
				Plata = plata;
		}

	}
}
