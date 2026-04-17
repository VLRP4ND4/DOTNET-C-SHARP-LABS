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
            this.groupBoxAddStudent = new System.Windows.Forms.GroupBox();
            this.textBoxAddCity = new System.Windows.Forms.TextBox();
            this.textBoxAddStipend = new System.Windows.Forms.TextBox();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.textBoxAddSurname = new System.Windows.Forms.TextBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.comboBoxAddUniversity = new System.Windows.Forms.ComboBox();
            this.numericUpDownAddCourse = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerAddBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelAddStudent = new System.Windows.Forms.Label();
            this.buttonConnectDB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).BeginInit();
            this.groupBoxStudentInfo.SuspendLayout();
            this.groupBoxAddStudent.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(775, 437);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBoxLectures";
            // 
            // dataGridViewLecturers
            // 
            this.dataGridViewLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLecturers.Location = new System.Drawing.Point(10, 74);
            this.dataGridViewLecturers.Name = "dataGridViewLecturers";
            this.dataGridViewLecturers.Size = new System.Drawing.Size(759, 353);
            this.dataGridViewLecturers.TabIndex = 7;
            // 
            // buttonLecturerSelect
            // 
            this.buttonLecturerSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonLecturerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLecturerSelect.Location = new System.Drawing.Point(459, 39);
            this.buttonLecturerSelect.Name = "buttonLecturerSelect";
            this.buttonLecturerSelect.Size = new System.Drawing.Size(133, 29);
            this.buttonLecturerSelect.TabIndex = 6;
            this.buttonLecturerSelect.Text = "Выбрать";
            this.buttonLecturerSelect.UseVisualStyleBackColor = false;
            this.buttonLecturerSelect.Click += new System.EventHandler(this.buttonLecturerSelect_Click);
            // 
            // comboBoxLecturerCity
            // 
            this.comboBoxLecturerCity.FormattingEnabled = true;
            this.comboBoxLecturerCity.Location = new System.Drawing.Point(10, 44);
            this.comboBoxLecturerCity.Name = "comboBoxLecturerCity";
            this.comboBoxLecturerCity.Size = new System.Drawing.Size(443, 21);
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
            this.groupBoxStudentInfo.Location = new System.Drawing.Point(793, 12);
            this.groupBoxStudentInfo.Name = "groupBoxStudentInfo";
            this.groupBoxStudentInfo.Size = new System.Drawing.Size(320, 437);
            this.groupBoxStudentInfo.TabIndex = 11;
            this.groupBoxStudentInfo.TabStop = false;
            this.groupBoxStudentInfo.Text = "groupBoxViewStudent";
            // 
            // labelStudentUniversity
            // 
            this.labelStudentUniversity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentUniversity.Location = new System.Drawing.Point(6, 143);
            this.labelStudentUniversity.Name = "labelStudentUniversity";
            this.labelStudentUniversity.Size = new System.Drawing.Size(308, 25);
            this.labelStudentUniversity.TabIndex = 15;
            this.labelStudentUniversity.Text = "Университет";
            // 
            // labelStudentHome
            // 
            this.labelStudentHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentHome.Location = new System.Drawing.Point(6, 118);
            this.labelStudentHome.Name = "labelStudentHome";
            this.labelStudentHome.Size = new System.Drawing.Size(308, 25);
            this.labelStudentHome.TabIndex = 14;
            this.labelStudentHome.Text = "Город";
            // 
            // labelStudentCourse
            // 
            this.labelStudentCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentCourse.Location = new System.Drawing.Point(6, 93);
            this.labelStudentCourse.Name = "labelStudentCourse";
            this.labelStudentCourse.Size = new System.Drawing.Size(308, 25);
            this.labelStudentCourse.TabIndex = 13;
            this.labelStudentCourse.Text = "Курс";
            // 
            // labelStudentBirthday
            // 
            this.labelStudentBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentBirthday.Location = new System.Drawing.Point(6, 68);
            this.labelStudentBirthday.Name = "labelStudentBirthday";
            this.labelStudentBirthday.Size = new System.Drawing.Size(308, 25);
            this.labelStudentBirthday.TabIndex = 12;
            this.labelStudentBirthday.Text = "Дата рождения";
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(6, 44);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(308, 21);
            this.comboBoxStudent.TabIndex = 11;
            this.comboBoxStudent.Click += new System.EventHandler(this.comboBoxStudent_SelectedIndexChanged);
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
            // groupBoxAddStudent
            // 
            this.groupBoxAddStudent.Controls.Add(this.textBoxAddCity);
            this.groupBoxAddStudent.Controls.Add(this.textBoxAddStipend);
            this.groupBoxAddStudent.Controls.Add(this.textBoxAddName);
            this.groupBoxAddStudent.Controls.Add(this.textBoxAddSurname);
            this.groupBoxAddStudent.Controls.Add(this.buttonAddStudent);
            this.groupBoxAddStudent.Controls.Add(this.comboBoxAddUniversity);
            this.groupBoxAddStudent.Controls.Add(this.numericUpDownAddCourse);
            this.groupBoxAddStudent.Controls.Add(this.dateTimePickerAddBirthday);
            this.groupBoxAddStudent.Controls.Add(this.labelAddStudent);
            this.groupBoxAddStudent.Location = new System.Drawing.Point(1119, 12);
            this.groupBoxAddStudent.Name = "groupBoxAddStudent";
            this.groupBoxAddStudent.Size = new System.Drawing.Size(353, 394);
            this.groupBoxAddStudent.TabIndex = 16;
            this.groupBoxAddStudent.TabStop = false;
            this.groupBoxAddStudent.Text = "groupBoxAddStudent";
            //this.groupBoxAddStudent.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBoxAddCity
            // 
            this.textBoxAddCity.Location = new System.Drawing.Point(10, 97);
            this.textBoxAddCity.Name = "textBoxAddCity";
            this.textBoxAddCity.Size = new System.Drawing.Size(292, 20);
            this.textBoxAddCity.TabIndex = 24;
            this.textBoxAddCity.Text = "Город";
            //this.textBoxAddCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            // 
            // textBoxAddStipend
            // 
            this.textBoxAddStipend.Location = new System.Drawing.Point(10, 123);
            this.textBoxAddStipend.Name = "textBoxAddStipend";
            this.textBoxAddStipend.Size = new System.Drawing.Size(292, 20);
            this.textBoxAddStipend.TabIndex = 23;
            this.textBoxAddStipend.Text = "Стипендия";
            //this.textBoxAddStipend.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(10, 71);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(292, 20);
            this.textBoxAddName.TabIndex = 22;
            this.textBoxAddName.Text = "Имя";
            //this.textBoxAddName.TextChanged += new System.EventHandler(this.textBoxAddName_TextChanged);
            // 
            // textBoxAddSurname
            // 
            this.textBoxAddSurname.Location = new System.Drawing.Point(10, 45);
            this.textBoxAddSurname.Name = "textBoxAddSurname";
            this.textBoxAddSurname.Size = new System.Drawing.Size(292, 20);
            this.textBoxAddSurname.TabIndex = 21;
            this.textBoxAddSurname.Text = "Фамилия";
            //this.textBoxAddSurname.TextChanged += new System.EventHandler(this.textBoxAddSurname_TextChanged);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddStudent.Location = new System.Drawing.Point(10, 228);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(91, 26);
            this.buttonAddStudent.TabIndex = 8;
            this.buttonAddStudent.Text = "Добавить";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonStudentSelect_Click);
            // 
            // comboBoxAddUniversity
            // 
            this.comboBoxAddUniversity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddUniversity.FormattingEnabled = true;
            this.comboBoxAddUniversity.Location = new System.Drawing.Point(10, 201);
            this.comboBoxAddUniversity.Name = "comboBoxAddUniversity";
            this.comboBoxAddUniversity.Size = new System.Drawing.Size(292, 21);
            this.comboBoxAddUniversity.TabIndex = 19;
            //this.comboBoxAddUniversity.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddUniversity_SelectedIndexChanged);
            // 
            // numericUpDownAddCourse
            // 
            this.numericUpDownAddCourse.Location = new System.Drawing.Point(10, 175);
            this.numericUpDownAddCourse.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownAddCourse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAddCourse.Name = "numericUpDownAddCourse";
            this.numericUpDownAddCourse.Size = new System.Drawing.Size(292, 20);
            this.numericUpDownAddCourse.TabIndex = 18;
            this.numericUpDownAddCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //this.numericUpDownAddCourse.ValueChanged += new System.EventHandler(this.numericUpDownAddCourse_ValueChanged);
            // 
            // dateTimePickerAddBirthday
            // 
            this.dateTimePickerAddBirthday.Location = new System.Drawing.Point(10, 149);
            this.dateTimePickerAddBirthday.Name = "dateTimePickerAddBirthday";
            this.dateTimePickerAddBirthday.Size = new System.Drawing.Size(292, 20);
            this.dateTimePickerAddBirthday.TabIndex = 17;
            //this.dateTimePickerAddBirthday.ValueChanged += new System.EventHandler(this.dateTimePickerAddBirthday_ValueChanged);
            // 
            // labelAddStudent
            // 
            this.labelAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddStudent.Location = new System.Drawing.Point(6, 16);
            this.labelAddStudent.Name = "labelAddStudent";
            this.labelAddStudent.Size = new System.Drawing.Size(519, 25);
            this.labelAddStudent.TabIndex = 16;
            this.labelAddStudent.Text = "Добавить студента";
            // 
            // buttonConnectDB
            // 
            this.buttonConnectDB.BackColor = System.Drawing.Color.Yellow;
            this.buttonConnectDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnectDB.Location = new System.Drawing.Point(1279, 412);
            this.buttonConnectDB.Name = "buttonConnectDB";
            this.buttonConnectDB.Size = new System.Drawing.Size(193, 37);
            this.buttonConnectDB.TabIndex = 17;
            this.buttonConnectDB.Text = "Подключиться к DB";
            this.buttonConnectDB.UseVisualStyleBackColor = false;
            this.buttonConnectDB.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 461);
            this.Controls.Add(this.buttonConnectDB);
            this.Controls.Add(this.groupBoxAddStudent);
            this.Controls.Add(this.groupBoxStudentInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).EndInit();
            this.groupBoxStudentInfo.ResumeLayout(false);
            this.groupBoxAddStudent.ResumeLayout(false);
            this.groupBoxAddStudent.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxAddStudent;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddBirthday;
        private System.Windows.Forms.Label labelAddStudent;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.ComboBox comboBoxAddUniversity;
        private System.Windows.Forms.NumericUpDown numericUpDownAddCourse;
        private System.Windows.Forms.Button buttonConnectDB;
        private System.Windows.Forms.TextBox textBoxAddSurname;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.TextBox textBoxAddCity;
        private System.Windows.Forms.TextBox textBoxAddStipend;
    }
}