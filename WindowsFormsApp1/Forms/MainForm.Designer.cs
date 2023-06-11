namespace WindowsFormsApp1.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBoxTransactions = new System.Windows.Forms.PictureBox();
            this.PictureBoxUser = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CardsComboBox = new System.Windows.Forms.ComboBox();
            this.AddCardButton = new System.Windows.Forms.Button();
            this.label_cardNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_cardTo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_cardCvv = new System.Windows.Forms.Label();
            this.label_cardCurrency = new System.Windows.Forms.Label();
            this.label_cardBalance = new System.Windows.Forms.Label();
            this.panelCard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CardTextBox = new System.Windows.Forms.TextBox();
            this.PayButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelPhone = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TransferButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelComunal = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonComunal = new System.Windows.Forms.Button();
            this.panelInternet = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonInternet = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelCredit = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCredit = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxVisa = new System.Windows.Forms.PictureBox();
            this.pictureBoxMastercard = new System.Windows.Forms.PictureBox();
            this.pictureBoxMIR = new System.Windows.Forms.PictureBox();
            this.CardsbunifuDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).BeginInit();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelComunal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelInternet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panelCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMastercard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMIR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.PictureBoxTransactions);
            this.panel1.Controls.Add(this.PictureBoxUser);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 48);
            this.panel1.TabIndex = 0;
            // 
            // PictureBoxTransactions
            // 
            this.PictureBoxTransactions.Image = global::WindowsFormsApp1.Properties.Resources.icons8_счет_90;
            this.PictureBoxTransactions.InitialImage = global::WindowsFormsApp1.Properties.Resources.icons8_счет_90;
            this.PictureBoxTransactions.Location = new System.Drawing.Point(49, 9);
            this.PictureBoxTransactions.Name = "PictureBoxTransactions";
            this.PictureBoxTransactions.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxTransactions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxTransactions.TabIndex = 6;
            this.PictureBoxTransactions.TabStop = false;
            this.PictureBoxTransactions.Click += new System.EventHandler(this.PictureBoxTransactions_Click);
            // 
            // PictureBoxUser
            // 
            this.PictureBoxUser.Image = global::WindowsFormsApp1.Properties.Resources.icons8_настройки_администратора_90;
            this.PictureBoxUser.InitialImage = global::WindowsFormsApp1.Properties.Resources.icons8_настройки_администратора_90;
            this.PictureBoxUser.Location = new System.Drawing.Point(11, 9);
            this.PictureBoxUser.Name = "PictureBoxUser";
            this.PictureBoxUser.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxUser.TabIndex = 5;
            this.PictureBoxUser.TabStop = false;
            this.PictureBoxUser.Click += new System.EventHandler(this.PictureBoxUser_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(1025, 11);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 27);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(284, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Карты";
            // 
            // CardsComboBox
            // 
            this.CardsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.CardsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardsComboBox.ForeColor = System.Drawing.SystemColors.Control;
            this.CardsComboBox.FormattingEnabled = true;
            this.CardsComboBox.Location = new System.Drawing.Point(373, 77);
            this.CardsComboBox.Name = "CardsComboBox";
            this.CardsComboBox.Size = new System.Drawing.Size(224, 32);
            this.CardsComboBox.TabIndex = 6;
            this.CardsComboBox.SelectedIndexChanged += new System.EventHandler(this.CardsComboBox_SelectedIndexChanged);
            // 
            // AddCardButton
            // 
            this.AddCardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.AddCardButton.FlatAppearance.BorderSize = 0;
            this.AddCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCardButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddCardButton.Location = new System.Drawing.Point(611, 77);
            this.AddCardButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(162, 32);
            this.AddCardButton.TabIndex = 25;
            this.AddCardButton.Text = "Добавить";
            this.AddCardButton.UseVisualStyleBackColor = false;
            this.AddCardButton.Click += new System.EventHandler(this.AddCardButton_Click);
            // 
            // label_cardNumber
            // 
            this.label_cardNumber.AutoSize = true;
            this.label_cardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(171)))));
            this.label_cardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cardNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.label_cardNumber.Location = new System.Drawing.Point(326, 275);
            this.label_cardNumber.Name = "label_cardNumber";
            this.label_cardNumber.Size = new System.Drawing.Size(271, 33);
            this.label_cardNumber.TabIndex = 28;
            this.label_cardNumber.Text = "0000000000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(171)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(328, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Действ. до:";
            // 
            // label_cardTo
            // 
            this.label_cardTo.AutoSize = true;
            this.label_cardTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(171)))));
            this.label_cardTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cardTo.ForeColor = System.Drawing.SystemColors.Control;
            this.label_cardTo.Location = new System.Drawing.Point(444, 317);
            this.label_cardTo.Name = "label_cardTo";
            this.label_cardTo.Size = new System.Drawing.Size(55, 24);
            this.label_cardTo.TabIndex = 30;
            this.label_cardTo.Text = "00/00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(171)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(505, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "CVV:";
            // 
            // label_cardCvv
            // 
            this.label_cardCvv.AutoSize = true;
            this.label_cardCvv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(171)))));
            this.label_cardCvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cardCvv.ForeColor = System.Drawing.SystemColors.Control;
            this.label_cardCvv.Location = new System.Drawing.Point(556, 317);
            this.label_cardCvv.Name = "label_cardCvv";
            this.label_cardCvv.Size = new System.Drawing.Size(40, 24);
            this.label_cardCvv.TabIndex = 32;
            this.label_cardCvv.Text = "000";
            this.label_cardCvv.Click += new System.EventHandler(this.label_cardCvv_Click);
            // 
            // label_cardCurrency
            // 
            this.label_cardCurrency.AutoSize = true;
            this.label_cardCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(171)))));
            this.label_cardCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cardCurrency.ForeColor = System.Drawing.SystemColors.Control;
            this.label_cardCurrency.Location = new System.Drawing.Point(328, 366);
            this.label_cardCurrency.Name = "label_cardCurrency";
            this.label_cardCurrency.Size = new System.Drawing.Size(48, 24);
            this.label_cardCurrency.TabIndex = 33;
            this.label_cardCurrency.Text = "RUB";
            // 
            // label_cardBalance
            // 
            this.label_cardBalance.AutoSize = true;
            this.label_cardBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(171)))));
            this.label_cardBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cardBalance.ForeColor = System.Drawing.SystemColors.Control;
            this.label_cardBalance.Location = new System.Drawing.Point(395, 366);
            this.label_cardBalance.Name = "label_cardBalance";
            this.label_cardBalance.Size = new System.Drawing.Size(20, 24);
            this.label_cardBalance.TabIndex = 34;
            this.label_cardBalance.Text = "0";
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panelCard.Controls.Add(this.panel2);
            this.panelCard.Controls.Add(this.label4);
            this.panelCard.Controls.Add(this.CardTextBox);
            this.panelCard.Controls.Add(this.PayButton);
            this.panelCard.Controls.Add(this.label2);
            this.panelCard.Controls.Add(this.pictureBox3);
            this.panelCard.Location = new System.Drawing.Point(52, 449);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(471, 158);
            this.panelCard.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel2.Location = new System.Drawing.Point(15, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 3);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "МИР/Visa/Mastercard российских и зарубежных банков";
            // 
            // CardTextBox
            // 
            this.CardTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.CardTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.CardTextBox.Location = new System.Drawing.Point(15, 75);
            this.CardTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CardTextBox.Multiline = true;
            this.CardTextBox.Name = "CardTextBox";
            this.CardTextBox.Size = new System.Drawing.Size(379, 30);
            this.CardTextBox.TabIndex = 8;
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.PayButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_шеврон_вправо_в_круге_60__1_;
            this.PayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PayButton.FlatAppearance.BorderSize = 0;
            this.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PayButton.Location = new System.Drawing.Point(410, 70);
            this.PayButton.Margin = new System.Windows.Forms.Padding(2);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(40, 40);
            this.PayButton.TabIndex = 7;
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(83, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Перевод на карту";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_transfer_5101494;
            this.pictureBox3.InitialImage = global::WindowsFormsApp1.Properties.Resources.free_icon_transfer_5101494;
            this.pictureBox3.Location = new System.Drawing.Point(15, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panelPhone
            // 
            this.panelPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panelPhone.Controls.Add(this.panel3);
            this.panelPhone.Controls.Add(this.label8);
            this.panelPhone.Controls.Add(this.PhoneTextBox);
            this.panelPhone.Controls.Add(this.label7);
            this.panelPhone.Controls.Add(this.TransferButton);
            this.panelPhone.Controls.Add(this.pictureBox4);
            this.panelPhone.Controls.Add(this.label6);
            this.panelPhone.Location = new System.Drawing.Point(540, 449);
            this.panelPhone.Name = "panelPhone";
            this.panelPhone.Size = new System.Drawing.Size(471, 158);
            this.panelPhone.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel3.Location = new System.Drawing.Point(64, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 3);
            this.panel3.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(14, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 29);
            this.label8.TabIndex = 38;
            this.label8.Text = "+ 7";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.PhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PhoneTextBox.Location = new System.Drawing.Point(64, 75);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneTextBox.Multiline = true;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(328, 30);
            this.PhoneTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.label7.Location = new System.Drawing.Point(61, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Пополнение только на российские номера";
            // 
            // TransferButton
            // 
            this.TransferButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.TransferButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_шеврон_вправо_в_круге_60__1_;
            this.TransferButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TransferButton.FlatAppearance.BorderSize = 0;
            this.TransferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransferButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TransferButton.Location = new System.Drawing.Point(412, 70);
            this.TransferButton.Margin = new System.Windows.Forms.Padding(2);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(40, 40);
            this.TransferButton.TabIndex = 10;
            this.TransferButton.UseVisualStyleBackColor = false;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_mobile_payment_4771522;
            this.pictureBox4.InitialImage = global::WindowsFormsApp1.Properties.Resources.free_icon_mobile_payment_4771522;
            this.pictureBox4.Location = new System.Drawing.Point(12, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(80, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Пополнение мобильного";
            // 
            // panelComunal
            // 
            this.panelComunal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panelComunal.Controls.Add(this.pictureBox5);
            this.panelComunal.Controls.Add(this.label9);
            this.panelComunal.Controls.Add(this.buttonComunal);
            this.panelComunal.Location = new System.Drawing.Point(52, 630);
            this.panelComunal.Name = "panelComunal";
            this.panelComunal.Size = new System.Drawing.Size(471, 82);
            this.panelComunal.TabIndex = 37;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_house_1172545;
            this.pictureBox5.InitialImage = global::WindowsFormsApp1.Properties.Resources.free_icon_house_1172545;
            this.pictureBox5.Location = new System.Drawing.Point(15, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(83, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 29);
            this.label9.TabIndex = 10;
            this.label9.Text = "Коммунальные платежи";
            // 
            // buttonComunal
            // 
            this.buttonComunal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.buttonComunal.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_шеврон_вправо_в_круге_60__1_;
            this.buttonComunal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonComunal.FlatAppearance.BorderSize = 0;
            this.buttonComunal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonComunal.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonComunal.Location = new System.Drawing.Point(410, 21);
            this.buttonComunal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonComunal.Name = "buttonComunal";
            this.buttonComunal.Size = new System.Drawing.Size(40, 40);
            this.buttonComunal.TabIndex = 39;
            this.buttonComunal.UseVisualStyleBackColor = false;
            this.buttonComunal.Click += new System.EventHandler(this.buttonComunal_Click);
            // 
            // panelInternet
            // 
            this.panelInternet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panelInternet.Controls.Add(this.pictureBox6);
            this.panelInternet.Controls.Add(this.label10);
            this.panelInternet.Controls.Add(this.buttonInternet);
            this.panelInternet.Controls.Add(this.button5);
            this.panelInternet.Location = new System.Drawing.Point(540, 630);
            this.panelInternet.Name = "panelInternet";
            this.panelInternet.Size = new System.Drawing.Size(471, 82);
            this.panelInternet.TabIndex = 40;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_internet_2059676;
            this.pictureBox6.InitialImage = global::WindowsFormsApp1.Properties.Resources.free_icon_internet_2059676;
            this.pictureBox6.Location = new System.Drawing.Point(12, 17);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(80, 27);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 29);
            this.label10.TabIndex = 40;
            this.label10.Text = "Интернет и ТВ";
            // 
            // buttonInternet
            // 
            this.buttonInternet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.buttonInternet.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_шеврон_вправо_в_круге_60__1_;
            this.buttonInternet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInternet.FlatAppearance.BorderSize = 0;
            this.buttonInternet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInternet.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonInternet.Location = new System.Drawing.Point(412, 21);
            this.buttonInternet.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInternet.Name = "buttonInternet";
            this.buttonInternet.Size = new System.Drawing.Size(40, 40);
            this.buttonInternet.TabIndex = 40;
            this.buttonInternet.UseVisualStyleBackColor = false;
            this.buttonInternet.Click += new System.EventHandler(this.buttonInternet_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(410, 21);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 39;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panelCredit
            // 
            this.panelCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panelCredit.Controls.Add(this.pictureBox7);
            this.panelCredit.Controls.Add(this.label11);
            this.panelCredit.Controls.Add(this.buttonCredit);
            this.panelCredit.Controls.Add(this.button7);
            this.panelCredit.Location = new System.Drawing.Point(296, 736);
            this.panelCredit.Name = "panelCredit";
            this.panelCredit.Size = new System.Drawing.Size(471, 82);
            this.panelCredit.TabIndex = 40;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_loan_2780250;
            this.pictureBox7.InitialImage = global::WindowsFormsApp1.Properties.Resources.free_icon_loan_2780250;
            this.pictureBox7.Location = new System.Drawing.Point(11, 17);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(47, 48);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 41;
            this.pictureBox7.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(79, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 29);
            this.label11.TabIndex = 41;
            this.label11.Text = "Кредит";
            // 
            // buttonCredit
            // 
            this.buttonCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.buttonCredit.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_шеврон_вправо_в_круге_60__1_;
            this.buttonCredit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCredit.FlatAppearance.BorderSize = 0;
            this.buttonCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCredit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCredit.Location = new System.Drawing.Point(410, 21);
            this.buttonCredit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCredit.Name = "buttonCredit";
            this.buttonCredit.Size = new System.Drawing.Size(40, 40);
            this.buttonCredit.TabIndex = 41;
            this.buttonCredit.UseVisualStyleBackColor = false;
            this.buttonCredit.Click += new System.EventHandler(this.buttonCredit_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(410, 21);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 39;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_обновить_90;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(789, 396);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxVisa
            // 
            this.pictureBoxVisa.Image = global::WindowsFormsApp1.Properties.Resources.Card_Visa;
            this.pictureBoxVisa.InitialImage = global::WindowsFormsApp1.Properties.Resources.Card_Visa;
            this.pictureBoxVisa.Location = new System.Drawing.Point(289, 125);
            this.pictureBoxVisa.Name = "pictureBoxVisa";
            this.pictureBoxVisa.Size = new System.Drawing.Size(484, 303);
            this.pictureBoxVisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVisa.TabIndex = 27;
            this.pictureBoxVisa.TabStop = false;
            // 
            // pictureBoxMastercard
            // 
            this.pictureBoxMastercard.Image = global::WindowsFormsApp1.Properties.Resources.Card_Mastercard;
            this.pictureBoxMastercard.InitialImage = global::WindowsFormsApp1.Properties.Resources.Card_Mastercard;
            this.pictureBoxMastercard.Location = new System.Drawing.Point(289, 125);
            this.pictureBoxMastercard.Name = "pictureBoxMastercard";
            this.pictureBoxMastercard.Size = new System.Drawing.Size(495, 303);
            this.pictureBoxMastercard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMastercard.TabIndex = 26;
            this.pictureBoxMastercard.TabStop = false;
            // 
            // pictureBoxMIR
            // 
            this.pictureBoxMIR.Image = global::WindowsFormsApp1.Properties.Resources.Card_MIR;
            this.pictureBoxMIR.InitialImage = global::WindowsFormsApp1.Properties.Resources.Card_MIR;
            this.pictureBoxMIR.Location = new System.Drawing.Point(289, 125);
            this.pictureBoxMIR.Name = "pictureBoxMIR";
            this.pictureBoxMIR.Size = new System.Drawing.Size(484, 303);
            this.pictureBoxMIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMIR.TabIndex = 7;
            this.pictureBoxMIR.TabStop = false;
            // 
            // CardsbunifuDropdown
            // 
            this.CardsbunifuDropdown.BackColor = System.Drawing.Color.Transparent;
            this.CardsbunifuDropdown.BackgroundColor = System.Drawing.Color.Transparent;
            this.CardsbunifuDropdown.BorderColor = System.Drawing.Color.Silver;
            this.CardsbunifuDropdown.BorderRadius = 1;
            this.CardsbunifuDropdown.Color = System.Drawing.Color.Silver;
            this.CardsbunifuDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.CardsbunifuDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CardsbunifuDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CardsbunifuDropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CardsbunifuDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CardsbunifuDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.CardsbunifuDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CardsbunifuDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.CardsbunifuDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CardsbunifuDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.CardsbunifuDropdown.FillDropDown = true;
            this.CardsbunifuDropdown.FillIndicator = false;
            this.CardsbunifuDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardsbunifuDropdown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardsbunifuDropdown.ForeColor = System.Drawing.SystemColors.Control;
            this.CardsbunifuDropdown.FormattingEnabled = true;
            this.CardsbunifuDropdown.Icon = null;
            this.CardsbunifuDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.CardsbunifuDropdown.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.CardsbunifuDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.CardsbunifuDropdown.ItemBackColor = System.Drawing.SystemColors.Control;
            this.CardsbunifuDropdown.ItemBorderColor = System.Drawing.SystemColors.Control;
            this.CardsbunifuDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.CardsbunifuDropdown.ItemHeight = 26;
            this.CardsbunifuDropdown.ItemHighLightColor = System.Drawing.Color.DarkSeaGreen;
            this.CardsbunifuDropdown.ItemHighLightForeColor = System.Drawing.SystemColors.Control;
            this.CardsbunifuDropdown.Items.AddRange(new object[] {
            "Муж",
            "Жен"});
            this.CardsbunifuDropdown.ItemTopMargin = 3;
            this.CardsbunifuDropdown.Location = new System.Drawing.Point(373, 77);
            this.CardsbunifuDropdown.Name = "CardsbunifuDropdown";
            this.CardsbunifuDropdown.Size = new System.Drawing.Size(224, 32);
            this.CardsbunifuDropdown.TabIndex = 41;
            this.CardsbunifuDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.CardsbunifuDropdown.TextLeftMargin = 5;
            this.CardsbunifuDropdown.SelectedIndexChanged += new System.EventHandler(this.CardsbunifuDropdown_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1062, 845);
            this.Controls.Add(this.CardsbunifuDropdown);
            this.Controls.Add(this.panelCredit);
            this.Controls.Add(this.panelInternet);
            this.Controls.Add(this.panelComunal);
            this.Controls.Add(this.panelPhone);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_cardBalance);
            this.Controls.Add(this.label_cardCurrency);
            this.Controls.Add(this.label_cardCvv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_cardTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_cardNumber);
            this.Controls.Add(this.pictureBoxVisa);
            this.Controls.Add(this.pictureBoxMastercard);
            this.Controls.Add(this.pictureBoxMIR);
            this.Controls.Add(this.AddCardButton);
            this.Controls.Add(this.CardsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).EndInit();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelPhone.ResumeLayout(false);
            this.panelPhone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelComunal.ResumeLayout(false);
            this.panelComunal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelInternet.ResumeLayout(false);
            this.panelInternet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panelCredit.ResumeLayout(false);
            this.panelCredit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMastercard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMIR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBoxTransactions;
        private System.Windows.Forms.PictureBox PictureBoxUser;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CardsComboBox;
        private System.Windows.Forms.Button AddCardButton;
        private System.Windows.Forms.PictureBox pictureBoxMastercard;
        private System.Windows.Forms.PictureBox pictureBoxMIR;
        private System.Windows.Forms.PictureBox pictureBoxVisa;
        private System.Windows.Forms.Label label_cardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_cardTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_cardCvv;
        private System.Windows.Forms.Label label_cardCurrency;
        private System.Windows.Forms.Label label_cardBalance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Panel panelPhone;
        private System.Windows.Forms.Panel panelComunal;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CardTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonComunal;
        private System.Windows.Forms.Panel panelInternet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonInternet;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelCredit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCredit;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuDropdown CardsbunifuDropdown;
    }
}