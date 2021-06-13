using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormEdit : Form
    {
        string connectionString = "Server=localhost;Port=5432;User Id=sqladmin;Password=sqladmin;Database=";
        string dbName = "";
        DataSet ds1, ds2;
        NpgsqlDataAdapter adapter1, adapter2;

        public FormEdit(string db)
        {
            InitializeComponent();
            connectionString += db + ";";
            dbName = db;
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("", conn);
            }

            gvCity.AllowUserToAddRows = false;
            gvCountry.AllowUserToAddRows = false;

            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                con.Open();
                adapter1 = new NpgsqlDataAdapter("select * from get_table_city()", con);
                adapter2 = new NpgsqlDataAdapter("select * from get_table_country()", con);

                ds1 = new DataSet();
                adapter1.Fill(ds1);
                gvCity.DataSource = ds1.Tables[0];
                ds2 = new DataSet();
                adapter2.Fill(ds2);
                gvCountry.DataSource = ds2.Tables[0];
            }
        }

        // Поиск города
        private void btnSearchCity_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                con.Open();
                adapter1 = new NpgsqlDataAdapter("select * from search_table_city('" + txtCity.Text + "')", con);

                ds1 = new DataSet();
                adapter1.Fill(ds1);
                gvCity.DataSource = ds1.Tables[0];
            }
        }

        // Поиск страны
        private void btnSearchCountry_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                con.Open();
                adapter2 = new NpgsqlDataAdapter("select * from search_table_country('" + txtCountry.Text + "')", con);

                ds2 = new DataSet();
                adapter2.Fill(ds2);
                gvCountry.DataSource = ds2.Tables[0];
            }
        }

        // Добавить город
        private void btnAddCity_Click(object sender, EventArgs e)
        {
            string c;
            if (textBox3.Text == "да") c = "true";
            else c = "false";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("call insert_into_city('" + textBox1.Text + "', " + textBox2.Text + ", " + c + ");", conn);
                    cmd.ExecuteNonQuery();
                }
                ShowCity();
                ShowCountry();
            }
            catch (Exception) { MessageBox.Show("Такой город уже существует!"); }
        }

        // Добавить страну
        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("call insert_into_country('" + textBox4.Text + "', 0);", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception) { MessageBox.Show("Такая страна уже существует!"); }
            ShowCountry();
        }

        // Удалить город
        private void btnDeleteCity_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("call delete_from_city('" + txtCity.Text + "')", conn);
                cmd.ExecuteNonQuery();
            }
            ShowCity();
            ShowCountry();
        }

        // Удалить страну
        private void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("call delete_from_country('" + txtCountry.Text + "')", conn);
                cmd.ExecuteNonQuery();
            }
            ShowCountry();
            ShowCity();
        }

        // Показать все города
        protected void ShowCity()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                con.Open();
                adapter1 = new NpgsqlDataAdapter("select * from get_table_city()", con);

                ds1 = new DataSet();
                adapter1.Fill(ds1);
                gvCity.DataSource = ds1.Tables[0];
            }
        }

        // Показать все города
        protected void ShowCountry()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                con.Open();
                adapter2 = new NpgsqlDataAdapter("select * from get_table_country()", con);

                ds2 = new DataSet();
                adapter2.Fill(ds2);
                gvCountry.DataSource = ds2.Tables[0];
            }
        }

        // Очистить таблицу
        private void btnClearCity_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("call clear_table_city();", conn);
                cmd.ExecuteNonQuery();
            }
            ShowCity();
            ShowCountry();
        }

        private void btnShowCity_Click(object sender, EventArgs e)
        {
            ShowCity();
        }

        private void btnShowCountry_Click(object sender, EventArgs e)
        {
            ShowCountry();
        }

        // Очистить таблицы
        private void btnClearTables_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("call clear_tables();", conn);
                cmd.ExecuteNonQuery();
            }
            ShowCity();
            ShowCountry();
        }

        // Удалить базу данных
        private void btnDropDB_Click(object sender, EventArgs e)
        {
            this.Close();
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=admin;"))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT	pg_terminate_backend (pid) FROM   pg_stat_activity " +
                "WHERE   pg_stat_activity.datname = '" + dbName + "'; drop database " + dbName, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
