using System;
using System.Windows.Forms;
using System.IO;

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
        private void back_Click_1(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddQuote ne = new AddQuote();
            ne.MaterialField.SelectedIndex = -1;
            ne.MaterialField.DataSource = Enum.GetValues(typeof(Material));
            WriteFile();
        }
        //Writefile to quotes.json
        private void WriteFile()
        {
            try
            {
                using (StreamWriter writeFile = new StreamWriter("../../../quotes.json", append: true))
                {
                    writeFile.Write(name.Text + ",");
                    writeFile.Write(width.Text + ",");
                    writeFile.Write(depth.Text + ",");
                    writeFile.Write(drawer.Text + ",");
                    writeFile.Write(material.Text + ",");
                    writeFile.Write(rush.Text + ",");
                    writeFile.Write(label1.Text + ",");
                    writeFile.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
                    MessageBox.Show("Quote has been created!");

                   
                    AddQuote ne = new AddQuote();
                    ne.MaterialField.SelectedIndex = -1;
                    ne.Drawer.SelectedIndex = -1;
                    ne.RushOrderOption.SelectedIndex = -1;
                    writeFile.Close();
                    AddQuote addNewQuoteForm = new AddQuote();
                    addNewQuoteForm.Show(this);
                    addNewQuoteForm.NameField.Clear();
                    Hide();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error when try to use StreamWriter. It says : " + e.Message);
            }
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
