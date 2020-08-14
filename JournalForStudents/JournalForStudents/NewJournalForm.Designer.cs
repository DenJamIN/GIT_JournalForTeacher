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
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupNameField
            // 
            this.groupNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupNameField.Location = new System.Drawing.Point(12, 127);
            this.groupNameField.Multiline = true;
            this.groupNameField.Name = "groupNameField";
            this.groupNameField.Size = new System.Drawing.Size(509, 58);
            this.groupNameField.TabIndex = 0;
            this.groupNameField.Enter += new System.EventHandler(this.groupNameField_Enter);
            this.groupNameField.Leave += new System.EventHandler(this.groupNameField_Leave);
            // 
            // disciplineNameField
            // 
            this.disciplineNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disciplineNameField.Location = new System.Drawing.Point(12, 236);
            this.disciplineNameField.Multiline = true;
            this.disciplineNameField.Name = "disciplineNameField";
            this.disciplineNameField.Size = new System.Drawing.Size(509, 58);
            this.disciplineNameField.TabIndex = 1;
            this.disciplineNameField.Enter += new System.EventHandler(this.disciplineNameField_Enter);
            this.disciplineNameField.Leave += new System.EventHandler(this.disciplineNameField_Leave);
            // 
            // buttonCreateJournal
            // 
            this.buttonCreateJournal.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonCreateJournal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateJournal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCreateJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateJournal.Location = new System.Drawing.Point(0, 380);
            this.buttonCreateJournal.Name = "buttonCreateJournal";
            this.buttonCreateJournal.Size = new System.Drawing.Size(533, 77);
            this.buttonCreateJournal.TabIndex = 2;
            this.buttonCreateJournal.Text = "Создать журнал";
            this.buttonCreateJournal.UseVisualStyleBackColor = false;
            this.buttonCreateJournal.Click += new System.EventHandler(this.button1_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(42, 37);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(435, 39);
            this.label.TabIndex = 3;
            this.label.Text = "Создание нового журнала";
            // 
            // NewJournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(533, 457);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonCreateJournal);
            this.Controls.Add(this.disciplineNameField);
            this.Controls.Add(this.groupNameField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewJournalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewJournalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox groupNameField;
        private System.Windows.Forms.TextBox disciplineNameField;
        private System.Windows.Forms.Button buttonCreateJournal;
        private System.Windows.Forms.Label label;
    }
}