using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk_Meim
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        //event that return to main menu
        private void button1_Click(object sender, EventArgs e)
        {
            UserClosing = true;
            var returnMainMenu = (MainMenu)Tag;
            returnMainMenu.Show();
            Close();
        }

        public bool UserClosing { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
