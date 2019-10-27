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

namespace R6_Match_Logging
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DebugWindow debugWindow;

        public MainWindow()
        {
            InitializeComponent();

            debugWindow = new DebugWindow(this);

            this.IsVisibleChanged += MainWindow_IsVisibleChanged;
            this.LocationChanged += MainWindow_LocationChanged;
            this.SizeChanged += MainWindow_SizeChanged;
        }

        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            debugWindow.SetPosition();
        }

        private void MainWindow_LocationChanged(object sender, EventArgs e)
        {
            debugWindow.SetPosition();
        }

        private void MainWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!this.IsVisible)
            {
                Environment.Exit(-1);
            }
        }

        private void DebugButton_Click(object sender, RoutedEventArgs e)
        {
            debugWindow.Toggle();
        }
    }
}
