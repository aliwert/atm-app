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
namespace atm_app
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRMEISB\\SQLEXPRESS;Initial Catalog=DbBankTest;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("NAME, SURNAME, TC, PHONE, ACCOUNTNO,PASSWORD) values(@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", mskTC.Text);
            cmd.Parameters.AddWithValue("@p4", mskPhone.Text);
            cmd.Parameters.AddWithValue("@p5", mskAccountNu.Text);
            cmd.Parameters.AddWithValue("@p6", txtPassword.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Your Details Have Been Saved", "Register");
        }

        private void btnAccountNu_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number = random.Next(100000, 1000000); // create account number from 100000 to 999999

        }
    }
}
