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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelUserID = new System.Windows.Forms.Label();
            this.tableJournalsList = new System.Windows.Forms.DataGridView();
            this.buttonToJournalForm = new System.Windows.Forms.Button();
            this.labelJournalName = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.buttonCreateNewJournal = new System.Windows.Forms.Button();
            this.buttonCloseApplication = new System.Windows.Forms.Button();
            this.journal_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableJournalsList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelUserID.Location = new System.Drawing.Point(0, 0);
            this.labelUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(15, 13);
            this.labelUserID.TabIndex = 16;
            this.labelUserID.Text = "id";
            // 
            // tableJournalsList
            // 
            this.tableJournalsList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableJournalsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.tableJournalsList.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableJournalsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableJournalsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableJournalsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.journal_id,
            this.groupName,
            this.disciplineName});
            this.tableJournalsList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableJournalsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableJournalsList.Location = new System.Drawing.Point(0, 107);
            this.tableJournalsList.Margin = new System.Windows.Forms.Padding(2);
            this.tableJournalsList.MultiSelect = false;
            this.tableJournalsList.Name = "tableJournalsList";
            this.tableJournalsList.RowHeadersWidth = 51;
            this.tableJournalsList.RowTemplate.Height = 24;
            this.tableJournalsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tableJournalsList.Size = new System.Drawing.Size(930, 160);
            this.tableJournalsList.TabIndex = 10;
            this.tableJournalsList.Click += new System.EventHandler(this.tableJournalsList_Click);
            // 
            // buttonToJournalForm
            // 
            this.buttonToJournalForm.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonToJournalForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToJournalForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonToJournalForm.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToJournalForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonToJournalForm.Location = new System.Drawing.Point(0, 271);
            this.buttonToJournalForm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonToJournalForm.Name = "buttonToJournalForm";
            this.buttonToJournalForm.Size = new System.Drawing.Size(930, 55);
            this.buttonToJournalForm.TabIndex = 11;
            this.buttonToJournalForm.Text = "Открыть журнал";
            this.buttonToJournalForm.UseVisualStyleBackColor = false;
            this.buttonToJournalForm.Click += new System.EventHandler(this.buttonToJournalForm_Click);
            // 
            // labelJournalName
            // 
            this.labelJournalName.AutoSize = true;
            this.labelJournalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelJournalName.Location = new System.Drawing.Point(11, 72);
            this.labelJournalName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJournalName.Name = "labelJournalName";
            this.labelJournalName.Size = new System.Drawing.Size(196, 26);
            this.labelJournalName.TabIndex = 12;
            this.labelJournalName.Text = "Выберите журнал";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Azure;
            this.userName.Font = new System.Drawing.Font("Elephant", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(12, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(193, 33);
            this.userName.TabIndex = 15;
            this.userName.Text = "Пользователь";
            // 
            // buttonCreateNewJournal
            // 
            this.buttonCreateNewJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateNewJournal.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonCreateNewJournal.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonCreateNewJournal.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateNewJournal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateNewJournal.Location = new System.Drawing.Point(799, 57);
            this.buttonCreateNewJournal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateNewJournal.Name = "buttonCreateNewJournal";
            this.buttonCreateNewJournal.Size = new System.Drawing.Size(131, 55);
            this.buttonCreateNewJournal.TabIndex = 17;
            this.buttonCreateNewJournal.Text = "Новый журнал";
            this.buttonCreateNewJournal.UseVisualStyleBackColor = false;
            this.buttonCreateNewJournal.Click += new System.EventHandler(this.buttonCreateNewJournal_Click_1);
            // 
            // buttonCloseApplication
            // 
            this.buttonCloseApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseApplication.BackColor = System.Drawing.Color.Brown;
            this.buttonCloseApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseApplication.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseApplication.Location = new System.Drawing.Point(898, 0);
            this.buttonCloseApplication.Name = "buttonCloseApplication";
            this.buttonCloseApplication.Size = new System.Drawing.Size(32, 33);
            this.buttonCloseApplication.TabIndex = 18;
            this.buttonCloseApplication.Text = "X";
            this.buttonCloseApplication.UseVisualStyleBackColor = false;
            this.buttonCloseApplication.Click += new System.EventHandler(this.button1_Click);
            // 
            // journal_id
            // 
            this.journal_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.journal_id.HeaderText = "id";
            this.journal_id.MinimumWidth = 6;
            this.journal_id.Name = "journal_id";
            this.journal_id.Width = 50;
            // 
            // groupName
            // 
            this.groupName.HeaderText = "Название группы";
            this.groupName.MinimumWidth = 6;
            this.groupName.Name = "groupName";
            this.groupName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.groupName.Width = 300;
            // 
            // disciplineName
            // 
            this.disciplineName.HeaderText = "Название Дисциплины";
            this.disciplineName.MinimumWidth = 6;
            this.disciplineName.Name = "disciplineName";
            this.disciplineName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.disciplineName.Width = 515;
            // 
            // JournalsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(930, 326);
            this.Controls.Add(this.buttonCloseApplication);
            this.Controls.Add(this.buttonCreateNewJournal);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.labelJournalName);
            this.Controls.Add(this.buttonToJournalForm);
            this.Controls.Add(this.tableJournalsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JournalsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.tableJournalsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tableJournalsList;
        private System.Windows.Forms.Button buttonToJournalForm;
        private System.Windows.Forms.Label labelJournalName;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button buttonCreateNewJournal;
        private System.Windows.Forms.Button buttonCloseApplication;
        private System.Windows.Forms.DataGridViewTextBoxColumn journal_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineName;
    }
}