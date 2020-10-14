﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

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
           
            ReadFile();

        }

        //Readfile from quotes.json
        private void ReadFile()
        {
            ///Read a json file.
            StreamReader jsonStream = new StreamReader("../../../quotes.json");

            //Store the entire file in one string.
            string rawJson = jsonStream.ReadToEnd();
            string materialQuery = srcbox.SelectedItem.ToString();

            // clear the data in grid
            dataGridView1.Rows.Clear();
            //Using JSON.NET convert the data stored in the string into a list of Desk objects.
            List<data> desks = JsonConvert.DeserializeObject<List<data>>(rawJson);

            //Loop through the list of desks. 
            foreach (data desk in desks)
            {
                if (desk.materials.ToString() == materialQuery)
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
        }

        private void button_Click(object sender, EventArgs e)
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


        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            
         
        }

      

        
    }
}
