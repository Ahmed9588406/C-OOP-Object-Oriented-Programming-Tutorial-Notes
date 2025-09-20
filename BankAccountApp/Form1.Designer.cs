namespace BankAccountApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            OwnerName = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            Depositebtn = new Button();
            Withdrawbtn = new Button();
            CreateAccountbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 19);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 41);
            label1.TabIndex = 0;
            label1.Text = "Owner";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 403);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 41);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            label2.Click += label2_Click;
            // 
            // OwnerName
            // 
            OwnerName.Location = new Point(176, 19);
            OwnerName.Name = "OwnerName";
            OwnerName.Size = new Size(281, 47);
            OwnerName.TabIndex = 2;
            OwnerName.TextChanged += OwnerName_TextChanged;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(176, 401);
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(281, 47);
            AmountNum.TabIndex = 3;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(505, 12);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 51;
            BankAccountsGrid.Size = new Size(755, 367);
            BankAccountsGrid.TabIndex = 4;
            // 
            // Depositebtn
            // 
            Depositebtn.Location = new Point(505, 401);
            Depositebtn.Name = "Depositebtn";
            Depositebtn.Size = new Size(351, 55);
            Depositebtn.TabIndex = 5;
            Depositebtn.Text = "Deposite";
            Depositebtn.TextAlign = ContentAlignment.BottomCenter;
            Depositebtn.UseVisualStyleBackColor = true;
            // 
            // Withdrawbtn
            // 
            Withdrawbtn.Location = new Point(862, 403);
            Withdrawbtn.Name = "Withdrawbtn";
            Withdrawbtn.Size = new Size(366, 53);
            Withdrawbtn.TabIndex = 6;
            Withdrawbtn.Text = "Withdraw";
            Withdrawbtn.UseVisualStyleBackColor = true;
            Withdrawbtn.Click += button2_Click;
            // 
            // CreateAccountbtn
            // 
            CreateAccountbtn.Location = new Point(176, 129);
            CreateAccountbtn.Name = "CreateAccountbtn";
            CreateAccountbtn.Size = new Size(281, 55);
            CreateAccountbtn.TabIndex = 7;
            CreateAccountbtn.Text = "Create Account";
            CreateAccountbtn.UseVisualStyleBackColor = true;
            CreateAccountbtn.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 487);
            Controls.Add(CreateAccountbtn);
            Controls.Add(Withdrawbtn);
            Controls.Add(Depositebtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerName;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button Depositebtn;
        private Button Withdrawbtn;
        private Button CreateAccountbtn;
    }
}
