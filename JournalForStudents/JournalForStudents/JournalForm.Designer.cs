namespace Journal
{
    partial class JournalForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableStudent = new System.Windows.Forms.DataGridView();
            this.students = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLessonType = new System.Windows.Forms.DataGridView();
            this.nullColumns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLessonDate = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group = new System.Windows.Forms.Label();
            this.discipline = new System.Windows.Forms.Label();
            this.labelGroupName = new System.Windows.Forms.Label();
            this.labelDisciplineName = new System.Windows.Forms.Label();
            this.labelScorePerLesson = new System.Windows.Forms.Label();
            this.scoresPerLesson = new System.Windows.Forms.TextBox();
            this.labelGroupID = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.menuJournalTools = new System.Windows.Forms.MenuStrip();
            this.journalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summationToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summationDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summationAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDatesSummation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLessonType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLessonDate)).BeginInit();
            this.menuJournalTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableStudent
            // 
            this.tableStudent.AllowUserToResizeColumns = false;
            this.tableStudent.AllowUserToResizeRows = false;
            this.tableStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.students});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableStudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableStudent.Location = new System.Drawing.Point(0, 273);
            this.tableStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableStudent.MultiSelect = false;
            this.tableStudent.Name = "tableStudent";
            this.tableStudent.RowHeadersWidth = 51;
            this.tableStudent.RowTemplate.Height = 24;
            this.tableStudent.Size = new System.Drawing.Size(1446, 527);
            this.tableStudent.TabIndex = 2;
            this.tableStudent.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tableStudent_Scroll);
            // 
            // students
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.students.DefaultCellStyle = dataGridViewCellStyle1;
            this.students.HeaderText = "Список студентов";
            this.students.MinimumWidth = 6;
            this.students.Name = "students";
            this.students.Width = 125;
            // 
            // tableLessonType
            // 
            this.tableLessonType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLessonType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nullColumns});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableLessonType.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableLessonType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLessonType.Location = new System.Drawing.Point(0, 220);
            this.tableLessonType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLessonType.MultiSelect = false;
            this.tableLessonType.Name = "tableLessonType";
            this.tableLessonType.RowHeadersWidth = 51;
            this.tableLessonType.RowTemplate.Height = 24;
            this.tableLessonType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tableLessonType.Size = new System.Drawing.Size(1446, 53);
            this.tableLessonType.TabIndex = 7;
            // 
            // nullColumns
            // 
            this.nullColumns.HeaderText = "";
            this.nullColumns.MinimumWidth = 6;
            this.nullColumns.Name = "nullColumns";
            this.nullColumns.ReadOnly = true;
            this.nullColumns.Width = 125;
            // 
            // tableLessonDate
            // 
            this.tableLessonDate.AllowUserToDeleteRows = false;
            this.tableLessonDate.AllowUserToResizeColumns = false;
            this.tableLessonDate.AllowUserToResizeRows = false;
            this.tableLessonDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLessonDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableLessonDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.tableLessonDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLessonDate.Location = new System.Drawing.Point(0, 168);
            this.tableLessonDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLessonDate.MultiSelect = false;
            this.tableLessonDate.Name = "tableLessonDate";
            this.tableLessonDate.RowHeadersWidth = 51;
            this.tableLessonDate.RowTemplate.Height = 24;
            this.tableLessonDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tableLessonDate.Size = new System.Drawing.Size(1446, 52);
            this.tableLessonDate.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // group
            // 
            this.group.AutoSize = true;
            this.group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group.Location = new System.Drawing.Point(30, 38);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(76, 25);
            this.group.TabIndex = 9;
            this.group.Text = "Группа";
            // 
            // discipline
            // 
            this.discipline.AutoSize = true;
            this.discipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discipline.Location = new System.Drawing.Point(30, 83);
            this.discipline.Name = "discipline";
            this.discipline.Size = new System.Drawing.Size(128, 25);
            this.discipline.TabIndex = 10;
            this.discipline.Text = "Дисциплина";
            // 
            // labelGroupName
            // 
            this.labelGroupName.AutoSize = true;
            this.labelGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroupName.Location = new System.Drawing.Point(165, 38);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(114, 25);
            this.labelGroupName.TabIndex = 11;
            this.labelGroupName.Text = "groupName";
            // 
            // labelDisciplineName
            // 
            this.labelDisciplineName.AutoSize = true;
            this.labelDisciplineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisciplineName.Location = new System.Drawing.Point(164, 83);
            this.labelDisciplineName.Name = "labelDisciplineName";
            this.labelDisciplineName.Size = new System.Drawing.Size(144, 25);
            this.labelDisciplineName.TabIndex = 12;
            this.labelDisciplineName.Text = "disciplineName";
            // 
            // labelScorePerLesson
            // 
            this.labelScorePerLesson.AutoSize = true;
            this.labelScorePerLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScorePerLesson.Location = new System.Drawing.Point(30, 126);
            this.labelScorePerLesson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScorePerLesson.Name = "labelScorePerLesson";
            this.labelScorePerLesson.Size = new System.Drawing.Size(193, 25);
            this.labelScorePerLesson.TabIndex = 15;
            this.labelScorePerLesson.Text = "Балл за посещение";
            // 
            // scoresPerLesson
            // 
            this.scoresPerLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoresPerLesson.Location = new System.Drawing.Point(233, 121);
            this.scoresPerLesson.Margin = new System.Windows.Forms.Padding(4);
            this.scoresPerLesson.Name = "scoresPerLesson";
            this.scoresPerLesson.Size = new System.Drawing.Size(75, 30);
            this.scoresPerLesson.TabIndex = 16;
            this.scoresPerLesson.Text = "0";
            // 
            // labelGroupID
            // 
            this.labelGroupID.AutoSize = true;
            this.labelGroupID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelGroupID.Location = new System.Drawing.Point(1184, 9);
            this.labelGroupID.Name = "labelGroupID";
            this.labelGroupID.Size = new System.Drawing.Size(19, 17);
            this.labelGroupID.TabIndex = 19;
            this.labelGroupID.Text = "id";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(992, 9);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(19, 17);
            this.labelUserID.TabIndex = 20;
            this.labelUserID.Text = "id";
            // 
            // menuJournalTools
            // 
            this.menuJournalTools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuJournalTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.journalToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuJournalTools.Location = new System.Drawing.Point(0, 0);
            this.menuJournalTools.Name = "menuJournalTools";
            this.menuJournalTools.Size = new System.Drawing.Size(1446, 28);
            this.menuJournalTools.TabIndex = 21;
            this.menuJournalTools.Text = "menuStrip1";
            // 
            // journalToolStripMenuItem
            // 
            this.journalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem});
            this.journalToolStripMenuItem.Name = "journalToolStripMenuItem";
            this.journalToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.journalToolStripMenuItem.Text = "Журнал";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
            this.saveToolStripMenuItem1.Text = "Сохранить";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.saveAsToolStripMenuItem.Text = "Сохранить как...";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addColumnToolStripMenuItem,
            this.summationToolsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.toolsToolStripMenuItem.Text = "Инструменты";
            // 
            // addColumnToolStripMenuItem
            // 
            this.addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            this.addColumnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addColumnToolStripMenuItem.Text = "Добавить колонку";
            this.addColumnToolStripMenuItem.Click += new System.EventHandler(this.addColumnToolStripMenuItem_Click);
            // 
            // summationToolsToolStripMenuItem
            // 
            this.summationToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summationDateToolStripMenuItem,
            this.summationAllToolStripMenuItem});
            this.summationToolsToolStripMenuItem.Name = "summationToolsToolStripMenuItem";
            this.summationToolsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.summationToolsToolStripMenuItem.Text = "Суммировать";
            // 
            // summationDateToolStripMenuItem
            // 
            this.summationDateToolStripMenuItem.Name = "summationDateToolStripMenuItem";
            this.summationDateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.summationDateToolStripMenuItem.Text = "По дате";
            this.summationDateToolStripMenuItem.Click += new System.EventHandler(this.GetSummationFormToolStripMenuItem_Click);
            // 
            // summationAllToolStripMenuItem
            // 
            this.summationAllToolStripMenuItem.Name = "summationAllToolStripMenuItem";
            this.summationAllToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.summationAllToolStripMenuItem.Text = "Текущий балл";
            this.summationAllToolStripMenuItem.Click += new System.EventHandler(this.SummationAllToolStripMenuItem_Click);
            // 
            // labelDatesSummation
            // 
            this.labelDatesSummation.AutoSize = true;
            this.labelDatesSummation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDatesSummation.Location = new System.Drawing.Point(635, 83);
            this.labelDatesSummation.Name = "labelDatesSummation";
            this.labelDatesSummation.Size = new System.Drawing.Size(248, 25);
            this.labelDatesSummation.TabIndex = 22;
            this.labelDatesSummation.Text = " диапазон суммирования";
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 800);
            this.Controls.Add(this.labelDatesSummation);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.labelGroupID);
            this.Controls.Add(this.scoresPerLesson);
            this.Controls.Add(this.labelScorePerLesson);
            this.Controls.Add(this.labelDisciplineName);
            this.Controls.Add(this.labelGroupName);
            this.Controls.Add(this.discipline);
            this.Controls.Add(this.group);
            this.Controls.Add(this.tableLessonDate);
            this.Controls.Add(this.tableLessonType);
            this.Controls.Add(this.tableStudent);
            this.Controls.Add(this.menuJournalTools);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JournalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный журнал";
            ((System.ComponentModel.ISupportInitialize)(this.tableStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLessonType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLessonDate)).EndInit();
            this.menuJournalTools.ResumeLayout(false);
            this.menuJournalTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tableStudent;
        private System.Windows.Forms.DataGridView tableLessonType;
        private System.Windows.Forms.DataGridView tableLessonDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn nullColumns;
        private System.Windows.Forms.Label group;
        private System.Windows.Forms.Label discipline;
        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.Label labelDisciplineName;
        private System.Windows.Forms.Label labelScorePerLesson;
        private System.Windows.Forms.TextBox scoresPerLesson;
        private System.Windows.Forms.Label labelGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn students;
        private System.Windows.Forms.MenuStrip menuJournalTools;
        private System.Windows.Forms.ToolStripMenuItem journalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summationToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summationDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summationAllToolStripMenuItem;
        private System.Windows.Forms.Label labelDatesSummation;
    }
}

