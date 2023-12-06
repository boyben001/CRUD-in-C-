using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        int i = 0;

        dbconnection dbconn = new dbconnection();
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbconn.dbconnect());
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if ((Stu_ID_txt.Text == string.Empty) || (Stu_Name_txt.Text == string.Empty) || (comboBox1.Text == string.Empty) || (stu_address_txt.Text == string.Empty) || (Stu_Phone_txt.Text == string.Empty) || (Birth.Text == string.Empty)){
                MessageBox.Show("Warning : Required Fill Filled ?", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO `crud`.`student`\r\n(`id`,\r\n`studentName`,\r\n`class`,\r\n`birth`,\r\n`address`,\r\n`phone`)\r\nVALUES\r\n(@id,@studentName,@class,@birth,@address,@phone);\r\n", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", Stu_ID_txt.Text);
                cmd.Parameters.AddWithValue("@studentName", Stu_Name_txt.Text);
                cmd.Parameters.AddWithValue("@class", comboBox1.Text);
                string date1 = dateTimePicker.Value.ToString("yyyy-MM-dd"); 
                cmd.Parameters.AddWithValue("@birth", date1);
                cmd.Parameters.AddWithValue("@address", stu_address_txt.Text);
                cmd.Parameters.AddWithValue("@phone", Stu_Phone_txt.Text);

                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Saved Success", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Saved Fail", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                conn.Close();
                LoadRecord();
                clear();
            }         
        }

        private void LoadRecord()
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT `student`.`id`,\r\n    `student`.`studentName`,\r\n    `student`.`class`,\r\n    `student`.`birth`,\r\n    `student`.`address`,\r\n    `student`.`phone`\r\nFROM `crud`.`student`;", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read()) {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, reader["id"].ToString(), reader["studentName"].ToString(), reader["class"].ToString(), reader["birth"].ToString(), reader["address"].ToString(), reader["phone"].ToString());
            }
            reader.Close();
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRecord();
        }

        public void clear()
        {
            Stu_ID_txt.Clear();
            Stu_Name_txt.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker.Value = DateTime.Now;
            stu_address_txt.Clear();
            Stu_Phone_txt.Clear();
        }

        private void updatabtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("UPDATE `crud`.`student` SET\r\n`studentName` = @studentName,\r\n`class` = @class,\r\n`birth` = @birth,\r\n`address` = @address,\r\n`phone` = @phone\r\nWHERE `id` = @id;", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@studentName", Stu_Name_txt.Text);
            cmd.Parameters.AddWithValue("@class", comboBox1.Text);
            string date1 = dateTimePicker.Value.ToString("yyyy-MM-dd");
            cmd.Parameters.AddWithValue("@birth", date1);
            cmd.Parameters.AddWithValue("@address", stu_address_txt.Text);
            cmd.Parameters.AddWithValue("@phone", Stu_Phone_txt.Text);
            cmd.Parameters.AddWithValue("@id", Stu_ID_txt.Text);

            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Update Success", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update Fail", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conn.Close();
            LoadRecord();
            clear();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("DELETE FROM `crud`.`student`\r\nWHERE `id`=@id;", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", Stu_ID_txt.Text);

            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Delete Success", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete Fail", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conn.Close();
            LoadRecord();
            clear();
        }

        private void Search_txt_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT `student`.`id`,\r\n    `student`.`studentName`,\r\n    `student`.`class`,\r\n    `student`.`birth`,\r\n    `student`.`address`,\r\n    `student`.`phone`\r\nFROM `crud`.`student` WHERE `student`.`id` like '%"+ Search_txt.Text + "%' or `student`.`studentName` like '%"+ Search_txt.Text + "%';", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, reader["id"].ToString(), reader["studentName"].ToString(), reader["class"].ToString(), reader["birth"].ToString(), reader["address"].ToString(), reader["phone"].ToString());
            }
            reader.Close();
            conn.Close();
        }
    }
}
