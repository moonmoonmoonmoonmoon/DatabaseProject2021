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
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddCustomerUser addUser = new AddCustomerUser();
            addUser.ShowDialog();
        }
    }
}
