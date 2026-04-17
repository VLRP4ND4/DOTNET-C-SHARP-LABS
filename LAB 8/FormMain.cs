using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace LAB_8
{
    public partial class FormMain : Form
    {
        private string connStr =
            "Host=localhost;Port=5432;Username=postgres;Password=1;Database=University";

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetPlaceholder(textBoxAddName, "Имя");
            SetPlaceholder(textBoxAddSurname, "Фамилия");
            SetPlaceholder(textBoxAddCity, "Город");
            SetPlaceholder(textBoxAddStipend, "Стипендия");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Подключение к БД успешно!");

                    LoadCities();
                    LoadStudents();
                    LoadUniversities();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения:\n" + ex.Message);
                }
            }
        }

        private void LoadCities()
        {
            comboBoxLecturerCity.Items.Clear();

            string query = "SELECT DISTINCT city FROM lectures ORDER BY city";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                    comboBoxLecturerCity.Items.Add(row["city"].ToString());
            }

            if (comboBoxLecturerCity.Items.Count > 0)
                comboBoxLecturerCity.SelectedIndex = 0;
        }

        private void LoadStudents()
        {
            string query = "SELECT student_id, surname FROM student ORDER BY surname";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBoxStudent.DataSource = dt;
                comboBoxStudent.DisplayMember = "surname";
                comboBoxStudent.ValueMember = "student_id";
            }
        }

        private void LoadUniversities()
        {
            string query = "SELECT univ_id, univ_name FROM university ORDER BY univ_name";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBoxAddUniversity.DataSource = dt;
                comboBoxAddUniversity.DisplayMember = "univ_name";
                comboBoxAddUniversity.ValueMember = "univ_id";
            }
        }

        private void buttonLecturerSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxLecturerCity.SelectedItem == null)
            {
                MessageBox.Show("Выберите город.");
                return;
            }

            string city = comboBoxLecturerCity.SelectedItem.ToString();

            string query = @"
                SELECT lecturer_id, surname, name, city, univ_id
                FROM lectures
                WHERE city = @city
                ORDER BY surname";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@city", city);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewLecturers.DataSource = dt;
            }
        }

        private void comboBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStudent.SelectedValue == null)
                return;

            int studentId;
            if (!int.TryParse(comboBoxStudent.SelectedValue.ToString(), out studentId))
                return;

            string query = @"
                SELECT s.birthday, s.kurs, s.city, u.univ_name
                FROM student s
                JOIN university u ON s.univ_id = u.univ_id
                WHERE s.student_id = @id";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", studentId);
                conn.Open();

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        labelStudentBirthday.Text = "Дата рождения: " +
                            Convert.ToDateTime(reader["birthday"]).ToShortDateString();

                        labelStudentCourse.Text = "Курс: " +
                            reader["kurs"].ToString();

                        labelStudentHome.Text = "Город: " +
                            reader["city"].ToString();

                        labelStudentUniversity.Text = "Университет: " +
                            reader["univ_name"].ToString();
                    }
                }
            }
        }

        private void buttonStudentSelect_Click(object sender, EventArgs e)
        {
            if (textBoxAddName.Text.Trim() == "" || textBoxAddName.Text == "Имя" ||
                textBoxAddSurname.Text.Trim() == "" || textBoxAddSurname.Text == "Фамилия" ||
                textBoxAddCity.Text.Trim() == "" || textBoxAddCity.Text == "Город" ||
                textBoxAddStipend.Text.Trim() == "" || textBoxAddStipend.Text == "Стипендия")
            {
                MessageBox.Show("Заполните все поля студента.");
                return;
            }

            if (comboBoxAddUniversity.SelectedValue == null)
            {
                MessageBox.Show("Выберите университет.");
                return;
            }

            double stipend;
            if (!double.TryParse(textBoxAddStipend.Text.Trim(), out stipend))
            {
                MessageBox.Show("Стипендия должна быть числом.");
                return;
            }

            int kurs = (int)numericUpDownAddCourse.Value;
            long univId = Convert.ToInt64(comboBoxAddUniversity.SelectedValue);

            string query = @"
                INSERT INTO student
                (student_id, surname, name, stipend, kurs, city, birthday, univ_id)
                VALUES
                (@student_id, @surname, @name, @stipend, @kurs, @city, @birthday, @univ_id)";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@student_id", GetNextStudentId());
                cmd.Parameters.AddWithValue("@surname", textBoxAddSurname.Text.Trim());
                cmd.Parameters.AddWithValue("@name", textBoxAddName.Text.Trim());
                cmd.Parameters.AddWithValue("@stipend", stipend);
                cmd.Parameters.AddWithValue("@kurs", kurs);
                cmd.Parameters.AddWithValue("@city", textBoxAddCity.Text.Trim());
                cmd.Parameters.AddWithValue("@birthday", dateTimePickerAddBirthday.Value);
                cmd.Parameters.AddWithValue("@univ_id", univId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Студент добавлен.");

            LoadStudents();

            textBoxAddName.Clear();
            textBoxAddSurname.Clear();
            textBoxAddCity.Clear();
            textBoxAddStipend.Clear();
            numericUpDownAddCourse.Value = 1;
        }

        private int GetNextStudentId()
        {
            string query = "SELECT COALESCE(MAX(student_id), 0) + 1 FROM student";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        //private void groupBox2_Enter(object sender, EventArgs e)
        //{

        //}

        //private void groupBox3_Enter(object sender, EventArgs e)
        //{

        //}

        //private void textBoxAddName_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void comboBoxAddUniversity_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void numericUpDownAddCourse_ValueChanged(object sender, EventArgs e)
        //{

        //}

        //private void dateTimePickerAddBirthday_ValueChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBoxCity_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBoxAddSurname_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}