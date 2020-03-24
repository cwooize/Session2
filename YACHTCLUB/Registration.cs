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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

                }
                else
                {
                    string path = @"Data Source=sqlstud; Initial Catalog=16is19; Persist Security Info=True; User ID=16is19; Password=16is19";
                    SqlConnection con;
                    SqlCommand cmd = new SqlCommand();
                    string query = "INSERT INTO [Y.USERS] ([Login],[Password],[E-Mail]) VALUES ('" + loginbox.Text + "','" + passbox.Text + "','" + emailbox.Text + "')";
                    con = new SqlConnection(path);
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Вы успешно зарегистрировались. Для перехода на форму авторизации нажмите «OK»", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Auth Auth = new Auth();
                    Auth.Show();
                    loginbox.Text = "";
                    passbox.Text = "";
                    emailbox.Text = "";
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
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth Auth = new Auth();
            Auth.Show();
        }
    }
}
