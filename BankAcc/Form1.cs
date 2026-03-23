namespace BankAcc
{
    public partial class Form1 : Form
    {
        List<BankAcc> BankAccs = new List<BankAcc>();

        public Form1()
        {
            InitializeComponent();


            


            BankAccsGrid.DataSource = BankAccs;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Im learning how to create a bankacc");
        }
    }
}
