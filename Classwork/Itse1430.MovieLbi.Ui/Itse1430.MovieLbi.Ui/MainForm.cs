﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itse1430.MovieLbi.Ui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {

        }

        private void movieToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }

        private void eexitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if (MessageBox.Show("Are you sure yuo want to exit?",
                "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            //aboutToolStripMenuItem.
            MessageBox.Show( this,"Sorry", "Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
