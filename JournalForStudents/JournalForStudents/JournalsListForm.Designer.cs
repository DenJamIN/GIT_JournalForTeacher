﻿namespace JournalForStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.intoTimetable = new System.Windows.Forms.Label();
            this.intoJournals = new System.Windows.Forms.Label();
            this.intoProfile = new System.Windows.Forms.Label();
            this.buttonCreateNewJournal = new System.Windows.Forms.PictureBox();
            this.tableJournalsList = new System.Windows.Forms.DataGridView();
            this.journal_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonToJournalForm = new System.Windows.Forms.Button();
            this.labelJournalName = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCreateNewJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableJournalsList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelUserID);
            this.panel1.Controls.Add(this.intoTimetable);
            this.panel1.Controls.Add(this.intoJournals);
            this.panel1.Controls.Add(this.intoProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 800);
            this.panel1.TabIndex = 1;
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
            // intoJournals
            // 
            this.intoJournals.AutoSize = true;
            this.intoJournals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.intoJournals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intoJournals.Location = new System.Drawing.Point(12, 223);
            this.intoJournals.Name = "intoJournals";
            this.intoJournals.Size = new System.Drawing.Size(123, 29);
            this.intoJournals.TabIndex = 1;
            this.intoJournals.Text = "Журналы";
            this.intoJournals.Click += new System.EventHandler(this.intoJournals_Click);
            // 
            // intoProfile
            // 
            this.intoProfile.AutoSize = true;
            this.intoProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intoProfile.Location = new System.Drawing.Point(14, 77);
            this.intoProfile.Name = "intoProfile";
            this.intoProfile.Size = new System.Drawing.Size(121, 29);
            this.intoProfile.TabIndex = 0;
            this.intoProfile.Text = "Профиль";
            // 
            // buttonCreateNewJournal
            // 
            this.buttonCreateNewJournal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateNewJournal.Image = global::JournalForStudents.Properties.Resources.CreateNewJournal;
            this.buttonCreateNewJournal.Location = new System.Drawing.Point(1326, 691);
            this.buttonCreateNewJournal.Name = "buttonCreateNewJournal";
            this.buttonCreateNewJournal.Size = new System.Drawing.Size(114, 109);
            this.buttonCreateNewJournal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonCreateNewJournal.TabIndex = 9;
            this.buttonCreateNewJournal.TabStop = false;
            this.buttonCreateNewJournal.Click += new System.EventHandler(this.buttonCreateNewJournal_Click);
            // 
            // tableJournalsList
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableJournalsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableJournalsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableJournalsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.journal_id,
            this.groupName,
            this.disciplineName});
            this.tableJournalsList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableJournalsList.DefaultCellStyle = dataGridViewCellStyle4;
            this.tableJournalsList.Location = new System.Drawing.Point(193, 163);
            this.tableJournalsList.MultiSelect = false;
            this.tableJournalsList.Name = "tableJournalsList";
            this.tableJournalsList.ReadOnly = true;
            this.tableJournalsList.RowHeadersWidth = 51;
            this.tableJournalsList.RowTemplate.Height = 24;
            this.tableJournalsList.Size = new System.Drawing.Size(1204, 505);
            this.tableJournalsList.TabIndex = 10;
            this.tableJournalsList.Click += new System.EventHandler(this.tableJournalsList_Click);
            // 
            // journal_id
            // 
            this.journal_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.journal_id.HeaderText = "id";
            this.journal_id.MinimumWidth = 6;
            this.journal_id.Name = "journal_id";
            this.journal_id.ReadOnly = true;
            this.journal_id.Width = 62;
            // 
            // groupName
            // 
            this.groupName.HeaderText = "Название группы";
            this.groupName.MinimumWidth = 6;
            this.groupName.Name = "groupName";
            this.groupName.ReadOnly = true;
            this.groupName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.groupName.Width = 300;
            // 
            // disciplineName
            // 
            this.disciplineName.HeaderText = "Название Дисциплины";
            this.disciplineName.MinimumWidth = 6;
            this.disciplineName.Name = "disciplineName";
            this.disciplineName.ReadOnly = true;
            this.disciplineName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.disciplineName.Width = 500;
            // 
            // buttonToJournalForm
            // 
            this.buttonToJournalForm.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonToJournalForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToJournalForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToJournalForm.Location = new System.Drawing.Point(1165, 107);
            this.buttonToJournalForm.Name = "buttonToJournalForm";
            this.buttonToJournalForm.Size = new System.Drawing.Size(232, 59);
            this.buttonToJournalForm.TabIndex = 11;
            this.buttonToJournalForm.Text = "Открыть журнал";
            this.buttonToJournalForm.UseVisualStyleBackColor = false;
            this.buttonToJournalForm.Click += new System.EventHandler(this.buttonToJournalForm_Click);
            // 
            // labelJournalName
            // 
            this.labelJournalName.AutoSize = true;
            this.labelJournalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelJournalName.Location = new System.Drawing.Point(309, 107);
            this.labelJournalName.Name = "labelJournalName";
            this.labelJournalName.Size = new System.Drawing.Size(238, 31);
            this.labelJournalName.TabIndex = 12;
            this.labelJournalName.Text = "Выберите журнал";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(3, 0);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(19, 17);
            this.labelUserID.TabIndex = 16;
            this.labelUserID.Text = "id";
            // 
            // JournalsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.Controls.Add(this.labelJournalName);
            this.Controls.Add(this.buttonToJournalForm);
            this.Controls.Add(this.tableJournalsList);
            this.Controls.Add(this.buttonCreateNewJournal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JournalsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JournalsListForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCreateNewJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableJournalsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label intoTimetable;
        private System.Windows.Forms.Label intoJournals;
        private System.Windows.Forms.Label intoProfile;
        private System.Windows.Forms.PictureBox buttonCreateNewJournal;
        private System.Windows.Forms.DataGridView tableJournalsList;
        private System.Windows.Forms.Button buttonToJournalForm;
        private System.Windows.Forms.Label labelJournalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn journal_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineName;
        private System.Windows.Forms.Label labelUserID;
    }
}