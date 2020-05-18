using System;
using System.Windows.Forms;

namespace ProjectEmber
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            loginTextBox.MaxLength = GlobalVars.NameLength;
            nameLabel.Text = nameLabel.Text.Replace("%s", loginTextBox.MaxLength.ToString());
        }

        private void Login_Closing(object sender, EventArgs e)
        {
            //save name here
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GlobalVars.Name))
            {
                MessageBox.Show("Your name must be up to 32 characters in length", "Harmony | Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            GlobalVars.Name = loginTextBox.Text.Trim();
        }
    }
}
