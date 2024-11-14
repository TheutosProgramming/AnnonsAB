namespace AnnonsAB.Views
{
    partial class MyAdverts
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
            listBoxAdvert = new ListBox();
            richTextBoxDescription = new RichTextBox();
            textBoxTitel = new TextBox();
            textBoxPrice = new TextBox();
            buttonCreateAdvert = new Button();
            buttonUpdateAdvert = new Button();
            buttonDeleteAdvert = new Button();
            comboBoxCategory = new ComboBox();
            labelTitel = new Label();
            labelPrice = new Label();
            SuspendLayout();
            // 
            // listBoxAdvert
            // 
            listBoxAdvert.FormattingEnabled = true;
            listBoxAdvert.ItemHeight = 15;
            listBoxAdvert.Location = new Point(18, 48);
            listBoxAdvert.Name = "listBoxAdvert";
            listBoxAdvert.Size = new Size(120, 304);
            listBoxAdvert.TabIndex = 0;
            listBoxAdvert.SelectedIndexChanged += listBoxAdvert_SelectedIndexChanged;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(144, 77);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(295, 275);
            richTextBoxDescription.TabIndex = 1;
            richTextBoxDescription.Text = "";
            // 
            // textBoxTitel
            // 
            textBoxTitel.Location = new Point(179, 48);
            textBoxTitel.Name = "textBoxTitel";
            textBoxTitel.Size = new Size(122, 23);
            textBoxTitel.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(339, 48);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 3;
            // 
            // buttonCreateAdvert
            // 
            buttonCreateAdvert.Location = new Point(348, 19);
            buttonCreateAdvert.Name = "buttonCreateAdvert";
            buttonCreateAdvert.Size = new Size(91, 23);
            buttonCreateAdvert.TabIndex = 4;
            buttonCreateAdvert.Text = "Skapa annons";
            buttonCreateAdvert.UseVisualStyleBackColor = true;
            buttonCreateAdvert.Click += buttonCreateAdvert_Click;
            // 
            // buttonUpdateAdvert
            // 
            buttonUpdateAdvert.Location = new Point(242, 18);
            buttonUpdateAdvert.Name = "buttonUpdateAdvert";
            buttonUpdateAdvert.Size = new Size(100, 23);
            buttonUpdateAdvert.TabIndex = 5;
            buttonUpdateAdvert.Text = "Uppdatera annons";
            buttonUpdateAdvert.UseVisualStyleBackColor = true;
            buttonUpdateAdvert.Click += buttonUpdateAdvert_Click;
            // 
            // buttonDeleteAdvert
            // 
            buttonDeleteAdvert.Location = new Point(144, 18);
            buttonDeleteAdvert.Name = "buttonDeleteAdvert";
            buttonDeleteAdvert.Size = new Size(92, 23);
            buttonDeleteAdvert.TabIndex = 6;
            buttonDeleteAdvert.Text = "Ta bort annons";
            buttonDeleteAdvert.UseVisualStyleBackColor = true;
            buttonDeleteAdvert.Click += buttonDeleteAdvert_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(18, 19);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(120, 23);
            comboBoxCategory.TabIndex = 7;
            // 
            // labelTitel
            // 
            labelTitel.AutoSize = true;
            labelTitel.Location = new Point(144, 51);
            labelTitel.Name = "labelTitel";
            labelTitel.Size = new Size(30, 15);
            labelTitel.TabIndex = 8;
            labelTitel.Text = "Titel";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(307, 51);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(26, 15);
            labelPrice.TabIndex = 9;
            labelPrice.Text = "Pris";
            // 
            // MyAdverts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 364);
            Controls.Add(labelPrice);
            Controls.Add(labelTitel);
            Controls.Add(comboBoxCategory);
            Controls.Add(buttonDeleteAdvert);
            Controls.Add(buttonUpdateAdvert);
            Controls.Add(buttonCreateAdvert);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxTitel);
            Controls.Add(richTextBoxDescription);
            Controls.Add(listBoxAdvert);
            Name = "MyAdverts";
            Text = "MyAdverts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAdvert;
        private RichTextBox richTextBoxDescription;
        private TextBox textBoxTitel;
        private TextBox textBoxPrice;
        private Button buttonCreateAdvert;
        private Button buttonUpdateAdvert;
        private Button buttonDeleteAdvert;
        private ComboBox comboBoxCategory;
        private Label labelTitel;
        private Label labelPrice;
    }
}