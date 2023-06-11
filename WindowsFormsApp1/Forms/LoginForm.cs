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
    public partial class LoginForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public LoginForm()
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //PhoneNumberTextBox.Select();
            PhoneNumberbunifuTextBox.Select();
            //PasswordTextBox.PasswordChar = '*';
            PasswordbunifuTextBox.PasswordChar = '●';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true) 
            {
                //PasswordTextBox.UseSystemPasswordChar = true;
                PasswordbunifuTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                //PasswordTextBox.UseSystemPasswordChar = false;
                PasswordbunifuTextBox.UseSystemPasswordChar = false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if /*(!string.IsNullOrEmpty(PhoneNumberTextBox.Text) && !string.IsNullOrEmpty(PasswordTextBox.Text))*/
                (!string.IsNullOrEmpty(PhoneNumberbunifuTextBox.Text) && !string.IsNullOrEmpty(PasswordbunifuTextBox.Text))
            {
                //var querySelectClient = $"SELECT * FROM client WHERE client_phone_number = '{PhoneNumberTextBox.Text}' AND client_password = '{PasswordTextBox.Text}'";
                var querySelectClient = $"SELECT * FROM client WHERE client_phone_number = '{PhoneNumberbunifuTextBox.Text}' AND client_password = '{PasswordbunifuTextBox.Text}'";
                //var queryGetID = $"select id_client from client where client_phone_number = '{PhoneNumberTextBox.Text}'";
                var queryGetID = $"select id_client from client where client_phone_number = '{PhoneNumberbunifuTextBox.Text}'";
                var commandGetId = new SqlCommand(queryGetID, database.getConnection());

                database.openConnection();
                SqlDataReader reader = commandGetId.ExecuteReader();
                while (reader.Read())
                {
                    DataStorage.idClient = reader[0].ToString();
                }
                reader.Close();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand(querySelectClient, database.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    //PhoneNumberTextBox.Clear();
                    PhoneNumberbunifuTextBox.Clear();
                    //PasswordTextBox.Clear();
                    PasswordbunifuTextBox.Clear();
                    ShowPasswordCheckBox.Checked = true; ;

                    Hide();

                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    mainForm = null;

                    //Show();
                    Application.Exit();
                    //PhoneNumberTextBox.Select();
                    PhoneNumberbunifuTextBox.Select();
                }
                else
                {
                    MessageBox.Show("Имя пользователя или пароль неверны! Повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //PhoneNumberTextBox.Focus();
                    PhoneNumberbunifuTextBox.Focus();
                    //PhoneNumberTextBox.SelectAll();
                    PhoneNumberbunifuTextBox.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //PhoneNumberTextBox.Select();
                PhoneNumberbunifuTextBox.Select();
            }
        }
    }
}
