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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string connectString = "Data Source=sqlstud; Initial Catalog=16is19; Persist Security Info=True; User ID=16is19; Password=16is19"; // DESKTOP-CI4PQEK

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT * FROM [Y.CATALOG] ORDER BY CodeProduct";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void add_Click(object sender, EventArgs e)
        {
            string path = @"Data Source=sqlstud; Initial Catalog=16is19; Persist Security Info=True; User ID=16is19; Password=16is19";
            SqlConnection con;
            SqlCommand cmd = new SqlCommand();
            string query = "INSERT INTO [Y.CATALOG] ([CodeProduct],[Model],[Type],[Capacity],[GradeWood],[Color],[Mast],[Price]) VALUES ('" + cd.Text + "','" + md.Text + "','" + tp.Text + "','" + cp.Text + "','" + gw.Text + "','" + cl.Text + "','" + ms.Text + "','" + pr.Text + "')";
            con = new SqlConnection(path);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Новый продукт был успешно добавлен \nКод продукта: " + cd.Text + " \nМодель: " + md.Text + " \nТип: " + tp.Text + " \nВместимость: " + cp.Text + " \nДерево: " + gw.Text + " \nЦвет: " + cl.Text + " \nМачта: " + ms.Text + " \nЦена: " + pr.Text + "", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form f0 = new Orders();
            f0.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string path1 = @"Data Source=sqlstud; Initial Catalog=16is19; Persist Security Info=True; User ID=16is19; Password=16is19";
            SqlConnection con1;
            SqlCommand cmd1 = new SqlCommand();
            string query1 = "DELETE FROM [Y.CATALOG] WHERE CodeProduct = '" + cd.Text + "'";
            con1 = new SqlConnection(path1);
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = query1;
            cmd1.ExecuteNonQuery();
            con1.Close();
            MessageBox.Show("Продукт № " + cd.Text + " был успешно удален", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form f0 = new Orders();
            f0.Show();
        }
    }
}
