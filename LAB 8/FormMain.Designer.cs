namespace LAB_8
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewLecturers = new System.Windows.Forms.DataGridView();
            this.buttonLecturerSelect = new System.Windows.Forms.Button();
            this.comboBoxLecturerCity = new System.Windows.Forms.ComboBox();
            this.labelLecturer = new System.Windows.Forms.Label();
            this.groupBoxStudentInfo = new System.Windows.Forms.GroupBox();
            this.labelStudentUniversity = new System.Windows.Forms.Label();
            this.labelStudentHome = new System.Windows.Forms.Label();
            this.labelStudentCourse = new System.Windows.Forms.Label();
            this.labelStudentBirthday = new System.Windows.Forms.Label();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.labelStudent = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.buttonStudentSelect = new System.Windows.Forms.Button();
            this.comboBoxAddUniversity = new System.Windows.Forms.ComboBox();
            this.numericUpDownAddCourse = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerAddBirthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).BeginInit();
            this.groupBoxStudentInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewLecturers);
            this.groupBox1.Controls.Add(this.buttonLecturerSelect);
            this.groupBox1.Controls.Add(this.comboBoxLecturerCity);
            this.groupBox1.Controls.Add(this.labelLecturer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 437);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBoxLectures";
            // 
            // dataGridViewLecturers
            // 
            this.dataGridViewLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLecturers.Location = new System.Drawing.Point(10, 106);
            this.dataGridViewLecturers.Name = "dataGridViewLecturers";
            this.dataGridViewLecturers.Size = new System.Drawing.Size(193, 321);
            this.dataGridViewLecturers.TabIndex = 7;
            // 
            // buttonLecturerSelect
            // 
            this.buttonLecturerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLecturerSelect.Location = new System.Drawing.Point(10, 71);
            this.buttonLecturerSelect.Name = "buttonLecturerSelect";
            this.buttonLecturerSelect.Size = new System.Drawing.Size(91, 29);
            this.buttonLecturerSelect.TabIndex = 6;
            this.buttonLecturerSelect.Text = "Выбрать";
            this.buttonLecturerSelect.UseVisualStyleBackColor = true;
            // 
            // comboBoxLecturerCity
            // 
            this.comboBoxLecturerCity.FormattingEnabled = true;
            this.comboBoxLecturerCity.Location = new System.Drawing.Point(10, 44);
            this.comboBoxLecturerCity.Name = "comboBoxLecturerCity";
            this.comboBoxLecturerCity.Size = new System.Drawing.Size(191, 21);
            this.comboBoxLecturerCity.TabIndex = 5;
            // 
            // labelLecturer
            // 
            this.labelLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLecturer.Location = new System.Drawing.Point(6, 16);
            this.labelLecturer.Name = "labelLecturer";
            this.labelLecturer.Size = new System.Drawing.Size(197, 25);
            this.labelLecturer.TabIndex = 4;
            this.labelLecturer.Text = "Преподаватели";
            // 
            // groupBoxStudentInfo
            // 
            this.groupBoxStudentInfo.Controls.Add(this.labelStudentUniversity);
            this.groupBoxStudentInfo.Controls.Add(this.labelStudentHome);
            this.groupBoxStudentInfo.Controls.Add(this.labelStudentCourse);
            this.groupBoxStudentInfo.Controls.Add(this.labelStudentBirthday);
            this.groupBoxStudentInfo.Controls.Add(this.comboBoxStudent);
            this.groupBoxStudentInfo.Controls.Add(this.labelStudent);
            this.groupBoxStudentInfo.Location = new System.Drawing.Point(230, 12);
            this.groupBoxStudentInfo.Name = "groupBoxStudentInfo";
            this.groupBoxStudentInfo.Size = new System.Drawing.Size(205, 437);
            this.groupBoxStudentInfo.TabIndex = 11;
            this.groupBoxStudentInfo.TabStop = false;
            this.groupBoxStudentInfo.Text = "groupBoxViewStudent";
            // 
            // labelStudentUniversity
            // 
            this.labelStudentUniversity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentUniversity.Location = new System.Drawing.Point(6, 143);
            this.labelStudentUniversity.Name = "labelStudentUniversity";
            this.labelStudentUniversity.Size = new System.Drawing.Size(191, 25);
            this.labelStudentUniversity.TabIndex = 15;
            this.labelStudentUniversity.Text = "Университет";
            // 
            // labelStudentHome
            // 
            this.labelStudentHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentHome.Location = new System.Drawing.Point(6, 118);
            this.labelStudentHome.Name = "labelStudentHome";
            this.labelStudentHome.Size = new System.Drawing.Size(191, 25);
            this.labelStudentHome.TabIndex = 14;
            this.labelStudentHome.Text = "Город";
            // 
            // labelStudentCourse
            // 
            this.labelStudentCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentCourse.Location = new System.Drawing.Point(6, 93);
            this.labelStudentCourse.Name = "labelStudentCourse";
            this.labelStudentCourse.Size = new System.Drawing.Size(191, 25);
            this.labelStudentCourse.TabIndex = 13;
            this.labelStudentCourse.Text = "Курс";
            // 
            // labelStudentBirthday
            // 
            this.labelStudentBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentBirthday.Location = new System.Drawing.Point(6, 68);
            this.labelStudentBirthday.Name = "labelStudentBirthday";
            this.labelStudentBirthday.Size = new System.Drawing.Size(191, 25);
            this.labelStudentBirthday.TabIndex = 12;
            this.labelStudentBirthday.Text = "Дата рождения";
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(6, 44);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(191, 21);
            this.comboBoxStudent.TabIndex = 11;
            // 
            // labelStudent
            // 
            this.labelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudent.Location = new System.Drawing.Point(6, 16);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(191, 25);
            this.labelStudent.TabIndex = 10;
            this.labelStudent.Text = "Студенты";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxAddName);
            this.groupBox2.Controls.Add(this.buttonStudentSelect);
            this.groupBox2.Controls.Add(this.comboBoxAddUniversity);
            this.groupBox2.Controls.Add(this.numericUpDownAddCourse);
            this.groupBox2.Controls.Add(this.dateTimePickerAddBirthday);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(441, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 437);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBoxAddStudent";
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(10, 44);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(292, 20);
            this.textBoxAddName.TabIndex = 20;
            // 
            // buttonStudentSelect
            // 
            this.buttonStudentSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudentSelect.Location = new System.Drawing.Point(10, 153);
            this.buttonStudentSelect.Name = "buttonStudentSelect";
            this.buttonStudentSelect.Size = new System.Drawing.Size(91, 29);
            this.buttonStudentSelect.TabIndex = 8;
            this.buttonStudentSelect.Text = "Выбрать";
            this.buttonStudentSelect.UseVisualStyleBackColor = true;
            // 
            // comboBoxAddUniversity
            // 
            this.comboBoxAddUniversity.FormattingEnabled = true;
            this.comboBoxAddUniversity.Location = new System.Drawing.Point(10, 126);
            this.comboBoxAddUniversity.Name = "comboBoxAddUniversity";
            this.comboBoxAddUniversity.Size = new System.Drawing.Size(292, 21);
            this.comboBoxAddUniversity.TabIndex = 19;
            // 
            // numericUpDownAddCourse
            // 
            this.numericUpDownAddCourse.Location = new System.Drawing.Point(10, 100);
            this.numericUpDownAddCourse.Name = "numericUpDownAddCourse";
            this.numericUpDownAddCourse.Size = new System.Drawing.Size(292, 20);
            this.numericUpDownAddCourse.TabIndex = 18;
            // 
            // dateTimePickerAddBirthday
            // 
            this.dateTimePickerAddBirthday.Location = new System.Drawing.Point(10, 74);
            this.dateTimePickerAddBirthday.Name = "dateTimePickerAddBirthday";
            this.dateTimePickerAddBirthday.Size = new System.Drawing.Size(292, 20);
            this.dateTimePickerAddBirthday.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(519, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Добавить студента";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxStudentInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).EndInit();
            this.groupBoxStudentInfo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewLecturers;
        private System.Windows.Forms.Button buttonLecturerSelect;
        private System.Windows.Forms.ComboBox comboBoxLecturerCity;
        private System.Windows.Forms.Label labelLecturer;
        private System.Windows.Forms.GroupBox groupBoxStudentInfo;
        private System.Windows.Forms.Label labelStudentUniversity;
        private System.Windows.Forms.Label labelStudentHome;
        private System.Windows.Forms.Label labelStudentCourse;
        private System.Windows.Forms.Label labelStudentBirthday;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddBirthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonStudentSelect;
        private System.Windows.Forms.ComboBox comboBoxAddUniversity;
        private System.Windows.Forms.NumericUpDown numericUpDownAddCourse;
        private System.Windows.Forms.TextBox textBoxAddName;
    }
}