namespace WindowsFormsApp1.Forms
{
    partial class CreditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditForm));
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TextBoxSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxMonth = new System.Windows.Forms.TextBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuHSlider2 = new Bunifu.UI.WinForms.BunifuHSlider();
            this.bunifuHSlider1 = new Bunifu.UI.WinForms.BunifuHSlider();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.labelMonthlyPayment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelToPay = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelDateToPay = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelTotalSum = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonCredit = new System.Windows.Forms.Button();
            this.ButtonPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_loan_2780250;
            this.pictureBox7.InitialImage = global::WindowsFormsApp1.Properties.Resources.free_icon_loan_2780250;
            this.pictureBox7.Location = new System.Drawing.Point(26, 27);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(47, 48);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 42;
            this.pictureBox7.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(92, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 29);
            this.label11.TabIndex = 43;
            this.label11.Text = "Кредит";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(559, 11);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 44;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TextBoxSum
            // 
            this.TextBoxSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.TextBoxSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSum.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBoxSum.Location = new System.Drawing.Point(94, 44);
            this.TextBoxSum.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxSum.Multiline = true;
            this.TextBoxSum.Name = "TextBoxSum";
            this.TextBoxSum.Size = new System.Drawing.Size(235, 30);
            this.TextBoxSum.TabIndex = 48;
            this.TextBoxSum.Click += new System.EventHandler(this.TextBoxSum_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.label6.Location = new System.Drawing.Point(369, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 18);
            this.label6.TabIndex = 52;
            this.label6.Text = "Ежемесячный платёж";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "Сумма:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(94, 80);
            this.trackBar1.Maximum = 5000000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(235, 45);
            this.trackBar1.TabIndex = 54;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(17, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "Количество месяцев:";
            // 
            // TextBoxMonth
            // 
            this.TextBoxMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.TextBoxMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxMonth.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBoxMonth.Location = new System.Drawing.Point(228, 140);
            this.TextBoxMonth.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxMonth.Multiline = true;
            this.TextBoxMonth.Name = "TextBoxMonth";
            this.TextBoxMonth.Size = new System.Drawing.Size(101, 30);
            this.TextBoxMonth.TabIndex = 56;
            this.TextBoxMonth.Click += new System.EventHandler(this.TextBoxMonth_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(228, 175);
            this.trackBar2.Maximum = 120;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(101, 45);
            this.trackBar2.TabIndex = 57;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.bunifuHSlider2);
            this.panel1.Controls.Add(this.bunifuHSlider1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelMonthlyPayment);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBoxMonth);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextBoxSum);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Location = new System.Drawing.Point(26, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 237);
            this.panel1.TabIndex = 58;
            // 
            // bunifuHSlider2
            // 
            this.bunifuHSlider2.AllowCursorChanges = true;
            this.bunifuHSlider2.AllowHomeEndKeysDetection = false;
            this.bunifuHSlider2.AllowIncrementalClickMoves = true;
            this.bunifuHSlider2.AllowMouseDownEffects = false;
            this.bunifuHSlider2.AllowMouseHoverEffects = false;
            this.bunifuHSlider2.AllowScrollingAnimations = true;
            this.bunifuHSlider2.AllowScrollKeysDetection = true;
            this.bunifuHSlider2.AllowScrollOptionsMenu = true;
            this.bunifuHSlider2.AllowShrinkingOnFocusLost = false;
            this.bunifuHSlider2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHSlider2.BackgroundImage")));
            this.bunifuHSlider2.BindingContainer = null;
            this.bunifuHSlider2.BorderRadius = 2;
            this.bunifuHSlider2.BorderThickness = 1;
            this.bunifuHSlider2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuHSlider2.DrawThickBorder = false;
            this.bunifuHSlider2.DurationBeforeShrink = 2000;
            this.bunifuHSlider2.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.bunifuHSlider2.LargeChange = 5;
            this.bunifuHSlider2.Location = new System.Drawing.Point(228, 173);
            this.bunifuHSlider2.Maximum = 120;
            this.bunifuHSlider2.Minimum = 0;
            this.bunifuHSlider2.MinimumSize = new System.Drawing.Size(0, 31);
            this.bunifuHSlider2.MinimumThumbLength = 18;
            this.bunifuHSlider2.Name = "bunifuHSlider2";
            this.bunifuHSlider2.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHSlider2.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider2.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHSlider2.ScrollBarBorderColor = System.Drawing.Color.Honeydew;
            this.bunifuHSlider2.ScrollBarColor = System.Drawing.Color.Honeydew;
            this.bunifuHSlider2.ShrinkSizeLimit = 3;
            this.bunifuHSlider2.Size = new System.Drawing.Size(101, 31);
            this.bunifuHSlider2.SliderColor = System.Drawing.Color.Honeydew;
            this.bunifuHSlider2.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuHSlider2.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuHSlider2.SmallChange = 1;
            this.bunifuHSlider2.TabIndex = 67;
            this.bunifuHSlider2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.bunifuHSlider2.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.bunifuHSlider2.ThumbLength = 18;
            this.bunifuHSlider2.ThumbMargin = 1;
            this.bunifuHSlider2.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.bunifuHSlider2.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuHSlider2.Value = 1;
            this.bunifuHSlider2.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.bunifuHSlider2_Scroll);
            // 
            // bunifuHSlider1
            // 
            this.bunifuHSlider1.AllowCursorChanges = true;
            this.bunifuHSlider1.AllowHomeEndKeysDetection = false;
            this.bunifuHSlider1.AllowIncrementalClickMoves = true;
            this.bunifuHSlider1.AllowMouseDownEffects = false;
            this.bunifuHSlider1.AllowMouseHoverEffects = false;
            this.bunifuHSlider1.AllowScrollingAnimations = true;
            this.bunifuHSlider1.AllowScrollKeysDetection = true;
            this.bunifuHSlider1.AllowScrollOptionsMenu = true;
            this.bunifuHSlider1.AllowShrinkingOnFocusLost = false;
            this.bunifuHSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHSlider1.BackgroundImage")));
            this.bunifuHSlider1.BindingContainer = null;
            this.bunifuHSlider1.BorderRadius = 2;
            this.bunifuHSlider1.BorderThickness = 1;
            this.bunifuHSlider1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuHSlider1.DrawThickBorder = false;
            this.bunifuHSlider1.DurationBeforeShrink = 2000;
            this.bunifuHSlider1.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.bunifuHSlider1.LargeChange = 50000;
            this.bunifuHSlider1.Location = new System.Drawing.Point(94, 74);
            this.bunifuHSlider1.Maximum = 5000000;
            this.bunifuHSlider1.Minimum = 0;
            this.bunifuHSlider1.MinimumSize = new System.Drawing.Size(0, 31);
            this.bunifuHSlider1.MinimumThumbLength = 18;
            this.bunifuHSlider1.Name = "bunifuHSlider1";
            this.bunifuHSlider1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.ScrollBarBorderColor = System.Drawing.Color.Honeydew;
            this.bunifuHSlider1.ScrollBarColor = System.Drawing.Color.Honeydew;
            this.bunifuHSlider1.ShrinkSizeLimit = 3;
            this.bunifuHSlider1.Size = new System.Drawing.Size(235, 31);
            this.bunifuHSlider1.SliderColor = System.Drawing.Color.Honeydew;
            this.bunifuHSlider1.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuHSlider1.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuHSlider1.SmallChange = 1;
            this.bunifuHSlider1.TabIndex = 66;
            this.bunifuHSlider1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.bunifuHSlider1.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.bunifuHSlider1.ThumbLength = 18;
            this.bunifuHSlider1.ThumbMargin = 1;
            this.bunifuHSlider1.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.bunifuHSlider1.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuHSlider1.Value = 100000;
            this.bunifuHSlider1.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.bunifuHSlider1_Scroll);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel4.Location = new System.Drawing.Point(228, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(101, 3);
            this.panel4.TabIndex = 65;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel3.Location = new System.Drawing.Point(94, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 3);
            this.panel3.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(367, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 29);
            this.label10.TabIndex = 59;
            this.label10.Text = "RUB";
            // 
            // labelMonthlyPayment
            // 
            this.labelMonthlyPayment.AutoSize = true;
            this.labelMonthlyPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMonthlyPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMonthlyPayment.Location = new System.Drawing.Point(434, 42);
            this.labelMonthlyPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMonthlyPayment.Name = "labelMonthlyPayment";
            this.labelMonthlyPayment.Size = new System.Drawing.Size(26, 29);
            this.labelMonthlyPayment.TabIndex = 60;
            this.labelMonthlyPayment.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(398, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 29);
            this.label5.TabIndex = 63;
            this.label5.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.label4.Location = new System.Drawing.Point(372, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "Процент по кредиту";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(370, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 29);
            this.label7.TabIndex = 62;
            this.label7.Text = "1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.labelToPay);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.labelDateToPay);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.labelTotalSum);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.labelSum);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(26, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 252);
            this.panel2.TabIndex = 65;
            // 
            // labelToPay
            // 
            this.labelToPay.AutoSize = true;
            this.labelToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToPay.ForeColor = System.Drawing.SystemColors.Control;
            this.labelToPay.Location = new System.Drawing.Point(101, 209);
            this.labelToPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelToPay.Name = "labelToPay";
            this.labelToPay.Size = new System.Drawing.Size(18, 20);
            this.labelToPay.TabIndex = 65;
            this.labelToPay.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.label20.Location = new System.Drawing.Point(22, 210);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 18);
            this.label20.TabIndex = 64;
            this.label20.Text = "К оплате:";
            // 
            // labelDateToPay
            // 
            this.labelDateToPay.AutoSize = true;
            this.labelDateToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateToPay.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDateToPay.Location = new System.Drawing.Point(173, 181);
            this.labelDateToPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateToPay.Name = "labelDateToPay";
            this.labelDateToPay.Size = new System.Drawing.Size(0, 20);
            this.labelDateToPay.TabIndex = 63;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.label18.Location = new System.Drawing.Point(22, 183);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(147, 18);
            this.label18.TabIndex = 62;
            this.label18.Text = "Следующая оплата:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.label17.Location = new System.Drawing.Point(185, 132);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 18);
            this.label17.TabIndex = 61;
            this.label17.Text = "RUB";
            // 
            // labelTotalSum
            // 
            this.labelTotalSum.AutoSize = true;
            this.labelTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalSum.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalSum.Location = new System.Drawing.Point(107, 131);
            this.labelTotalSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalSum.Name = "labelTotalSum";
            this.labelTotalSum.Size = new System.Drawing.Size(63, 20);
            this.labelTotalSum.TabIndex = 60;
            this.labelTotalSum.Text = "100000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(89, 131);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 20);
            this.label15.TabIndex = 59;
            this.label15.Text = "\\";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSum.Location = new System.Drawing.Point(21, 131);
            this.labelSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(63, 20);
            this.labelSum.TabIndex = 58;
            this.labelSum.Text = "100000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.label13.Location = new System.Drawing.Point(22, 102);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 18);
            this.label13.TabIndex = 57;
            this.label13.Text = "Уплачено:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDate.Location = new System.Drawing.Point(168, 53);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 20);
            this.labelDate.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.label9.Location = new System.Drawing.Point(22, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 18);
            this.label9.TabIndex = 55;
            this.label9.Text = "Дата оформления:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(21, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Мой кредит";
            // 
            // ButtonCredit
            // 
            this.ButtonCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.ButtonCredit.FlatAppearance.BorderSize = 0;
            this.ButtonCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCredit.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonCredit.Location = new System.Drawing.Point(26, 376);
            this.ButtonCredit.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCredit.Name = "ButtonCredit";
            this.ButtonCredit.Size = new System.Drawing.Size(548, 62);
            this.ButtonCredit.TabIndex = 64;
            this.ButtonCredit.Text = "Оформить кредит";
            this.ButtonCredit.UseVisualStyleBackColor = false;
            this.ButtonCredit.Click += new System.EventHandler(this.ButtonCredit_Click);
            // 
            // ButtonPay
            // 
            this.ButtonPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.ButtonPay.FlatAppearance.BorderSize = 0;
            this.ButtonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPay.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonPay.Location = new System.Drawing.Point(26, 376);
            this.ButtonPay.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPay.Name = "ButtonPay";
            this.ButtonPay.Size = new System.Drawing.Size(548, 62);
            this.ButtonPay.TabIndex = 66;
            this.ButtonPay.Text = "Оплатить";
            this.ButtonPay.UseVisualStyleBackColor = false;
            this.ButtonPay.Click += new System.EventHandler(this.ButtonPay_Click);
            // 
            // CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(600, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonPay);
            this.Controls.Add(this.ButtonCredit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreditForm";
            this.Text = "CreditForm";
            this.Load += new System.EventHandler(this.CreditForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreditForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox TextBoxSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxMonth;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelMonthlyPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonCredit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonPay;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelToPay;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelDateToPay;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelTotalSum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuHSlider1;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuHSlider2;
    }
}