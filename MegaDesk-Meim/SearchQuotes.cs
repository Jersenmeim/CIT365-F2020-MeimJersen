using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_Meim
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
           
            InitializeComponent();
            srcbox.DataSource = Enum.GetValues(typeof(Material));
            listView2.Items.Clear();
        }

        


        //event that return to main menu
        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            ReadFile();

        }

        //Readfile from quotes.json
        private void ReadFile()
        {
            //read all quotes from a file then put it it desklist
            List<string[]> deskList = new List<string[]>();
            StreamReader streamReader = new StreamReader("../../../quotes.json");
            string line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] items = line.Split(',');
                deskList.Add(items);
            }

            //get the material that user chose
            string findThisMtrl = srcbox.SelectedValue.ToString();


            foreach (string[] temp in deskList)
            {
                //Readfile according to material used
                ListViewItem listViewItem = new ListViewItem();
                if (temp[4].ToString().Equals(findThisMtrl))
                {
                    listViewItem.Text = temp[0];
                    for (int i = 1; i < 8; i++)
                        listViewItem.SubItems.Add(temp[i]);
                    listView2.Items.Add(listViewItem);
                }

            }
            streamReader.Close();
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
            listView2.Items.Clear();
            ReadFile();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
