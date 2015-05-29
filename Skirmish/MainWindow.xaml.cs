using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
            NewCharacter charWindow = new NewCharacter();
            charWindow.Owner = this;
            charWindow.ShowDialog();
            DockPanel charPanel = new DockPanel();
            Label name = new Label();
            Label hp = new Label();
            name.Content = charWindow.CharacterName;
            name.Foreground = (charWindow.IsEnemy) ? Brushes.Red : Brushes.Black;
            hp.Content = string.Format("({0})", charWindow.CharacterHealth);
            ProgressBar healthBar = new ProgressBar();
            healthBar.Width = 120;
            healthBar.Height = 10;
            healthBar.Value = 100;
            charPanel.Children.Add(healthBar);
            charPanel.Children.Add(name);
            charPanel.Children.Add(hp);
            DockPanel.SetDock(hp, Dock.Left);
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
