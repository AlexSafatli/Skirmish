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
        public NewCharacter()
        {
            InitializeComponent();
            this.Closing += new System.ComponentModel.CancelEventHandler(NewCharacter_Closing);
        }

        public void NewCharacter_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }
    }
}
