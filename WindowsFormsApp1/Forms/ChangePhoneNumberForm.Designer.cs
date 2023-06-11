namespace WindowsFormsApp1.Forms
{
    partial class ChangePhoneNumberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePhoneNumberForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ChangePhoneButton = new System.Windows.Forms.Button();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PhoneNumberbunifuTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(368, 11);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ChangePhoneButton
            // 
            this.ChangePhoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.ChangePhoneButton.FlatAppearance.BorderSize = 0;
            this.ChangePhoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePhoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePhoneButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ChangePhoneButton.Location = new System.Drawing.Point(35, 144);
            this.ChangePhoneButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePhoneButton.Name = "ChangePhoneButton";
            this.ChangePhoneButton.Size = new System.Drawing.Size(338, 47);
            this.ChangePhoneButton.TabIndex = 36;
            this.ChangePhoneButton.Text = "Изменить номер телефона";
            this.ChangePhoneButton.UseVisualStyleBackColor = false;
            this.ChangePhoneButton.Click += new System.EventHandler(this.ChangePhoneButton_Click);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.PhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(35, 96);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNumberTextBox.Multiline = true;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(338, 30);
            this.PhoneNumberTextBox.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Введите новый номер телефона:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.panel1.Location = new System.Drawing.Point(35, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 2);
            this.panel1.TabIndex = 39;
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
            this.PhoneNumberbunifuTextBox.Location = new System.Drawing.Point(35, 88);
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
            this.PhoneNumberbunifuTextBox.Size = new System.Drawing.Size(338, 38);
            this.PhoneNumberbunifuTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.PhoneNumberbunifuTextBox.TabIndex = 40;
            this.PhoneNumberbunifuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PhoneNumberbunifuTextBox.TextMarginBottom = 0;
            this.PhoneNumberbunifuTextBox.TextMarginLeft = 0;
            this.PhoneNumberbunifuTextBox.TextMarginTop = 0;
            this.PhoneNumberbunifuTextBox.TextPlaceholder = "";
            this.PhoneNumberbunifuTextBox.UseSystemPasswordChar = false;
            this.PhoneNumberbunifuTextBox.WordWrap = true;
            // 
            // ChangePhoneNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(409, 226);
            this.Controls.Add(this.PhoneNumberbunifuTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.ChangePhoneButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePhoneNumberForm";
            this.Text = "ChangePhoneNumberForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePhoneNumberForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ChangePhoneButton;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextBox PhoneNumberbunifuTextBox;
    }
}