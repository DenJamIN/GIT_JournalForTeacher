namespace JournalForStudents
{
    partial class SummationForm
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
            this.labelSummation = new System.Windows.Forms.Label();
            this.textBoxFirstDate = new System.Windows.Forms.TextBox();
            this.textBoxSecondDate = new System.Windows.Forms.TextBox();
            this.buttonConfirmDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSummation
            // 
            this.labelSummation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSummation.AutoSize = true;
            this.labelSummation.Font = new System.Drawing.Font("Elephant", 24.25F);
            this.labelSummation.Location = new System.Drawing.Point(75, 25);
            this.labelSummation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSummation.Name = "labelSummation";
            this.labelSummation.Size = new System.Drawing.Size(242, 42);
            this.labelSummation.TabIndex = 0;
            this.labelSummation.Text = "Введите даты";
            // 
            // textBoxFirstDate
            // 
            this.textBoxFirstDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstDate.Location = new System.Drawing.Point(82, 108);
            this.textBoxFirstDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFirstDate.Multiline = true;
            this.textBoxFirstDate.Name = "textBoxFirstDate";
            this.textBoxFirstDate.Size = new System.Drawing.Size(241, 58);
            this.textBoxFirstDate.TabIndex = 1;
            this.textBoxFirstDate.Enter += new System.EventHandler(this.textBoxFirstDate_Enter);
            this.textBoxFirstDate.Leave += new System.EventHandler(this.textBoxFirstDate_Leave);
            // 
            // textBoxSecondDate
            // 
            this.textBoxSecondDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecondDate.Location = new System.Drawing.Point(82, 218);
            this.textBoxSecondDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSecondDate.Multiline = true;
            this.textBoxSecondDate.Name = "textBoxSecondDate";
            this.textBoxSecondDate.Size = new System.Drawing.Size(241, 58);
            this.textBoxSecondDate.TabIndex = 2;
            this.textBoxSecondDate.Enter += new System.EventHandler(this.textBoxSecondDate_Enter);
            this.textBoxSecondDate.Leave += new System.EventHandler(this.textBoxSecondDate_Leave);
            // 
            // buttonConfirmDate
            // 
            this.buttonConfirmDate.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonConfirmDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonConfirmDate.Font = new System.Drawing.Font("Century", 22.25F, System.Drawing.FontStyle.Bold);
            this.buttonConfirmDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConfirmDate.Location = new System.Drawing.Point(0, 331);
            this.buttonConfirmDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonConfirmDate.Name = "buttonConfirmDate";
            this.buttonConfirmDate.Size = new System.Drawing.Size(376, 64);
            this.buttonConfirmDate.TabIndex = 3;
            this.buttonConfirmDate.Text = "Посчитать баллы";
            this.buttonConfirmDate.UseVisualStyleBackColor = false;
            this.buttonConfirmDate.Click += new System.EventHandler(this.buttonConfirmDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "До";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "От";
            // 
            // SummationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(376, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirmDate);
            this.Controls.Add(this.textBoxSecondDate);
            this.Controls.Add(this.textBoxFirstDate);
            this.Controls.Add(this.labelSummation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SummationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Суммирование по диапазону";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSummation;
        private System.Windows.Forms.TextBox textBoxFirstDate;
        private System.Windows.Forms.TextBox textBoxSecondDate;
        private System.Windows.Forms.Button buttonConfirmDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}