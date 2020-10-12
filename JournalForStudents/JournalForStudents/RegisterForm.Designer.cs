﻿namespace JournalForStudents
{
    partial class RegisterForm
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
            this.CloseButton = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.middleNameField = new System.Windows.Forms.TextBox();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.DarkCyan;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Showcard Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.DarkRed;
            this.CloseButton.Location = new System.Drawing.Point(646, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(54, 46);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Х";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegister.Location = new System.Drawing.Point(0, 777);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(700, 73);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Создать аккаунт";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.SystemColors.MenuBar;
            this.passwordField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(49, 681);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(460, 45);
            this.passwordField.TabIndex = 4;
            this.passwordField.UseSystemPasswordChar = true;
            this.passwordField.Enter += new System.EventHandler(this.passwordField_Enter);
            this.passwordField.Leave += new System.EventHandler(this.passwordField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JournalForStudents.Properties.Resources.Authorization_Password;
            this.pictureBox2.Location = new System.Drawing.Point(565, 662);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.SystemColors.MenuBar;
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginField.Location = new System.Drawing.Point(49, 562);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(460, 64);
            this.loginField.TabIndex = 2;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JournalForStudents.Properties.Resources.Authorization_User;
            this.pictureBox1.Location = new System.Drawing.Point(565, 553);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.LightCyan;
            this.MenuPanel.Controls.Add(this.panel1);
            this.MenuPanel.Controls.Add(this.middleNameField);
            this.MenuPanel.Controls.Add(this.userSurnameField);
            this.MenuPanel.Controls.Add(this.userNameField);
            this.MenuPanel.Controls.Add(this.buttonRegister);
            this.MenuPanel.Controls.Add(this.passwordField);
            this.MenuPanel.Controls.Add(this.pictureBox2);
            this.MenuPanel.Controls.Add(this.loginField);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(700, 850);
            this.MenuPanel.TabIndex = 1;
            this.MenuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPanel_MouseDown);
            this.MenuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuPanel_MouseMove);
            // 
            // middleNameField
            // 
            this.middleNameField.BackColor = System.Drawing.SystemColors.MenuBar;
            this.middleNameField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameField.Location = new System.Drawing.Point(49, 417);
            this.middleNameField.Multiline = true;
            this.middleNameField.Name = "middleNameField";
            this.middleNameField.Size = new System.Drawing.Size(460, 64);
            this.middleNameField.TabIndex = 11;
            this.middleNameField.Enter += new System.EventHandler(this.middleNameField_Enter);
            this.middleNameField.Leave += new System.EventHandler(this.middleNameField_Leave);
            // 
            // userSurnameField
            // 
            this.userSurnameField.BackColor = System.Drawing.SystemColors.MenuBar;
            this.userSurnameField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSurnameField.Location = new System.Drawing.Point(49, 292);
            this.userSurnameField.Multiline = true;
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(460, 64);
            this.userSurnameField.TabIndex = 7;
            this.userSurnameField.Enter += new System.EventHandler(this.userLastNameField_Enter);
            this.userSurnameField.Leave += new System.EventHandler(this.userLastNameField_Leave);
            // 
            // userNameField
            // 
            this.userNameField.BackColor = System.Drawing.SystemColors.MenuBar;
            this.userNameField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameField.Location = new System.Drawing.Point(49, 177);
            this.userNameField.Multiline = true;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(460, 64);
            this.userNameField.TabIndex = 6;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 140);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(210, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Регистрация";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 850);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox middleNameField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}