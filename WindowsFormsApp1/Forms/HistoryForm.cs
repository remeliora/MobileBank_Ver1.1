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
    public partial class HistoryForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        public HistoryForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HistoryForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            var querySelectTransactions = $"select transaction_type, transaction_destination, transaction_date, transaction_number, transaction_value from transactions inner join bank_card on transactions.id_bank_card = bank_card.id_bank_card inner join client on client.id_client = bank_card.id_client where client.id_client = '{DataStorage.idClient}'";
            SqlCommand command = new SqlCommand(querySelectTransactions, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvItem = new ListViewItem(reader[0].ToString());
                lvItem.SubItems.Add(reader[1].ToString());
                lvItem.SubItems.Add(reader[2].ToString());
                lvItem.SubItems.Add(reader[3].ToString());
                lvItem.SubItems.Add(reader[4].ToString());
                ListView.Items.Add(lvItem);
            }
            reader.Close();

            ListView.Sort();
        }
    }
}
