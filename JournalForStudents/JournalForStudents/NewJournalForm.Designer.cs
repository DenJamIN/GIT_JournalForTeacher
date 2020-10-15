namespace JournalForStudents
{
    partial class NewJournalForm
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
            this.groupNameField = new System.Windows.Forms.TextBox();
            this.disciplineNameField = new System.Windows.Forms.TextBox();
            this.buttonCreateJournal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupNameField
            // 
            this.groupNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupNameField.Location = new System.Drawing.Point(9, 36);
            this.groupNameField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupNameField.Multiline = true;
            this.groupNameField.Name = "groupNameField";
            this.groupNameField.Size = new System.Drawing.Size(383, 48);
            this.groupNameField.TabIndex = 0;
            this.groupNameField.Enter += new System.EventHandler(this.groupNameField_Enter);
            this.groupNameField.Leave += new System.EventHandler(this.groupNameField_Leave);
            // 
            // disciplineNameField
            // 
            this.disciplineNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disciplineNameField.Location = new System.Drawing.Point(9, 123);
            this.disciplineNameField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.disciplineNameField.Multiline = true;
            this.disciplineNameField.Name = "disciplineNameField";
            this.disciplineNameField.Size = new System.Drawing.Size(383, 48);
            this.disciplineNameField.TabIndex = 1;
            this.disciplineNameField.Enter += new System.EventHandler(this.disciplineNameField_Enter);
            this.disciplineNameField.Leave += new System.EventHandler(this.disciplineNameField_Leave);
            // 
            // buttonCreateJournal
            // 
            this.buttonCreateJournal.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCreateJournal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateJournal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCreateJournal.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateJournal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateJournal.Location = new System.Drawing.Point(0, 215);
            this.buttonCreateJournal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateJournal.Name = "buttonCreateJournal";
            this.buttonCreateJournal.Size = new System.Drawing.Size(400, 63);
            this.buttonCreateJournal.TabIndex = 2;
            this.buttonCreateJournal.Text = "Создать журнал";
            this.buttonCreateJournal.UseVisualStyleBackColor = false;
            this.buttonCreateJournal.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewJournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(400, 278);
            this.Controls.Add(this.buttonCreateJournal);
            this.Controls.Add(this.disciplineNameField);
            this.Controls.Add(this.groupNameField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewJournalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый журнал";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox groupNameField;
        private System.Windows.Forms.TextBox disciplineNameField;
        private System.Windows.Forms.Button buttonCreateJournal;
    }
}