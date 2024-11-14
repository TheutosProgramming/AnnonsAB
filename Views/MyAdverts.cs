using AnnonsAB.Entities;
using AnnonsAB.Repository;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;

namespace AnnonsAB.Views
{
    public partial class MyAdverts : Form
    {
        private int _activeUser;

        public MyAdverts(int userID)
        {
            InitializeComponent();
            LoadCategoryComboBox();

            this._activeUser = userID;
            LoadUserAdverts(_activeUser);
        }

        private void buttonCreateAdvert_Click(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)comboBoxCategory.SelectedItem;

            AdvertRepo repo = new AdvertRepo();
            repo.CreateAdvert(_activeUser, selectedCategory.CategoryID, textBoxTitel.Text, richTextBoxDescription.Text, 
                              Convert.ToDecimal(textBoxPrice.Text), DateTime.Now);

            LoadUserAdverts(_activeUser);
            MessageBox.Show("Annonsen skapad");
        }

        private void buttonUpdateAdvert_Click(object sender, EventArgs e)
        {
            Advert selectedAdvert = (Advert)listBoxAdvert.SelectedItem;
            Category selectedCategory = (Category)comboBoxCategory.SelectedItem;

            AdvertRepo repo = new();
            repo.UpdateAdvert(selectedAdvert.AdvertID, selectedCategory.CategoryID, textBoxTitel.Text, richTextBoxDescription.Text, Convert.ToDecimal(textBoxPrice.Text));

            LoadUserAdverts(_activeUser);

            MessageBox.Show("Annonsen uppdaterad");
        }

        private void buttonDeleteAdvert_Click(object sender, EventArgs e)
        {
            Advert selectedAdvert = (Advert)listBoxAdvert.SelectedItem;
            AdvertRepo repo = new();
            repo.DeleteAdvert(selectedAdvert.AdvertID);

            LoadUserAdverts(_activeUser);
            MessageBox.Show("Annonsen borttagen");
        }

        private void listBoxAdvert_SelectedIndexChanged(object sender, EventArgs e)
        {
            Advert selectedAdvert = (Advert)listBoxAdvert.SelectedItem;

            if (selectedAdvert != null)
            {
                textBoxTitel.Text = selectedAdvert.Titel;
                richTextBoxDescription.Text = selectedAdvert.Description;
                textBoxPrice.Text = selectedAdvert.Price.ToString("G29");
            }
        }

        public void LoadCategoryComboBox()
        {
            CategoryRepo repo = new CategoryRepo();
            var result = repo.GetCategoryList();

            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryID";
            comboBoxCategory.DataSource = repo.GetCategoryList();
        }

        private void LoadUserAdverts(int userID)
        {
            AdvertRepo repo = new AdvertRepo();
            var result = repo.GetUserAdvertList(userID);

            listBoxAdvert.DisplayMember = "Titel";
            listBoxAdvert.ValueMember = "AdvertID";
            listBoxAdvert.DataSource = result;
        }
    }
}
