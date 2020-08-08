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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableStudent = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCreateRows = new System.Windows.Forms.Button();
            this.tableLessonType = new System.Windows.Forms.DataGridView();
            this.students = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLessonDate = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nullColumns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLessonType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLessonDate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 800);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(167, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1273, 57);
            this.panel2.TabIndex = 1;
            // 
            // tableStudent
            // 
            this.tableStudent.AllowUserToResizeColumns = false;
            this.tableStudent.AllowUserToResizeRows = false;
            this.tableStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.students});
            this.tableStudent.Location = new System.Drawing.Point(167, 270);
            this.tableStudent.Name = "tableStudent";
            this.tableStudent.RowHeadersWidth = 51;
            this.tableStudent.RowTemplate.Height = 24;
            this.tableStudent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tableStudent.Size = new System.Drawing.Size(264, 530);
            this.tableStudent.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(167, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 109);
            this.panel3.TabIndex = 3;
            // 
            // buttonCreateRows
            // 
            this.buttonCreateRows.BackColor = System.Drawing.Color.Orange;
            this.buttonCreateRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateRows.Location = new System.Drawing.Point(809, 80);
            this.buttonCreateRows.Name = "buttonCreateRows";
            this.buttonCreateRows.Size = new System.Drawing.Size(566, 59);
            this.buttonCreateRows.TabIndex = 6;
            this.buttonCreateRows.Text = "ёкарный бабай жми";
            this.buttonCreateRows.UseVisualStyleBackColor = false;
            this.buttonCreateRows.Click += new System.EventHandler(this.buttonCreateRows_Click);
            // 
            // tableLessonType
            // 
            this.tableLessonType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLessonType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nullColumns});
            this.tableLessonType.Location = new System.Drawing.Point(167, 224);
            this.tableLessonType.Name = "tableLessonType";
            this.tableLessonType.RowHeadersWidth = 51;
            this.tableLessonType.RowTemplate.Height = 24;
            this.tableLessonType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tableLessonType.Size = new System.Drawing.Size(264, 49);
            this.tableLessonType.TabIndex = 7;
            // 
            // students
            // 
            this.students.HeaderText = "Список студентов";
            this.students.MinimumWidth = 6;
            this.students.Name = "students";
            this.students.Width = 125;
            // 
            // tableLessonDate
            // 
            this.tableLessonDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLessonDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.tableLessonDate.Location = new System.Drawing.Point(167, 199);
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
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // nullColumns
            // 
            this.nullColumns.HeaderText = "";
            this.nullColumns.MinimumWidth = 6;
            this.nullColumns.Name = "nullColumns";
            this.nullColumns.Width = 125;
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.Controls.Add(this.tableLessonDate);
            this.Controls.Add(this.tableLessonType);
            this.Controls.Add(this.buttonCreateRows);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableStudent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JournalForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tableStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLessonType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLessonDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tableStudent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonCreateRows;
        private System.Windows.Forms.DataGridView tableLessonType;
        private System.Windows.Forms.DataGridViewTextBoxColumn students;
        private System.Windows.Forms.DataGridViewTextBoxColumn nullColumns;
        private System.Windows.Forms.DataGridView tableLessonDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

