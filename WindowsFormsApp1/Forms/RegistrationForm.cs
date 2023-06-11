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
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Forms
{
    public partial class RegistrationForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        public RegistrationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            //LastNameTextBox.Select(); 
            LastNamebunifuTextBox.Select();
            //PasswordTextBox.PasswordChar = '●';
            PasswordbunifuTextBox.PasswordChar = '●';
            //ConfirmPasswordTextBox.PasswordChar = '●';
            ConfirmPasswordbunifuTextBox.PasswordChar = '●';
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;

            string caption = "Дата сохранения";

            if /*(!Regex.IsMatch(LastNameTextBox.Text, "[А-Яа-я]+$"))*/
                (!Regex.IsMatch(LastNamebunifuTextBox.Text, "[А-Яа-я]+$"))
            {
                MessageBox.Show("Подалуйста, введите фамилию повторно", caption, btn, ico);
                //LastNameTextBox.Select();
                LastNamebunifuTextBox.Select();
                return;
            }

            if /*(!Regex.IsMatch(FirstNameTextBox.Text, "[А-Яа-я]+$"))*/
                (!Regex.IsMatch(FirstNamebunifuTextBox.Text, "[А-Яа-я]+$"))
            {
                MessageBox.Show("Подалуйста, введите имя повторно", caption, btn, ico);
                //LastNameTextBox.Select();
                FirstNamebunifuTextBox.Select();
                return;
            }

            if /*(!Regex.IsMatch(MiddleNameTextBox.Text, "[А-Яа-я]+$"))*/
                (!Regex.IsMatch(MiddleNamebunifuTextBox.Text, "[А-Яа-я]+$"))
            {
                MessageBox.Show("Подалуйста, введите отчество повторно", caption, btn, ico);
                //LastNameTextBox.Select();
                MiddleNamebunifuTextBox.Select();
                return;
            }
/*
            if(string.IsNullOrEmpty(GenderComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Пожалуйста, выберите пол", caption, btn, ico);
                GenderComboBox.Select();
                return;
            }*/

            if (string.IsNullOrEmpty(GenderbunifuDropdown.SelectedItem.ToString()))
            {
                MessageBox.Show("Пожалуйста, выберите пол", caption, btn, ico);
                GenderbunifuDropdown.Select();
                return;
            }

            if /*(!Regex.IsMatch(PasswordTextBox.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))*/
                (!Regex.IsMatch(PasswordbunifuTextBox.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                MessageBox.Show("Пожалуйста, введите пароль", caption, btn, ico);
                //PasswordTextBox.Select();
                PasswordbunifuTextBox.Select();
                return;
            }

            if /*(!Regex.IsMatch(ConfirmPasswordTextBox.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))*/
                (!Regex.IsMatch(ConfirmPasswordbunifuTextBox.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                MessageBox.Show("Пожалуйста, введите пароль повторно", caption, btn, ico);
                //PasswordTextBox.Select();
                ConfirmPasswordbunifuTextBox.Select();
                return;
            }

            if /*(PasswordTextBox.Text != ConfirmPasswordTextBox.Text)*/
                (PasswordbunifuTextBox.Text != ConfirmPasswordbunifuTextBox.Text)
            {
                MessageBox.Show("Пароли не совпадают!", caption, btn, ico);
                //ConfirmPasswordTextBox.SelectAll();
                ConfirmPasswordbunifuTextBox.SelectAll();
                return;
            }

            if /*(!Regex.IsMatch(EmailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))*/
                (!Regex.IsMatch(EmailbunifuTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Пожалуйста, введите электронную почту", caption, btn, ico);
                //EmailTextBox.SelectAll();
                EmailbunifuTextBox.SelectAll();
                return;
            }

            if /*(!Regex.IsMatch(PhoneNumberextBox.Text, "^[+][7][0-9]{7,11}$"))*/
                (!Regex.IsMatch(PhoneNumberbunifuTextBox.Text, "^[+][7][0-9]{7,11}$"))
            {
                MessageBox.Show("Пожалуйста, введите номер телефона",caption, btn, ico);
                //PhoneNumberextBox.SelectAll();
                PhoneNumberbunifuTextBox.SelectAll();
                return;
            }

            /*string yourSQL = "SELECT client_phone_number FROM client WHERE client_phone_number = '" + PhoneNumberextBox.Text + "'";*/
            string yourSQL = "SELECT client_phone_number FROM client WHERE client_phone_number = '" + PhoneNumberbunifuTextBox.Text + "'";

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(yourSQL, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Номер телефона уже существует. Невозможно зарегистрировать аккаунт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //PhoneNumberextBox.SelectAll();
                PhoneNumberbunifuTextBox.SelectAll();
                return;
            }

            DialogResult result;
            result = MessageBox.Show("Вы хотите сохранить введённые данные?", "Сохранение данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string mySQL = string.Empty;

                mySQL += "INSERT INTO client (client_last_name, client_first_name, client_middle_name, client_gender, client_password, client_email, client_phone_number) ";
                /*mySQL += "VALUES ('" + LastNameTextBox.Text + "','" + FirstNameTextBox.Text + "','" + MiddleNameTextBox.Text + "',";*/
                mySQL += "VALUES ('" + LastNamebunifuTextBox.Text + "','" + FirstNamebunifuTextBox.Text + "','" + MiddleNamebunifuTextBox.Text + "',";
                //mySQL += "'" + GenderComboBox.SelectedItem.ToString() + "','" + PasswordTextBox.Text + "','" + EmailTextBox.Text + "','" + PhoneNumberextBox.Text + "')";
                mySQL += "'" + GenderbunifuDropdown.SelectedItem.ToString() + "','" + PasswordbunifuTextBox.Text + "','" + EmailbunifuTextBox.Text + "','" + PhoneNumberbunifuTextBox.Text + "')";

                database.openConnection();
                SqlCommand commandAddNewUser = new SqlCommand(mySQL, database.getConnection());
                commandAddNewUser.ExecuteNonQuery();

                MessageBox.Show("Запись успешно сохранена", "Данные сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearControls();
                database.closeConnection();
                Close();
            }
        }

        private void clearControls()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                textBox.Text = string.Empty;
            }

            foreach (ComboBox comboBox in Controls.OfType<ComboBox>())
            {
                comboBox.SelectedItem = null;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //LastNameTextBox.Select();
            LastNamebunifuTextBox.Select();
            clearControls();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true)
            {
                PasswordbunifuTextBox.UseSystemPasswordChar = true;
                ConfirmPasswordbunifuTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordbunifuTextBox.UseSystemPasswordChar = false;
                ConfirmPasswordbunifuTextBox.UseSystemPasswordChar = false;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
