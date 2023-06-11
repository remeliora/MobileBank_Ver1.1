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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1.Forms
{
    public partial class PhoneTransferForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        Random rand = new Random();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        public PhoneTransferForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PhoneTransferForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PhoneTransferForm_Load(object sender, EventArgs e)
        {
            //PhoneTextBox.Text = DataStorage.phoneNumber;
            PhoneNumberbunifuTextBox.Text = DataStorage.phoneNumber;
            TextBoxCard.Text = DataStorage.cardNumber;

            var queryChooseOperator = $"select id_service, serviceName from clientServices where serviceType = 'Mobile'";
            SqlDataAdapter commandChooseOperator = new SqlDataAdapter(queryChooseOperator, database.getConnection());
            database.openConnection();
            DataTable operators = new DataTable();
            commandChooseOperator.Fill(operators);
            //MobileComboBox.DataSource = operators;
            MobilebunifuDropdown.DataSource = operators;
            //MobileComboBox.ValueMember = "id_service"; 
            MobilebunifuDropdown.ValueMember = "id_service";
            //MobileComboBox.DisplayMember = "serviceName";
            MobilebunifuDropdown.DisplayMember = "serviceName";
            database.closeConnection();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Дата сохранения";

            //string tmp = PhoneTextBox.Text;
            string tmp = PhoneNumberbunifuTextBox.Text;
            string phoneNumberToCheck = String.Concat(tmp[0], tmp[1], tmp[2]);

            //string selectOperator = MobileComboBox.GetItemText(MobileComboBox.SelectedItem);
            string selectOperator = MobilebunifuDropdown.GetItemText(MobilebunifuDropdown.SelectedItem);

            bool numberCheck = false;

            if (selectOperator == "Yota")
            {
                if (phoneNumberToCheck != "991" && phoneNumberToCheck != "996" && phoneNumberToCheck != "999")
                {
                    MessageBox.Show("Введите корректный номер телефона.", caption, btn, ico);
                    numberCheck = true;
                }
            }
            else if (selectOperator == "МегаФон")
            {
                if (phoneNumberToCheck != "924" && phoneNumberToCheck != "929" && phoneNumberToCheck != "934")
                {
                    MessageBox.Show("Введите корректный номер телефона.", caption, btn, ico);
                    numberCheck = true;
                }
            }
            else if (selectOperator == "МТС")
            {
                if (phoneNumberToCheck != "914" && phoneNumberToCheck != "984" && phoneNumberToCheck != "989")
                {
                    MessageBox.Show("Введите корректный номер телефона.", caption, btn, ico);
                    numberCheck = true;
                }
            }
            else if (selectOperator == "Билайн")
            {
                if (phoneNumberToCheck != "900" && phoneNumberToCheck != "903" && phoneNumberToCheck != "909")
                {
                    MessageBox.Show("Введите корректный номер телефона.", caption, btn, ico);
                    numberCheck = true;
                }
            }
            else if (selectOperator == "Tele2")
            {
                if (phoneNumberToCheck != "953" && phoneNumberToCheck != "958" && phoneNumberToCheck != "994")
                {
                    MessageBox.Show("Введите корректный номер телефона.", caption, btn, ico);
                    numberCheck = true;
                }
            }

            if (numberCheck == false)
            {
                //var phoneNumber = PhoneTextBox.Text;
                var phoneNumber = PhoneNumberbunifuTextBox.Text;
                //double sum = Convert.ToDouble(TextBoxSum.Text);
                double sum = Convert.ToDouble(SumbunifuTextBox.Text);
                var cardNumber = TextBoxCard.Text;
                var cardCVV = TextBoxCVV.Text;
                var cardDate = TextBoxCardTo.Text;
                var cardCVVCheck = "";
                var cardDateCheck = "";
                double cardBalanceCheck = 0;
                bool error = false;
                string cardCurrency = "";
                double commission = ((Convert.ToDouble(sum)) / 100);
                double totalSum = commission + Convert.ToDouble(sum);

                if /*(!Regex.IsMatch(PhoneTextBox.Text, "^[0-9]{7,11}$"))*/
                    (!Regex.IsMatch(PhoneNumberbunifuTextBox.Text, "^[0-9]{7,11}$"))
                {
                    MessageBox.Show("Пожалуйста, введите номер телефона", caption, btn, ico);
                    //PhoneTextBox.Select();
                    PhoneNumberbunifuTextBox.Select();
                    return;
                }

                var gueryCheckCard = $"select bank_card_cvv_code, CONCAT(FORMAT(bank_card_date, '%M'), '/', FORMAT(bank_card_date, '%y')), bank_card_balance, bank_card_currency from bank_card where bank_card_number = '{cardNumber}'";
                SqlCommand commandCheckCard = new SqlCommand(gueryCheckCard, database.getConnection());
                database.openConnection();
                SqlDataReader reader = commandCheckCard.ExecuteReader();

                while (reader.Read())
                {
                    cardCVVCheck = reader[0].ToString();
                    cardDateCheck = reader[1].ToString();
                    cardBalanceCheck = Convert.ToDouble(reader[2].ToString());
                    cardCurrency = reader[3].ToString();
                }
                reader.Close();

                if (cardCurrency != "RUB")
                {
                    MessageBox.Show("Пополнение мобильного может происходить только в рублях", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }

                if (cardCVV != cardCVVCheck)
                {
                    MessageBox.Show("Ошибка. Некорректно введён CVV-код", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }

                if (cardDate != cardDateCheck)
                {
                    MessageBox.Show("Ошибка. Некорректно введена дата карты", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }

                if (Convert.ToDouble(sum) < 5.00)
                {
                    MessageBox.Show("Ошибка. Минимальная сумма пополнения 5.00 рублей", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }

                if (sum > cardBalanceCheck)
                {
                    MessageBox.Show("Ошибка. Недостаточно средств для совершения операции", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }

                if (error == false)
                {
                    DataStorage.bankCard = TextBoxCard.Text;
                    ValidationForm validation = new ValidationForm();
                    validation.ShowDialog();

                    if (DataStorage.attempts > 0)
                    {
                        DateTime transactionDate = DateTime.Now;
                        var transactionNumber = "P";
                        for (int i = 0; i < 10; i++)
                        {
                            transactionNumber += Convert.ToString(rand.Next(0, 10));
                        }

                        var queryTransaction1 = $"update bank_card set bank_card_balance = bank_card_balance - '{totalSum}' where bank_card_number = '{cardNumber}'";

                        //var queryTransaction2 = $"insert into transactions(transaction_type, transaction_destination, transaction_date, transaction_number, transaction_value, id_bank_card) values('Пополнение мобильного', '+7{PhoneTextBox.Text}', '{transactionDate}', '{transactionNumber}', '{totalSum}', (select id_bank_card from bank_card where bank_card_number = '{cardNumber}'))";
                        var queryTransaction2 = $"insert into transactions(transaction_type, transaction_destination, transaction_date, transaction_number, transaction_value, id_bank_card) values('Пополнение мобильного', '+7{PhoneNumberbunifuTextBox.Text}', '{transactionDate}', '{transactionNumber}', '{totalSum}', (select id_bank_card from bank_card where bank_card_number = '{cardNumber}'))";

                        //var queryTransaction3 = $"update clientServices set serviceBalance = serviceBalance + '{sum}' where serviceName = '{MobileComboBox.GetItemText(MobileComboBox.SelectedItem)}' and serviceType = 'Mobile'";
                        var queryTransaction3 = $"update clientServices set serviceBalance = serviceBalance + '{sum}' where serviceName = '{MobilebunifuDropdown.GetItemText(MobilebunifuDropdown.SelectedItem)}' and serviceType = 'Mobile'";

                        var command1 = new SqlCommand(queryTransaction1, database.getConnection());
                        var command2 = new SqlCommand(queryTransaction2, database.getConnection());
                        var command3 = new SqlCommand(queryTransaction3, database.getConnection());

                        database.openConnection();
                        
                        command1.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                        command3.ExecuteNonQuery();

                        database.closeConnection();

                        Close();
                    }
                }
            }
        }

        private void TextBoxSum_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSum.Text == string.Empty)
            {
                TextBoxSum.Text = null;
                labelCommission.Text = "0";
                labelTotalSum.Text = "0";
            }
            else
            {
                double sum = Convert.ToDouble(TextBoxSum.Text);
                labelCommission.Text = Convert.ToString((sum) / 100);
                labelTotalSum.Text = Convert.ToString(((sum) / 100) + sum);
            }
        }

        private void SumbunifuTextBox_TextChange(object sender, EventArgs e)
        {
            if (SumbunifuTextBox.Text == string.Empty)
            {
                SumbunifuTextBox.Text = null;
                labelCommission.Text = "0";
                labelTotalSum.Text = "0";
            }
            else
            {
                double sum = Convert.ToDouble(SumbunifuTextBox.Text);
                labelCommission.Text = Convert.ToString((sum) / 100);
                labelTotalSum.Text = Convert.ToString(((sum) / 100) + sum);
            }
        }
    }
}
