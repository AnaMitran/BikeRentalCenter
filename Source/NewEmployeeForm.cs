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

namespace BikeRentalCompany
{
    public partial class NewEmployeeForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PL7MP9D\SQLEXPRESS;Initial Catalog=Centru de Inchirieri Biciclete;User ID=sa;Password=ED308");
        public NewEmployeeForm()
        {
            InitializeComponent();
            displayData();
        }

        

        private void exitButton_Click(object sender, EventArgs e)
        {
            MenuForm objForm1 = new MenuForm();
            this.Hide();
            objForm1.Show();
        }

        public void displayData()
        {
            string query = "select * from Angajati";
            SqlDataAdapter data = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
