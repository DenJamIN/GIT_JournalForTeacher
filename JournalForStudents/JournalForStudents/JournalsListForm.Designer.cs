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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelUserID = new System.Windows.Forms.Label();
            this.tableJournalsList = new System.Windows.Forms.DataGridView();
            this.journal_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonToJournalForm = new System.Windows.Forms.Button();
            this.labelJournalName = new System.Windows.Forms.Label();
            this.surnameProf = new System.Windows.Forms.Label();
            this.nameProf = new System.Windows.Forms.Label();
            this.middlenameProf = new System.Windows.Forms.Label();
            this.buttonCreateNewJournal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableJournalsList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelUserID.Location = new System.Drawing.Point(1421, 0);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(19, 17);
            this.labelUserID.TabIndex = 16;
            this.labelUserID.Text = "id";
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
            this.tableJournalsList.Location = new System.Drawing.Point(200, 223);
            this.tableJournalsList.MultiSelect = false;
            this.tableJournalsList.Name = "tableJournalsList";
            this.tableJournalsList.ReadOnly = true;
            this.tableJournalsList.RowHeadersWidth = 51;
            this.tableJournalsList.RowTemplate.Height = 24;
            this.tableJournalsList.Size = new System.Drawing.Size(1204, 395);
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
            this.buttonToJournalForm.Location = new System.Drawing.Point(1172, 167);
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
            this.labelJournalName.Location = new System.Drawing.Point(316, 167);
            this.labelJournalName.Name = "labelJournalName";
            this.labelJournalName.Size = new System.Drawing.Size(238, 31);
            this.labelJournalName.TabIndex = 12;
            this.labelJournalName.Text = "Выберите журнал";
            // 
            // surnameProf
            // 
            this.surnameProf.AutoSize = true;
            this.surnameProf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.surnameProf.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameProf.Location = new System.Drawing.Point(924, 0);
            this.surnameProf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameProf.Name = "surnameProf";
            this.surnameProf.Size = new System.Drawing.Size(115, 36);
            this.surnameProf.TabIndex = 16;
            this.surnameProf.Text = "Иванов";
            // 
            // nameProf
            // 
            this.nameProf.AutoSize = true;
            this.nameProf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameProf.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProf.Location = new System.Drawing.Point(924, 51);
            this.nameProf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameProf.Name = "nameProf";
            this.nameProf.Size = new System.Drawing.Size(128, 36);
            this.nameProf.TabIndex = 15;
            this.nameProf.Text = "Евгений";
            // 
            // middlenameProf
            // 
            this.middlenameProf.AutoSize = true;
            this.middlenameProf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.middlenameProf.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middlenameProf.Location = new System.Drawing.Point(924, 103);
            this.middlenameProf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.middlenameProf.Name = "middlenameProf";
            this.middlenameProf.Size = new System.Drawing.Size(148, 36);
            this.middlenameProf.TabIndex = 14;
            this.middlenameProf.Text = "Иванович";
            // 
            // buttonCreateNewJournal
            // 
            this.buttonCreateNewJournal.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonCreateNewJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateNewJournal.Location = new System.Drawing.Point(200, 615);
            this.buttonCreateNewJournal.Name = "buttonCreateNewJournal";
            this.buttonCreateNewJournal.Size = new System.Drawing.Size(1204, 61);
            this.buttonCreateNewJournal.TabIndex = 17;
            this.buttonCreateNewJournal.Text = "Добавить новый журнал";
            this.buttonCreateNewJournal.UseVisualStyleBackColor = false;
            this.buttonCreateNewJournal.Click += new System.EventHandler(this.buttonCreateNewJournal_Click_1);
            // 
            // JournalsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.Controls.Add(this.buttonCreateNewJournal);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.surnameProf);
            this.Controls.Add(this.nameProf);
            this.Controls.Add(this.middlenameProf);
            this.Controls.Add(this.labelJournalName);
            this.Controls.Add(this.buttonToJournalForm);
            this.Controls.Add(this.tableJournalsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JournalsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JournalsListForm";
            ((System.ComponentModel.ISupportInitialize)(this.tableJournalsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tableJournalsList;
        private System.Windows.Forms.Button buttonToJournalForm;
        private System.Windows.Forms.Label labelJournalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn journal_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineName;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label surnameProf;
        private System.Windows.Forms.Label nameProf;
        private System.Windows.Forms.Label middlenameProf;
        private System.Windows.Forms.Button buttonCreateNewJournal;
    }
}