namespace WindowsFormsApp1.Forms
{
    partial class ChangeEmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeEmailForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ChangeEmailButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmailbunifuTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
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
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Введите новую эл. почту:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.EmailTextBox.Location = new System.Drawing.Point(35, 95);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailTextBox.Multiline = true;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(338, 30);
            this.EmailTextBox.TabIndex = 40;
            // 
            // ChangeEmailButton
            // 
            this.ChangeEmailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.ChangeEmailButton.FlatAppearance.BorderSize = 0;
            this.ChangeEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeEmailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeEmailButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ChangeEmailButton.Location = new System.Drawing.Point(35, 141);
            this.ChangeEmailButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeEmailButton.Name = "ChangeEmailButton";
            this.ChangeEmailButton.Size = new System.Drawing.Size(338, 47);
            this.ChangeEmailButton.TabIndex = 41;
            this.ChangeEmailButton.Text = "Изменить электронную почту";
            this.ChangeEmailButton.UseVisualStyleBackColor = false;
            this.ChangeEmailButton.Click += new System.EventHandler(this.ChangeEmailButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.panel1.Location = new System.Drawing.Point(35, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 2);
            this.panel1.TabIndex = 42;
            // 
            // EmailbunifuTextBox
            // 
            this.EmailbunifuTextBox.AcceptsReturn = false;
            this.EmailbunifuTextBox.AcceptsTab = false;
            this.EmailbunifuTextBox.AnimationSpeed = 200;
            this.EmailbunifuTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EmailbunifuTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EmailbunifuTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.EmailbunifuTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmailbunifuTextBox.BackgroundImage")));
            this.EmailbunifuTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.EmailbunifuTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EmailbunifuTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EmailbunifuTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.EmailbunifuTextBox.BorderRadius = 1;
            this.EmailbunifuTextBox.BorderThickness = 2;
            this.EmailbunifuTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmailbunifuTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailbunifuTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailbunifuTextBox.DefaultText = "";
            this.EmailbunifuTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.EmailbunifuTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.EmailbunifuTextBox.HideSelection = true;
            this.EmailbunifuTextBox.IconLeft = null;
            this.EmailbunifuTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailbunifuTextBox.IconPadding = 10;
            this.EmailbunifuTextBox.IconRight = null;
            this.EmailbunifuTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailbunifuTextBox.Lines = new string[0];
            this.EmailbunifuTextBox.Location = new System.Drawing.Point(35, 87);
            this.EmailbunifuTextBox.MaxLength = 32767;
            this.EmailbunifuTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.EmailbunifuTextBox.Modified = false;
            this.EmailbunifuTextBox.Multiline = false;
            this.EmailbunifuTextBox.Name = "EmailbunifuTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmailbunifuTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.EmailbunifuTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmailbunifuTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            stateProperties4.ForeColor = System.Drawing.SystemColors.Control;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmailbunifuTextBox.OnIdleState = stateProperties4;
            this.EmailbunifuTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.EmailbunifuTextBox.PasswordChar = '\0';
            this.EmailbunifuTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.EmailbunifuTextBox.PlaceholderText = "";
            this.EmailbunifuTextBox.ReadOnly = false;
            this.EmailbunifuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailbunifuTextBox.SelectedText = "";
            this.EmailbunifuTextBox.SelectionLength = 0;
            this.EmailbunifuTextBox.SelectionStart = 0;
            this.EmailbunifuTextBox.ShortcutsEnabled = true;
            this.EmailbunifuTextBox.Size = new System.Drawing.Size(338, 38);
            this.EmailbunifuTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.EmailbunifuTextBox.TabIndex = 43;
            this.EmailbunifuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmailbunifuTextBox.TextMarginBottom = 0;
            this.EmailbunifuTextBox.TextMarginLeft = 0;
            this.EmailbunifuTextBox.TextMarginTop = 0;
            this.EmailbunifuTextBox.TextPlaceholder = "";
            this.EmailbunifuTextBox.UseSystemPasswordChar = false;
            this.EmailbunifuTextBox.WordWrap = true;
            // 
            // ChangeEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(409, 226);
            this.Controls.Add(this.EmailbunifuTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChangeEmailButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeEmailForm";
            this.Text = "ChangeEmailForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeEmailForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button ChangeEmailButton;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextBox EmailbunifuTextBox;
    }
}