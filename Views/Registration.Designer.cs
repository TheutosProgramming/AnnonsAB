namespace AnnonsAB.Views
{
    partial class Registration
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
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxCity = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            labelUserName = new Label();
            labelPassword = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelAddress = new Label();
            labelCity = new Label();
            labelEmail = new Label();
            labelPhone = new Label();
            buttonCreateAccount = new Button();
            SuspendLayout();
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(15, 34);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(177, 23);
            textBoxUserName.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(15, 78);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(177, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(15, 122);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(177, 23);
            textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(15, 166);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(177, 23);
            textBoxLastName.TabIndex = 3;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(198, 34);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(177, 23);
            textBoxAddress.TabIndex = 4;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(198, 78);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(177, 23);
            textBoxCity.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(198, 122);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(177, 23);
            textBoxEmail.TabIndex = 6;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(198, 166);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(177, 23);
            textBoxPhone.TabIndex = 7;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(15, 16);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(89, 15);
            labelUserName.TabIndex = 10;
            labelUserName.Text = "Användarnamn";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(15, 60);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(56, 15);
            labelPassword.TabIndex = 11;
            labelPassword.Text = "Lösenord";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(15, 104);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(55, 15);
            labelFirstName.TabIndex = 12;
            labelFirstName.Text = "Förnamn";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(15, 148);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(62, 15);
            labelLastName.TabIndex = 13;
            labelLastName.Text = "Efternamn";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(198, 14);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(42, 15);
            labelAddress.TabIndex = 14;
            labelAddress.Text = "Adress";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(198, 60);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(30, 15);
            labelCity.TabIndex = 15;
            labelCity.Text = "Stad";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(198, 104);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "Epost";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(198, 148);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(91, 15);
            labelPhone.TabIndex = 17;
            labelPhone.Text = "Telefonnummer";
            // 
            // buttonCreateAccount
            // 
            buttonCreateAccount.Location = new Point(279, 195);
            buttonCreateAccount.Name = "buttonCreateAccount";
            buttonCreateAccount.Size = new Size(96, 23);
            buttonCreateAccount.TabIndex = 20;
            buttonCreateAccount.Text = "Create account";
            buttonCreateAccount.UseVisualStyleBackColor = true;
            buttonCreateAccount.Click += buttonCreateAccount_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 231);
            Controls.Add(buttonCreateAccount);
            Controls.Add(labelPhone);
            Controls.Add(labelEmail);
            Controls.Add(labelCity);
            Controls.Add(labelAddress);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxAddress;
        private TextBox textBoxCity;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private Label labelUserName;
        private Label labelPassword;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelAddress;
        private Label labelCity;
        private Label labelEmail;
        private Label labelPhone;
        private Button buttonCreateAccount;
    }
}