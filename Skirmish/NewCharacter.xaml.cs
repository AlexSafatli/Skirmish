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
using System.Windows.Shapes;

namespace Skirmish
{
    /// <summary>
    /// Interaction logic for NewCharacter.xaml
    /// </summary>
    public partial class NewCharacter : Window
    {

        public String CharacterName { get; set; }
        public int CharacterHealth { get; set; }
        public bool IsEnemy { get; set; }

        public NewCharacter()
        {
            InitializeComponent();
            CharacterName = "Name";
            CharacterHealth = 0;
            IsEnemy = false;
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {


            int hp;
            CharacterName = nameTextBox.Text;
            if (!int.TryParse(hpTextBox.Text,out hp))
            {
                MessageBox.Show("HP must be a number.");
                return;
            } else if (hp <= 0)
            {
                MessageBox.Show("HP must be more than 0.");
                return;
            }
            IsEnemy = (allyRadio.IsChecked != true);
            CharacterHealth = hp;
            DialogResult = true;

        }

    }
}
