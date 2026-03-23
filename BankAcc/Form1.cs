namespace BankAcc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAcc bankacc1 = new BankAcc("Phat");
            BankAcc bankacc2 = new BankAcc("Elon");
            BankAcc bankacc3 = new BankAcc("Levi");
            BankAcc bankacc4 = new BankAcc("Lmao");


            List<BankAcc> bankaccs = new List<BankAcc>();
            bankaccs.Add(bankacc1);
            bankaccs.Add(bankacc2);
            bankaccs.Add(bankacc3);
            bankaccs.Add(bankacc4);


            BankAccsGrid.DataSource = bankaccs;
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
