using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApp3._c_DataSetTableAdapters;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CharactersTableAdapter characters = new CharactersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            Characters.ItemsSource = characters.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 win = new Window1();
            win.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            characters.InsertQuery(NameTcx.Text, NameTbx.Text);
            Characters.ItemsSource = characters.GetData();
        }
    }
}
