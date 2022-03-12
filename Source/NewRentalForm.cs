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
    public partial class NewRentalForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PL7MP9D\SQLEXPRESS;Initial Catalog=Centru de Inchirieri Biciclete;User ID=sa;Password=ED308");
        
        public NewRentalForm()
        {
            InitializeComponent();
            displayData();

            //Nr biciclete disponibile
            string query = "select count(BicicletaID) from Biciclete B inner join StariBiciclete S on S.StareID = B.StareID where S.Descriere = 'disponibila' ";
            SqlDataAdapter data = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            data.Fill(table);

            availableTextBox.Text = table.Rows[0][0].ToString();

            //Nr biciclete inchiriate
            query = "select count(BicicletaID) from Biciclete B inner join StariBiciclete S on S.StareID = B.StareID where S.Descriere = 'inchiriata' ";
            data = new SqlDataAdapter(query, connection);
            table = new DataTable();
            data.Fill(table);

            rentedTextBox.Text = table.Rows[0][0].ToString();
        }

        public string comboBoxSelection;
        public string clientID;
        public string bycicleID;
        public string serviceID;
        public string employeeID;
        public string sum;
        public string time;
        public string finish;

        private void clientContactComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxSelection = clientContactComboBox.Text;


        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            MenuForm objForm1 = new MenuForm();
            this.Hide();
            objForm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            //gasire ClientID
            string query = "Select ClientID from Clienti where ["+ clientContactComboBox.Text.Trim() + "]= '" + identificationTextBox.Text.Trim() + "'";
            SqlDataAdapter data = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            data.Fill(table);

            if (table.Rows.Count == 1)
                clientID = table.Rows[0][0].ToString();

            //gasire ServiciuId
            query = "Select top 1 ServiciuID from Servicii where Tip = '" + serviceComboBox.Text + "'";
            SqlDataAdapter data2 = new SqlDataAdapter(query, connection);
            DataTable table2 = new DataTable();
            data2.Fill(table2);

            if (table2.Rows.Count == 1)
                serviceID = table2.Rows[0][0].ToString();


            //gasire SumaPlatita
            query = "Select top 1 Tarif from Servicii where Tip = '" + serviceComboBox.Text + "'";
            SqlDataAdapter data3 = new SqlDataAdapter(query, connection);
            DataTable table3 = new DataTable();
            data3.Fill(table3);

            if (table3.Rows.Count == 1)
                sum = table3.Rows[0][0].ToString();

            //gasire BicicletaID
            query = "Select top 1 BicicletaID from Biciclete B inner join StariBiciclete S on B.StareID = S.StareID where S.Descriere = 'Disponibila'";
            SqlDataAdapter data4 = new SqlDataAdapter(query, connection);
            DataTable table4 = new DataTable();
            data4.Fill(table4);

            if (table4.Rows.Count == 1)
                bycicleID = table4.Rows[0][0].ToString();


            //gasire AngajatID
            query = "Select AngajatID from Login where AngajatID = 1";
            data = new SqlDataAdapter(query, connection);
            table = new DataTable();
            data.Fill(table);

            if (table.Rows.Count == 1)
                employeeID = table.Rows[0][0].ToString();

            if (discountComboBox.Text != null)
            {
                string discount = discountComboBox.Text;
            }

            //gasire durata inchiriere din Valabilitate Servicii
            query = "Select top 1 Valabilitate from Servicii where Tip = '" + serviceComboBox.Text + "'";
            data = new SqlDataAdapter(query, connection);
            table = new DataTable();
            data.Fill(table);


            if (table.Rows.Count == 1)
                 time = table.Rows[0][0].ToString();


            query = "select DATEADD(hour," + time.ToString() + ", GETDATE())";
            data = new SqlDataAdapter(query, connection);
            table = new DataTable();
            data.Fill(table);

            if(table.Rows.Count == 1)
                 finish = table.Rows[0][0].ToString();

            query = "insert into Inchirieri values(" + bycicleID.ToString() + ", " + clientID.ToString() + " , " + serviceID.ToString() + " , " + employeeID.ToString() + ", GETDATE(), '" + finish.ToString() + "', '" + discountComboBox.Text.Trim() + "', " + sum.ToString() + " )";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Date salvate cu succes");

            //query = "update Biciclete set Nume = '" + lastNameTextBox.Text + "', Prenume = '" + firstNameTextBox.Text + "', [E - mail] = '" + emailTextBox.Text + "', Telefon = '" + telephoneTextBox.Text + "', CNP = " + CNPTextBox.Text + ", SerieBuletin = '" + seriesTextBox.Text + "', NumarBuletin = " + numberCITextBox.Text + ", Oras = '" + cityTextBox.Text + "', Judet = '" + countyTextBox.Text + "' where " + selectionComboBox.Text + " = "  + "'" + infoTextBox.Text + "' ";
            //command = new SqlCommand(query, connection);
            //command.ExecuteNonQuery();

            displayData();

            //Nr biciclete disponibile
            query = "select count(BicicletaID) from Biciclete B inner join StariBiciclete S on S.StareID = B.StareID where S.Descriere = 'disponibila' ";
            data = new SqlDataAdapter(query, connection);
            table = new DataTable();
            data.Fill(table);

            availableTextBox.Text = table.Rows[0][0].ToString();

            int nr = Convert.ToInt32(availableTextBox.Text) - 1;

            availableTextBox.Text = nr.ToString();

            //Nr biciclete inchiriate
            query = "select count(BicicletaID) from Biciclete B inner join StariBiciclete S on S.StareID = B.StareID where S.Descriere = 'inchiriata' ";
            data = new SqlDataAdapter(query, connection);
            table = new DataTable();
            data.Fill(table);

            rentedTextBox.Text = table.Rows[0][0].ToString();

            nr = Convert.ToInt32(rentedTextBox.Text) + 1;

            rentedTextBox.Text = nr.ToString();

            if (connection.State == ConnectionState.Open)
                connection.Close();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            MenuForm objForm1 = new MenuForm();
            this.Hide();
            objForm1.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
           
        }

        public void displayData()
        {
            string query = "select * from Inchirieri";
            SqlDataAdapter data = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bycicleID = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //clientID = "' , '" + serviceID + "' , '" + employeeID + "' , '" + DateTime.Now.ToString() + "', '" + DateTime.Now.ToString() + "', '" + discountComboBox.Text + "', " + sum
        }
    }
}
