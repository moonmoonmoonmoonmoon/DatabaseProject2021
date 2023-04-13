using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealershipFormApp2021
{
    public partial class DealerShipForm : Form
    {
        public DealerShipForm() // class
        {
            InitializeComponent();
        }

        private void DealerShipForm_Load(object sender, EventArgs e)
        {

        }

        private void userLogin_Click(object sender, EventArgs e)
        {
            salesLoginForm salesLogin = new salesLoginForm();
            salesLogin.ShowDialog();

        } // end of NewCustomerButton_Click

        private void addUser_Click(object sender, EventArgs e)
        {
            salesGUI adminOverride = new salesGUI();
            adminOverride.ShowDialog();

        } // end of ReturningCustomerButton_Click

        private void customerLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void DealerShipForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
