using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;


namespace MegaDesk_Meim
{
    public partial class AddQuote : Form
    {
        // Make the variables accecible to all forms
        public static string name;
        public static double width;
        public static double depth;
        public static string drawer;
        public static string material;
        public static string rush;
        public static string date;
        public static string total;


        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        //Back Button
        private void button1_Click(object sender, EventArgs e)
        {
            
            

            try
            {
                UserClosing = true;
                var returnMainMenu = (MainMenu)Tag;
                returnMainMenu.Show();
                Hide();
            }
            catch (Exception)
            {
                
                Close();
            }
            
            
        }

       
        public bool UserClosing { get; set; }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      

        //Storing Values to a variable
        private void button2_Click(object sender, EventArgs e)
        {

            //Use try catch block to handle exception; empty text box.
            try
            {

                {
                    name = textBox1.Text; //save name-data in variable
                    width = double.Parse(textBox2.Text); //save width-data in variable
                    depth = double.Parse(textBox3.Text); //save depth-data in variable
                    date = DateTime.Now.Date.ToLongDateString().Replace(DateTime.Now.DayOfWeek.ToString() + ", ", "");
                    drawer = comboBox1.Text; //Display Drawers in Panel
                    material = comboBox2.Text; //Display Material in Panel
                    rush = comboBox3.Text; //Display Rush Order in Panel

                    //Calling the GetPrice Method
                    GetPrice();
                    this.Close();
                }
            }
            catch (Exception)
            {
               
                MessageBox.Show("Could not confirm quote details. Please fill out all fields", "Error");
                //throw;
               
            }
        }

        
       

        //Validate Customer's Name
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                //MessageBox.Show("Please enter a Name");
                textBox1.Text = String.Empty;
                textBox1.BackColor = Color.Red;
            }
            else
            {
                textBox1.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        //Validate Width Values using Constraint
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int WidthInput) == true)
            {
                if (WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("Please enter a width from " + Desk.MINWIDTH + " to " + Desk.MAXWIDTH + " inches");
                    textBox2.Text = String.Empty;
                    textBox2.BackColor = Color.Red;
                    textBox2.Focus();
                }
                else
                {
                    textBox2.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            else if (int.TryParse(textBox2.Text, out WidthInput) == false && textBox2.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                textBox2.Text = String.Empty;
                textBox2.BackColor = Color.Red;
                textBox2.Focus();
            }
            else
            {
                textBox2.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        //Validate Depth Values using Constraint

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int DepthInput) == true)
            {
                if (DepthInput < Desk.MINDEPTH || DepthInput > Desk.MAXDEPTH)
                {
                    MessageBox.Show("Please enter a depth from " + Desk.MINDEPTH + " to " + Desk.MAXDEPTH + " inches");
                    textBox3.Text = String.Empty;
                    textBox3.BackColor = Color.Red;
                    textBox3.Focus();
                }
                else
                {
                    textBox3.BackColor = System.Drawing.SystemColors.Window;
                }
            }  
        }

        //Validate Depth Values using Keypress
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) == false && Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please enter a number");
                e.Handled = true;
                textBox3.BackColor = Color.Red;
                textBox3.Focus();
            }
            else
            {
                textBox3.BackColor = System.Drawing.SystemColors.Window;
            }
        }


        
        private void GetPrice()
        {

            int width = int.Parse(textBox2.Text);
            int depth = int.Parse(textBox3.Text);
            int size = width * depth;
           
            //Pass all values to the parameter

            int.TryParse(comboBox1.Text, out int nDrawers);
          
            Desk desk = new Desk(int.Parse(textBox2.Text), int.Parse(textBox3.Text), nDrawers);
            DeskQuote deskQuotes = new DeskQuote(desk);
       
            deskQuotes.CalcOversizeCost();
            deskQuotes.CalcDrawerCost();
            deskQuotes.CalcMtrlCost(comboBox2.Text);
            deskQuotes.CalcRushOrderCost(comboBox3.Text);
            deskQuotes.CalcTotalCost();

            label11.Text = "$" + deskQuotes.OversizeCost;
            label10.Text = "$" + deskQuotes.DrawerCost;
            label9.Text = "$" + deskQuotes.MaterialCost;
            label8.Text = "$" + deskQuotes.RushOrderCost;
      
            //output total price to display quote
            label22.Text = "$" + deskQuotes.TotalCost;
            DisplayQuote fr = new DisplayQuote(label22.Text,
                                               label8.Text,
                                               label9.Text,
                                               label10.Text,
                                               label11.Text);
            fr.Show();
        }

        private void label22_Click(object sender, EventArgs e)
        {
        }
    }
}
