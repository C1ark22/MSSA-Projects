
namespace Assignment4._2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userLogin = txtboxUserID.Text;
            string password = txtboxPassword.Text;

            if (userLogin == "Teacher" && password == "Admin")
            {
                this.Hide();

                // opens studentForm 
                Form2 studentForm = new Form2();
                studentForm.ShowDialog();

                txtboxPassword.Clear();

                this.Show();
            }
            else
            {
                MessageBox.Show("Incorrect user or password. Try again.");
            }
        }
    }
}
