namespace MegaDesk_Meim
{
    partial class SearchQuotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            this.button1 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.customer = new System.Windows.Forms.ColumnHeader();
            this.deskWidth = new System.Windows.Forms.ColumnHeader();
            this.deskDepth = new System.Windows.Forms.ColumnHeader();
            this.numDrawers = new System.Windows.Forms.ColumnHeader();
            this.materialused = new System.Windows.Forms.ColumnHeader();
            this.rushOrder = new System.Windows.Forms.ColumnHeader();
            this.totalPrice = new System.Windows.Forms.ColumnHeader();
            this.DateT = new System.Windows.Forms.ColumnHeader();
            this.srcbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customer,
            this.deskWidth,
            this.deskDepth,
            this.numDrawers,
            this.materialused,
            this.rushOrder,
            this.totalPrice,
            this.DateT});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 50);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(560, 267);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // customer
            // 
            this.customer.Text = "Name";
            this.customer.Width = 50;
            // 
            // deskWidth
            // 
            this.deskWidth.Text = "Width";
            this.deskWidth.Width = 50;
            // 
            // deskDepth
            // 
            this.deskDepth.Text = "Depth";
            this.deskDepth.Width = 50;
            // 
            // numDrawers
            // 
            this.numDrawers.Text = "Number of Drawers";
            this.numDrawers.Width = 115;
            // 
            // materialused
            // 
            this.materialused.Text = "Material Used";
            this.materialused.Width = 85;
            // 
            // rushOrder
            // 
            this.rushOrder.Text = "Rush Order";
            this.rushOrder.Width = 75;
            // 
            // totalPrice
            // 
            this.totalPrice.Text = "Total Price";
            this.totalPrice.Width = 75;
            // 
            // DateT
            // 
            this.DateT.Text = "Date";
            this.DateT.Width = 70;
            // 
            // srcbox
            // 
            this.srcbox.FormattingEnabled = true;
            this.srcbox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.srcbox.Location = new System.Drawing.Point(12, 21);
            this.srcbox.Name = "srcbox";
            this.srcbox.Size = new System.Drawing.Size(141, 23);
            this.srcbox.TabIndex = 3;
            this.srcbox.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(169, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = " <- Please Select";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srcbox);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader customer;
        private System.Windows.Forms.ColumnHeader deskWidth;
        private System.Windows.Forms.ColumnHeader deskDepth;
        private System.Windows.Forms.ColumnHeader numDrawers;
        private System.Windows.Forms.ColumnHeader materialused;
        private System.Windows.Forms.ColumnHeader rushOrder;
        private System.Windows.Forms.ColumnHeader totalPrice;
        private System.Windows.Forms.ColumnHeader DateT;
        private System.Windows.Forms.ComboBox srcbox;
        private System.Windows.Forms.Label label1;
    }
}