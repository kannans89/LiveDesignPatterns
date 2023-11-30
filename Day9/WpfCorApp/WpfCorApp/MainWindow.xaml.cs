using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfCorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    class Node {
        public string data;
        public Node nextNode;
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Node n1 =new Node();
            n1.data = "first";

            Node n2 = new Node();
            n2.data = "second";

            n1.nextNode = n2;

        }

        private void GridMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Grid seee the event ");

            e.Handled = true;
        }

        private void ButtonMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Button seee the event ");
        }
    }
}
