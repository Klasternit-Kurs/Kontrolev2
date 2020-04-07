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

namespace Kontrolev2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public List<Primer> Lista = new List<Primer>();
		public Dictionary<Primer, int> Recnik = new Dictionary<Primer, int>();

		public MainWindow()
		{
			InitializeComponent();
			Lista.Add(new Primer("Prvi"));
			Lista.Add(new Primer("Drugi"));
			Lista.Add(new Primer("Treci"));

			Recnik.Add(new Primer("Prvi"), 1);
			Recnik.Add(new Primer("Drugi"), 2);
			Recnik.Add(new Primer("Treci"), 3);

			cmb.ItemsSource = Recnik;
			cmb.DisplayMemberPath = "Key.Nesto";

			TreeViewItem tvI = new TreeViewItem();
			tvI.Header = "Neki string";
			CheckBox cb1 = new CheckBox();
			cb1.Content = "Test 1";
			CheckBox cb2 = new CheckBox();
			cb2.Content = "Test 2";

			tvI.Items.Add(cb1);
			tvI.Items.Add(cb2);


			tv.Items.Add(tvI);

			tv.Items.Add("Nesto");
			tv.Items.Add("Drugo");
			tv.Items.Add("Trece");
		}

		private void Promena(object sender, SelectionChangedEventArgs e)
		{
			if (cmb.SelectedItem != null)
			{
				var par = (KeyValuePair<Primer, int>)cmb.SelectedItem;
				
				lbl.Content = par.Value;
			}
		}
	}

	public class Primer
	{
		public string Nesto { get; set; }

		public Primer(string n) => Nesto = n;

		//public override string ToString() => Nesto;

	}
}
