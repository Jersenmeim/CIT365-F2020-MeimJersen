using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk_Meim
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        //event that return to main menu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MainMenu main = new MainMenu();
                main.Show(this);
                Hide();
            }
            catch (Exception)
            {

                Hide();
            }

        }

        public bool UserClosing { get; set; }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {

        }
    }
}
