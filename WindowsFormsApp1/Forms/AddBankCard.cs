﻿using System;
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
    public partial class AddBankCard : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        Random rand = new Random();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        
        public AddBankCard()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        private void AddBankCard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBankCard_Load(object sender, EventArgs e)
        {
            //CardTypeComboBox.SelectedIndex = 0;
            CardTypebunifuDropdown.SelectedIndex = 0;
            //CurrencyComboBox.SelectedIndex = 0;
            CurrencybunifuDropdown.SelectedIndex = 0;
            //PaymentSystemComboBox.SelectedIndex = 0;
            PaymentSystembunifuDropdown.SelectedIndex = 0;
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            //var cardType = CardTypeComboBox.GetItemText(CardTypeComboBox.SelectedItem);
            var cardType = CardTypebunifuDropdown.GetItemText(CardTypebunifuDropdown.SelectedItem);
            //var currency = CurrencyComboBox.GetItemText(CurrencyComboBox.SelectedItem);
            var currency = CurrencybunifuDropdown.GetItemText(CurrencybunifuDropdown.SelectedItem);
            //var paymentSystem = PaymentSystemComboBox.GetItemText(PaymentSystemComboBox.SelectedItem);
            var paymentSystem = PaymentSystembunifuDropdown.GetItemText(PaymentSystembunifuDropdown.SelectedItem);
            var cardNumber = "";
            var cardPin = numericUpDownPin.Value;
            var cvvCode = "";
            bool isCardFree = false;
            DateTime dateTime = DateTime.Now;
            var cardDate = dateTime.AddYears(4);

            for (int i = 0; i < 3; i++)
            {
                cvvCode += Convert.ToString(rand.Next(0, 10));
            }

            do
            {
                if (paymentSystem == "Visa")
                {
                    cardNumber += "4";
                    for (int i = 0; i < 15; i++)
                    {
                        cardNumber += Convert.ToString(rand.Next(0, 10));
                    }
                }
                else if (paymentSystem == "Mastercard")
                {
                    cardNumber += "5";
                    for (int i = 0; i < 15; i++)
                    {
                        cardNumber += Convert.ToString(rand.Next(0, 10));
                    }
                }
                else if (paymentSystem == "Мир")
                {
                    cardNumber += "2";
                    for (int i = 0; i < 15; i++)
                    {
                        cardNumber += Convert.ToString(rand.Next(0, 10));
                    }
                }

                var queryCheckCardNumber = $"select * from bank_card where bank_card_number = '{cardNumber}'";

                SqlCommand command = new SqlCommand(queryCheckCardNumber, database.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    isCardFree = true;
                }
            }
            while (isCardFree == false);

            var queryAddNewCard = $"INSERT INTO bank_card(bank_card_type, bank_card_number, bank_card_cvv_code, bank_card_currency, bank_card_paymentSystem, bank_card_date, id_client, bank_card_pin) values ('{cardType}', '{cardNumber}', '{cvvCode}', '{currency}', '{paymentSystem}', '{cardDate}', '{DataStorage.idClient}', '{cardPin}' )";
            SqlCommand commandAddNewCard = new SqlCommand(queryAddNewCard, database.getConnection());
            database.openConnection();
            commandAddNewCard.ExecuteNonQuery();
            database.closeConnection();

            MessageBox.Show("Карта успешно создана", "Данные сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
