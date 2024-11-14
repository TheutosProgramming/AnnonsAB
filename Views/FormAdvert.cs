using AnnonsAB.Entities;
using AnnonsAB.Repository;
using AnnonsAB.Views;
using System.Data;

namespace AnnonsAB
{
    public partial class FormAdvert : Form
    {
        public FormAdvert()
        {
            InitializeComponent();
            LoadAdverts();
            LoadCategoryComboBox();
            LoadComboBoxSortBy();
        }

        int userID;

        private void buttonLoggIn_Click(object sender, EventArgs e)
        {
            UserRepo repo = new UserRepo();
            List<User> users = repo.Login(textBoxUsername.Text, textBoxPassword.Text);

            if (users.Count == 1)
            {
                userID = users[0].UserID;

                labelUsername.Visible = false;
                labelPassword.Visible = false;
                textBoxUsername.Visible = false;
                textBoxPassword.Visible = false;
                buttonCreateAccount.Visible = false;
                buttonLoggIn.Visible = false;
                labelLoggedIn.Text = $"Välkommen {textBoxUsername.Text}";
                labelLoggedIn.Visible = true;
                buttonMyAdverts.Visible = true;
                buttonLoggOut.Visible = true;
            }
            else
            {
                MessageBox.Show("Felaktigt användarnamn eller lösenord");
            }
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }

        private void buttonMyAdverts_Click(object sender, EventArgs e)
        {
            MyAdverts myAdverts = new MyAdverts(userID);
            myAdverts.Show();
        }

        private void buttonLoggOut_Click(object sender, EventArgs e)
        {
            labelUsername.Visible = true;
            labelPassword.Visible = true;
            textBoxUsername.Visible = true;
            textBoxPassword.Visible = true;
            buttonCreateAccount.Visible = true;
            buttonLoggIn.Visible = true;
            labelLoggedIn.Visible = false;
            buttonMyAdverts.Visible = false;
            buttonLoggOut.Visible = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            AdvertRepo repo = new AdvertRepo();

            listBoxAdverts.DisplayMember = "Titel";
            listBoxAdverts.ValueMember = "AdvertID";
            listBoxAdverts.DataSource = repo.SearchAdvert(textBoxSearch.Text, comboBoxCategory.Text, comboBoxSortBy.Text);
        }

        private void listBoxAdverts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Advert selectedAdvert = (Advert)listBoxAdverts.SelectedItem;

            if (selectedAdvert != null)
            {
                textBoxTitel.Text = selectedAdvert.Titel;
                richTextBoxAdvert.Text = selectedAdvert.Description;
                textBoxPrice.Text = selectedAdvert.Price.ToString("G29");
            }
        }

        private void LoadAdverts()
        {
            AdvertRepo repo = new AdvertRepo();
            var result = repo.GetAdvertList();

            listBoxAdverts.DisplayMember = "Titel";
            listBoxAdverts.ValueMember = "AdvertID";
            listBoxAdverts.DataSource = result;
        }

        public void LoadCategoryComboBox()
        {
            CategoryRepo repo = new CategoryRepo();
            var result = repo.GetCategoryList();

            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryID";
            comboBoxCategory.DataSource = repo.GetCategoryList();
        }

        public void LoadComboBoxSortBy()
        {
            comboBoxSortBy.Items.Add("Lägsta pris");
            comboBoxSortBy.Items.Add("Högsta pris");
            comboBoxSortBy.Items.Add("Senaste");
            comboBoxSortBy.Items.Add("Äldst");
            comboBoxSortBy.Items.Add("A-Ö");
            comboBoxSortBy.Items.Add("Ö-A");
        }
    }
}
