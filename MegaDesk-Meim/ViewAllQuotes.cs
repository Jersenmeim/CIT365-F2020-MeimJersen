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
            //read all list of quotes
            List<string[]> deskList = new List<string[]>();
            StreamReader streamReader = new StreamReader("../../../quotes.json");
            string line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] items = line.Split(',');
                deskList.Add(items);
            }




            //populate from the file to the object
            foreach (string[] temp in deskList)
            {
                ListViewItem listViewItem = new ListViewItem();
                
                {
                    listViewItem.Text = temp[0];
                    for (int i = 1; i < 8; i++)
                        listViewItem.SubItems.Add(temp[i]);
                    listView2.Items.Add(listViewItem);
                }

            }
            streamReader.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
