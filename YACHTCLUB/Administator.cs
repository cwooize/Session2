using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace YACHTCLUB
{
    public partial class Administator : Form
    {

        public Administator()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string connectString = "Data Source=sqlstud; Initial Catalog=16is19; Persist Security Info=True; User ID=16is19; Password=16is19"; // DESKTOP-CI4PQEK

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT * FROM [Y.USERS] ORDER BY Login";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (loginbox.Text == "")
            {
                MessageBox.Show("Поле «Логин» не заполнено, пожалуйста заполните данное поле", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginbox.Focus();
                return;
            }

            if (passbox.Text == "")
            {
                MessageBox.Show("Поле «Пароль» не заполнено, пожалуйста заполните данное поле", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passbox.Focus();
                return;
            }
            if (emailbox.Text == "")
            {
                MessageBox.Show("Поле «E-Mail» не заполнено, пожалуйста заполните данное поле", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passbox.Focus();
                return;
            }
            if (rolebox.Text == "")
            {
                MessageBox.Show("Поле «Роль» не заполнено, пожалуйста заполните данное поле", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passbox.Focus();
                return;
            }
            string connectionString = @"Data Source=sqlstud; Initial Catalog=16is19; Persist Security Info=True; User ID=16is19; Password=16is19"; // DESKTOP-CI4PQEK
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query1 = "SELECT * FROM dbo.[Y.USERS] Where Login = '" + loginbox.Text.Trim() + "'";
                SqlDataAdapter b = new SqlDataAdapter(query1, connection);
                DataTable table = new DataTable();
                b.Fill(table);
                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Данный логин уже используется, пожалуйста, введите другой логин", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginbox.Text = "";
                    passbox.Text = "";
                    emailbox.Text = "";
                    rolebox.Text = "";

                }
                else
                {
                    string path = @"Data Source=sqlstud; Initial Catalog=16is19; Persist Security Info=True; User ID=16is19; Password=16is19";
                    SqlConnection con;
                    SqlCommand cmd = new SqlCommand();
                    string query = "INSERT INTO [Y.USERS] ([Login],[Password],[E-Mail],[Role]) VALUES ('" + loginbox.Text + "','" + passbox.Text + "','" + emailbox.Text + "','" + rolebox.Text + "')";
                    con = new SqlConnection(path);
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Новый пользователь был успешно добавлен \nЛогин: " + loginbox.Text + " \nПароль: " + passbox.Text + " \nПочта: " + emailbox.Text + " \nРоль: " + rolebox.Text + "", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form f0 = new Administator();
                    f0.Show();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            Console.Read();

        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f0 = new Administator();
            f0.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string path1 = @"Data Source=sqlstud; Initial Catalog=16is19; Persist Security Info=True; User ID=16is19; Password=16is19";
            SqlConnection con1;
            SqlCommand cmd1 = new SqlCommand();
            string query1 = "DELETE FROM [Y.USERS] WHERE Login = '"+ logbox.Text +"'";
            con1 = new SqlConnection(path1);
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = query1;
            cmd1.ExecuteNonQuery();
            con1.Close();
            MessageBox.Show("Пользователь "+ logbox.Text +" был успешно удален", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form f0 = new Administator();
            f0.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(logobox.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Login"], ListSortDirection.Ascending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Login"], ListSortDirection.Descending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["EMail"], ListSortDirection.Ascending);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["EMail"], ListSortDirection.Descending);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path2 = @"Data Source=sqlstud; Initial Catalog=16is19; Persist Security Info=True; User ID=16is19; Password=16is19";
            SqlConnection con2;
            SqlCommand cmd2 = new SqlCommand();
            string query2 = "UPDATE [Y.USERS] SET " +
                "Password = '" + passbox.Text + "', " +
                "[E-Mail] = '" + emailbox.Text + "', " +
                "Role = '" + rolebox.Text + "', " +
                "WHERE Login = '" + loginbox.Text + "'";
            con2 = new SqlConnection(path2);
            con2.Open();
            cmd2.Connection = con2;
            cmd2.CommandText = query2;
            cmd2.ExecuteNonQuery();
            con2.Close();
            }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f0 = new Orders();
            f0.Show();
        }
    }
    
    }
