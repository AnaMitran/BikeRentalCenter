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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PL7MP9D\SQLEXPRESS;Initial Catalog=Centru de Inchirieri Biciclete;User ID=sa;Password=ED308");

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            //Cel mai popular serviciu
            string query = "select top 1 S.Tip, S.Descriere, count(S.ServiciuID) as Nr from Servicii S inner join Inchirieri I on S.ServiciuID = I.ServiciuID group by S.Tip, S.Descriere";
            SqlDataAdapter data = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            data.Fill(table);

            serviceLabel2.Text = table.Rows[0][0].ToString() + ", " + table.Rows[0][1].ToString();

            //Cea mai populara categorie de biciclete
            query = "select top 1  C.Denumire from CategoriiBiciclete C inner join Biciclete B on B.CategorieID = C.CategorieID inner join Inchirieri I on I.BicicletaID = B.BicicletaID group by C.Denumire having count(C.CategorieID) >= Any(select count(B2.CategorieID) from Biciclete B2 inner join Inchirieri I2 on I2.BicicletaID = B2.BicicletaID)";
            data = new SqlDataAdapter(query, connection);
            table = new DataTable();
            data.Fill(table);

            categoryTextBox.Text = table.Rows[0][0].ToString();

            //Nr clienti care au beneficiat de reduceri
            query = "SELECT count(ClientID) FROM Clienti WHERE ClientID IN(SELECT ClientID FROM Inchirieri WHERE ActReducere is not null)";
            data = new SqlDataAdapter(query, connection);
            table = new DataTable();
            data.Fill(table);

            discountTextBox.Text = table.Rows[0][0].ToString();

            //Anul cu cele mai multe inchirieri
            query = "SELECT YEAR(DataInregistrare) AS An, COUNT(DataInregistrare) as Nr FROM Clienti GROUP BY YEAR(DataInregistrare) HAVING COUNT(YEAR(DataInregistrare)) >= ALL(SELECT COUNT(YEAR(A.DataInregistrare)) FROM Clienti A GROUP BY YEAR(A.DataInregistrare))";
            data = new SqlDataAdapter(query, connection);
            table = new DataTable();
            data.Fill(table);

            yearTextBox.Text = table.Rows[0][0].ToString();

            query = "select top 3 Nume + ' ' + Prenume as [Nume Client], [Numarul de Inchirieri] =  (SELECT COUNT(I.InchiriereID) FROM Inchirieri I WHERE I.ClientID = C.ClientID ) from Clienti C order by [Numarul de Inchirieri] desc";
            data = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;

            

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = "select c.nume + ' ' + c.prenume as [Nume Client], max(s.tarif) as Tarif from Clienti c inner join Inchirieri i on i.clientID = c.clientID inner join servicii s on s.serviciuID = i.serviciuID group by c.nume, c.prenume having max(tarif) > '" + priceTextBox.Text + "'";
            SqlDataAdapter data = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select top 3 Nume + ' ' + Prenume as [Nume Client], [Numarul de Inchirieri] =  (SELECT COUNT(I.InchiriereID) FROM Inchirieri I WHERE I.ClientID = C.ClientID and month(I.Inceput) = '"+ monthTextBox.Text + "') from Clienti C order by [Numarul de Inchirieri] desc";
            SqlDataAdapter data = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
