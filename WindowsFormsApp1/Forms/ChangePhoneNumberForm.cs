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
    public partial class ChangePhoneNumberForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        public ChangePhoneNumberForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangePhoneNumberForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ChangePhoneButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Дата сохранения";

            if /*(!Regex.IsMatch(PhoneNumberTextBox.Text, "^[+][7][0-9]{7,11}$"))*/
                (!Regex.IsMatch(PhoneNumberbunifuTextBox.Text, "^[+][7][0-9]{7,11}$"))
            {
                MessageBox.Show("Пожалуйста, введите номер телефона", caption, btn, ico);
                //PhoneNumberTextBox.Select();
                PhoneNumberbunifuTextBox.Select();
                return;
            }

            //var phonenumber = PhoneNumberTextBox.Text;
            var phonenumber = PhoneNumberbunifuTextBox.Text;
            var changeNumberQuery = $"update client set client_phone_number = '{phonenumber}' where id_client = '{DataStorage.idClient}'";
            var command = new SqlCommand(changeNumberQuery, database.getConnection());
            database.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Номер телефона успешно изменён!");
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
            database.closeConnection();
        }
    }
}
