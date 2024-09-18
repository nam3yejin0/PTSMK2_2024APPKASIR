namespace Lat2Tambahan_541231155
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }

        private void btnc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string usernm, passwd;
            usernm = txtuser.Text;
            passwd = txtpass.Text;

            if (usernm == "" && passwd == "541231155")
            {
                FormKasir fk = new FormKasir();
                fk.Show();
            }
            else
            {
                MessageBox.Show("Username dan Password salah");
                txtpass.Clear();
                txtuser.Clear();
                txtuser.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}