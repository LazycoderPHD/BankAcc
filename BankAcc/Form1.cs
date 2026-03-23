namespace BankAcc
{
    public partial class Form1 : Form
    {
        List<BankAcc> BankAccs = new List<BankAcc>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
            {
                return;
            }

            BankAcc bankacc = new BankAcc(OwnerTxt.Text);
            BankAccs.Add(bankacc);

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            BankAccsGrid.DataSource = null;
            BankAccsGrid.DataSource = BankAccs;
        }
    }
}
