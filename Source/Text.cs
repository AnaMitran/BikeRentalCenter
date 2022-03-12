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
    public partial class Text : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PL7MP9D\SQLEXPRESS;Initial Catalog=Centru de Inchirieri Biciclete;User ID=sa;Password=ED308");
        public Text()
        {
            InitializeComponent();
            displayData();

        }


        public void displayData()
        {

            connection.Open();
            SqlDataAdapter data = new SqlDataAdapter("select * from Clienti", connection);
            DataTable table = new DataTable();
            data.Fill(table);

            connection.Close();
        }

        private void clientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.centru_de_Inchirieri_BicicleteDataSet);

        }

        private void Text_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'centru_de_Inchirieri_BicicleteDataSet.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.centru_de_Inchirieri_BicicleteDataSet.Clienti);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
}

