using System;
using System.Collections.Generic;
using System.Globalization;
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
using Calculator;

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		string language;
		private void cbLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)  //
		{
			ComboBox cb = sender as ComboBox;
			language = (cb.SelectedItem as ComboBoxItem).Tag.ToString();
			if (language != null)
			{
				CultureInfo lang = new CultureInfo(language);
				if (lang != null)
				{
					App.Language = lang;
				}
			}
		}

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Sum_Click(object sender, RoutedEventArgs e)
		{
			String inputDataA = tbA.Text;
			String inputDataB = tbB.Text;

			try
			{
				double dataA = Double.Parse(inputDataA);
				double dataB = Double.Parse(inputDataB);
				Calculations s = new Calculations(dataA, dataB);
				double result = s.Summary();

				Result.Text = result.ToString();
			}
			catch (Exception)
			{
				MessageBox.Show("Enter the valid numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private void Multi_Click(object sender, RoutedEventArgs e)
		{
			String inputDataA = tbA.Text;
			String inputDataB = tbB.Text;

			try
			{
				double dataA = Double.Parse(inputDataA);
				double dataB = Double.Parse(inputDataB);
				Calculations s = new Calculations(dataA, dataB);
				double result = s.Multiply();

				Result.Text = result.ToString();
			}
			catch (Exception)
			{
				MessageBox.Show("Enter the valid numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private void Minus_Click(object sender, RoutedEventArgs e)
		{
			String inputDataA = tbA.Text;
			String inputDataB = tbB.Text;

			try
			{
				double dataA = Double.Parse(inputDataA);
				double dataB = Double.Parse(inputDataB);
				Calculations s = new Calculations(dataA, dataB);
				double result = s.Difference();

				Result.Text = result.ToString();
			}
			catch (Exception)
			{
				MessageBox.Show("Enter the valid numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private void Divide_Click(object sender, RoutedEventArgs e)
		{
			String inputDataA = tbA.Text;
			String inputDataB = tbB.Text;

			try
			{
				double dataA = Double.Parse(inputDataA);
				double dataB = Double.Parse(inputDataB);
				Calculations s = new Calculations(dataA, dataB);
				double result = s.Division();

				Result.Text = result.ToString();
			}
			catch (Exception)
			{
				MessageBox.Show("Enter the valid numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private void Sin_Click(object sender, RoutedEventArgs e)
		{
			String inputDataA = tbA.Text;
			try
			{
				double dataA = Double.Parse(inputDataA);
				Calculations s = new Calculations(dataA);
				double result = s.Sin();

				Result.Text = result.ToString();
			}
			catch (Exception)
			{
				MessageBox.Show("Enter the valid numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private void Cos_Click(object sender, RoutedEventArgs e)
		{
			String inputDataA = tbA.Text;
			try
			{
				double dataA = Double.Parse(inputDataA);
				Calculations s = new Calculations(dataA);
				double result = s.Cos();

				Result.Text = result.ToString();
			}
			catch (Exception)
			{
				MessageBox.Show("Enter the valid numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}
	}
}
