using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load( object sender, EventArgs e )
        {

        }

        private void button1_Click( object sender, EventArgs e )
        {
            // casting the arguments
            MouseEventArgs eventargs = e as MouseEventArgs;
            Button button1 = sender as Button;
            // displays which mouse button I used
            MessageBox.Show(eventargs.Button.ToString());
            // displays the name of the button I clicked
            MessageBox.Show(button1.Name.ToString());
            // changes the text of the button
            button1.Text = "Ive changed";
        }

        private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
        {

        }
    }
}
