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
    public partial class ChangePasswordForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        public ChangePasswordForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangePasswordForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Дата сохранения";

            if /*(!Regex.IsMatch(PasswordTextBox.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))*/
                (!Regex.IsMatch(PasswordbunifuTextBox.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                MessageBox.Show("Пожалуйста, введите новый пароль", caption, btn, ico);
                //PasswordTextBox.Select();
                PasswordbunifuTextBox.Select();
                return;
            }

            //var password = PasswordTextBox.Text;
            var password = PasswordbunifuTextBox.Text;
            var changePasswordQuery = $"update client set client_password = '{password}' where id_client = (select id_client from client where id_client = '{DataStorage.idClient}')";
            var command = new SqlCommand(changePasswordQuery, database.getConnection());
            database.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пароль успешно изменён!");
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
