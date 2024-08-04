using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRMEISB\SQLEXPRESS;Initial Catalog=DbBankTest;Integrated Security=True");
        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Select * From TBLPEOPLE where ACCOUNTNO=@p1 and PASSWORD=@p2", conn);
            command.Parameters.AddWithValue("@p1", mskAccountNu.Text);
            command.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr=command.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm2 = new Form2();
                frm2.account=mskAccountNu.Text;
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Failure Account Number or Password");
            }
        }
    }
}
