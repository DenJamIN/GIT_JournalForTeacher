﻿namespace Journal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableStudent = new System.Windows.Forms.DataGridView();
            this.students = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCreateRows = new System.Windows.Forms.Button();
            this.tableLessonType = new System.Windows.Forms.DataGridView();
            this.nullColumns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLessonDate = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group = new System.Windows.Forms.Label();
            this.discipline = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.disciplineName = new System.Windows.Forms.Label();
            this.buttonForSummation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scoresPerLesson = new System.Windows.Forms.TextBox();
            this.buttonSafeChanges = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLessonType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLessonDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 800);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(167, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1273, 44);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 110);
            this.panel3.TabIndex = 3;
            // 
            // tableStudent
            // 
            this.tableStudent.AllowUserToResizeColumns = false;
            this.tableStudent.AllowUserToResizeRows = false;
            this.tableStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.students});
            this.tableStudent.Location = new System.Drawing.Point(167, 273);
            this.tableStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableStudent.Name = "tableStudent";
            this.tableStudent.RowHeadersWidth = 51;
            this.tableStudent.RowTemplate.Height = 24;
            this.tableStudent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tableStudent.Size = new System.Drawing.Size(264, 527);
            this.tableStudent.TabIndex = 2;
            // 
            // students
            // 
            this.students.HeaderText = "Список студентов";
            this.students.MinimumWidth = 6;
            this.students.Name = "students";
            this.students.Width = 125;
            // 
            // buttonCreateRows
            // 
            this.buttonCreateRows.BackColor = System.Drawing.Color.Orange;
            this.buttonCreateRows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateRows.Location = new System.Drawing.Point(428, 171);
            this.buttonCreateRows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateRows.Name = "buttonCreateRows";
            this.buttonCreateRows.Size = new System.Drawing.Size(171, 36);
            this.buttonCreateRows.TabIndex = 6;
            this.buttonCreateRows.Text = "Новый столбик";
            this.buttonCreateRows.UseVisualStyleBackColor = false;
            this.buttonCreateRows.Click += new System.EventHandler(this.buttonCreateRows_Click);
            // 
            // tableLessonType
            // 
            this.tableLessonType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLessonType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nullColumns});
            this.tableLessonType.Location = new System.Drawing.Point(167, 226);
            this.tableLessonType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLessonType.Name = "tableLessonType";
            this.tableLessonType.RowHeadersWidth = 51;
            this.tableLessonType.RowTemplate.Height = 24;
            this.tableLessonType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tableLessonType.Size = new System.Drawing.Size(264, 49);
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
            this.tableLessonDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLessonDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.tableLessonDate.Location = new System.Drawing.Point(167, 204);
            this.tableLessonDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLessonDate.Name = "tableLessonDate";
            this.tableLessonDate.RowHeadersWidth = 51;
            this.tableLessonDate.RowTemplate.Height = 24;
            this.tableLessonDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tableLessonDate.Size = new System.Drawing.Size(264, 49);
            this.tableLessonDate.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // group
            // 
            this.group.AutoSize = true;
            this.group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group.Location = new System.Drawing.Point(461, 63);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(76, 25);
            this.group.TabIndex = 9;
            this.group.Text = "Группа";
            // 
            // discipline
            // 
            this.discipline.AutoSize = true;
            this.discipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discipline.Location = new System.Drawing.Point(409, 106);
            this.discipline.Name = "discipline";
            this.discipline.Size = new System.Drawing.Size(128, 25);
            this.discipline.TabIndex = 10;
            this.discipline.Text = "Дисциплина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(564, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "groupName";
            // 
            // disciplineName
            // 
            this.disciplineName.AutoSize = true;
            this.disciplineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disciplineName.Location = new System.Drawing.Point(564, 106);
            this.disciplineName.Name = "disciplineName";
            this.disciplineName.Size = new System.Drawing.Size(144, 25);
            this.disciplineName.TabIndex = 12;
            this.disciplineName.Text = "disciplineName";
            // 
            // buttonForSummation
            // 
            this.buttonForSummation.BackColor = System.Drawing.Color.Gold;
            this.buttonForSummation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForSummation.Location = new System.Drawing.Point(592, 171);
            this.buttonForSummation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonForSummation.Name = "buttonForSummation";
            this.buttonForSummation.Size = new System.Drawing.Size(164, 36);
            this.buttonForSummation.TabIndex = 14;
            this.buttonForSummation.Text = "Суммировать";
            this.buttonForSummation.UseVisualStyleBackColor = false;
            this.buttonForSummation.Click += new System.EventHandler(this.buttonForSummation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(423, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Балл за посещение";
            // 
            // scoresPerLesson
            // 
            this.scoresPerLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoresPerLesson.Location = new System.Drawing.Point(641, 140);
            this.scoresPerLesson.Margin = new System.Windows.Forms.Padding(4);
            this.scoresPerLesson.Name = "scoresPerLesson";
            this.scoresPerLesson.Size = new System.Drawing.Size(75, 30);
            this.scoresPerLesson.TabIndex = 16;
            // 
            // buttonSafeChanges
            // 
            this.buttonSafeChanges.BackColor = System.Drawing.Color.Coral;
            this.buttonSafeChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSafeChanges.Location = new System.Drawing.Point(753, 171);
            this.buttonSafeChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSafeChanges.Name = "buttonSafeChanges";
            this.buttonSafeChanges.Size = new System.Drawing.Size(164, 36);
            this.buttonSafeChanges.TabIndex = 17;
            this.buttonSafeChanges.Text = "Сохранить";
            this.buttonSafeChanges.UseVisualStyleBackColor = false;
            this.buttonSafeChanges.Click += new System.EventHandler(this.buttonSafeChanges_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::JournalForStudents.Properties.Resources.Значок_Кгу;
            this.pictureBox3.Location = new System.Drawing.Point(167, 81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(236, 194);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonSafeChanges);
            this.Controls.Add(this.scoresPerLesson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonForSummation);
            this.Controls.Add(this.disciplineName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.discipline);
            this.Controls.Add(this.group);
            this.Controls.Add(this.tableLessonDate);
            this.Controls.Add(this.tableLessonType);
            this.Controls.Add(this.buttonCreateRows);
            this.Controls.Add(this.tableStudent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JournalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLessonType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLessonDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tableStudent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonCreateRows;
        private System.Windows.Forms.DataGridView tableLessonType;
        private System.Windows.Forms.DataGridViewTextBoxColumn students;
        private System.Windows.Forms.DataGridView tableLessonDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn nullColumns;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label group;
        private System.Windows.Forms.Label discipline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label disciplineName;
        private System.Windows.Forms.Button buttonForSummation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox scoresPerLesson;
        private System.Windows.Forms.Button buttonSafeChanges;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
