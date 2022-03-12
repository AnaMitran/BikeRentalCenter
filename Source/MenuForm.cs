using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRentalCompany
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void newRentalButton_Click(object sender, EventArgs e)
        {

            NewRentalForm objForm1 = new NewRentalForm();
            openChildFormInPanel(objForm1);
        }

        private void newClientButton_Click(object sender, EventArgs e)
        {
            NewClientForm objForm1 = new NewClientForm();
            openChildFormInPanel(objForm1);
        }

        private void bycicleManagementButton_Click(object sender, EventArgs e)
        {
            BicycleForm objForm1 = new BicycleForm();
            openChildFormInPanel(objForm1);
        }

        private void servicesManagementbutton_Click(object sender, EventArgs e)
        {
            ServicesForm objForm1 = new ServicesForm();
            openChildFormInPanel(objForm1);
        }

        private void newEmployeeButton_Click(object sender, EventArgs e)
        {
            NewEmployeeForm objForm1 = new NewEmployeeForm();
            openChildFormInPanel(objForm1);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            StatisticsForm objForm1 = new StatisticsForm();
            openChildFormInPanel(objForm1);
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
