namespace WindowsFormsApp1.Forms
{
    partial class AddBankCard
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CardTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.PaymentSystemComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddCardButton = new System.Windows.Forms.Button();
            this.numericUpDownPin = new System.Windows.Forms.NumericUpDown();
            this.CardTypebunifuDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.CurrencybunifuDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.PaymentSystembunifuDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPin)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(300, 11);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Тип карты:";
            // 
            // CardTypeComboBox
            // 
            this.CardTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.CardTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardTypeComboBox.ForeColor = System.Drawing.SystemColors.Control;
            this.CardTypeComboBox.FormattingEnabled = true;
            this.CardTypeComboBox.Items.AddRange(new object[] {
            "Дебетовая",
            "Кредитная"});
            this.CardTypeComboBox.Location = new System.Drawing.Point(12, 78);
            this.CardTypeComboBox.Name = "CardTypeComboBox";
            this.CardTypeComboBox.Size = new System.Drawing.Size(317, 32);
            this.CardTypeComboBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Валюта:";
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.CurrencyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrencyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrencyComboBox.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Items.AddRange(new object[] {
            "RUB",
            "USD",
            "EUR"});
            this.CurrencyComboBox.Location = new System.Drawing.Point(12, 151);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(317, 32);
            this.CurrencyComboBox.TabIndex = 14;
            // 
            // PaymentSystemComboBox
            // 
            this.PaymentSystemComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.PaymentSystemComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentSystemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentSystemComboBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PaymentSystemComboBox.FormattingEnabled = true;
            this.PaymentSystemComboBox.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "Мир"});
            this.PaymentSystemComboBox.Location = new System.Drawing.Point(12, 224);
            this.PaymentSystemComboBox.Name = "PaymentSystemComboBox";
            this.PaymentSystemComboBox.Size = new System.Drawing.Size(317, 32);
            this.PaymentSystemComboBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Платёжная система:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(9, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "PIN-код:";
            // 
            // AddCardButton
            // 
            this.AddCardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.AddCardButton.FlatAppearance.BorderSize = 0;
            this.AddCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCardButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddCardButton.Location = new System.Drawing.Point(12, 344);
            this.AddCardButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(317, 54);
            this.AddCardButton.TabIndex = 25;
            this.AddCardButton.Text = "Создать";
            this.AddCardButton.UseVisualStyleBackColor = false;
            this.AddCardButton.Click += new System.EventHandler(this.AddCardButton_Click);
            // 
            // numericUpDownPin
            // 
            this.numericUpDownPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.numericUpDownPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPin.ForeColor = System.Drawing.SystemColors.Control;
            this.numericUpDownPin.Location = new System.Drawing.Point(12, 294);
            this.numericUpDownPin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownPin.Name = "numericUpDownPin";
            this.numericUpDownPin.Size = new System.Drawing.Size(317, 29);
            this.numericUpDownPin.TabIndex = 26;
            // 
            // CardTypebunifuDropdown
            // 
            this.CardTypebunifuDropdown.BackColor = System.Drawing.Color.Transparent;
            this.CardTypebunifuDropdown.BackgroundColor = System.Drawing.Color.Transparent;
            this.CardTypebunifuDropdown.BorderColor = System.Drawing.Color.Silver;
            this.CardTypebunifuDropdown.BorderRadius = 1;
            this.CardTypebunifuDropdown.Color = System.Drawing.Color.Silver;
            this.CardTypebunifuDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.CardTypebunifuDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CardTypebunifuDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CardTypebunifuDropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CardTypebunifuDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CardTypebunifuDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.CardTypebunifuDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CardTypebunifuDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.CardTypebunifuDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CardTypebunifuDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.CardTypebunifuDropdown.FillDropDown = true;
            this.CardTypebunifuDropdown.FillIndicator = false;
            this.CardTypebunifuDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardTypebunifuDropdown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardTypebunifuDropdown.ForeColor = System.Drawing.SystemColors.Control;
            this.CardTypebunifuDropdown.FormattingEnabled = true;
            this.CardTypebunifuDropdown.Icon = null;
            this.CardTypebunifuDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.CardTypebunifuDropdown.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.CardTypebunifuDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.CardTypebunifuDropdown.ItemBackColor = System.Drawing.SystemColors.Control;
            this.CardTypebunifuDropdown.ItemBorderColor = System.Drawing.SystemColors.Control;
            this.CardTypebunifuDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.CardTypebunifuDropdown.ItemHeight = 26;
            this.CardTypebunifuDropdown.ItemHighLightColor = System.Drawing.Color.DarkSeaGreen;
            this.CardTypebunifuDropdown.ItemHighLightForeColor = System.Drawing.SystemColors.Control;
            this.CardTypebunifuDropdown.Items.AddRange(new object[] {
            "Дебетовая",
            "Кредитная"});
            this.CardTypebunifuDropdown.ItemTopMargin = 3;
            this.CardTypebunifuDropdown.Location = new System.Drawing.Point(12, 78);
            this.CardTypebunifuDropdown.Name = "CardTypebunifuDropdown";
            this.CardTypebunifuDropdown.Size = new System.Drawing.Size(317, 32);
            this.CardTypebunifuDropdown.TabIndex = 29;
            this.CardTypebunifuDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.CardTypebunifuDropdown.TextLeftMargin = 5;
            // 
            // CurrencybunifuDropdown
            // 
            this.CurrencybunifuDropdown.BackColor = System.Drawing.Color.Transparent;
            this.CurrencybunifuDropdown.BackgroundColor = System.Drawing.Color.Transparent;
            this.CurrencybunifuDropdown.BorderColor = System.Drawing.Color.Silver;
            this.CurrencybunifuDropdown.BorderRadius = 1;
            this.CurrencybunifuDropdown.Color = System.Drawing.Color.Silver;
            this.CurrencybunifuDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.CurrencybunifuDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CurrencybunifuDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CurrencybunifuDropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CurrencybunifuDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CurrencybunifuDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.CurrencybunifuDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CurrencybunifuDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.CurrencybunifuDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencybunifuDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.CurrencybunifuDropdown.FillDropDown = true;
            this.CurrencybunifuDropdown.FillIndicator = false;
            this.CurrencybunifuDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrencybunifuDropdown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrencybunifuDropdown.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrencybunifuDropdown.FormattingEnabled = true;
            this.CurrencybunifuDropdown.Icon = null;
            this.CurrencybunifuDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.CurrencybunifuDropdown.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.CurrencybunifuDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.CurrencybunifuDropdown.ItemBackColor = System.Drawing.SystemColors.Control;
            this.CurrencybunifuDropdown.ItemBorderColor = System.Drawing.SystemColors.Control;
            this.CurrencybunifuDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.CurrencybunifuDropdown.ItemHeight = 26;
            this.CurrencybunifuDropdown.ItemHighLightColor = System.Drawing.Color.DarkSeaGreen;
            this.CurrencybunifuDropdown.ItemHighLightForeColor = System.Drawing.SystemColors.Control;
            this.CurrencybunifuDropdown.Items.AddRange(new object[] {
            "RUB",
            "USD",
            "EUR"});
            this.CurrencybunifuDropdown.ItemTopMargin = 3;
            this.CurrencybunifuDropdown.Location = new System.Drawing.Point(12, 151);
            this.CurrencybunifuDropdown.Name = "CurrencybunifuDropdown";
            this.CurrencybunifuDropdown.Size = new System.Drawing.Size(317, 32);
            this.CurrencybunifuDropdown.TabIndex = 30;
            this.CurrencybunifuDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.CurrencybunifuDropdown.TextLeftMargin = 5;
            // 
            // PaymentSystembunifuDropdown
            // 
            this.PaymentSystembunifuDropdown.BackColor = System.Drawing.Color.Transparent;
            this.PaymentSystembunifuDropdown.BackgroundColor = System.Drawing.Color.Transparent;
            this.PaymentSystembunifuDropdown.BorderColor = System.Drawing.Color.Silver;
            this.PaymentSystembunifuDropdown.BorderRadius = 1;
            this.PaymentSystembunifuDropdown.Color = System.Drawing.Color.Silver;
            this.PaymentSystembunifuDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.PaymentSystembunifuDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PaymentSystembunifuDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PaymentSystembunifuDropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PaymentSystembunifuDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PaymentSystembunifuDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.PaymentSystembunifuDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PaymentSystembunifuDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.PaymentSystembunifuDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentSystembunifuDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.PaymentSystembunifuDropdown.FillDropDown = true;
            this.PaymentSystembunifuDropdown.FillIndicator = false;
            this.PaymentSystembunifuDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentSystembunifuDropdown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentSystembunifuDropdown.ForeColor = System.Drawing.SystemColors.Control;
            this.PaymentSystembunifuDropdown.FormattingEnabled = true;
            this.PaymentSystembunifuDropdown.Icon = null;
            this.PaymentSystembunifuDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.PaymentSystembunifuDropdown.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.PaymentSystembunifuDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.PaymentSystembunifuDropdown.ItemBackColor = System.Drawing.SystemColors.Control;
            this.PaymentSystembunifuDropdown.ItemBorderColor = System.Drawing.SystemColors.Control;
            this.PaymentSystembunifuDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.PaymentSystembunifuDropdown.ItemHeight = 26;
            this.PaymentSystembunifuDropdown.ItemHighLightColor = System.Drawing.Color.DarkSeaGreen;
            this.PaymentSystembunifuDropdown.ItemHighLightForeColor = System.Drawing.SystemColors.Control;
            this.PaymentSystembunifuDropdown.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "Мир"});
            this.PaymentSystembunifuDropdown.ItemTopMargin = 3;
            this.PaymentSystembunifuDropdown.Location = new System.Drawing.Point(12, 224);
            this.PaymentSystembunifuDropdown.Name = "PaymentSystembunifuDropdown";
            this.PaymentSystembunifuDropdown.Size = new System.Drawing.Size(317, 32);
            this.PaymentSystembunifuDropdown.TabIndex = 31;
            this.PaymentSystembunifuDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.PaymentSystembunifuDropdown.TextLeftMargin = 5;
            // 
            // AddBankCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(341, 411);
            this.Controls.Add(this.PaymentSystembunifuDropdown);
            this.Controls.Add(this.CurrencybunifuDropdown);
            this.Controls.Add(this.CardTypebunifuDropdown);
            this.Controls.Add(this.numericUpDownPin);
            this.Controls.Add(this.AddCardButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PaymentSystemComboBox);
            this.Controls.Add(this.CurrencyComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBankCard";
            this.Text = "AddBankCard";
            this.Load += new System.EventHandler(this.AddBankCard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddBankCard_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CardTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.ComboBox PaymentSystemComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddCardButton;
        private System.Windows.Forms.NumericUpDown numericUpDownPin;
        private Bunifu.UI.WinForms.BunifuDropdown CardTypebunifuDropdown;
        private Bunifu.UI.WinForms.BunifuDropdown CurrencybunifuDropdown;
        private Bunifu.UI.WinForms.BunifuDropdown PaymentSystembunifuDropdown;
    }
}