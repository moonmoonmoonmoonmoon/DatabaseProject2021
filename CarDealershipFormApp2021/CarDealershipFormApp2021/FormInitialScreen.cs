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

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            salesLoginForm salesLogin = new salesLoginForm();
            salesLogin.ShowDialog();

        } // end of NewCustomerButton_Click

        private void ReturningCustomerButton_Click(object sender, EventArgs e)
        {
            customerValidateForm validateCustomerForm = new customerValidateForm();
            validateCustomerForm.ShowDialog();

        } // end of ReturningCustomerButton_Click
    }
}
