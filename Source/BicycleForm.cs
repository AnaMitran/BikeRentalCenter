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
    public partial class BicycleForm : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PL7MP9D\SQLEXPRESS;Initial Catalog=Centru de Inchirieri Biciclete;User ID=sa;Password=ED308");
        public BicycleForm()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {
            string query = "select * from Biciclete";
            SqlDataAdapter data = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void clearData()
        {
            stateComboBox.Text = "";
            categoryComboBox.Text = "";
            this.dateTimePicker1.Text = "";
        }

        public string categoryID;
        public string categoryName;
        public string stateID;
        public string stateName;

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            //gasire  CategorieID
            string query = "Select CategorieID from CategoriiBiciclete where Denumire = '" + categoryComboBox.Text.Trim() + "'";
            SqlDataAdapter data = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            data.Fill(table);

            if (table.Rows.Count == 1)
                categoryID = table.Rows[0][0].ToString();

            MessageBox.Show(categoryID);

            //gasire StareID
            query = "Select StareID from StariBiciclete where Descriere = '" + stateComboBox.Text.Trim() + "'";
            data = new SqlDataAdapter(query, connection);
            table = new DataTable();
            data.Fill(table);

            if (table.Rows.Count == 1)
                stateID = table.Rows[0][0].ToString();

            MessageBox.Show(stateID);

            query = "insert into Biciclete values(" + categoryID.ToString() + ", " + stateID.ToString() + " , '" + this.dateTimePicker1.Text + "', '" + this.dateTimePicker2.Text + "', '" + this.dateTimePicker3.Text + "', '" + this.dateTimePicker4.Text + "', '" + this.dateTimePicker5.Text + " ')";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Date salvate cu succes");

            clearData();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MenuForm objForm1 = new MenuForm();
            this.Hide();
            objForm1.Show();
        }

        public static string id = "";

        private void searchButton_Click(object sender, EventArgs e)
        {
            clearData();


            string query = "Select * from Biciclete where BicicletaID = '" + infoTextBox.Text.Trim() + "'";
            SqlDataAdapter data = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            data.Fill(table);

            //gasire  Denumire categorie bicicleta
            query = "Select Denumire from CategoriiBiciclete where CategorieID = " + table.Rows[0][1].ToString() + "";
            data = new SqlDataAdapter(query, connection);
            DataTable table1 = new DataTable();
            data.Fill(table1);

            if (table1.Rows.Count == 1)
                categoryName = table1.Rows[0][0].ToString();

            MessageBox.Show(categoryID);

            //gasire Descriere stare
            query = "Select Descriere from StariBiciclete where StareID = " + table.Rows[0][2].ToString() + "";
            data = new SqlDataAdapter(query, connection);
            table1 = new DataTable();
            data.Fill(table1);

            if (table1.Rows.Count == 1)
                stateName= table1.Rows[0][0].ToString();

            id = table.Rows[0][0].ToString();
            categoryComboBox.SelectedText = categoryName;
            stateComboBox.SelectedText = stateName;
            this.dateTimePicker1.Text = table.Rows[0][3].ToString();
            this.dateTimePicker2.Text = table.Rows[0][4].ToString();
            this.dateTimePicker3.Text = table.Rows[0][5].ToString();
            this.dateTimePicker4.Text = table.Rows[0][6].ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //clearData();
            connection.Open();

            //gasire  CategorieID
            string query = "Select CategorieID from CategoriiBiciclete where Denumire = '" + categoryComboBox.Text.Trim() + "'";
            SqlDataAdapter data = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            data.Fill(table);

            if (table.Rows.Count == 1)
                categoryID = table.Rows[0][0].ToString();

            MessageBox.Show(categoryID);

            //gasire StareID
            query = "Select StareID from StariBiciclete where Descriere = '" + stateComboBox.Text.Trim() + "'";
            data = new SqlDataAdapter(query, connection);
            table = new DataTable();
            data.Fill(table);

            if (table.Rows.Count == 1)
                stateID = table.Rows[0][0].ToString();

            query = "update Biciclete set CategorieID=" + categoryID.ToString() + ", StareID=" + stateID.ToString() + "";//"', UltimaRevizie='" + this.dateTimePicker1.Text + "', ExpirareRevizie= '" + this.dateTimePicker2.Text + "', RealizareAsigurare='" + this.dateTimePicker3.Text + "', ExpirareAsigurare='" + this.dateTimePicker4.Text + "', Achizitionare='" + this.dateTimePicker5.Text +  "')", connection);
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            MessageBox.Show("Date modificate cu succes");
            clearData();
            connection.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "delete Biciclete where BicicletaID= '" + infoTextBox.Text.Trim() + "'";
                SqlDataAdapter data = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                data.Fill(table);
            }
            catch{
                MessageBox.Show("Bicicleta nu poate fi stearsa! Se afla in uz");
            }
        }
    }
}
