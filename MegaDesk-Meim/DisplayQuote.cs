using System;
using System.Windows.Forms;

namespace MegaDesk_Meim
{
    public partial class DisplayQuote : Form
    {
        public static string total;


        //Passing the total cost value from AddQuote to this form
        public DisplayQuote(string total, string rush, string material, string drawer, string oversize)
        {
            InitializeComponent();
            this.label1.Text = total;
            this.label9.Text = rush;
            this.label11.Text = material;
            this.label12.Text = drawer;
            this.label14.Text = oversize;
        }

       

        public bool UserClosing { get; set; }


        //Passing of all other values from AddQuote to DisplayQuote
        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            
            name.Text = AddQuote.name;
            date.Text = AddQuote.date;
            width.Text = AddQuote.width + " inch";
            depth.Text = AddQuote.depth + " inch";
            drawer.Text = AddQuote.drawer;
            material.Text = AddQuote.material;
            rush.Text = AddQuote.rush;

        }

        private void date_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
