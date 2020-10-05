using MegaDesk_Meim.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Meim
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        //Button to Add Quote
        private void button1_Click(object sender, EventArgs e)
        {   
            AddQuote addQuote = new AddQuote();
            addQuote.Show(this);
            Hide();
        }

        //Button to View Quote
        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes();
            viewAllQuotes.Show(this);
            Hide();
        }

        //Button to Search Quotes

        private void button3_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Show(this);
            Hide();
        }


        //Button to Exit the application
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
