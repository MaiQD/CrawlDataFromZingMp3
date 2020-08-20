using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace CrawlDataFromZingMp3
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		public MainWindow()
		{
			InitializeComponent();

			listBoxTopSong.ItemsSource = new List<string> { "", "", "", "", "", "", "", "", "", "" };
			ucSong.BackToList += UcSong_BackToList;
			IsCheckVN = true;
			//để binding
			this.DataContext = this;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private bool isCheckVN;
		private bool isCheckEU;
		private bool isCheckKO;
		public bool IsCheckVN { get => isCheckVN; set { isCheckVN = value; isCheckEU = false; isCheckKO = false; OnPropertyChanged("IsCheckVN"); OnPropertyChanged("IsCheckEU"); OnPropertyChanged("IsCheckKO"); } }
		public bool IsCheckEU { get => isCheckEU; set { isCheckEU = value; isCheckVN = false; isCheckKO = false; OnPropertyChanged("IsCheckVN"); OnPropertyChanged("IsCheckEU"); OnPropertyChanged("IsCheckKO"); } }
		public bool IsCheckKO { get => isCheckKO; set { isCheckKO = value; isCheckEU = false; isCheckVN = false; OnPropertyChanged("IsCheckVN"); OnPropertyChanged("IsCheckEU"); OnPropertyChanged("IsCheckKO"); } }


		private void UcSong_BackToList(object sender, EventArgs e)
		{
			songDetail.Visibility = Visibility.Hidden;
			topSong.Visibility = Visibility.Visible;
		}

		private void btnPlay_Click(object sender, RoutedEventArgs e)
		{
			songDetail.Visibility = Visibility.Visible;
			topSong.Visibility = Visibility.Hidden;
		}
		protected virtual void OnPropertyChanged(string newName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(newName));
			}

		}
	}
}
