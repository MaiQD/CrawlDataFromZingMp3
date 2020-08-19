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

namespace CrawlDataFromZingMp3
{
	/// <summary>
	/// Interaction logic for UCSong.xaml
	/// </summary>
	public partial class UCSong : UserControl
	{
		public UCSong()
		{
			InitializeComponent();
		}
		private event EventHandler _BackToList;
		public event EventHandler BackToList
		{
			add { _BackToList += value; }
			remove { _BackToList -= value; }
		}
		private void btnBack_Click(object sender, RoutedEventArgs e)
		{
			if (_BackToList!= null)
				_BackToList(this, new EventArgs());
		}
	}
}
