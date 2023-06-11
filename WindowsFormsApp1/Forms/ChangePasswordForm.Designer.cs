namespace WindowsFormsApp1.Forms
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordbunifuTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
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
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Введите новый пароль:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordTextBox.Location = new System.Drawing.Point(35, 95);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(338, 30);
            this.PasswordTextBox.TabIndex = 41;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.ChangePasswordButton.FlatAppearance.BorderSize = 0;
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePasswordButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ChangePasswordButton.Location = new System.Drawing.Point(35, 140);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(338, 47);
            this.ChangePasswordButton.TabIndex = 42;
            this.ChangePasswordButton.Text = "Изменить пароль";
            this.ChangePasswordButton.UseVisualStyleBackColor = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.panel1.Location = new System.Drawing.Point(35, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 2);
            this.panel1.TabIndex = 43;
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
            this.PasswordbunifuTextBox.Location = new System.Drawing.Point(35, 87);
            this.PasswordbunifuTextBox.MaxLength = 32767;
            this.PasswordbunifuTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.PasswordbunifuTextBox.Modified = false;
            this.PasswordbunifuTextBox.Multiline = false;
            this.PasswordbunifuTextBox.Name = "PasswordbunifuTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordbunifuTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PasswordbunifuTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordbunifuTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            stateProperties4.ForeColor = System.Drawing.SystemColors.Control;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordbunifuTextBox.OnIdleState = stateProperties4;
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
            this.PasswordbunifuTextBox.Size = new System.Drawing.Size(338, 38);
            this.PasswordbunifuTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.PasswordbunifuTextBox.TabIndex = 44;
            this.PasswordbunifuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordbunifuTextBox.TextMarginBottom = 0;
            this.PasswordbunifuTextBox.TextMarginLeft = 0;
            this.PasswordbunifuTextBox.TextMarginTop = 0;
            this.PasswordbunifuTextBox.TextPlaceholder = "";
            this.PasswordbunifuTextBox.UseSystemPasswordChar = false;
            this.PasswordbunifuTextBox.WordWrap = true;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(409, 224);
            this.Controls.Add(this.PasswordbunifuTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePasswordForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextBox PasswordbunifuTextBox;
    }
}