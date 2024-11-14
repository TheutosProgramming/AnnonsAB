using AnnonsAB.Entities;
using AnnonsAB.Repository;

namespace AnnonsAB.Views
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "" || textBoxPassword.Text == "" || textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxAddress.Text == "" ||
                textBoxCity.Text == "" || textBoxEmail.Text == "" || textBoxPhone.Text == "")
            {
                MessageBox.Show("Du kan inte lämna några fält tomma!");
            }
            else 
            {
                UserRepo repo = new UserRepo();

                repo.CreateNewUser(textBoxUserName.Text, textBoxPassword.Text, textBoxFirstName.Text, textBoxLastName.Text, textBoxAddress.Text,
                                             textBoxCity.Text, textBoxEmail.Text, textBoxPhone.Text);

                MessageBox.Show("Profilen sparad");
            }
        }
    }
}
