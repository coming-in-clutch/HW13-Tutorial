using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerWindowsApplication
{
    public partial class CustomerAppForm : Form
    {
        public CustomerAppForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomerForm myAddCustomerForm = new AddCustomerForm(this);
            myAddCustomerForm.Show();
            this.Hide();
        }

        private void listAllCustomersBtn_Click(object sender, EventArgs e)
        {
            ListAllCustomersForm myListAllCustomerForm = new ListAllCustomersForm(this);
            myListAllCustomerForm.Show();
            this.Hide();
        }
    }
}
