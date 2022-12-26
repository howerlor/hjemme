using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsHjemme
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            //String loginUser = login.Text;
            //String passUser = password.Text;
            //Class1 db = new Class1();
            //DataTable table = new DataTable();
            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            //MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`= @uL AND `password`= @uP", db.getConnection());
            //command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            //command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            //adapter.SelectCommand = command;
            //adapter.Fill(table);
            //if (table.Rows.Count > 0)
            //{
            //    ////Form4 enter = new Form4();
            //    ////enter.Show();
            //    ////this.Hide();
            //    //var mainManu = new Form4();
            //    //mainManu.Show();
            //    //Hide();
            //    MessageBox.Show("yes");
            //}
            //else
            //{
            //    MessageBox.Show("Нет такого логина или пароля");
            //}
            Form4 enter = new Form4();
            enter.Show();
            this.Hide();

        }
    }
}
