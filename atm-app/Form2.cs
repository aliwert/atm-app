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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        public string account;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRMEISB\SQLEXPRESS;Initial Catalog=DbBankTest;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            lblAccountNu.Text = account;
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from TBLPEOPLE where ACCOUNTNO=@p1", conn);
            command.Parameters.AddWithValue("@p1", account);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblNameSurname.Text = dr[1]+ " " + dr[2];
                lblTC.Text = dr[3].ToString();
                lblPhone.Text = dr[4].ToString();
            }
            conn.Close();
        }
    }
}
