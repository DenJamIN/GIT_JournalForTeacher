namespace JournalForStudents
{
    partial class mainTeacherForm
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
            this.lastnameProf = new System.Windows.Forms.Label();
            this.nameProf = new System.Windows.Forms.Label();
            this.middlenameProf = new System.Windows.Forms.Label();
            this.rankProf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Showcard Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.DarkRed;
            this.CloseButton.Location = new System.Drawing.Point(1382, -1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(60, 46);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Х";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // lastnameProf
            // 
            this.lastnameProf.AutoSize = true;
            this.lastnameProf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastnameProf.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameProf.Location = new System.Drawing.Point(532, 262);
            this.lastnameProf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastnameProf.Name = "lastnameProf";
            this.lastnameProf.Size = new System.Drawing.Size(115, 36);
            this.lastnameProf.TabIndex = 13;
            this.lastnameProf.Text = "Иванов";
            // 
            // nameProf
            // 
            this.nameProf.AutoSize = true;
            this.nameProf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameProf.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProf.Location = new System.Drawing.Point(532, 343);
            this.nameProf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameProf.Name = "nameProf";
            this.nameProf.Size = new System.Drawing.Size(128, 36);
            this.nameProf.TabIndex = 12;
            this.nameProf.Text = "Евгений";
            // 
            // middlenameProf
            // 
            this.middlenameProf.AutoSize = true;
            this.middlenameProf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.middlenameProf.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middlenameProf.Location = new System.Drawing.Point(532, 418);
            this.middlenameProf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.middlenameProf.Name = "middlenameProf";
            this.middlenameProf.Size = new System.Drawing.Size(148, 36);
            this.middlenameProf.TabIndex = 11;
            this.middlenameProf.Text = "Иванович";
            // 
            // rankProf
            // 
            this.rankProf.AutoSize = true;
            this.rankProf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rankProf.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankProf.Location = new System.Drawing.Point(532, 187);
            this.rankProf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rankProf.Name = "rankProf";
            this.rankProf.Size = new System.Drawing.Size(217, 36);
            this.rankProf.TabIndex = 10;
            this.rankProf.Text = "Преподаватель";
            // 
            // mainTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::JournalForStudents.Properties.Resources.Профиль_ГлавныйЭкран;
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.Controls.Add(this.lastnameProf);
            this.Controls.Add(this.nameProf);
            this.Controls.Add(this.middlenameProf);
            this.Controls.Add(this.rankProf);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainTeacherForm";
            this.Text = "mainTeacherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CloseButton;
        public string teacherFromLoginForm = "";
        private System.Windows.Forms.Label lastnameProf;
        private System.Windows.Forms.Label nameProf;
        private System.Windows.Forms.Label middlenameProf;
        private System.Windows.Forms.Label rankProf;
    }
}