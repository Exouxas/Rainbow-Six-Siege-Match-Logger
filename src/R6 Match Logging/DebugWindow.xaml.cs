using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace R6_Match_Logging
{
    /// <summary>
    /// Interaction logic for DebugWindow.xaml
    /// </summary>
    public partial class DebugWindow : Window
    {
        private readonly MainWindow MyOwner;

        public DebugWindow(MainWindow mainWindow)
        {
            InitializeComponent();

            MyOwner = mainWindow;
            this.Closing += DebugWindow_Closing;
        }

        private void DebugWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public void Toggle()
        {
            if (this.IsVisible)
            {
                this.Hide();
            }
            else
            {
                SetPosition();
                this.Show();
            }
        }

        internal void SetPosition()
        {
            this.Top = MyOwner.Top;
            this.Left = MyOwner.Left + MyOwner.Width - 10;
        }
    }
}
