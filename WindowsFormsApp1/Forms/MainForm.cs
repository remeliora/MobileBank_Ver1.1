using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Forms
{
    public partial class MainForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            AddBankCard addBankCard = new AddBankCard();
            addBankCard.ShowDialog();

            //int index = CardsComboBox.SelectedIndex;
            int index = CardsbunifuDropdown.SelectedIndex;
            var queryMyCards = $"select id_bank_card, bank_card_number from bank_card where id_client = '{DataStorage.idClient}'";
            SqlDataAdapter commandMyCards = new SqlDataAdapter(queryMyCards, database.getConnection());
            database.openConnection();
            DataTable cards = new DataTable();
            commandMyCards.Fill(cards);
            //CardsComboBox.DataSource = cards;
            CardsbunifuDropdown.DataSource = cards;
            //CardsComboBox.ValueMember = "id_bank_card";
            CardsbunifuDropdown.ValueMember = "id_bank_card";
            //CardsComboBox.DisplayMember = "bank_card_number";
            CardsbunifuDropdown.DisplayMember = "bank_card_number";
            database.closeConnection();
            //CardsComboBox.SelectedIndex = index;
            CardsbunifuDropdown.SelectedIndex = index;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label_cardNumber.BringToFront();
            label_cardNumber.Text = "";
            label3.BringToFront();
            label_cardTo.BringToFront();
            label5.BringToFront();
            label_cardCvv.BringToFront();
            label_cardCurrency.BringToFront();
            label_cardBalance.BringToFront();
            pictureBoxMIR.Visible = true;
            pictureBoxMastercard.Visible = false;
            pictureBoxVisa.Visible = false;

            var queryMyCards = $"select id_bank_card, bank_card_number from bank_card where id_client = '{DataStorage.idClient}'";
            SqlDataAdapter commandMyCards = new SqlDataAdapter(queryMyCards, database.getConnection());
            database.openConnection();
            DataTable cards = new DataTable();
            commandMyCards.Fill(cards);
            //CardsComboBox.DataSource = cards;
            CardsbunifuDropdown.DataSource = cards;
            //CardsComboBox.ValueMember = "id_bank_card";
            CardsbunifuDropdown.ValueMember = "id_bank_card";
            //CardsComboBox.DisplayMember = "bank_card_number";
            CardsbunifuDropdown.DisplayMember = "bank_card_number";
            database.closeConnection();

            selectBankCard();
        }   

        private void selectBankCard()
        {
            label_cardNumber.Text = "";
            string paymentSystem = "";
            //string querySelectCard = $"select bank_card_number, bank_card_cvv_code, CONCAT(FORMAT(bank_card_date, '%M'), '/', FORMAT(bank_card_date, '%y')), bank_card_paymentSystem, bank_card_balance, bank_card_currency from bank_card where bank_card_number = '{CardsComboBox.GetItemText(CardsComboBox.SelectedItem)}'";
            string querySelectCard = $"select bank_card_number, bank_card_cvv_code, CONCAT(FORMAT(bank_card_date, '%M'), '/', FORMAT(bank_card_date, '%y')), bank_card_paymentSystem, bank_card_balance, bank_card_currency from bank_card where bank_card_number = '{CardsbunifuDropdown.GetItemText(CardsbunifuDropdown.SelectedItem)}'";
            SqlCommand command = new SqlCommand(querySelectCard, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var cardNumber = reader[0].ToString();

                int tmp = 0;
                int tmp1 = 4;
                for (int m = 0; m < 4; m++)
                {
                    for (int n = tmp; n < tmp1; n++)
                    {
                        label_cardNumber.Text += cardNumber[n].ToString();
                    }
                    label_cardNumber.Text += " ";
                    tmp += 4;
                    tmp1 += 4;
                }

                label_cardCvv.Text = reader[1].ToString();
                label_cardTo.Text = reader[2].ToString();
                paymentSystem = reader[3].ToString();
                label_cardBalance.Text = Math.Round(Convert.ToDouble(reader[4]), 2).ToString();
                label_cardCurrency.Text = reader[5].ToString();
                DataStorage.cardCVV = label_cardCvv.Text;
                label_cardCvv.Text = "***";
            }
            reader.Close();

            if (paymentSystem == "Мир")
            {
                pictureBoxMIR.Visible = true;
                pictureBoxMastercard.Visible = false;
                pictureBoxVisa.Visible = false;
            }
            else if (paymentSystem == "Mastercard")
            {
                pictureBoxMastercard.Visible = true;
                pictureBoxMIR.Visible = false;
                pictureBoxVisa.Visible = false;
            }
            else if (paymentSystem == "Visa")
            {
                pictureBoxVisa.Visible = true;
                pictureBoxMastercard.Visible = false;
                pictureBoxMIR.Visible= false;
            }

        }

        private void label_cardCvv_Click(object sender, EventArgs e)
        {
            if (label_cardCvv.Text == "***")
            {
                label_cardCvv.Text = DataStorage.cardCVV;
            }
            else
                label_cardCvv.Text = "***";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*var queryMyCards = $"select id_bank_card, bank_card_number from bank_card where id_client = '{DataStorage.idClient}'";
            SqlDataAdapter commandMyCards = new SqlDataAdapter(queryMyCards, database.getConnection());
            database.openConnection();
            DataTable cards = new DataTable();
            commandMyCards.Fill(cards);
            CardsComboBox.DataSource = cards;
            CardsComboBox.ValueMember = "id_bank_card";
            CardsComboBox.DisplayMember = "bank_card_number";
            database.closeConnection();*/

            selectBankCard();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CardsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectBankCard();
        }

        private void CardsbunifuDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectBankCard();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            SendToForm sendToForm = new SendToForm();
            DataStorage.bankCard = CardTextBox.Text;
            //DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);
            DataStorage.cardNumber = CardsbunifuDropdown.GetItemText(CardsbunifuDropdown.SelectedItem);
            //CardsComboBox.Text = "";
            CardsbunifuDropdown.Text = "";
            sendToForm.ShowDialog();
        }

        private void PictureBoxTransactions_Click(object sender, EventArgs e)
        {
            HistoryForm history = new HistoryForm();
            history.Show();
        }

        private void PictureBoxUser_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            user.Show();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            PhoneTransferForm phoneTransfer = new PhoneTransferForm();
            //DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);
            DataStorage.cardNumber = CardsbunifuDropdown.GetItemText(CardsbunifuDropdown.SelectedItem);
            DataStorage.phoneNumber = PhoneTextBox.Text;
            PhoneTextBox.Text = "";
            phoneTransfer.Show();
        }

        private void buttonComunal_Click(object sender, EventArgs e)
        {
            CommunalPaymentsForm communalPayments = new CommunalPaymentsForm();
            //DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);
            DataStorage.cardNumber = CardsbunifuDropdown.GetItemText(CardsbunifuDropdown.SelectedItem);
            communalPayments.Show();
        }

        private void buttonInternet_Click(object sender, EventArgs e)
        {
            InternetAndTVPaymentsForm internetAndTVPayments = new InternetAndTVPaymentsForm();
            //DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);
            DataStorage.cardNumber = CardsbunifuDropdown.GetItemText(CardsbunifuDropdown.SelectedItem);
            internetAndTVPayments.Show();
        }

        private void buttonCredit_Click(object sender, EventArgs e)
        {
            //DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);
            DataStorage.cardNumber = CardsbunifuDropdown.GetItemText(CardsbunifuDropdown.SelectedItem);
            var cardCurrency = "";
            var queryCheckCurrency = $"select bank_card_currency from bank_card where bank_card_number = '{DataStorage.cardNumber}'";
            SqlCommand commandCheckCurrency = new SqlCommand(queryCheckCurrency, database.getConnection());
            SqlDataReader reader = commandCheckCurrency.ExecuteReader();
            while (reader.Read())
            {
                cardCurrency = reader[0].ToString();
            }
            reader.Close();

            if (cardCurrency == "RUB")
            {
                CreditForm credit = new CreditForm();
                credit.Show();
            }
            else
                MessageBox.Show("Операции с кредитом могут производиться только в рублях", "Отказ", MessageBoxButtons.OK, MessageBoxIcon.Information)   ;
        }
    }
}
