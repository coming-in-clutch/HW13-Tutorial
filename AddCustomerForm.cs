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
    public partial class AddCustomerForm : Form
    {
        private Form myReturnForm = null;

        public AddCustomerForm(Form formThatCreatedMe)
        {
            InitializeComponent();

            myReturnForm = formThatCreatedMe;
        }

        private void saveAndExitBtn_Click(object sender, EventArgs e)
        {
            saveNewCustomerInfo();
            this.Dispose();
            myReturnForm.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            myReturnForm.Show();
        }
        private void saveNewCustomerInfo()
        {
            //get the values from the textBoxes
            String newName = custNameField.Text;
            String newAddress = custAddressField.Text;
            int newZip = 0;
            try
            {
                newZip = Convert.ToInt32(custZipField.Text);
            }
            catch (Exception e)
            {
            }
            // create a new customer object
            Customer newCustObj = new Customer();
            // set the cust obj. attributes
            newCustObj.setCustomerName(newName);
            newCustObj.setCustomerAddress(newAddress);
            newCustObj.setCustomerZip(newZip);
            // save the new customer object
            Customer.saveACustomer(newCustObj);
        }//end save customer
    }
}
