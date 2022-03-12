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
    public partial class RentalListForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PL7MP9D\SQLEXPRESS;Initial Catalog=Centru de Inchirieri Biciclete;User ID=sa;Password=ED308");

        public RentalListForm()
        {
            InitializeComponent();
        }

        string v;

        public RentalListForm(string value)
        {
            InitializeComponent();
            string query = "select I.Inceput, I.FinalizareStabilita, I.ActReducere, I.SumaPlatita from Inchirieri I inner join Clienti C on C.ClientID = I.ClientID where C.ClientID = " + value.ToString() + " ;";
            SqlDataAdapter data = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public string Value { get; set; }

        private void RentalListForm_Load(object sender, EventArgs e)
        {
            v = Value;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
