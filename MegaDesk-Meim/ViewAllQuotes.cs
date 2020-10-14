using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_Meim
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            ReadFile();
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

        //Read File from quotes.json
        private void ReadFile()
        {
            //Read from the json file.
            StreamReader jsonStream = new StreamReader("../../../quotes.json");

            //Store the entire file in one string.
            string rawJson = jsonStream.ReadToEnd();

           
            List<data> desks = JsonConvert.DeserializeObject<List<data>>(rawJson);

            //Loop through the list of desks.
            foreach (data desk in desks)
            {
                string[] row = {
                    desk.Name
                    , desk.widths
                    , desk.depths
                    , desk.drawers
                    , desk.materials
                    , desk.rush
                    , desk.total.ToString()
                    , desk.date};

                dataGridView1.Rows.Add(row);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {

        }
    }
}
