namespace JournalForStudents
{
    partial class JournalsListForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.intoProfile = new System.Windows.Forms.Label();
            this.intoJournals = new System.Windows.Forms.Label();
            this.intoTimetable = new System.Windows.Forms.Label();
            this.buttonCreateNewJournal = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCreateNewJournal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.intoTimetable);
            this.panel1.Controls.Add(this.intoJournals);
            this.panel1.Controls.Add(this.intoProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 753);
            this.panel1.TabIndex = 1;
            // 
            // intoProfile
            // 
            this.intoProfile.AutoSize = true;
            this.intoProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intoProfile.Location = new System.Drawing.Point(12, 47);
            this.intoProfile.Name = "intoProfile";
            this.intoProfile.Size = new System.Drawing.Size(121, 29);
            this.intoProfile.TabIndex = 0;
            this.intoProfile.Text = "Профиль";
            // 
            // intoJournals
            // 
            this.intoJournals.AutoSize = true;
            this.intoJournals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.intoJournals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intoJournals.Location = new System.Drawing.Point(12, 208);
            this.intoJournals.Name = "intoJournals";
            this.intoJournals.Size = new System.Drawing.Size(123, 29);
            this.intoJournals.TabIndex = 1;
            this.intoJournals.Text = "Журналы";
            this.intoJournals.Click += new System.EventHandler(this.intoJournals_Click);
            // 
            // intoTimetable
            // 
            this.intoTimetable.AutoSize = true;
            this.intoTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intoTimetable.Location = new System.Drawing.Point(12, 391);
            this.intoTimetable.Name = "intoTimetable";
            this.intoTimetable.Size = new System.Drawing.Size(154, 29);
            this.intoTimetable.TabIndex = 2;
            this.intoTimetable.Text = "Расписание";
            // 
            // buttonCreateNewJournal
            // 
            this.buttonCreateNewJournal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateNewJournal.Image = global::JournalForStudents.Properties.Resources.CreateNewJournal;
            this.buttonCreateNewJournal.Location = new System.Drawing.Point(1135, 440);
            this.buttonCreateNewJournal.Name = "buttonCreateNewJournal";
            this.buttonCreateNewJournal.Size = new System.Drawing.Size(231, 232);
            this.buttonCreateNewJournal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonCreateNewJournal.TabIndex = 9;
            this.buttonCreateNewJournal.TabStop = false;
            this.buttonCreateNewJournal.Click += new System.EventHandler(this.buttonCreateNewJournal_Click);
            // 
            // JournalsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 753);
            this.Controls.Add(this.buttonCreateNewJournal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JournalsListForm";
            this.Text = "JournalsListForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCreateNewJournal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label intoTimetable;
        private System.Windows.Forms.Label intoJournals;
        private System.Windows.Forms.Label intoProfile;
        private System.Windows.Forms.PictureBox buttonCreateNewJournal;
    }
}