using System.Windows.Forms;

namespace VPproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.Compare(txt_user.Text, "Maha_Tanveer") == 0 && string.Compare(txt_pass.Text, "22011556-023") == 0)

            {
                MessageBox.Show("correct login password");
            }
            else
            {
                MessageBox.Show("login failed");
            }
        } 
    }
}
