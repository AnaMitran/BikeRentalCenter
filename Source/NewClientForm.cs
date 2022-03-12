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
    public partial class NewClientForm : Form
    {
        public NewClientForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PL7MP9D\SQLEXPRESS;Initial Catalog=Centru de Inchirieri Biciclete;User ID=sa;Password=ED308");

        private void InsertButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            if(CNPTextBox.Text == "ab")
                errorProviderCNP.SetError(CNPTextBox, "Format CNP incorect");
            else
            {
                SqlCommand command = new SqlCommand("insert into Clienti values('" + lastNameTextBox.Text + "' , '" + firstNameTextBox.Text + "' , '" + emailTextBox.Text + "' , '" + telephoneTextBox.Text + "', '" + CNPTextBox.Text + "', '" + seriesTextBox.Text + "', '" + numberCITextBox.Text + "', '" + cityTextBox.Text + "', '" + countyTextBox.Text + "', GETDATE())", connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Date salvate cu succes");
                clearData();
            }
            connection.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MenuForm objForm1 = new MenuForm();
            this.Hide();
            objForm1.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update Clienti set Nume='" + lastNameTextBox.Text + "' , Prenume= '" + firstNameTextBox.Text + "' , [E-mail]='" + emailTextBox.Text + "' , Telefon='" + telephoneTextBox.Text + "', CNP=" + CNPTextBox.Text + ", SerieBuletin ='" + seriesTextBox.Text + "', NumarBuletin = " + numberCITextBox.Text + ", Oras='" + cityTextBox.Text + "', Judet='" + countyTextBox.Text + "' where " + selectionComboBox.Text + "="  + "'" + infoTextBox.Text + "' ", connection);
            //string query = "UPDATE Clienti SET Nume =@last_name, Prenume=@first_name, [E-mail]=@email, Telefon=@telephone, CNP=@cnp, SerieBuletin=@series, NumarBuletin=@numberCI, Oras=@city, Judet=@county WHERE " + selectionComboBox.Text + "=" + "'" + infoTextBox.Text + "' ";
           
            //SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@last_name", lastNameTextBox.Text);
            command.Parameters.AddWithValue("@first_name", firstNameTextBox.Text);
            command.Parameters.AddWithValue("@email", emailTextBox.Text);
            command.Parameters.AddWithValue("@telephone", telephoneTextBox.Text);
            command.Parameters.AddWithValue("@CNP", CNPTextBox.Text);
            command.Parameters.AddWithValue("@series", seriesTextBox.Text);
            command.Parameters.AddWithValue("@numberCI", numberCITextBox.Text);
            command.Parameters.AddWithValue("@city", cityTextBox.Text);
            command.Parameters.AddWithValue("@county", countyTextBox.Text);
            command.ExecuteNonQuery();
            
            MessageBox.Show("Date modificate cu succes");
            clearData();
            connection.Close();
        }

        private void selectionComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        public static string id = "";

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            string query = "Select * from Clienti where [" + selectionComboBox.Text.Trim() + "]= '" + infoTextBox.Text.Trim() + "'";
            SqlDataAdapter data = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            data.Fill(table);

            
            id = table.Rows[0][0].ToString();
            lastNameTextBox.Text = table.Rows[0][1].ToString();
            firstNameTextBox.Text = table.Rows[0][2].ToString();
            emailTextBox.Text = table.Rows[0][3].ToString();
            telephoneTextBox.Text = table.Rows[0][4].ToString();
            CNPTextBox.Text = table.Rows[0][5].ToString();
            seriesTextBox.Text = table.Rows[0][6].ToString();
            numberCITextBox.Text = table.Rows[0][7].ToString();
            cityTextBox.Text = table.Rows[0][8].ToString();
            countyTextBox.Text = table.Rows[0][9].ToString();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            //SqlCommand command = new SqlCommand("update Clienti set Nume='" + lastNameTextBox.Text + "' , Prenume= '" + firstNameTextBox.Text + "' , [E-mail]='" + emailTextBox.Text + "' , Telefon='" + telephoneTextBox.Text + "', CNP=" + CNPTextBox.Text + ", SerieBuletin ='" + seriesTextBox.Text + "', NumarBuletin = " + numberCITextBox.Text + ", Oras='" + cityTextBox.Text + "', Judet='" + countyTextBox.Text + "' where " + selectionComboBox.Text + "="  + "'" + infoTextBox.Text + "' ", connection);
            string query = "delete from Clienti WHERE " + selectionComboBox.Text + "=" + "'" + infoTextBox.Text + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Date sterse cu succes");
            clearData();
            connection.Close();
        }

        public void clearData()
        {
            lastNameTextBox.Text = "";
            firstNameTextBox.Text = "";
            emailTextBox.Text = "";
            telephoneTextBox.Text = "";
            CNPTextBox.Text = "";
            seriesTextBox.Text = "";
            numberCITextBox.Text = "";
            cityTextBox.Text = "";
            countyTextBox.Text = "";
        }

        

        private void listButton_Click(object sender, EventArgs e)
        { 
            RentalListForm objForm1 = new RentalListForm(id);
            objForm1.Show();
        }
    }


}
