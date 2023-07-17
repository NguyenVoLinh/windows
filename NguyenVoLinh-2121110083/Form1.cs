using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenVoLinh_2121110083
{
    public partial class Form1 : Form

    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            //MessageBox.Show("username:" + username + "\n password:" + password);

            //Form2 trang2 = new Form2();
            //trang2.ShowDialog();

            string gender = radioMale.Checked ? "Nam" : "Nu";
            DateTime selectedDate = dateTimePicker1.Value;
            int day = selectedDate.Day;
            int month = selectedDate.Month;
            int year = selectedDate.Year;
            string birth = day + "/" + month + "/" + year;


            form2.DisplayUsernameAndPassword(username, password, birth, gender);
            form2.Show();
        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
