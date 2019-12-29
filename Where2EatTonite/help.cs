using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Where2EatTonite
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {
            label.Text = "This software is designed for friends with choice disorders. \nYou can add from the system and change the restaurants you usually like.\nWith the random function, the program will randomize a restaurant \nto help you decide which restaurant you will eat tonight.\nI wish you a wonderful dinner.";
        }
    }
}
