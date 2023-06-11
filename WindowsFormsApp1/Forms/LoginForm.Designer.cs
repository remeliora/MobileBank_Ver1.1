namespace WindowsFormsApp1.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PhoneNumberbunifuTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.PasswordbunifuTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.PhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(23, 95);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNumberTextBox.Multiline = true;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(320, 30);
            this.PhoneNumberTextBox.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.Location = new System.Drawing.Point(79, 331);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(208, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Нет учётной записи? Создать Аккакунт";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(329, 11);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 26);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(156, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вход";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите номер телефона:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordTextBox.Location = new System.Drawing.Point(23, 174);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(320, 30);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(20, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите пароль:";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPasswordCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(232, 218);
            this.ShowPasswordCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(111, 17);
            this.ShowPasswordCheckBox.TabIndex = 7;
            this.ShowPasswordCheckBox.Text = "Показать пароль";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginButton.Location = new System.Drawing.Point(23, 254);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(320, 54);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.panel1.Location = new System.Drawing.Point(23, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 2);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.panel2.Location = new System.Drawing.Point(23, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 2);
            this.panel2.TabIndex = 10;
            // 
            // PhoneNumberbunifuTextBox
            // 
            this.PhoneNumberbunifuTextBox.AcceptsReturn = false;
            this.PhoneNumberbunifuTextBox.AcceptsTab = false;
            this.PhoneNumberbunifuTextBox.AnimationSpeed = 200;
            this.PhoneNumberbunifuTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PhoneNumberbunifuTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PhoneNumberbunifuTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.PhoneNumberbunifuTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PhoneNumberbunifuTextBox.BackgroundImage")));
            this.PhoneNumberbunifuTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.PhoneNumberbunifuTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PhoneNumberbunifuTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PhoneNumberbunifuTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.PhoneNumberbunifuTextBox.BorderRadius = 1;
            this.PhoneNumberbunifuTextBox.BorderThickness = 2;
            this.PhoneNumberbunifuTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PhoneNumberbunifuTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNumberbunifuTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberbunifuTextBox.DefaultText = "";
            this.PhoneNumberbunifuTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.PhoneNumberbunifuTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PhoneNumberbunifuTextBox.HideSelection = true;
            this.PhoneNumberbunifuTextBox.IconLeft = null;
            this.PhoneNumberbunifuTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNumberbunifuTextBox.IconPadding = 10;
            this.PhoneNumberbunifuTextBox.IconRight = null;
            this.PhoneNumberbunifuTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNumberbunifuTextBox.Lines = new string[0];
            this.PhoneNumberbunifuTextBox.Location = new System.Drawing.Point(23, 87);
            this.PhoneNumberbunifuTextBox.MaxLength = 32767;
            this.PhoneNumberbunifuTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.PhoneNumberbunifuTextBox.Modified = false;
            this.PhoneNumberbunifuTextBox.Multiline = false;
            this.PhoneNumberbunifuTextBox.Name = "PhoneNumberbunifuTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PhoneNumberbunifuTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PhoneNumberbunifuTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PhoneNumberbunifuTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            stateProperties4.ForeColor = System.Drawing.SystemColors.Control;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PhoneNumberbunifuTextBox.OnIdleState = stateProperties4;
            this.PhoneNumberbunifuTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.PhoneNumberbunifuTextBox.PasswordChar = '\0';
            this.PhoneNumberbunifuTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PhoneNumberbunifuTextBox.PlaceholderText = "";
            this.PhoneNumberbunifuTextBox.ReadOnly = false;
            this.PhoneNumberbunifuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PhoneNumberbunifuTextBox.SelectedText = "";
            this.PhoneNumberbunifuTextBox.SelectionLength = 0;
            this.PhoneNumberbunifuTextBox.SelectionStart = 0;
            this.PhoneNumberbunifuTextBox.ShortcutsEnabled = true;
            this.PhoneNumberbunifuTextBox.Size = new System.Drawing.Size(320, 38);
            this.PhoneNumberbunifuTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.PhoneNumberbunifuTextBox.TabIndex = 11;
            this.PhoneNumberbunifuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PhoneNumberbunifuTextBox.TextMarginBottom = 0;
            this.PhoneNumberbunifuTextBox.TextMarginLeft = 0;
            this.PhoneNumberbunifuTextBox.TextMarginTop = 0;
            this.PhoneNumberbunifuTextBox.TextPlaceholder = "";
            this.PhoneNumberbunifuTextBox.UseSystemPasswordChar = false;
            this.PhoneNumberbunifuTextBox.WordWrap = true;
            // 
            // PasswordbunifuTextBox
            // 
            this.PasswordbunifuTextBox.AcceptsReturn = false;
            this.PasswordbunifuTextBox.AcceptsTab = false;
            this.PasswordbunifuTextBox.AnimationSpeed = 200;
            this.PasswordbunifuTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordbunifuTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordbunifuTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.PasswordbunifuTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasswordbunifuTextBox.BackgroundImage")));
            this.PasswordbunifuTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.PasswordbunifuTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PasswordbunifuTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PasswordbunifuTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.PasswordbunifuTextBox.BorderRadius = 1;
            this.PasswordbunifuTextBox.BorderThickness = 2;
            this.PasswordbunifuTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordbunifuTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordbunifuTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordbunifuTextBox.DefaultText = "";
            this.PasswordbunifuTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.PasswordbunifuTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordbunifuTextBox.HideSelection = true;
            this.PasswordbunifuTextBox.IconLeft = null;
            this.PasswordbunifuTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordbunifuTextBox.IconPadding = 10;
            this.PasswordbunifuTextBox.IconRight = null;
            this.PasswordbunifuTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordbunifuTextBox.Lines = new string[0];
            this.PasswordbunifuTextBox.Location = new System.Drawing.Point(23, 166);
            this.PasswordbunifuTextBox.MaxLength = 32767;
            this.PasswordbunifuTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.PasswordbunifuTextBox.Modified = false;
            this.PasswordbunifuTextBox.Multiline = true;
            this.PasswordbunifuTextBox.Name = "PasswordbunifuTextBox";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordbunifuTextBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PasswordbunifuTextBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordbunifuTextBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            stateProperties8.ForeColor = System.Drawing.SystemColors.Control;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordbunifuTextBox.OnIdleState = stateProperties8;
            this.PasswordbunifuTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.PasswordbunifuTextBox.PasswordChar = '\0';
            this.PasswordbunifuTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PasswordbunifuTextBox.PlaceholderText = "";
            this.PasswordbunifuTextBox.ReadOnly = false;
            this.PasswordbunifuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordbunifuTextBox.SelectedText = "";
            this.PasswordbunifuTextBox.SelectionLength = 0;
            this.PasswordbunifuTextBox.SelectionStart = 0;
            this.PasswordbunifuTextBox.ShortcutsEnabled = true;
            this.PasswordbunifuTextBox.Size = new System.Drawing.Size(320, 38);
            this.PasswordbunifuTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.PasswordbunifuTextBox.TabIndex = 12;
            this.PasswordbunifuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordbunifuTextBox.TextMarginBottom = 0;
            this.PasswordbunifuTextBox.TextMarginLeft = 0;
            this.PasswordbunifuTextBox.TextMarginTop = 0;
            this.PasswordbunifuTextBox.TextPlaceholder = "";
            this.PasswordbunifuTextBox.UseSystemPasswordChar = false;
            this.PasswordbunifuTextBox.WordWrap = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(366, 362);
            this.Controls.Add(this.PasswordbunifuTextBox);
            this.Controls.Add(this.PhoneNumberbunifuTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuTextBox PhoneNumberbunifuTextBox;
        private Bunifu.UI.WinForms.BunifuTextBox PasswordbunifuTextBox;
    }
}