namespace BankAcc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAcc bankacc1 = new BankAcc();
            bankacc1.Owner = "Phat";
            bankacc1.AccNum = Guid.NewGuid();
            bankacc1.Balance = 100;

            BankAcc bankacc2 = new BankAcc();
            bankacc2.Owner = "Elon";
            bankacc2.AccNum = Guid.NewGuid();
            bankacc2.Balance = 9000;

            BankAcc bankacc3 = new BankAcc();
            bankacc3.Owner = "Levi";
            bankacc3.AccNum = Guid.NewGuid();
            bankacc3.Balance = 1;

            List<BankAcc> bankaccs = new List<BankAcc>();
            bankaccs.Add(bankacc1);
            bankaccs.Add(bankacc2);
            bankaccs.Add(bankacc3);

            BankAccsGrid.DataSource = bankaccs;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
