namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount bankaccount = new BankAccount("Ahmed Alaa");
            //bankaccount.Owner = "Ahmed Alaa";
            //bankaccount.AccountNumber = Guid.NewGuid();
            //bankaccount.Balance = 250;


            BankAccount bankaccount2 = new BankAccount("Mohamed Alaa");
            //bankaccount2.Owner = "Mohamed Alaa";
            //bankaccount2.AccountNumber = Guid.NewGuid();
            //bankaccount2.Balance = 9999;


            BankAccount bankaccount3 = new BankAccount("Elon Mask");
            //bankaccount3.Owner = "Elon Mask";
            //bankaccount3.AccountNumber = Guid.NewGuid();
            //bankaccount3.Balance = 5000;

            BankAccount bankaccount4 = new BankAccount("Mark joe");

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankaccount);
            bankAccounts.Add(bankaccount2);
            bankAccounts.Add(bankaccount3);
            bankAccounts.Add(bankaccount4);


            BankAccountsGrid.DataSource = bankAccounts;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
