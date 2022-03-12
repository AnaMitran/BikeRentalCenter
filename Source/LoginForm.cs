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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public int ok = 1;

        private void loginButton_Click(object sender, EventArgs e)
        {

            SqlConnection loginConnection = new SqlConnection(@"Data Source=DESKTOP-PL7MP9D\SQLEXPRESS;Initial Catalog=Centru de Inchirieri Biciclete;User ID=sa;Password=ED308");
            string query = "Select * from Login where NumeUtilizator = '" + usernameTextBox.Text.Trim() + "' and parola = '" + passwordTextBox.Text.Trim() + "'";
            SqlDataAdapter data = new SqlDataAdapter(query, loginConnection);
            DataTable table = new DataTable();
            data.Fill(table);

            
            if (table.Rows.Count == 1)
            {
                MenuForm objForm1 = new MenuForm();
                this.Hide();
                objForm1.Show();
            }
            else
            {
                //MessageBox.Show("Date introduse invalide");
                passwordTextBox.Focus();
                errorProvider1.SetError(passwordTextBox, "Parola incorecta");
            }
            //if (ValidateChildren(ValidationConstraints.Enabled))
            //    MessageBox.Show(passwordTextBox.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point mousedownpoint = Point.Empty;

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownpoint = Point.Empty;
        }

        private void LoginForm_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mousedownpoint.IsEmpty)
                return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mousedownpoint.X), f.Location.Y + (e.Y - mousedownpoint.Y));
        }

        private void LoginForm_MouseDown_1(object sender, MouseEventArgs e)
        {
            mousedownpoint = new Point(e.X, e.Y);
        }
        
        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            /*if(ok == 0)
            {
                e.Cancel = true;
                passwordTextBox.Focus();
                errorProvider1.SetError(passwordTextBox, "Parola incorecta");

            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(passwordTextBox, null);
            }*/
        }
    }
}
