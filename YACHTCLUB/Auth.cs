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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Registration Registration = new Registration();
            Registration.Show();
            this.Hide();
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
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=sqlstud; Initial Catalog=16is19; Persist Security Info=True; User ID=16is19; Password=16is19"); // DESKTOP-CI4PQEK
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Y.USERS] WHERE Login ='" + loginbox.Text.Trim() + "' and Password = '" + passbox.Text.Trim() + "'", con);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("Вы успешно зашли в систему. Для перехода на форму нажмите «OK»", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form f0 = new Administator();
                        f0.Show();
                    }
                   
                
                else
                {
                    MessageBox.Show("Неправильный логин или пароль, проверьте правильность введенных данных", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginbox.Text = "";
                    passbox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка выполнения операции", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
