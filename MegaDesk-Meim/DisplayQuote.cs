using System;
using System.Windows.Forms;

namespace MegaDesk_Meim
{
    public partial class DisplayQuote : Form
    {
       public static string TotalValue;
       public static string OversizeValue;
       public static string RushCostValue;
       public static string MaterialCost;
       public static string DrawerCostValue;


        //Passing the total cost value from AddQuote to this form

        public DisplayQuote()
        {
            InitializeComponent();
            

        }



       


        //Passing of all other values from AddQuote to DisplayQuote
        public void DisplayQuote_Load(object sender, EventArgs e)
        {
            
            name.Text = AddQuote.NameValue;
            date.Text = AddQuote.DateToday;
            width.Text = AddQuote.WidthValue + " inch";
            depth.Text = AddQuote.DepthValue + " inch";
            drawer.Text = AddQuote.NoOfDrawer;
            material.Text = AddQuote.MaterialUsed;
            rush.Text = AddQuote.RushOption;
            label1.Text = TotalValue;
            label14.Text = OversizeValue;
            label9.Text = RushCostValue;
            label11.Text = MaterialCost;
            label12.Text = DrawerCostValue;

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
