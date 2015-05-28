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

namespace Skirmish
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

        private DockPanel makeNewCharacterPanel()
        {
            DockPanel charPanel = new DockPanel();
            Label name = new Label();
            name.Content = "Door";
            ProgressBar healthBar = new ProgressBar();
            healthBar.Width = 120;
            healthBar.Height = 10;
            charPanel.Children.Add(healthBar);
            charPanel.Children.Add(name);
            DockPanel.SetDock(name, Dock.Left);
            DockPanel.SetDock(healthBar, Dock.Right);
            return charPanel;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DockPanel charPanel = makeNewCharacterPanel();
            panel.Children.Add(charPanel);
        }
    }
}
