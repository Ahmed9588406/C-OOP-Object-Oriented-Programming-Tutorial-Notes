namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();

            BankAccount bankaccount = new BankAccount("Ahmed Alaa");
            //bankaccount.Owner = "Ahmed Alaa";
            //bankaccount.AccountNumber = Guid.NewGuid();
            //bankaccount.Balance = 250;


            //BankAccount bankaccount2 = new BankAccount("Mohamed Alaa");
            //bankaccount2.Owner = "Mohamed Alaa";
            //bankaccount2.AccountNumber = Guid.NewGuid();
            //bankaccount2.Balance = 9999;


            //BankAccount bankaccount3 = new BankAccount("Elon Mask");
            //bankaccount3.Owner = "Elon Mask";
            //bankaccount3.AccountNumber = Guid.NewGuid();
            //bankaccount3.Balance = 5000;

            //BankAccount bankaccount4 = new BankAccount("Mark joe");

            //bankAccounts.Add(bankaccount);
            //bankAccounts.Add(bankaccount2);
            //bankAccounts.Add(bankaccount3);
            //bankAccounts.Add(bankaccount4);


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
            if (string.IsNullOrWhiteSpace(OwnerName.Text))
            {
                MessageBox.Show("Owner name is required");
                return;
            }
            string name = OwnerName.Text.Trim();
            MessageBox.Show($"Name of the Account: {name}");
            BankAccount newAccount = new BankAccount(name);
            bankAccounts.Add(newAccount);
            RefreshGrid();
            OwnerName.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void OwnerName_TextChanged(object sender, EventArgs e)
        {

        }
        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = bankAccounts;
        }
    }
}
