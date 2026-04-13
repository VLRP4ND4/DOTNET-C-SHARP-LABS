using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace LAB_8
{
    public partial class FormMain : Form
    {
        private string connStr = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=1;Database=University;";
        public FormMain()
        {
            InitializeComponent();
        }
        //private void FormMain_Load(object sender, EventArgs e)
        //{
        //    LoadCities();
        //    LoadStudents();
        //    LoadUniversities();
        //}

        //private void LoadCities()
        //{
        //    comboBoxLecturerCity.Items.Clear();

        //    string query = "SELECT DISTINCT city FROM lectures ORDER BY city";

        //    using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
        //    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
        //    {
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);

        //        foreach (DataRow row in dt.Rows)
        //            comboBoxLecturerCity.Items.Add(row["city"].ToString());
        //    }

        //    if (comboBoxLecturerCity.Items.Count > 0)
        //        comboBoxLecturerCity.SelectedIndex = 0;
        //}

        //private void buttonShowLectures_Click(object sender, EventArgs e)
        //{
        //    if (comboBoxLecturerCity.SelectedItem == null)
        //    {
        //        MessageBox.Show("Выберите город.");
        //        return;
        //    }

        //    string city = comboBoxLecturerCity.SelectedItem.ToString();

        //    string query = @"
        //    SELECT teacher_id, surname, name, city, univ_id
        //    FROM lectures
        //    WHERE city = @city
        //    ORDER BY surname";

        //    using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
        //    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
        //    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
        //    {
        //        cmd.Parameters.AddWithValue("@city", city);

        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);

        //        comboBoxLecturerCity.DataSource = dt;
        //    }
        //}

        //private void LoadStudents()
        //{
        //    string query = "SELECT student_id, surname FROM student ORDER BY surname";

        //    using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
        //    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
        //    {
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);

        //        comboBoxStudent.DataSource = dt;
        //        comboBoxStudent.DisplayMember = "surname";
        //        comboBoxStudent.ValueMember = "student_id";
        //    }
        //}

        //private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBoxStudent.SelectedValue == null)
        //        return;

        //    int studentId;
        //    if (!int.TryParse(comboBoxStudent.SelectedValue.ToString(), out studentId))
        //        return;

        //    string query = @"
        //    SELECT s.birthday, s.kurs, s.city, u.univ_name
        //    FROM student s
        //    JOIN university u ON s.univ_id = u.univ_id
        //    WHERE s.student_id = @id";

        //    using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
        //    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
        //    {
        //        cmd.Parameters.AddWithValue("@id", studentId);
        //        conn.Open();

        //        using (NpgsqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            if (reader.Read())
        //            {
        //                labelStudentBirthday.Text = Convert.ToDateTime(reader["birthday"]).ToShortDateString();
        //                labelStudentCourse.Text = reader["kurs"].ToString();
        //                labelStudentHome.Text = reader["city"].ToString();
        //                labelStudentUniversity.Text = reader["univ_name"].ToString();
        //            }
        //        }
        //    }
        //}
        //private void LoadUniversities()
        //{
        //    string query = "SELECT univ_id, univ_name FROM university ORDER BY univ_name";

        //    using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
        //    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
        //    {
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);

        //        comboBox.DataSource = dt;
        //        comboBoxUniversity.DisplayMember = "univ_name";
        //        comboBoxUniversity.ValueMember = "univ_id";
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

        //private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}
