using Npgsql;
using System;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormStart : Form
    {
        string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=admin;";

        public FormStart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from pg_catalog.pg_database where datname = '" + textBox1.Text + "'", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    dr.Close();
                    cmd.Dispose();
                    NpgsqlCommand cmd2 = new NpgsqlCommand();
                    cmd2.CommandText = "DO $do$ BEGIN IF NOT EXISTS(SELECT * FROM pg_catalog.pg_user WHERE usename = 'sqladmin') THEN " +
                    "create USER sqladmin WITH ENCRYPTED PASSWORD 'sqladmin'; " +
                    "END IF; " +
                    "END $do$; ";
                    cmd2.Connection = conn;
                    cmd2.ExecuteNonQuery();
                    cmd2.CommandText = "create database " + textBox1.Text + " owner sqladmin";
                    cmd2.ExecuteNonQuery();

                    using (NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=sqladmin;Password='sqladmin';Database=" + textBox1.Text))
                    {
                        con.Open();
                        string command = File.ReadAllText("SQL.txt");
                        NpgsqlCommand cmd3 = new NpgsqlCommand(command, con);
                        cmd3.ExecuteNonQuery();
                    }
                }
                dr.Close();
            }
            // Открытие второй формы
            var formEdit = new FormEdit(textBox1.Text);
            formEdit.ShowDialog();
        }
    }
}
