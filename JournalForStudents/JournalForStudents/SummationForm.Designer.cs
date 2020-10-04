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
            this.labelSummation.AutoSize = true;
            this.labelSummation.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSummation.Location = new System.Drawing.Point(139, 38);
            this.labelSummation.Name = "labelSummation";
            this.labelSummation.Size = new System.Drawing.Size(264, 44);
            this.labelSummation.TabIndex = 0;
            this.labelSummation.Text = "Введите даты";
            // 
            // textBoxFirstDate
            // 
            this.textBoxFirstDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstDate.Location = new System.Drawing.Point(147, 148);
            this.textBoxFirstDate.Multiline = true;
            this.textBoxFirstDate.Name = "textBoxFirstDate";
            this.textBoxFirstDate.Size = new System.Drawing.Size(320, 70);
            this.textBoxFirstDate.TabIndex = 1;
            // 
            // textBoxSecondDate
            // 
            this.textBoxSecondDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecondDate.Location = new System.Drawing.Point(147, 281);
            this.textBoxSecondDate.Multiline = true;
            this.textBoxSecondDate.Name = "textBoxSecondDate";
            this.textBoxSecondDate.Size = new System.Drawing.Size(320, 70);
            this.textBoxSecondDate.TabIndex = 2;
            // 
            // buttonConfirmDate
            // 
            this.buttonConfirmDate.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonConfirmDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonConfirmDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirmDate.Location = new System.Drawing.Point(0, 407);
            this.buttonConfirmDate.Name = "buttonConfirmDate";
            this.buttonConfirmDate.Size = new System.Drawing.Size(547, 79);
            this.buttonConfirmDate.TabIndex = 3;
            this.buttonConfirmDate.Text = "Посчитать баллы за этот период";
            this.buttonConfirmDate.UseVisualStyleBackColor = false;
            this.buttonConfirmDate.Click += new System.EventHandler(this.buttonConfirmDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "До";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "От";
            // 
            // SummationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(547, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirmDate);
            this.Controls.Add(this.textBoxSecondDate);
            this.Controls.Add(this.textBoxFirstDate);
            this.Controls.Add(this.labelSummation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SummationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SummationForm";
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