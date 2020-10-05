using System;
using System.Windows.Forms;

namespace MegaDesk_Meim
{
    public partial class DisplayQuote : Form
    {
       public static string total;
       public static string oversize;
       public static string rushcost;
       public static string materialcost;
       public static string drawercost;


        //Passing the total cost value from AddQuote to this form

        public DisplayQuote()
        {
            InitializeComponent();
            

        }



        public bool UserClosing { get; set; }


        //Passing of all other values from AddQuote to DisplayQuote
        public void DisplayQuote_Load(object sender, EventArgs e)
        {
            
            name.Text = AddQuote.name;
            date.Text = AddQuote.date;
            width.Text = AddQuote.width + " inch";
            depth.Text = AddQuote.depth + " inch";
            drawer.Text = AddQuote.drawer;
            material.Text = AddQuote.material;
            rush.Text = AddQuote.rush;
            label1.Text = total;
            label14.Text = oversize;
            label9.Text = rushcost;
            label11.Text = materialcost;
            label12.Text = drawercost;

        }

        private void date_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
