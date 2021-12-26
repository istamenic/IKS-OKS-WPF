using System.Windows;
using System.Windows.Controls;

namespace IKS_OKS
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		public int igrac = 2;
		public int potez = 0;
		public int s1 = 0;
		public int s2 = 0;
		public int s3 = 0;		

		private void button_click(object sender, RoutedEventArgs e)
		{
			Button button = (Button)sender;
			{
				if (button.Content == "")
				{
					if (igrac % 2 == 0)
					{
						button.Content = "X";
						potez++;
						igrac++;
					}
					else
					{
						button.Content = "O";
						potez++;
						igrac++;
					}
					if (nereseno() == true)
					{							
						MessageBox.Show("NERESENO!!!", "I N F O");
						s3++;
						Nereseno.Content = "Nereseno: " + s3;
						//NewGame();
					}
					if (pobednik() == true)
					{
						if (button.Content == "X")
						{
							MessageBox.Show("POBEDIO JE IGRAC X", "I N F O");
							s1++;
							Pobeda_X.Content = "X: " + s1;
							//NewGame();
						}
						else
						{
							MessageBox.Show("POBEDIO JE IGRAC O", "I N F O");
							s2++;
							Pobeda_O.Content = "O: " + s2;
							//NewGame();
						}
					}
				}
			}
		}
		
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			Close();
		}
		void NewGame()
		{
			igrac = 2;
			potez = 0;
			b11.Content = b12.Content = b13.Content = b21.Content = b22.Content = b23.Content = b31.Content = b32.Content = b33.Content = "";
			
		}
		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			NewGame();
		}

		void Button_Click_3(object sender, RoutedEventArgs e)
		{
			s1 = s2 = s3 = 0;
			igrac = 2;
			potez = 0;
			b11.Content = b12.Content = b13.Content = b21.Content = b22.Content = b23.Content = b31.Content = b32.Content = b33.Content = "";
			reset_label();
		}
		bool nereseno()
		{
			if (potez == 9 & pobednik() != true)
				return true;
			else
				return false;			
		}
		bool pobednik()
		{
			if (b11.Content == b12.Content && b12.Content == b13.Content && b11.Content != "" ||
					b21.Content == b22.Content && b22.Content == b23.Content && b21.Content != "" ||
					b31.Content == b32.Content && b32.Content == b33.Content && b31.Content != "" ||
					b11.Content == b21.Content && b21.Content == b31.Content && b11.Content != "" ||
					b12.Content == b22.Content && b22.Content == b32.Content && b12.Content != "" ||
					b13.Content == b23.Content && b23.Content == b33.Content && b13.Content != "" ||
					b11.Content == b22.Content && b22.Content == b33.Content && b11.Content != "" ||
					b13.Content == b22.Content && b22.Content == b31.Content && b13.Content != "")
				return true;
			else
				return false;
		}		
		void reset_label()
		{
			Pobeda_X.Content = "X: 0";
			Pobeda_O.Content = "O: 0";
			Nereseno.Content = "Nereseno: 0";
		}
	}
}
