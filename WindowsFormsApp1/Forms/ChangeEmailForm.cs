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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1.Forms
{
    public partial class ChangeEmailForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        public ChangeEmailForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeEmailForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ChangeEmailButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Дата сохранения";

            if /*(!Regex.IsMatch(EmailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))*/
                (!Regex.IsMatch(EmailbunifuTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Пожалуйста, введите вашу электронную почту", caption, btn, ico);
                //EmailTextBox.Select();
                EmailbunifuTextBox.Select();
                return;
            }

            //var email = EmailTextBox.Text;
            var email = EmailbunifuTextBox.Text;
            var changeEmailQuery = $"update client set client_email = '{email}' where id_client = '{DataStorage.idClient}'";
            var command = new SqlCommand(changeEmailQuery, database.getConnection());
            database.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Электронная почта успешно изменена !");
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
