namespace AnnonsAB
{
    partial class FormAdvert
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            buttonLoggIn = new Button();
            listBoxAdverts = new ListBox();
            comboBoxCategory = new ComboBox();
            comboBoxSortBy = new ComboBox();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonCreateAccount = new Button();
            richTextBoxAdvert = new RichTextBox();
            textBoxPrice = new TextBox();
            textBoxTitel = new TextBox();
            buttonMyAdverts = new Button();
            labelLoggedIn = new Label();
            labelPrice = new Label();
            buttonLoggOut = new Button();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(200, 27);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(166, 23);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(372, 27);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(166, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(200, 9);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(89, 15);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Användarnamn";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(372, 9);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(56, 15);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Lösenord";
            // 
            // buttonLoggIn
            // 
            buttonLoggIn.Location = new Point(463, 56);
            buttonLoggIn.Name = "buttonLoggIn";
            buttonLoggIn.Size = new Size(75, 23);
            buttonLoggIn.TabIndex = 4;
            buttonLoggIn.Text = "Logga in";
            buttonLoggIn.UseVisualStyleBackColor = true;
            buttonLoggIn.Click += buttonLoggIn_Click;
            // 
            // listBoxAdverts
            // 
            listBoxAdverts.FormattingEnabled = true;
            listBoxAdverts.ItemHeight = 15;
            listBoxAdverts.Location = new Point(12, 173);
            listBoxAdverts.Name = "listBoxAdverts";
            listBoxAdverts.Size = new Size(188, 469);
            listBoxAdverts.TabIndex = 5;
            listBoxAdverts.SelectedIndexChanged += listBoxAdverts_SelectedIndexChanged;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(12, 144);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(91, 23);
            comboBoxCategory.TabIndex = 6;
            // 
            // comboBoxSortBy
            // 
            comboBoxSortBy.FormattingEnabled = true;
            comboBoxSortBy.Location = new Point(109, 143);
            comboBoxSortBy.Name = "comboBoxSortBy";
            comboBoxSortBy.Size = new Size(91, 23);
            comboBoxSortBy.TabIndex = 7;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(206, 143);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(248, 23);
            textBoxSearch.TabIndex = 8;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(460, 143);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonCreateAccount
            // 
            buttonCreateAccount.Location = new Point(372, 56);
            buttonCreateAccount.Name = "buttonCreateAccount";
            buttonCreateAccount.Size = new Size(85, 23);
            buttonCreateAccount.TabIndex = 10;
            buttonCreateAccount.Text = "Skapa konto";
            buttonCreateAccount.UseVisualStyleBackColor = true;
            buttonCreateAccount.Click += buttonCreateAccount_Click;
            // 
            // richTextBoxAdvert
            // 
            richTextBoxAdvert.BackColor = SystemColors.Window;
            richTextBoxAdvert.Location = new Point(206, 202);
            richTextBoxAdvert.Name = "richTextBoxAdvert";
            richTextBoxAdvert.ReadOnly = true;
            richTextBoxAdvert.Size = new Size(329, 440);
            richTextBoxAdvert.TabIndex = 11;
            richTextBoxAdvert.Text = "";
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = SystemColors.Window;
            textBoxPrice.Location = new Point(435, 173);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 12;
            // 
            // textBoxTitel
            // 
            textBoxTitel.BackColor = SystemColors.Window;
            textBoxTitel.Location = new Point(206, 172);
            textBoxTitel.Name = "textBoxTitel";
            textBoxTitel.ReadOnly = true;
            textBoxTitel.Size = new Size(188, 23);
            textBoxTitel.TabIndex = 13;
            // 
            // buttonMyAdverts
            // 
            buttonMyAdverts.Location = new Point(200, 56);
            buttonMyAdverts.Name = "buttonMyAdverts";
            buttonMyAdverts.Size = new Size(166, 23);
            buttonMyAdverts.TabIndex = 14;
            buttonMyAdverts.Text = "Mina annonser";
            buttonMyAdverts.UseVisualStyleBackColor = true;
            buttonMyAdverts.Visible = false;
            buttonMyAdverts.Click += buttonMyAdverts_Click;
            // 
            // labelLoggedIn
            // 
            labelLoggedIn.AutoSize = true;
            labelLoggedIn.Location = new Point(372, 35);
            labelLoggedIn.Name = "labelLoggedIn";
            labelLoggedIn.Size = new Size(153, 15);
            labelLoggedIn.TabIndex = 15;
            labelLoggedIn.Text = "Välkommen användarnamn";
            labelLoggedIn.Visible = false;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(400, 175);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(29, 15);
            labelPrice.TabIndex = 17;
            labelPrice.Text = "Pris:";
            // 
            // buttonLoggOut
            // 
            buttonLoggOut.Location = new Point(372, 56);
            buttonLoggOut.Name = "buttonLoggOut";
            buttonLoggOut.Size = new Size(166, 23);
            buttonLoggOut.TabIndex = 18;
            buttonLoggOut.Text = "Logga ut";
            buttonLoggOut.UseVisualStyleBackColor = true;
            buttonLoggOut.Visible = false;
            buttonLoggOut.Click += buttonLoggOut_Click;
            // 
            // FormAdvert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 654);
            Controls.Add(buttonLoggOut);
            Controls.Add(labelPrice);
            Controls.Add(labelLoggedIn);
            Controls.Add(buttonMyAdverts);
            Controls.Add(textBoxTitel);
            Controls.Add(textBoxPrice);
            Controls.Add(richTextBoxAdvert);
            Controls.Add(buttonCreateAccount);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(comboBoxSortBy);
            Controls.Add(comboBoxCategory);
            Controls.Add(listBoxAdverts);
            Controls.Add(buttonLoggIn);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Name = "FormAdvert";
            Text = "AnnonsAB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelUsername;
        private Label labelPassword;
        private Button buttonLoggIn;
        private ListBox listBoxAdverts;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxSortBy;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonCreateAccount;
        private RichTextBox richTextBoxAdvert;
        private TextBox textBoxPrice;
        private TextBox textBoxTitel;
        private Button buttonMyAdverts;
        private Label labelLoggedIn;
        private Label labelPrice;
        private Button buttonLoggOut;
    }
}
